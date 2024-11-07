using System;
using System.Windows.Forms;

namespace TNT_Viewer
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.mainLayout = new System.Windows.Forms.TableLayoutPanel();
            this.splitThumbMain = new System.Windows.Forms.SplitContainer();
            this.imageViewLayout = new TNT_Viewer.ImageViewLayout();
            this.thumbTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.directoryBar = new TNT_Viewer.DirectoryBar();
            this.ThumbnailView = new TNT_Viewer.ThumbnailView();
            this.toolbar = new TNT_Viewer.Toolbar();
            this.mainLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitThumbMain)).BeginInit();

            this.splitThumbMain.Panel1.SuspendLayout();
            this.splitThumbMain.Panel2.SuspendLayout();
            this.splitThumbMain.SuspendLayout();
            this.thumbTableLayout.SuspendLayout();
            this.directoryBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainLayout
            // 
            this.mainLayout.ColumnCount = 1;
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.mainLayout.Controls.Add(this.splitThumbMain, 0, 1);
            this.mainLayout.Controls.Add(this.toolbar, 0, 0);
            this.mainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainLayout.Location = new System.Drawing.Point(0, 0);
            this.mainLayout.Name = "mainLayout";
            this.mainLayout.RowCount = 2;
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.mainLayout.Size = new System.Drawing.Size(983, 955);
            this.mainLayout.TabIndex = 0;
            // 
            // splitThumbMain
            // 
            this.splitThumbMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitThumbMain.Location = new System.Drawing.Point(3, 103);
            this.splitThumbMain.Name = "splitThumbMain";
            this.splitThumbMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitThumbMain.Panel1
            // 
            this.splitThumbMain.Panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.splitThumbMain.Panel1.Controls.Add(this.imageViewLayout);
            // 
            // splitThumbMain.Panel2
            // 
            this.splitThumbMain.Panel2.BackColor = System.Drawing.SystemColors.Control;
            this.splitThumbMain.Panel2.Controls.Add(this.thumbTableLayout);
            this.splitThumbMain.Size = new System.Drawing.Size(977, 849);
            this.splitThumbMain.SplitterDistance = 566;
            this.splitThumbMain.SplitterWidth = 20;
            this.splitThumbMain.TabIndex = 0;
            // 
            // imageViewLayout
            // 
            this.imageViewLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 977F));
            this.imageViewLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageViewLayout.Location = new System.Drawing.Point(0, 0);
            this.imageViewLayout.Name = "imageViewLayout";
            this.imageViewLayout.Size = new System.Drawing.Size(977, 566);
            this.imageViewLayout.TabIndex = 0;
            // 
            // thumbTableLayout
            // 
            this.thumbTableLayout.ColumnCount = 1;
            this.thumbTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.thumbTableLayout.Controls.Add(this.directoryBar, 0, 0);
            this.thumbTableLayout.Controls.Add(this.ThumbnailView, 0, 1);
            this.thumbTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.thumbTableLayout.Location = new System.Drawing.Point(0, 0);
            this.thumbTableLayout.Name = "thumbTableLayout";
            this.thumbTableLayout.RowCount = 2;
            this.thumbTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.thumbTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.thumbTableLayout.Size = new System.Drawing.Size(977, 263);
            this.thumbTableLayout.TabIndex = 0;
            // 
            // directoryBar
            // 
            this.directoryBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.directoryBar.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.directoryBar.Location = new System.Drawing.Point(0, 0);
            this.directoryBar.Name = "directoryBar";
            this.directoryBar.Size = new System.Drawing.Size(977, 50);
            this.directoryBar.TabIndex = 0;
            // 
            // ThumbnailView
            // 
            this.ThumbnailView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ThumbnailView.HideSelection = false;
            this.ThumbnailView.Location = new System.Drawing.Point(3, 53);
            this.ThumbnailView.Name = "ThumbnailView";
            this.ThumbnailView.Size = new System.Drawing.Size(971, 207);
            this.ThumbnailView.TabIndex = 1;
            this.ThumbnailView.UseCompatibleStateImageBehavior = false;
            // 
            // toolbar
            // 
            this.toolbar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.toolbar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 977F));
            this.toolbar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolbar.Location = new System.Drawing.Point(3, 3);
            this.toolbar.Name = "toolbar";
            this.toolbar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 94F));
            this.toolbar.Size = new System.Drawing.Size(977, 94);
            this.toolbar.TabIndex = 1;

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 955);
            this.Controls.Add(this.mainLayout);
            this.Name = "Form1";
            this.Text = "Form1";


            this.mainLayout.ResumeLayout(false);
            this.splitThumbMain.Panel1.ResumeLayout(false);
            this.splitThumbMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitThumbMain)).EndInit();
            this.splitThumbMain.ResumeLayout(false);
            this.thumbTableLayout.ResumeLayout(false);
            this.thumbTableLayout.PerformLayout();
            this.directoryBar.ResumeLayout(false);
            this.directoryBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Toolbar toolbar;
        internal DirectoryBar directoryBar;
        internal ImageViewLayout imageViewLayout;

        private TableLayoutPanel mainLayout;
        private SplitContainer splitThumbMain;
        private TableLayoutPanel thumbTableLayout;
        internal ThumbnailView ThumbnailView;

    }
}

