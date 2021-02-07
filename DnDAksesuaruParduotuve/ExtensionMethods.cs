using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace DnDAksesuaruParduotuve
{
    public static class ExtensionMethods
    {
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

        public static void AtvaizduotiNuotraukaCentre(this PictureBox box, int itemId)
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
