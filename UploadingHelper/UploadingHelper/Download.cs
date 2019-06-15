using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UploadingHelper
{
    public class Download
    {
        public bool DownloadWithURL(string sUrl, string sSave)
        {
            try
            {// Xác định dung lượng tập tin
                Uri url = new Uri(sUrl);
                System.Net.HttpWebRequest request = (System.Net.HttpWebRequest)System.Net.WebRequest.Create(url);
                System.Net.HttpWebResponse response = (System.Net.HttpWebResponse)request.GetResponse();
                response.Close();
                // Lấy dung lượng tập tin
                Int64 iSize = response.ContentLength;
                // Dùng Webclient để download
                System.Net.WebClient client = new System.Net.WebClient();
                // Mở URL để download
                Stream streamRemote = client.OpenRead(new Uri(sUrl));
                // Vừa đọc vừa lưu
                Stream streamLocal = new FileStream(sSave, FileMode.Create, FileAccess.Write, FileShare.None);
                // Tiến hành loop quá trình download, vừa load vừa lưu
                int iByteSize = 0;
                byte[] byteBuffer = new byte[iSize];
                while ((iByteSize = streamRemote.Read(byteBuffer, 0, byteBuffer.Length)) > 0)
                {
                    // Lưu byte xuống đường dẫn chỉ định
                    streamLocal.Write(byteBuffer, 0, iByteSize);
                }
                streamLocal.Close();
                streamRemote.Close();
                return true;
            }
            catch(Exception)
            {
                return false;
            }
        }
    }
}
