using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DnDAksesuaruParduotuve
{
    public static class ExtensionMethods
    {
        public static void AtvaizduotiNuotrauka(this PictureBox box, string pictureLocation)
        {
            Image picture = Image.FromFile(pictureLocation);

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
            }

            box.Size = new System.Drawing.Size((int)boxWidth, (int)boxHeight);
            box.ImageLocation = pictureLocation;
        }
    }
}
