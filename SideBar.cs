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

        //Methods
        private void SettingOptionsOpen (object sender, EventArgs e)//When setting options open
        {
            settingsBackgroundColorChanger.Location = new Point(20, 20);
            settingsBackgroundColorChanger.Size = new Size(100, 20);
            settingsBackgroundColorChanger.Visible = true;

            settingsBackgroundColorChangerButton.Location = new Point(120, 20);
            settingsBackgroundColorChangerButton.Size = new Size(50, 20);
            settingsBackgroundColorChangerButton.Visible = true;
        }
        private void SettingOptionsClose(object sender, EventArgs e)//When Setting options close
        {
            
            settingsBackgroundColorChanger.Location = new Point(0, 0);
            settingsBackgroundColorChanger.Size = new Size(0, 0);
            settingsBackgroundColorChanger.Visible = false;

           
            settingsBackgroundColorChangerButton.Location = new Point(0, 0);
            settingsBackgroundColorChangerButton.Size = new Size(0, 0);
            settingsBackgroundColorChangerButton.Visible = false;
        }

        private void Mouse_Enter(object sender, EventArgs e)
        {// Hide and Unhide the SideBar
            if(accessFlag == true && settingFlag == true)
            {
                Location = new Point(Screen.PrimaryScreen.Bounds.Width - 1, 0);
                ClientSize = new Size(40, Screen.PrimaryScreen.Bounds.Height);
                SideBarPrimaryButtonPanel.Location = new Point(0, Screen.PrimaryScreen.Bounds.Height - 110);
                accessFlag = false;
                settingFlag = false;

                SettingOptionsClose(sender, e);
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
        private void SettingButton_Cllick(object sender, EventArgs e)
        {//Opens up the Settings Panel
            if (settingFlag == false)
            {
                Location = new Point(Screen.PrimaryScreen.Bounds.Width - 550, 0);
                ClientSize = new Size(550, Screen.PrimaryScreen.Bounds.Height);
                SideBarPrimaryButtonPanel.Location = new Point(ClientSize.Width - 40, Screen.PrimaryScreen.Bounds.Height - 110);
                settingFlag = true;

                SettingOptionsOpen(sender, e);
            }
            else
            {
                Location = new Point(Screen.PrimaryScreen.Bounds.Width - 40, 0);
                ClientSize = new Size(40, Screen.PrimaryScreen.Bounds.Height);
                SideBarPrimaryButtonPanel.Location = new Point(0, Screen.PrimaryScreen.Bounds.Height - 110);
                settingFlag = false;

                SettingOptionsClose(sender, e);
            }
        }
        private void BackgroundColorChanger_Text_Changed(object sender, EventArgs e)
        {

        }
        private void VisiblityButton_Cllick(object sender, EventArgs e)
        {//Prevents or allows default behaviour(hide or unhide)
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
        private void CloseButton_Cllick(object sender, EventArgs e)
        {//Closes the SideBar
            this.Dispose();
            this.Close();
        }

    }
}
