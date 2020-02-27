using System;
using System.IO;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace Catalogo_GitHub.Models
{
    public class Arquivo
    {
        public string name { get; set; }

        public string content { get; set; }

        public string encoding { get; set; }
        public string type { get; set; }

        public string decodedContent()
        {


            byte[] bytes;
            switch (this.encoding)
            {
                case "base64":
                default:
                    bytes = Convert.FromBase64String(this.content);
                    break;
            }

            return Encoding.UTF8.GetString(bytes);

        }

        public MemoryStream decodedImage()
        {


            byte[] bytes;
            switch (this.encoding)
            {
                case "base64":
                default:
                    bytes = Convert.FromBase64String(this.content);
                    break;
            }

            MemoryStream ms = new MemoryStream(bytes, 0, bytes.Length);

            ms.Write(bytes, 0, bytes.Length);
           
            return ms;

        }


    }
}
