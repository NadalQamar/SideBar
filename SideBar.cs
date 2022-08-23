using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SideBar
{
    public partial class SideBar : Form
    {
        bool accessTag = false;
        public SideBar()
        {
            InitializeComponent();
        }

        private void SideBar_Load(object sender, EventArgs e)
        {
            
        }

        private void Mouse_Enter(object sender, EventArgs e)
        {// Hide and Unhide
            if(accessTag == false)
            {
                Location = new Point(Screen.PrimaryScreen.Bounds.Width - 40, 0);
                accessTag = true;
            }
            else
            {
                Location = new Point(Screen.PrimaryScreen.Bounds.Width - 1, 0);
                accessTag = false;
            }
        }


    }
}
