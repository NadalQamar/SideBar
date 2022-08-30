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
        int formColorA;
        int formColorR;
        int formColorG;
        int formColorB;
        

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
            //position of controlsTextBox
            int[] position1 = { 20, 20 };
            int[] position2 = { 20, 50 };//y+30
            int[] position3 = { 20, 80 };
            int[] position4 = { 20, 110 };
            //position of controlsLabel
            int[] position1Label = { 50, 23 };
            int[] position2Label = { 50, 53 };
            int[] position3Label = { 50, 83 };
            int[] position4Label = { 50, 113 };
            //size of the controls
            int sizeWidthBox = 30;
            int sizeHeightBox = 20;
            int sizeWidthLabel = 100;
            int sizeHeightLabel = 20;

            ////alpha-opacity
            //settingsBackgroundColorChangerAlpha.Location = new Point(position1[0], position1[1]);
            //settingsBackgroundColorChangerAlpha.Size = new Size(sizeWidthBox, sizeHeightBox);
            //settingsBackgroundColorChangerAlpha.Visible = true;
            //settingsBackgroundColorChangerAlpha.Text = formColorA.ToString();
            ////alpha-opacityLabel
            //settingsBackgroundColorChangerAlphaLabel.Location = new Point(position1Label[0], position1Label[1]);
            //settingsBackgroundColorChangerAlphaLabel.Size = new Size(sizeWidthLabel, sizeHeightLabel);
            //settingsBackgroundColorChangerAlphaLabel.Visible = true;
            //settingsBackgroundColorChangerAlphaLabel.Text = "0-255 Opacity";
            //red
            settingsBackgroundColorChangerRed.Location = new Point(position2[0], position2[1]);
            settingsBackgroundColorChangerRed.Size = new Size(sizeWidthBox, sizeHeightBox);
            settingsBackgroundColorChangerRed.Visible = true;
            settingsBackgroundColorChangerRed.Text = formColorR.ToString();
            //redLabel
            settingsBackgroundColorChangerRedLabel.Location = new Point(position2Label[0], position2Label[1]);
            settingsBackgroundColorChangerRedLabel.Size = new Size(sizeWidthLabel, sizeHeightLabel);
            settingsBackgroundColorChangerRedLabel.Visible = true;
            settingsBackgroundColorChangerRedLabel.Text = "0-255 Red";
            //green
            settingsBackgroundColorChangerGreen.Location = new Point(position3[0], position3[1]);
            settingsBackgroundColorChangerGreen.Size = new Size(sizeWidthBox, sizeHeightBox);
            settingsBackgroundColorChangerGreen.Visible = true;
            settingsBackgroundColorChangerGreen.Text = formColorG.ToString();
            //greenLabel
            settingsBackgroundColorChangerGreenLabel.Location = new Point(position3Label[0], position3Label[1]);
            settingsBackgroundColorChangerGreenLabel.Size = new Size(sizeWidthLabel, sizeHeightLabel);
            settingsBackgroundColorChangerGreenLabel.Visible = true;
            settingsBackgroundColorChangerGreenLabel.Text = "0-255 Green";
            //blue
            settingsBackgroundColorChangerBlue.Location = new Point(position4[0], position4[1]);
            settingsBackgroundColorChangerBlue.Size = new Size(sizeWidthBox, sizeHeightBox);
            settingsBackgroundColorChangerBlue.Visible = true;
            settingsBackgroundColorChangerBlue.Text = formColorB.ToString();
            //blueLabel
            settingsBackgroundColorChangerBlueLabel.Location = new Point(position4Label[0], position4Label[1]);
            settingsBackgroundColorChangerBlueLabel.Size = new Size(sizeWidthLabel, sizeHeightLabel);
            settingsBackgroundColorChangerBlueLabel.Visible = true;
            settingsBackgroundColorChangerBlueLabel.Text = "0-255 Blue";
        }
        private void SettingOptionsClose(object sender, EventArgs e)//When setting options close
        {
            ////alpha-opacity
            //settingsBackgroundColorChangerAlpha.Location = new Point(0, 0);
            //settingsBackgroundColorChangerAlpha.Size = new Size(0, 0);
            //settingsBackgroundColorChangerAlpha.Visible = false;
            ////alpha-opacityLabel
            //settingsBackgroundColorChangerAlphaLabel.Location = new Point(0, 0);
            //settingsBackgroundColorChangerAlphaLabel.Size = new Size(0, 0);
            //settingsBackgroundColorChangerAlphaLabel.Visible = false;
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
        //private void BackgroundColorChangerAlpha_Text_Changed(object sender, EventArgs e)//alpha-opacity
        //{
        //    if (Int32.TryParse(settingsBackgroundColorChangerAlpha.Text, out formColorA))
        //    {   if(formColorA > 255)
        //        {
        //            //do nothing
        //        }
        //        else
        //        {
        //            BackColor = Color.FromArgb(formColorA, formColorR, formColorG, formColorB);
        //        }
                
        //    }
        //    else
        //    {
        //        formColorA = 0;
        //        //settingsBackgroundColorChangerAlpha.Text = formColorA.ToString();
        //        BackColor = Color.FromArgb(formColorA, formColorR, formColorG, formColorB);

        //    }
        //}
        private void BackgroundColorChangerRed_Text_Changed(object sender, EventArgs e)//red
        {
            if(Int32.TryParse(settingsBackgroundColorChangerRed.Text, out formColorR))
            {
                if (formColorR > 255)
                {
                    //do nothing
                }
                else
                {
                    BackColor = Color.FromArgb(formColorA, formColorR, formColorG, formColorB);
                }
            }
            else
            {
                formColorR = 0;
                //settingsBackgroundColorChangerRed.Text = formColorR.ToString();
                BackColor = Color.FromArgb(formColorA, formColorR, formColorG, formColorB);

            }
        }
        private void BackgroundColorChangerGreen_Text_Changed(object sender, EventArgs e)//green
        {
            if (Int32.TryParse(settingsBackgroundColorChangerGreen.Text, out formColorG))
            {
                if (formColorG > 255)
                {
                    //do nothing
                }
                else
                {
                    BackColor = Color.FromArgb(formColorA, formColorR, formColorG, formColorB);
                }
            }
            else
            {
                formColorG = 0;
               // settingsBackgroundColorChangerGreen.Text = formColorG.ToString();
                BackColor = Color.FromArgb(formColorA, formColorR, formColorG, formColorB);
            }
        }
        private void BackgroundColorChangerBlue_Text_Changed(object sender, EventArgs e)//blue
        {
            if (Int32.TryParse(settingsBackgroundColorChangerBlue.Text, out formColorB))
            {
                if (formColorB > 255)
                {
                    //do nothing
                }
                else
                {
                    BackColor = Color.FromArgb(formColorA, formColorR, formColorG, formColorB);
                }
            }
            else
            {
                formColorB = 0;
                //settingsBackgroundColorChangerBlue.Text = formColorB.ToString();
                BackColor = Color.FromArgb(formColorA, formColorR, formColorG, formColorB);
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
            this.Close();
            this.Dispose();
            
        }

    }
}
