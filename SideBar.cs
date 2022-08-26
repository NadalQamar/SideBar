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
        bool accessFlag = false;
        bool settingFlag = false;

        public SideBar()
        {
            InitializeComponent();
        }
        private void SideBar_Load(object sender, EventArgs e)
        {

        }

        private void Mouse_Enter(object sender, EventArgs e)
        {// Hide and Unhide
            if(accessFlag == true && settingFlag == true)
            {
                Location = new Point(Screen.PrimaryScreen.Bounds.Width - 1, 0);
                ClientSize = new Size(40, Screen.PrimaryScreen.Bounds.Height);
                SideBarPrimaryButtonPanel.Location = new System.Drawing.Point(0, Screen.PrimaryScreen.Bounds.Height - 110);
                accessFlag = false;
                settingFlag = false;
            }
            else if(accessFlag == false)
            {
                Location = new Point(Screen.PrimaryScreen.Bounds.Width - 40, 0);
                accessFlag = true;
            }
            else
            {
                Location = new Point(Screen.PrimaryScreen.Bounds.Width - 1, 0);
                accessFlag = false;
            }
        }
        private void settingsButton_Click(object sender, EventArgs e)
        {
            if (settingFlag == false)
            {
                Location = new Point(Screen.PrimaryScreen.Bounds.Width - 550, 0);
                ClientSize = new Size(550, Screen.PrimaryScreen.Bounds.Height);
                SideBarPrimaryButtonPanel.Location = new System.Drawing.Point(ClientSize.Width - 40, Screen.PrimaryScreen.Bounds.Height - 110);
                settingFlag = true;
            }
            else
            {
                Location = new Point(Screen.PrimaryScreen.Bounds.Width - 40, 0);
                ClientSize = new Size(40, Screen.PrimaryScreen.Bounds.Height);
                SideBarPrimaryButtonPanel.Location = new System.Drawing.Point(0, Screen.PrimaryScreen.Bounds.Height - 110);
                settingFlag = false;
            }
        }
        private void visiblityButton_Click(object sender, EventArgs e)
        {
            if(accessFlag == true && settingFlag == true && ControlBox.Enabled == true)
            {
                ControlBox.Enabled = false;
            }
            else if (accessFlag == true && settingFlag == true && ControlBox.Enabled == false)
            {
                ControlBox.Enabled = true;
            }
            else if(ControlBox.Enabled == true)
            {
                Location = new Point(Screen.PrimaryScreen.Bounds.Width - 40, 0);
                ControlBox.Enabled = false;
            }else
            {
                Location = new Point(Screen.PrimaryScreen.Bounds.Width - 1, 0);
                ControlBox.Enabled = true;
            }

        }
        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }

    }
}
