using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ImageCompare
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
            this.tableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.imageLayout = new System.Windows.Forms.TableLayoutPanel();
            this.colorText = new System.Windows.Forms.Label();
            this.sideBar = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.listImagePath = new System.Windows.Forms.ListBox();
            this.tableControl = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonListAdd = new System.Windows.Forms.Button();
            this.buttonListDelete = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonReload = new System.Windows.Forms.Button();
            this.flowViewOption = new System.Windows.Forms.FlowLayoutPanel();
            this.viewAllBtn = new System.Windows.Forms.RadioButton();
            this.viewSingle = new System.Windows.Forms.RadioButton();
            this.tableLayout.SuspendLayout();
            this.sideBar.SuspendLayout();
            this.tableControl.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowViewOption.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayout
            // 
            this.tableLayout.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayout.ColumnCount = 2;
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 400F));
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayout.Controls.Add(this.imageLayout, 1, 1);
            this.tableLayout.Controls.Add(this.colorText, 1, 2);
            this.tableLayout.Controls.Add(this.sideBar, 0, 1);
            this.tableLayout.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayout.Location = new System.Drawing.Point(0, 0);
            this.tableLayout.Name = "tableLayout";
            this.tableLayout.RowCount = 3;
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayout.Size = new System.Drawing.Size(1685, 997);
            this.tableLayout.TabIndex = 0;
            // 
            // imageLayout
            // 
            this.imageLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imageLayout.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.imageLayout.ColumnCount = 3;
            this.imageLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.imageLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.imageLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.imageLayout.Location = new System.Drawing.Point(405, 105);
            this.imageLayout.Name = "imageLayout";
            this.imageLayout.RowCount = 1;
            this.imageLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.imageLayout.Size = new System.Drawing.Size(1280, 837);
            this.imageLayout.TabIndex = 2;
            // 
            // colorText
            // 
            this.colorText.AutoSize = true;
            this.colorText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.colorText.Location = new System.Drawing.Point(405, 946);
            this.colorText.Name = "colorText";
            this.colorText.Size = new System.Drawing.Size(1280, 50);
            this.colorText.TabIndex = 3;
            this.colorText.Text = "label1";
            // 
            // sideBar
            // 
            this.sideBar.Controls.Add(this.label1);
            this.sideBar.Controls.Add(this.listImagePath);
            this.sideBar.Controls.Add(this.tableControl);
            this.sideBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sideBar.Location = new System.Drawing.Point(4, 105);
            this.sideBar.Name = "sideBar";
            this.sideBar.Size = new System.Drawing.Size(394, 837);
            this.sideBar.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Images list";
            // 
            // listImagePath
            // 
            this.listImagePath.AllowDrop = true;
            this.listImagePath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.listImagePath.FormattingEnabled = true;
            this.listImagePath.ItemHeight = 25;
            this.listImagePath.Location = new System.Drawing.Point(3, 28);
            this.listImagePath.Name = "listImagePath";
            this.listImagePath.Size = new System.Drawing.Size(391, 304);
            this.listImagePath.TabIndex = 1;
            this.listImagePath.SelectedIndexChanged += new System.EventHandler(this.listImagePath_SelectedIndexChanged);
            this.listImagePath.DragDrop += new System.Windows.Forms.DragEventHandler(this.listImagePath_DragDrop);
            this.listImagePath.DragEnter += new System.Windows.Forms.DragEventHandler(this.listImagePath_DragEnter);
            // 
            // tableControl
            // 
            this.tableControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableControl.Controls.Add(this.buttonListAdd);
            this.tableControl.Controls.Add(this.buttonListDelete);
            this.tableControl.Controls.Add(this.buttonClear);
            this.tableControl.Location = new System.Drawing.Point(3, 338);
            this.tableControl.Name = "tableControl";
            this.tableControl.Size = new System.Drawing.Size(389, 53);
            this.tableControl.TabIndex = 2;
            // 
            // buttonListAdd
            // 
            this.buttonListAdd.Location = new System.Drawing.Point(3, 3);
            this.buttonListAdd.Name = "buttonListAdd";
            this.buttonListAdd.Size = new System.Drawing.Size(58, 38);
            this.buttonListAdd.TabIndex = 0;
            this.buttonListAdd.Text = "+";
            this.buttonListAdd.UseVisualStyleBackColor = true;
            // 
            // buttonListDelete
            // 
            this.buttonListDelete.Location = new System.Drawing.Point(67, 3);
            this.buttonListDelete.Name = "buttonListDelete";
            this.buttonListDelete.Size = new System.Drawing.Size(61, 38);
            this.buttonListDelete.TabIndex = 1;
            this.buttonListDelete.Text = "-";
            this.buttonListDelete.UseVisualStyleBackColor = true;
            this.buttonListDelete.Click += new System.EventHandler(this.buttonListDelete_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(134, 3);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(94, 42);
            this.buttonClear.TabIndex = 2;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayout.SetColumnSpan(this.flowLayoutPanel1, 2);
            this.flowLayoutPanel1.Controls.Add(this.buttonReload);
            this.flowLayoutPanel1.Controls.Add(this.flowViewOption);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(4, 4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1681, 94);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // buttonReload
            // 
            this.buttonReload.Location = new System.Drawing.Point(3, 3);
            this.buttonReload.Name = "buttonReload";
            this.buttonReload.Size = new System.Drawing.Size(145, 40);
            this.buttonReload.TabIndex = 0;
            this.buttonReload.Text = "Reload";
            this.buttonReload.UseVisualStyleBackColor = true;
            this.buttonReload.Click += new System.EventHandler(this.buttonReload_Click_1);
            // 
            // flowViewOption
            // 
            this.flowViewOption.Controls.Add(this.viewAllBtn);
            this.flowViewOption.Controls.Add(this.viewSingle);
            this.flowViewOption.Location = new System.Drawing.Point(154, 3);
            this.flowViewOption.Name = "flowViewOption";
            this.flowViewOption.Size = new System.Drawing.Size(444, 50);
            this.flowViewOption.TabIndex = 1;
            // 
            // viewAllBtn
            // 
            this.viewAllBtn.AutoSize = true;
            this.viewAllBtn.Checked = true;
            this.viewAllBtn.Location = new System.Drawing.Point(3, 3);
            this.viewAllBtn.Name = "viewAllBtn";
            this.viewAllBtn.Size = new System.Drawing.Size(67, 29);
            this.viewAllBtn.TabIndex = 0;
            this.viewAllBtn.TabStop = true;
            this.viewAllBtn.Text = "All";
            this.viewAllBtn.UseVisualStyleBackColor = true;
            this.viewAllBtn.CheckedChanged += new System.EventHandler(this.viewAllBtn_CheckedChanged);
            // 
            // viewSingle
            // 
            this.viewSingle.AutoSize = true;
            this.viewSingle.Location = new System.Drawing.Point(76, 3);
            this.viewSingle.Name = "viewSingle";
            this.viewSingle.Size = new System.Drawing.Size(83, 29);
            this.viewSingle.TabIndex = 1;
            this.viewSingle.Text = "One";
            this.viewSingle.UseVisualStyleBackColor = true;
            this.viewSingle.CheckedChanged += new System.EventHandler(this.viewSingle_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1685, 997);
            this.Controls.Add(this.tableLayout);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayout.ResumeLayout(false);
            this.tableLayout.PerformLayout();
            this.sideBar.ResumeLayout(false);
            this.sideBar.PerformLayout();
            this.tableControl.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowViewOption.ResumeLayout(false);
            this.flowViewOption.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayout;
        private System.Windows.Forms.PictureBox mainImage;
        private System.Windows.Forms.TableLayoutPanel imageLayout;
        private System.Windows.Forms.Label colorText;
        private System.Windows.Forms.FlowLayoutPanel sideBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listImagePath;
        private System.Windows.Forms.FlowLayoutPanel tableControl;
        private System.Windows.Forms.Button buttonListAdd;
        private System.Windows.Forms.Button buttonListDelete;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button buttonReload;
        private System.Windows.Forms.FlowLayoutPanel flowViewOption;
        private System.Windows.Forms.RadioButton viewAllBtn;
        private System.Windows.Forms.RadioButton viewSingle;
        private System.Windows.Forms.Button buttonClear;
    }
}

