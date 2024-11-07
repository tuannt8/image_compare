using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;
using System.Windows.Media.Imaging;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace TNT_Viewer
{


    internal class ThumbnailView : ListView
    {
        Bitmap thumb_empty = new Bitmap(Properties.Resources.thumb_empty);

        public ThumbnailView() : base()
        {
            this.ItemSelectionChanged += SelectionChanged;
        }

        internal void GetThumbnail(string file)
        {
            //Stream imageStreamSource = new FileStream(file, FileMode.Open, FileAccess.Read, FileShare.Read);
            //TiffBitmapDecoder decoder = new TiffBitmapDecoder(imageStreamSource, BitmapCreateOptions.PreservePixelFormat, BitmapCacheOption.None);

            //Console.WriteLine($"Image {file} have {decoder.Frames.Count} image directories");
            //foreach (BitmapSource bitmapSource in decoder.Frames)
            //{
                
            //}
        }

        internal void SelectionChanged(object sender, System.EventArgs e)
        {
            Form1.Instance.imageViewLayout.UpdateLayout();

        }

        internal bool Reload(String dir)
        { 
            this.Items.Clear();

            Form1.Instance.imageViewLayout.UpdateLayout();

            if (Directory.Exists(dir)) 
            {
                ImageList imageList = new ImageList();
                imageList.ImageSize = new Size(128, 128);

                int count = 0;
                foreach(string file in Directory.GetFiles(dir))
                {
                    var ext = Path.GetExtension(file);
                    var name = Path.GetFileName(file);

                    if (ext == ".tif" || ext == ".tiff")
                    {
                        imageList.Images.Add(name, thumb_empty);

                        ListViewItem lst = new ListViewItem();
                        lst.Text = name;
                        lst.Tag = file;
                        lst.ImageIndex = count++;
                        this.Items.Add(lst);
                    }
                }

                this.LargeImageList = imageList;

                return true;
            }
            
            return false;
        }
    }
}
