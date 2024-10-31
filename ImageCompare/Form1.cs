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
using System.Collections;
using System.Collections.Specialized;

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

        public Form1()
        {
            

            instance = this;

            InitializeComponent();

            this.FormClosing += OnClose;
            ReloadFileList();
        }

        protected void OnClose(object sender, EventArgs e)
        {
            SaveFileList(); 
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

        private void ReloadFileList()
        {
            StringCollection list = Properties.Settings.Default.lastFileList;
            if (list != null)
            {
                 this.listImagePath.Items.Clear();
                foreach (var file in list)
                {
                    this.listImagePath.Items.Add(file);
                }               
            }

        }

        private void SaveFileList()
        {
            List<string> file = this.listImagePath.Items.Cast<String>().ToList();


            StringCollection test = new StringCollection();
            test.AddRange(file.ToArray());

            Properties.Settings.Default.lastFileList = test;
            Properties.Settings.Default.Save();

        }

        public static Form1 instance = null;

        private void UpdateImageLayout()
        {

            // Remove old view
            this.imageLayout.Controls.Clear();

            if (viewMode == ViewMode.ALl)
            {
                foreach (var image in imageList)
                {
                    image.Visible = true;
                }

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
            else
            {
                this.imageLayout.RowCount = 1;
                this.imageLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));

                this.imageLayout.ColumnCount = 1;
                this.imageLayout.ColumnStyles.Add(new RowStyle(SizeType.Percent, 100F));


                foreach (var image in imageList)
                {
                    this.imageLayout.Controls.Add(image);
                }

                // Set to active selection
                if (this.listImagePath.SelectedIndex == -1 && this.listImagePath.Items.Count > 0)
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

            if (imageList.Count > 0)
                imageList[0].UpdateViewRect();
        }

        private void listImagePath_DragEnter(object sender, DragEventArgs e)
        {
            Console.WriteLine("Drag enter");
            e.Effect = DragDropEffects.All;
        }

        private void listImagePath_DragLeave(object sender, DragEventArgs e)
        {
            Console.WriteLine("Drag leave");
        }

        private void listImagePath_DragDrop(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;

            var dropped = ((string[])e.Data.GetData(DataFormats.FileDrop));
            var files = dropped.ToList();

            Console.WriteLine($"Dragged {files}");

            if (!files.Any())
                return;

            foreach (var file in files)
            {
                this.listImagePath.Items.Add(file);
            }
        }


        public void Reload()
        {
            // Remove old view
            this.imageLayout.Controls.Clear();

            foreach(var im in imageList)
            {
                im.Free();
            }
            imageList.Clear();

            List<string> file = this.listImagePath.Items.Cast<String>().ToList();

            foreach (var im in file)
            {
                try
                {
                    var newImageBox = new ImageView(im);
                    newImageBox.Dock = DockStyle.Fill;

                    imageList.Add(newImageBox);
                }
                catch (Exception e)
                {
                    MessageBox.Show($"Error: {e}. File is removed", "Failed to load files", MessageBoxButtons.OK);

                    this.listImagePath.Items.Remove(im);
                }

            }

            UpdateImageLayout();
        }

        private void UpdateCurrentImageInSingleView()
        {
            if (viewMode == ViewMode.Single)
            {
                for (int i = 0; i < imageList.Count; i++)
                {
                    if (i == this.listImagePath.SelectedIndex)
                    {
                        imageList[i].Visible = true;
                    }
                }

                for (int i = 0; i < imageList.Count; i++)
                {
                    if (i != this.listImagePath.SelectedIndex)
                    {
                        imageList[i].Visible = false;
                    }
                }
            }
        }

        private void buttonReload_Click_1(object sender, EventArgs e)
        {
            Reload();
        }

        private void viewAllBtn_CheckedChanged(object sender, EventArgs e)
        {
            if(this.viewAllBtn.Checked)
            {
                viewMode = ViewMode.ALl;

                UpdateImageLayout();
            }

        }

        private void viewSingle_CheckedChanged(object sender, EventArgs e)
        {
            if (this.viewSingle.Checked)
            {
                viewMode = ViewMode.Single;
                UpdateImageLayout();
            }
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
