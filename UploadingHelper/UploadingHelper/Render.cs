using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UploadingHelper
{
    public class Render
    {
        public Render()
        {

        }
        private string ResizeImage(string imagePath, ref string logs)
        {
            logs += "\nResize image...";
            try
            {
                Bitmap img = new Bitmap(imagePath);

                int imageHeight = img.Width;
                int imageWidth = img.Height;

                img.Dispose();

                if ((imageHeight % 2) != 0 || (imageWidth % 2) != 0)
                {
                    if ((imageHeight % 2) != 0) imageHeight += 1;
                    if ((imageWidth % 2) != 0) imageWidth += 1;

                    string[] arr = imagePath.Split('\\');
                    string[] arr1 = arr[arr.Length - 1].Split('.');
                    string newName = arr1[0] + "_" + imageHeight + "x" + imageWidth + "." + arr1[1];
                    string folderPath = "";
                    for (int i = 0; i < arr.Length - 1; i++)
                    {
                        folderPath += arr[i] + "\\";
                    }

                    string command = @"/c cd C:\ffmpeg\bin&C:\ffmpeg\bin\ffmpeg -i " + imagePath + " -vf scale=" + imageHeight + ":" + imageWidth + " " + folderPath + newName;

                    Process process = new Process();
                    ProcessStartInfo startInfo = new ProcessStartInfo();
                    startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    startInfo.FileName = "cmd.exe";
                    startInfo.Arguments = command;
                    process.StartInfo = startInfo;
                    process.StartInfo.UseShellExecute = false;
                    process.StartInfo.RedirectStandardOutput = true;
                    process.Start();
                    process.WaitForExit();

                    File.Delete(imagePath);
                    logs += "\n\tSuccessfully!!!";

                    return folderPath + newName;
                }
            }
            catch (Exception ex)
            {
                logs += "\n\tFailed!!!" + ex.ToString();
            }
            return imagePath;
        }
        public string RenderWithImageAndSound(string imagePath, string soundPath, ref string logs)
        {
            try
            {
                string videoOutputPath = Properties.Settings.Default.DataFolder + "\\" + DateTime.Now.Day + "-" + DateTime.Now.Month + ".mp4";

                if (imagePath == null || imagePath == "")
                {
                    logs += "\nNot found image!";
                    logs += "\nRender was failed!!!";
                    return null;
                }
                if (soundPath == null || soundPath == "")
                {
                    logs += "\nNot found sound!";
                    logs += "\nRender was failed!!!";
                    return null;
                }

                imagePath = ResizeImage(imagePath, ref logs);

                string command = @"/c cd C:\ffmpeg\bin&C:\ffmpeg\bin\ffmpeg -loop 1 -i " + imagePath +
                    " -i " + soundPath + " -c:v libx264 -c:a aac -strict experimental -b:a 192k -shortest " + videoOutputPath;

                Process process = new Process();
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                startInfo.FileName = "cmd.exe";
                startInfo.Arguments = command;
                process.StartInfo = startInfo;
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.RedirectStandardOutput = true;
                process.Start();
                process.WaitForExit();

                logs += "\nRender was successful!!!";
                return videoOutputPath;
            }
            catch (Exception ex)
            {
                logs += ex.Message;
                return null;
            }
        }
    }
}
