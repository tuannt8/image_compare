using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TNT_Viewer
{
    internal class ImageViewLayout : TableLayoutPanel
    {
        public void UpdateLayout()
        {
            var selected = Form1.Instance.ThumbnailView.SelectedItems;

            int numImage = selected.Count;

            if (numImage == 0)
            {
                this.Controls.Clear();
                this.ColumnCount = 0;
                this.RowCount = 0;
            }
            else if(numImage == 1)
            {
                this.RowCount = 1;
                this.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
                this.ColumnCount = 1;
                this.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            }
            else if (numImage == 2)
            {
                this.RowCount = 1;
                this.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
                this.ColumnCount = 2;
                this.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
                this.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            }


            // Add image
            int idx = 0;
            foreach (var item in selected)
            {
                ImageView imageView = new ImageView();
                imageView.TabIndex = idx++;

                imageView.BackColor = idx==0? Color.AliceBlue : Color.Bisque;

                this.Controls.Add(imageView);
            }
            
        }


    }
}
