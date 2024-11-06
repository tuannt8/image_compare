using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TNT_Viewer
{
    internal class ThumbnailView : ListView
    {
        private void DownloadImagesFromWeb(List<string> adress, ImageList il)
        {
            foreach (string img in adress)
            {
                Bitmap bmp = (Bitmap)Image.FromFile("D:/data/test/0.tif");

                il.Images.Add(bmp);
            }
        }

        public ThumbnailView() : base()
        {
            this.View = View.LargeIcon;

            List<string> adress = new List<string>()
            {
                "http://i.telegraph.co.uk/multimedia/archive/02351/Jaguar-F-type-9_2351861k.jpg",
                "http://i.telegraph.co.uk/multimedia/archive/02351/Jaguar-F-type-5_2351885k.jpg",
                "http://i.telegraph.co.uk/multimedia/archive/02351/Jaguar-F-type-7_2351893k.jpg"
            };

            ImageList il = new ImageList();

            DownloadImagesFromWeb(adress, il);

            il.ImageSize = new Size(128, 128);
            int count = 0;
            this.LargeImageList = il;
            List<string> names = new List<string>() { "1", "2", "3", "4" };

            foreach (string s in names)
            {
                ListViewItem lst = new ListViewItem();
                lst.Text = s;
                lst.ImageIndex = count++;
                this.Items.Add(lst);
            }
        }
    }
}
