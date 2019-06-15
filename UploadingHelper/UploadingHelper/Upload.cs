using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.Upload;
using Google.Apis.Util.Store;
using Google.Apis.YouTube.v3;
using Google.Apis.YouTube.v3.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UploadingHelper
{
    public partial class Upload : Form
    {
        public Upload()
        {
            InitializeComponent();
        }
        public Upload(string Title, string Description, string Tags, string PlayListId, string videoPath)
        {
            InitializeComponent();
            txtVideoPath.Text = videoPath;

            if(Title.Length > 57) txtTitle.Text = Title.Substring(0, 57) + "...";
            else txtTitle.Text = Title;

            string[] arrTitle = Title.Split(' ');
            string lastDescription = "";
            foreach(string str in arrTitle)
            {
                lastDescription += "#" + str + " ";
            }

            if ((Description.Length + lastDescription.Length + Title.Length) > 4500) txtDescription.Text = Title + ".\n" + Description.Substring(0, Description.Length - lastDescription.Length - Title.Length) + "\n" + lastDescription;
            else txtDescription.Text = Title + ".\n" + Description + "\n" + lastDescription;

            string[] arr = Tags.Split(',');
            int i = 0;
            Tags = "";
            foreach(string str in arr)
            {
                if (str.Length > 25) Tags += str.Substring(0, 25);
                else Tags += str;
                i++;
                if (i == 10) break;
                Tags += ",";
            }
            txtTags.Text = Tags;

            txtPlayListId.Text = PlayListId;
        }
        private void WriteLog(string message)
        {
            rtbLog.Text += "\n" + message;
        }
        
        #region Upload to youtube
        private async Task Run()
        {
            UserCredential credential;
            using (var stream = new FileStream("client_secrets.json", FileMode.Open, FileAccess.Read))
            {
                credential = await GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets,
                    // This OAuth 2.0 access scope allows an application to upload files to the
                    // authenticated user's YouTube channel, but doesn't allow other types of access.
                    new[] { YouTubeService.Scope.YoutubeUpload },
                    "user",
                    CancellationToken.None
                );
            }

            var youtubeService = new YouTubeService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = Assembly.GetExecutingAssembly().GetName().Name
            });

            var video = new Video();
            video.Snippet = new VideoSnippet();
            video.Snippet.Title = txtTitle.Text;
            video.Snippet.Description = txtDescription.Text;
            video.Snippet.Tags = txtTags.Text.Split(',');
            video.Snippet.CategoryId = txtCategoryId.Text; // See https://developers.google.com/youtube/v3/docs/videoCategories/list
            video.Status = new VideoStatus();
            video.Status.PrivacyStatus = cbPrivacyStatus.Items[cbPrivacyStatus.SelectedIndex].ToString(); // or "private" or "public" or unlisted

            var filePath = txtVideoPath.Text; // Replace with path to actual movie file.

            using (var fileStream = new FileStream(filePath, FileMode.Open))
            {
                var videosInsertRequest = youtubeService.Videos.Insert(video, "snippet,status", fileStream, "video/*");
                videosInsertRequest.ProgressChanged += videosInsertRequest_ProgressChanged;
                videosInsertRequest.ResponseReceived += videosInsertRequest_ResponseReceived;

                await videosInsertRequest.UploadAsync();
            }

        }
        void videosInsertRequest_ProgressChanged(Google.Apis.Upload.IUploadProgress progress)
        {
            switch (progress.Status)
            {
                case UploadStatus.Uploading:
                    WriteLog(string.Format("{0} bytes sent.", progress.BytesSent));
                    break;

                case UploadStatus.Failed:
                    WriteLog(string.Format("An error prevented the upload from completing.\n{0}", progress.Exception));
                    break;
            }
        }
        async void videosInsertRequest_ResponseReceived(Video video)
        {
            WriteLog(string.Format("Video '{0}' was successfully uploaded!!!", video.Snippet.Title));

            UserCredential credential;
            using (var stream = new FileStream("client_secrets.json", FileMode.Open, FileAccess.Read))
            {
                credential = await GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets,
                    // This OAuth 2.0 access scope allows for full read/write access to the
                    // authenticated user's account.
                    new[] { YouTubeService.Scope.Youtube },
                    "user",
                    CancellationToken.None,
                    new FileDataStore(this.GetType().ToString())
                );
            }

            var youtubeService = new YouTubeService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = this.GetType().ToString()
            });


            try
            {
                WriteLog("\n--- Add video to playlist");
                // Add a video to the newly created playlist.
                var newPlaylistItem = new PlaylistItem();
                newPlaylistItem.Snippet = new PlaylistItemSnippet();
                newPlaylistItem.Snippet.PlaylistId = txtPlayListId.Text.Trim();
                newPlaylistItem.Snippet.ResourceId = new ResourceId();
                newPlaylistItem.Snippet.ResourceId.Kind = "youtube#video";
                newPlaylistItem.Snippet.ResourceId.VideoId = video.Id;
                await youtubeService.PlaylistItems.Insert(newPlaylistItem, "snippet").ExecuteAsync();

                WriteLog("Add video to playlist '" + txtPlayListId.Text + "' successfully!!!\n");

                this.Close();
            }
            catch (Exception)
            {
                WriteLog("Can't add video to playlist '" + txtPlayListId.Text + "'.\n");
                this.Close();
            }
        }
        #endregion
        private void Upload_Load(object sender, EventArgs e)
        {
            Properties.Settings.Default.UploadLogs = "";
            cbPrivacyStatus.SelectedIndex = 0;
            WriteLog("\t\tYouTube Data API: Upload Video");
            WriteLog("=======================================================\n");

            //Upload video
            WriteLog("\n---- Upload to youtube:");
            FileInfo fileInfo = new FileInfo(txtVideoPath.Text);
            if (fileInfo.Exists)
            {
                Thread thrd = new Thread(() =>
                {
                    try
                    {
                        Run().Wait();
                    }
                    catch (Exception ex)
                    {
                        WriteLog("Error: " + ex.ToString());
                        this.Close();
                    }
                });

                thrd.IsBackground = true;
                thrd.Start();
            }
            else
            {
                WriteLog("Not found " + txtVideoPath.Text + "\nUpload failed!!!");
                this.Close();
            }
        }

        private void Upload_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.UploadLogs = rtbLog.Text;
        }
    }
}
