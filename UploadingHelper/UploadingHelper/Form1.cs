using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UploadingHelper
{
    public partial class CrawlAndRender : Form
    {
        private TimeSpan tsDelay;
        public CrawlAndRender()
        {
            InitializeComponent();
            tmCurrentTime.Start();
        }
        private void WriteLog(string message)
        {
            string[] arr = message.Split('\n');
            foreach (string str in arr)
                rtbLog.Text += "\n" + str;
        }
        //Mỗi lần ra 1 link image, 1 link sound
        public void CrawlData()
        {

        }

        private void btnStrat_Click(object sender, EventArgs e)
        {
            Thread thrd = new Thread(() =>
            {
                btnStrat.Enabled = false;
                nmTimeDelay.Enabled = false;

                rtbLog.ResetText();
                Download download = new Download();
                Render render = new Render();
                Data data = new Data();
                string logs = "";

                WriteLog("============================ Uploading Helper ============================");

                //Clean up folder data
                data.CleanUpFolderData(ref logs);
                WriteLog(logs); logs = "";

                //Crawl
                WriteLog("\n--- Crawl data:");
                CrawlData();

                //Download image and sound
                WriteLog("\n--- Download:");
                //Download image
                string ImageLink = data.GetImageLink(ref logs);
                txtImageLink.Text = ImageLink;
                WriteLog(logs); logs = "";
                WriteLog("\tDownloading Image: " + ImageLink);
                string[] arr = ImageLink.Trim().Split('/');
                string[] arr1 = arr[arr.Length - 1].Split('.');
                string Extension = arr1[arr1.Length - 1];
                if (download.DownloadWithURL(ImageLink, Properties.Settings.Default.DataFolder + "\\" + DateTime.Now.Day + "_" + DateTime.Now.Month + "." + Extension)) WriteLog("\tDownload image successfully!!!");
                else
                {
                    WriteLog("\tDownload image failed!!!");
                    WriteLog("============================ Finish ============================");
                    return;
                }
                //Download sound
                string SoundLink = data.GetSoundLink(ref logs);
                txtSoundLink.Text = SoundLink;
                WriteLog(logs); logs = "";
                WriteLog("\tDownloading Sound: " + SoundLink);
                if (download.DownloadWithURL(SoundLink, Properties.Settings.Default.DataFolder + "\\" + DateTime.Now.Day + "_" + DateTime.Now.Month + ".mp3")) WriteLog("\tDownload sound successfully!!!");
                else
                {
                    WriteLog("\tDownload sound failed!!!");
                    WriteLog("============================ Finish ============================");
                    return;
                }

                //Render
                WriteLog("\n--- Render:");
                string VideoPath = render.RenderWithImageAndSound(data.GetImagePath(), data.GetSoundPath(), ref logs);
                WriteLog(logs); logs = "";
                if (VideoPath == null)
                {
                    WriteLog("\tRender failed!!!");
                    WriteLog("============================ Finish ============================");
                    return;
                }

                //Upload
                WriteLog("\n--- Upload to youtube:");
                string Title = data.GetTitle(ref logs); string Description = data.GetDescription(ref logs);
                string Tags = data.GetTags(ref logs); string PlayListId = data.GetPlayListId(ref logs);
                WriteLog(logs); logs = "";
                (new Upload(Title, Description, Tags, PlayListId, VideoPath)).ShowDialog();
                WriteLog(Properties.Settings.Default.UploadLogs);
                Properties.Settings.Default.UploadLogs = "";
                WriteLog("============================ Finish ============================");

                //Save logs
                data.SaveLog(rtbLog.Text);

                tsDelay = new TimeSpan(0, (int)nmTimeDelay.Value, 0);
                while (tsDelay != (new TimeSpan(0, 0, 0)))
                {
                    Thread.Sleep(1000);
                    tsDelay = tsDelay.Add(new TimeSpan(0, 0, -1));
                    lblNextTime.Text = tsDelay.ToString();
                }

                btnStrat.Enabled = true;
                nmTimeDelay.Enabled = true;
                btnStrat.PerformClick();

            });
            thrd.IsBackground = true;
            thrd.Start();
        }

        private void tmCurrentTime_Tick(object sender, EventArgs e)
        {
            lblCurentTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}
