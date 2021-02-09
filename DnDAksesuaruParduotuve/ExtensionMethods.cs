using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace DnDAksesuaruParduotuve
{
    public static class ExtensionMethods
    {
        public static bool UrlExists(this string url)
        {
            Uri uriResult;
            if (!(Uri.TryCreate(url, UriKind.Absolute, out uriResult) && (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps))) return false;
            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Timeout = 1000; //Suteikiama sekundė laiko prisijungimui
            WebResponse webResponse;
            try
            {
                webResponse = webRequest.GetResponse();
                return true;
            }
            catch { return false; }
        }

        public static void AtvaizduotiNuotrauka(this PictureBox box, string pictureFromWeb)
        {
            if (!pictureFromWeb.UrlExists()) return;
            byte[] pictureData = new WebClient().DownloadData(pictureFromWeb);
            MemoryStream pictureStream = new MemoryStream(pictureData);
            Image picture = Image.FromStream(pictureStream);

            double pictureWidth = picture.Width;
            double pictureHeight = picture.Height;
            double pictureRatio = pictureWidth / pictureHeight;
            picture.Dispose();

            double boxWidth = box.Width;
            double boxHeight = box.Height;
            double boxRatio = boxWidth / boxHeight;

            if (pictureRatio > boxRatio)
            {
                boxHeight = (int)(boxWidth / pictureWidth * pictureHeight);
                box.Top = box.Top + (box.Height - (int)boxHeight) / 2;
            }
            else if (pictureRatio < boxRatio)
            {
                boxWidth = (int)(boxHeight / pictureHeight * pictureWidth);
            }

            box.Size = new Size((int)boxWidth, (int)boxHeight);
            box.ImageLocation = pictureFromWeb;
        }

        public static void AtvaizduotiNuotrauka(this PictureBox box, int itemId)
        {
            string pictureLocation;
            if (File.Exists($"{itemId}.png")) pictureLocation = $"{itemId}.png";
            else if (File.Exists($"{itemId}.jpg")) pictureLocation = $"{itemId}.jpg";
            else return;
            Image picture = Image.FromFile(pictureLocation);

            double pictureWidth = picture.Width;
            double pictureHeight = picture.Height;
            double pictureRatio = pictureWidth / pictureHeight;
            picture.Dispose();

            double boxWidth = box.Width;
            double boxHeight = box.Height;
            double boxRatio = boxWidth / boxHeight;

            if (pictureRatio > boxRatio)
            {
                boxHeight = (int)(boxWidth / pictureWidth * pictureHeight);
                box.Top = box.Top + (box.Height - (int)boxHeight) / 2;
            }
            else if (pictureRatio < boxRatio)
            {
                boxWidth = (int)(boxHeight / pictureHeight * pictureWidth);
            }

            box.Size = new Size((int)boxWidth, (int)boxHeight);
            box.ImageLocation = pictureLocation;
        }

        public static void AtvaizduotiNuotraukaKrepselyje(this PictureBox box, Image picture)
        {
            if (picture == null) return;
            double pictureWidth = picture.Width;
            double pictureHeight = picture.Height;
            double pictureRatio = pictureWidth / pictureHeight;

            double boxWidth = box.Width;
            double boxHeight = box.Height;
            double boxRatio = boxWidth / boxHeight;

            if (pictureRatio > boxRatio)
            {
                boxHeight = (int)(boxWidth / pictureWidth * pictureHeight);
                box.Top = box.Top + (box.Height - (int)boxHeight) / 2;
            }
            else if (pictureRatio < boxRatio)
            {
                boxWidth = (int)(boxHeight / pictureHeight * pictureWidth);
                box.Left = box.Left + (box.Width - (int)boxWidth) / 2;
            }

            box.Size = new Size((int)boxWidth, (int)boxHeight);
            box.Image = picture;
        }

        public static void AtvaizduotiNuotraukaKrepselyje(this PictureBox box, int itemId)
        {
            string pictureLocation;
            if (File.Exists($"{itemId}.png")) pictureLocation = $"{itemId}.png";
            else if (File.Exists($"{itemId}.jpg")) pictureLocation = $"{itemId}.jpg";
            else return;
            Image picture = Image.FromFile(pictureLocation);

            double pictureWidth = picture.Width;
            double pictureHeight = picture.Height;
            double pictureRatio = pictureWidth / pictureHeight;
            picture.Dispose();

            double boxWidth = box.Width;
            double boxHeight = box.Height;
            double boxRatio = boxWidth / boxHeight;

            if (pictureRatio > boxRatio)
            {
                boxHeight = (int)(boxWidth / pictureWidth * pictureHeight);
                box.Top = box.Top + (box.Height - (int)boxHeight) / 2;
            }
            else if (pictureRatio < boxRatio)
            {
                boxWidth = (int)(boxHeight / pictureHeight * pictureWidth);
                box.Left = box.Left + (box.Width - (int)boxWidth) / 2;
            }

            box.Size = new Size((int)boxWidth, (int)boxHeight);
            box.ImageLocation = pictureLocation;
        }
    }
}
