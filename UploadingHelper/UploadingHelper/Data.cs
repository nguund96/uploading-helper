using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UploadingHelper
{
    public class Data
    {
        public string GetDescription(ref string logs)
        {
            string defaultDescriptionPath = Properties.Settings.Default.DataFolder + "\\DefaultDescription.txt";
            string descriptionPath = Properties.Settings.Default.DataFolder + "\\Description.txt";
            string line = "", str = "";
            //Đọc DefaultDescription.txt
            try
            {
                using (StreamReader rd = new StreamReader(defaultDescriptionPath))
                {
                    do
                    {
                        line += str + "\n";
                        str = rd.ReadLine();
                    }
                    while (str != null);
                    rd.Close();
                }
            }
            catch (Exception)
            {
                logs += "Can't load DefaultDescription.txt!!!";
            }
            //Đọc Description.txt
            line += "\n";
            try
            {
                using (StreamReader rd = new StreamReader(descriptionPath))
                {
                    str = rd.ReadLine();
                    while (str != null)
                    {
                        line += str + "\n";
                        str = rd.ReadLine();
                    }
                    rd.Close();
                }
            }
            catch (Exception)
            {
                logs += "Can't load Description.txt!!!";
            }
            return ConvertHtmlToString(line);
        }
        public string GetTags(ref string logs)
        {
            string defaultTagsPath = Properties.Settings.Default.DataFolder + "\\DefaultTags.txt";
            string tagsPath = Properties.Settings.Default.DataFolder + "\\Tags.txt";
            string line = "";
            //Đọc DefaultTags.txt
            try
            {
                using (StreamReader rd = new StreamReader(defaultTagsPath))
                {
                    line = rd.ReadLine();
                    rd.Close();
                }
            }
            catch (Exception)
            {
                logs += "Can't load DefaultTags.txt!!!";
            }
            //Đọc Tags.txt
            try
            {
                using (StreamReader rd = new StreamReader(tagsPath))
                {
                    line += rd.ReadLine();
                    rd.Close();
                }
            }
            catch (Exception)
            {
                logs += "Can't load Tags.txt!!!";
            }
            return line;
        }
        public string GetTitle(ref string logs)
        {
            string defaultTitlePath = Properties.Settings.Default.DataFolder + "\\DefaultTitle.txt";
            string titlePath = Properties.Settings.Default.DataFolder + "\\Title.txt";
            string line = "";
            //Đọc DefaultTitle.txt
            try
            {
                using (StreamReader rd = new StreamReader(defaultTitlePath))
                {
                    string str = rd.ReadLine();
                    while (str != null)
                    {
                        line += str;
                        str = rd.ReadLine();
                    }
                    rd.Close();
                }
            }
            catch (Exception)
            {
                logs += "Can't load DefaultTitle.txt!!!";
            }
            //Đọc Title.txt
            try
            {
                using (StreamReader rd = new StreamReader(titlePath))
                {
                    string str = rd.ReadLine();
                    while (str != null)
                    {
                        line += str;
                        str = rd.ReadLine();
                    }
                    rd.Close();
                }
            }
            catch (Exception)
            {
                logs += "Can't load Title.txt!!!";
            }
            return ConvertHtmlToString(line);
        }
        public string GetPlayListId(ref string logs)
        {
            string playListIdPath = Properties.Settings.Default.DataFolder + "\\PlayListId.txt";
            string line = "";
            //Đọc PlayListId.txt
            try
            {
                using (StreamReader rd = new StreamReader(playListIdPath))
                {
                    line = rd.ReadLine();
                    rd.Close();
                }
            }
            catch (Exception)
            {
                logs += "Can't load PlayListId.txt!!!";
            }
            return line;
        }
        public string GetImageLink(ref string logs)
        {
            string imageLinkPath = Properties.Settings.Default.DataFolder + "\\ImageLink.txt";
            string line = "";
            //Đọc ImageLink.txt
            try
            {
                using (StreamReader rd = new StreamReader(imageLinkPath))
                {
                    line = rd.ReadLine();
                    rd.Close();
                }
            }
            catch (Exception)
            {
                logs += "Can't load ImageLink.txt!!!";
            }
            return line;
        }
        public string GetSoundLink(ref string logs)
        {
            string soundLinkPath = Properties.Settings.Default.DataFolder + "\\SoundLink.txt";
            string line = "";
            //Đọc SoundLink.txt
            try
            {
                using (StreamReader rd = new StreamReader(soundLinkPath))
                {
                    line = rd.ReadLine();
                    rd.Close();
                }
            }
            catch (Exception)
            {
                logs += "Can't load SoundLink.txt!!!";
            }
            return line;
        }

        public string GetImagePath()
        {
            DirectoryInfo directory = new DirectoryInfo(Properties.Settings.Default.DataFolder);
            var arrFileImage = directory.GetFiles("*.*").Where(s => s.Extension == ".jpg" || s.Extension == ".png");
            foreach (FileInfo item in arrFileImage)
            {
                return item.FullName;
            }
            return null;
        }
        public string GetSoundPath()
        {
            DirectoryInfo directory = new DirectoryInfo(Properties.Settings.Default.DataFolder);
            foreach (FileInfo item in directory.GetFiles("*.mp3"))
            {
                return item.FullName;
            }
            return null;
        }
        public string GetVideoPath()
        {
            DirectoryInfo directory = new DirectoryInfo(Properties.Settings.Default.DataFolder);
            foreach (FileInfo item in directory.GetFiles("*.mp4"))
            {
                return item.FullName;
            }
            return null;
        }

        public bool SaveLog(string Logs)
        {
            try
            {
                // Bước 1: tạo biến để lưu thư mục cần tạo. Tên thư mục đặt theo ngày tháng năm (6-7-2017)
                string directoryPath = Properties.Settings.Default.DataFolder + @"\Logs\" + DateTime.Now.Day + "-" + DateTime.Now.Month + "-" + DateTime.Now.Year;
                // Bước 2: kiểm tra nếu thư mục chưa tồn tại thì tạo mới
                if (!System.IO.Directory.Exists(directoryPath))
                    System.IO.Directory.CreateDirectory(directoryPath);

                // Bước 4: tạo tập tin
                string filePath = directoryPath + @"\["
                    + (DateTime.Now.Hour > 9 ? DateTime.Now.Hour.ToString() : ("0" + DateTime.Now.Hour))
                    + (DateTime.Now.Minute > 9 ? DateTime.Now.Minute.ToString() : ("0" + DateTime.Now.Minute))
                    + (DateTime.Now.Second > 9 ? DateTime.Now.Second.ToString() : ("0" + DateTime.Now.Second)) + "] "
                    + ".txt";

                // Bước 5: ghi
                using (StreamWriter sw = new StreamWriter(filePath))
                {
                    sw.WriteLine("Time: " + DateTime.Now.ToString());
                    sw.WriteLine("\nLog: \n");
                    string[] arrLog = Logs.Split('\n');
                    foreach (string str in arrLog)
                    {
                        sw.WriteLine(str + "\n");
                    }

                    sw.Close();
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        private string ConvertHtmlToString(string str)
        {
            if (str == null) return "";

            str = str.Replace("<strong>", "").Replace("</strong>", "");
            str = str.Replace("<em>", "").Replace("</em>", "");
            str = str.Replace("<i>", "").Replace("</i>", "");
            str = str.Replace("(audio)", "");
            str = str.Replace("&amp;", "&");

            str = str.Replace("&#8216;", "'");
            str = str.Replace("&#8217;", "'");
            str = str.Replace("&#8218;", "'");
            str = str.Replace("&#8219;", "'");
            str = str.Replace("&#8242;", "'");

            str = str.Replace("&#8220;", "\"");
            str = str.Replace("&#8221;", "\"");
            str = str.Replace("&#8222;", "\"");
            str = str.Replace("&#8243;", "\"");
            str = str.Replace("&#8246;", "\"");
            str = str.Replace("&#8247;", "\"");

            str = str.Replace("</a>", "");

            int firstIndex = -1;
            firstIndex = str.IndexOf("<a");
            while (firstIndex != -1)
            {
                int lastIndex = str.IndexOf(">", firstIndex);
                str = str.Substring(0, firstIndex) + str.Substring(lastIndex + 1);
                firstIndex = str.IndexOf("<a");
            }

            str = str.Replace("</span>", "");
            firstIndex = -1;
            firstIndex = str.IndexOf("<span");
            while (firstIndex != -1)
            {
                int lastIndex = str.IndexOf(">", firstIndex);
                str = str.Substring(0, firstIndex) + str.Substring(lastIndex + 1);
                firstIndex = str.IndexOf("<span");
            }

            return str;
        }
        public void CleanUpFolderData(ref string logs)
        {
            string folderData = Properties.Settings.Default.DataFolder;
            if (Directory.Exists(folderData))
            {
                DirectoryInfo directory = new DirectoryInfo(folderData);

                foreach (FileInfo item in directory.GetFiles("*.mp4"))
                {
                    File.Delete(item.FullName);
                    logs += "File deleted: " + item.Name;
                }
                foreach (FileInfo item in directory.GetFiles("*.mp3"))
                {
                    File.Delete(item.FullName);
                    logs += "File deleted: " + item.Name;
                }
                var arrFileImage = directory.GetFiles("*.*").Where(s => s.Extension == ".jpg" || s.Extension == ".png");
                foreach (FileInfo item in arrFileImage)
                {
                    File.Delete(item.FullName);
                    logs += "File deleted: " + item.Name;
                }

                File.WriteAllText(Properties.Settings.Default.DataFolder + "\\Description.txt", string.Empty);
                logs += "Reset file: NewLink.txt";
                File.WriteAllText(Properties.Settings.Default.DataFolder + "\\Tags.txt", string.Empty);
                logs += "Reset file: Tags.txt";
                File.WriteAllText(Properties.Settings.Default.DataFolder + "\\Title.txt", string.Empty);
                logs += "Reset file: Title.txt";
                File.WriteAllText(Properties.Settings.Default.DataFolder + "\\ImageLink.txt", string.Empty);
                logs += "Reset file: ImageLink.txt";
                File.WriteAllText(Properties.Settings.Default.DataFolder + "\\SoundLink.txt", string.Empty);
                logs += "Reset file: SoundLink.txt";
            }
        }
    }
}
