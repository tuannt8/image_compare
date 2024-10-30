using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace ImageCompare
{
    public enum ViewMode
    {
        ALl,
        Single
    }

    public partial class Form1 : Form
    {
        List<ImageView> imageList = new List<ImageView>();
        ViewMode viewMode = ViewMode.ALl;

        List<string> testPath = new List<string>{ 
            "D:/data/test/aa_cpu.tif",
            "D:/data/test/curve.png",
            "D:/data/test/aa_cpu.tif"
        };
        public Form1()
        {
            

            instance = this;

            InitializeComponent();

        }

        public void UpdateImages()
        {
            foreach (var image in imageList)
            {
                image.Refresh();
            }
        }

        public void UpdateColorText(int x, int y, Color c)
        {
            this.colorText.Text = $"x: {x}, y: {y}; R: {c.R}, G: {c.G}, B: {c.B}";
        }


        public static Form1 instance = null;


        public void Reload()
        {


            // Remove old view
            this.imageLayout.Controls.Clear();

            foreach(var im in imageList)
            {
                im.Free();
            }
            imageList.Clear();

            this.listImagePath.Items.Clear();
            this.listImagePath.Items.Add("D:/data/test/aa_cpu.tif");
            this.listImagePath.Items.Add("D:/data/test/aa_cpu.tif");
            this.listImagePath.Items.Add("D:/data/test/aa_cpu.tif");


            List<string> file = this.listImagePath.Items.Cast<String>().ToList();

            try
            {
                foreach (var im in file)
                {
                    var newImageBox = new ImageView();
                    newImageBox.Dock = DockStyle.Fill;

                    imageList.Add(newImageBox);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show($"Error: {e}", "Failed to load files", MessageBoxButtons.OK);

                throw;
            }


            if (viewMode == ViewMode.ALl)
            {


                // View all
                if (imageList.Count == 1)
                {
                    this.imageLayout.ColumnCount = 1;
                    this.imageLayout.RowCount = 1;

                    this.imageLayout.ColumnStyles.Add(new ColumnStyle());
                    this.imageLayout.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
                    this.imageLayout.Controls.Add(imageList[0], 0, 0);
                }
                else if (imageList.Count == 2)
                {
                    this.imageLayout.ColumnCount = 2;
                    this.imageLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
                    this.imageLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));

                    this.imageLayout.RowCount = 1;
                    this.imageLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));


                    this.imageLayout.Controls.Add(imageList[0], 0, 0);
                    this.imageLayout.Controls.Add(imageList[1], 1, 0);
                }
                else if (imageList.Count == 3)
                {
                    this.imageLayout.ColumnCount = 3;
                    this.imageLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
                    this.imageLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
                    this.imageLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));

                    this.imageLayout.RowCount = 1;
                    this.imageLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));


                    this.imageLayout.Controls.Add(imageList[0], 0, 0);
                    this.imageLayout.Controls.Add(imageList[1], 1, 0);
                    this.imageLayout.Controls.Add(imageList[2], 2, 0);
                }
            }
            else{
                this.imageLayout.RowCount = 1;
                this.imageLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));

                this.imageLayout.ColumnCount = 1;
                this.imageLayout.ColumnStyles.Add(new RowStyle(SizeType.Percent, 100F));

                // Set to active selection
                if(this.listImagePath.SelectedIndex == -1)
                {
                    this.listImagePath.SelectedIndex = 0;
                }
                else
                {
                    UpdateCurrentImageInSingleView();
                }
            }

            foreach (var image in imageList)
            {
                image.UpdateViewRect();
            }

            if(imageList.Count > 0)
                imageList[0].UpdateViewRect();

            
        }

        private void UpdateCurrentImageInSingleView()
        {
            if (viewMode == ViewMode.Single)
            {
                this.imageLayout.Controls.Clear();

                this.imageLayout.Controls.Add(imageList[this.listImagePath.SelectedIndex]);

                if (imageList.Count > 0)
                    imageList[0].UpdateViewRect();
                UpdateImages();
                this.imageLayout.Refresh();
            }
        }

        private void buttonReload_Click_1(object sender, EventArgs e)
        {
            Reload();
        }

        private void viewAllBtn_CheckedChanged(object sender, EventArgs e)
        {
            viewMode = ViewMode.ALl;
        }

        private void viewSingle_CheckedChanged(object sender, EventArgs e)
        {
            viewMode = ViewMode.Single;
        }

        private void listImagePath_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateCurrentImageInSingleView();


        }

        private void buttonListDelete_Click(object sender, EventArgs e)
        {
            if(this.listImagePath.SelectedIndex != -1)
            {
                int newIdx = this.listImagePath.SelectedIndex;
                if (newIdx > 0) newIdx = newIdx - 1;
                else if (newIdx < this.listImagePath.Items.Count - 1)
                {

                }
                else
                {
                    newIdx = -1;
                }

                this.listImagePath.Items.RemoveAt(this.listImagePath.SelectedIndex);

                if(newIdx >= 0)
                    this.listImagePath.SelectedIndex = newIdx;
            }
        }
    }
}
