using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TNT_Viewer
{
    internal class Toolbar : TableLayoutPanel
    {
        public Toolbar() : base()
        {
            this.btn1 = new Button();

            this.Controls.Add(this.btn1);
        }

        private Button btn1;
    }
}
