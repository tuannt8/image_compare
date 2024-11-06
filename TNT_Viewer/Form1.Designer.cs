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
            this.mainLayout = new System.Windows.Forms.TableLayoutPanel();
            this.splitTreeMain = new System.Windows.Forms.SplitContainer();
            this.splitThumbMain = new System.Windows.Forms.SplitContainer();
            this.toolbar = new TNT_Viewer.Toolbar();
            this.mainLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitTreeMain)).BeginInit();
            this.splitTreeMain.Panel2.SuspendLayout();
            this.splitTreeMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitThumbMain)).BeginInit();
            this.splitThumbMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainLayout
            // 
            this.mainLayout.ColumnCount = 1;
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.mainLayout.Controls.Add(this.splitTreeMain, 0, 1);
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
            // splitTreeMain
            // 
            this.splitTreeMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitTreeMain.Location = new System.Drawing.Point(3, 103);
            this.splitTreeMain.Name = "splitTreeMain";
            // 
            // splitTreeMain.Panel1
            // 
            this.splitTreeMain.Panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            // 
            // splitTreeMain.Panel2
            // 
            this.splitTreeMain.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitTreeMain.Panel2.Controls.Add(this.splitThumbMain);
            this.splitTreeMain.Size = new System.Drawing.Size(977, 849);
            this.splitTreeMain.SplitterDistance = 200;
            this.splitTreeMain.SplitterWidth = 20;
            this.splitTreeMain.TabIndex = 0;
            // 
            // splitThumbMain
            // 
            this.splitThumbMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitThumbMain.Location = new System.Drawing.Point(0, 0);
            this.splitThumbMain.Name = "splitThumbMain";
            this.splitThumbMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitThumbMain.Panel1
            // 
            this.splitThumbMain.Panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            // 
            // splitThumbMain.Panel2
            // 
            this.splitThumbMain.Panel2.BackColor = System.Drawing.SystemColors.Control;
            this.splitThumbMain.Size = new System.Drawing.Size(600, 600);
            this.splitThumbMain.SplitterDistance = 400;
            this.splitThumbMain.SplitterWidth = 20;
            this.splitThumbMain.TabIndex = 0;
            // 
            // toolbar
            // 
            this.toolbar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.toolbar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 977F));
            this.toolbar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolbar.Location = new System.Drawing.Point(3, 3);
            this.toolbar.Name = "toolbar";
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
            this.splitTreeMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitTreeMain)).EndInit();
            this.splitTreeMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitThumbMain)).EndInit();
            this.splitThumbMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Toolbar toolbar;

        private TableLayoutPanel mainLayout;
        private SplitContainer splitTreeMain;
        private SplitContainer splitThumbMain;
    }
}

