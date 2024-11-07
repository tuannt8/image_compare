using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TNT_Viewer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            if (Instance != null)
            {
                throw new ApplicationException("Form 1 is singleton");
            }
            Instance = this;

            WindowState = FormWindowState.Maximized;

            InitializeComponent();

            this.splitThumbMain.SplitterDistance = this.splitThumbMain.Height * 8 / 10;
        }

        public static Form1 Instance = null;
    }
}
