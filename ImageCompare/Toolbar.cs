using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageCompare
{
    public class Toolbar : TableLayoutPanel
    {

        
        private void InitializeComponent()
        {
            this.btnReload = new Button();

            this.SuspendLayout();
            // 
            // Toolbar
            // 
            this.ColumnCount = 3;
            this.RowCount = 1;
            this.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));

            this.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));

            // add control
            this.Controls.Add(this.btnReload, 0, 1);

            // reload button
            this.btnReload.Text = "Reload";
            this.btnReload.Click += Reload;

            this.PerformLayout();
            this.ResumeLayout(false);

        }

        private void Reload(object sender, EventArgs e)
        {
            Form1.instance.Reload();
        }

        private Button btnReload;
    }
}
