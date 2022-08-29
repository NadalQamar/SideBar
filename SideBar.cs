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
        int formColorR;
        int formColorG;
        int formColorB;
        int formColorA;

        public SideBar()
        {
            InitializeComponent();
        }
        private void SideBar_Load(object sender, EventArgs e)
        {
            formColorA = BackColor.A;
            formColorR = BackColor.R;
            formColorG = BackColor.G;
            formColorB = BackColor.B;

        }

        //Methods
        private void SettingOptionsOpen (object sender, EventArgs e)//When setting options open
        {
            //size of the controls
            int sizeWidthBox = 30;
            int sizeHeightBox = 20;
            int sizeWidthLabel = 50;
            int sizeHeightLabel = 20;
            //red
            settingsBackgroundColorChangerRed.Location = new Point(20, 20);
            settingsBackgroundColorChangerRed.Size = new Size(sizeWidthBox, sizeHeightBox);
            settingsBackgroundColorChangerRed.Visible = true;
            settingsBackgroundColorChangerRed.Text = formColorR.ToString();
            //redLabel
            settingsBackgroundColorChangerRedLabel.Location = new Point(50, 20);
            settingsBackgroundColorChangerRedLabel.Size = new Size(sizeWidthLabel, sizeHeightLabel);
            settingsBackgroundColorChangerRedLabel.Visible = true;
            settingsBackgroundColorChangerRedLabel.Text = "Red";
            //green
            settingsBackgroundColorChangerGreen.Location = new Point(20, 50);
            settingsBackgroundColorChangerGreen.Size = new Size(sizeWidthBox, sizeHeightBox);
            settingsBackgroundColorChangerGreen.Visible = true;
            settingsBackgroundColorChangerGreen.Text = formColorG.ToString();
            //greenLabel
            settingsBackgroundColorChangerGreenLabel.Location = new Point(50, 50);
            settingsBackgroundColorChangerGreenLabel.Size = new Size(sizeWidthLabel, sizeHeightLabel);
            settingsBackgroundColorChangerGreenLabel.Visible = true;
            settingsBackgroundColorChangerGreenLabel.Text = "Green";
            //blue
            settingsBackgroundColorChangerBlue.Location = new Point(20, 80);
            settingsBackgroundColorChangerBlue.Size = new Size(sizeWidthBox, sizeHeightBox);
            settingsBackgroundColorChangerBlue.Visible = true;
            settingsBackgroundColorChangerBlue.Text = formColorB.ToString();
            //blueLabel
            settingsBackgroundColorChangerBlueLabel.Location = new Point(50, 80);
            settingsBackgroundColorChangerBlueLabel.Size = new Size(sizeWidthLabel, sizeHeightLabel);
            settingsBackgroundColorChangerBlueLabel.Visible = true;
            settingsBackgroundColorChangerBlueLabel.Text = "Blue";
        }
        private void SettingOptionsClose(object sender, EventArgs e)//When Setting options close
        {
            //red
            settingsBackgroundColorChangerRed.Location = new Point(0, 0);
            settingsBackgroundColorChangerRed.Size = new Size(0, 0);
            settingsBackgroundColorChangerRed.Visible = false;
            //redLabel
            settingsBackgroundColorChangerRedLabel.Location = new Point(0, 0);
            settingsBackgroundColorChangerRedLabel.Size = new Size(0, 0);
            settingsBackgroundColorChangerRedLabel.Visible = false;
            //green
            settingsBackgroundColorChangerGreen.Location = new Point(0, 0);
            settingsBackgroundColorChangerGreen.Size = new Size(0, 0);
            settingsBackgroundColorChangerGreen.Visible = false;
            //greenLabel
            settingsBackgroundColorChangerGreenLabel.Location = new Point(0, 0);
            settingsBackgroundColorChangerGreenLabel.Size = new Size(0, 0);
            settingsBackgroundColorChangerGreenLabel.Visible = false;
            //blue
            settingsBackgroundColorChangerBlue.Location = new Point(0, 0);
            settingsBackgroundColorChangerBlue.Size = new Size(0, 0);
            settingsBackgroundColorChangerBlue.Visible = false;
            //blueLabel
            settingsBackgroundColorChangerBlueLabel.Location = new Point(0, 0);
            settingsBackgroundColorChangerBlueLabel.Size = new Size(0, 0);
            settingsBackgroundColorChangerBlueLabel.Visible = false;
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
        private void BackgroundColorChangerRed_Text_Changed(object sender, EventArgs e)//red
        {
            if(Int32.TryParse(settingsBackgroundColorChangerRed.Text, out formColorR) == true)
            {
                BackColor = Color.FromArgb(formColorA, formColorR, formColorG, formColorB);
            }
            else
            {
                Console.WriteLine("Only Numbers1");
            }
        }
        private void BackgroundColorChangerGreen_Text_Changed(object sender, EventArgs e)//green
        {
            if (Int32.TryParse(settingsBackgroundColorChangerGreen.Text, out formColorG) == true)
            {
                BackColor = Color.FromArgb(formColorA, formColorR, formColorG, formColorB);
            }
            else
            {
                Console.WriteLine("Only Numbers"2);
            }
        }
        private void BackgroundColorChangerBlue_Text_Changed(object sender, EventArgs e)//blue
        {
            if (Int32.TryParse(settingsBackgroundColorChangerBlue.Text, out formColorB) == true)
            {
                BackColor = Color.FromArgb(formColorA, formColorR, formColorG, formColorB);
            }
            else
            {
                Console.WriteLine("Only Numbers3");
            }
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
