using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TNT_Viewer.Properties;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Collections.Specialized;

namespace TNT_Viewer
{
    internal class DirectoryBar : ToolStrip
    {       
        private ToolStripComboBox directoryListComboBox;
        private ToolStripButton addDirectoryBtn;


        public DirectoryBar() : base() 
        {
            InitializeComponent();


        }

        public void Reload()
        {
            // Load directory list
            StringCollection list = Properties.Settings.Default.ListDirectories;
            if (list != null)
            {
                this.directoryListComboBox.Items.Clear();
                foreach (var file in list)
                {
                    this.directoryListComboBox.Items.Add(file);
                }

                // active one
                String activeDirectory = Properties.Settings.Default.CurrentDirectory;
                if (activeDirectory != null)
                {
                    this.directoryListComboBox.SelectedItem = activeDirectory;
                }
                else
                {
                    this.directoryListComboBox.SelectedIndex = 0;
                }
            }
        }



        private void InitializeComponent()
        {
            this.SuspendLayout();

            this.directoryListComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.addDirectoryBtn = new System.Windows.Forms.ToolStripButton();


            this.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.directoryListComboBox,
                this.addDirectoryBtn});

            // 
            // toolStripComboBox1
            // 
            this.directoryListComboBox.Name = "toolStripComboBox1";
            this.directoryListComboBox.Size = new System.Drawing.Size(300, 50);
            this.directoryListComboBox.SelectedIndexChanged += DirectoryChanged;
            // 
            // toolStripButton1
            // 
            this.addDirectoryBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text ;
            this.addDirectoryBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addDirectoryBtn.Name = "toolStripButton1";
            this.addDirectoryBtn.Size = new System.Drawing.Size(46, 50);
            this.addDirectoryBtn.Text = "Load";
            this.addDirectoryBtn.Click += AddDirectory;

            // 
            // DirectoryBar
            // 
            this.ResumeLayout(false);

        }

        internal void DirectoryChanged(object sender, System.EventArgs e)
        {
            String curDir = this.directoryListComboBox.SelectedItem as String;
            Settings.Default.CurrentDirectory = curDir;
            Settings.Default.Save();

            if(Form1.Instance.ThumbnailView != null)
            {
                if (!Form1.Instance.ThumbnailView.Reload(curDir))
                {
                    MessageBox.Show($"Directory {curDir} is invalid.", "Failed to load files", MessageBoxButtons.OK);
                }
            }


        }

        // TODO Drag and drop 
        private void AddDirectory(object sender, System.EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var newPath = dialog.SelectedPath;

                this.directoryListComboBox.Items.Insert(0, newPath);
                if(this.directoryListComboBox.Items.Count > 10)
                {
                    // remove last one
                    this.directoryListComboBox.Items.RemoveAt(this.directoryListComboBox.Items.Count - 1);
                }

                this.directoryListComboBox.SelectedIndex = 0;

                // Save it
                StringCollection directories = new StringCollection();
                directories.AddRange(this.directoryListComboBox.Items.Cast<String>().ToArray());
                Properties.Settings.Default.ListDirectories = directories;
                Settings.Default.Save();
            }
        }
    }
}
