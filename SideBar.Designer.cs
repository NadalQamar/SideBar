using System;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;

namespace SideBar
{
    partial class SideBar
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
            this.components = new Container();
            this.ControlBox = new Label();
            this.settingsButton = new Button();
            this.settingsBackgroundColorChangerRed = new TextBox();
            this.settingsBackgroundColorChangerRedLabel = new Label();
            this.settingsBackgroundColorChangerGreen = new TextBox();
            this.settingsBackgroundColorChangerGreenLabel = new Label();
            this.settingsBackgroundColorChangerBlue = new TextBox();
            this.settingsBackgroundColorChangerBlueLabel = new Label();
            this.visiblityButton = new Button();
            this.closeButton = new Button();
            this.settingsButtonInfo = new ToolTip(this.components);
            this.visiblityButtonInfo = new ToolTip(this.components);
            this.closeButtonInfo = new ToolTip(this.components);
            this.SideBarPrimaryButtonPanel = new FlowLayoutPanel();
            this.SideBarPrimaryButtonPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ControlBox
            // 
            this.ControlBox.BackColor = Color.Transparent;
            this.ControlBox.Location = new Point(0, 0);
            this.ControlBox.Name = "ControlBox";
            this.ControlBox.Size = new Size(10, Screen.PrimaryScreen.Bounds.Height);
            this.ControlBox.TabIndex = 2;
            this.ControlBox.MouseEnter += new EventHandler(this.Mouse_Enter);
            // 
            // settingsButton
            // 
            this.settingsButton.Location = new Point(0, 0);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new Size(35, 30);
            this.settingsButton.TabIndex = 1;
            this.settingsButton.Text = "Ѕ";
            this.settingsButtonInfo.SetToolTip(this.settingsButton, "Settings");
            this.settingsButton.UseVisualStyleBackColor = true;
            this.settingsButton.Click += new EventHandler(this.SettingButton_Cllick);
            //
            //settingsBackgroundColorChangerRed
            //
            this.Controls.Add(settingsBackgroundColorChangerRed);
            this.settingsBackgroundColorChangerRed.Name = "settingsBackgroundColorChangerRed";
            this.settingsBackgroundColorChangerRed.Location = new Point(0, 0);
            this.settingsBackgroundColorChangerRed.Size = new Size(0, 0);
            this.settingsBackgroundColorChangerRed.Visible = false;
            this.settingsBackgroundColorChangerRed.TextChanged += new EventHandler(this.BackgroundColorChangerRed_Text_Changed);
            this.settingsBackgroundColorChangerRed.MaxLength = 3;
            //
            //settingsBackgroundColorChangerRedLabel
            //
            this.Controls.Add(settingsBackgroundColorChangerRedLabel);
            this.settingsBackgroundColorChangerRedLabel.Name = "settingsBackgroundColorChangerRedLabel";
            this.settingsBackgroundColorChangerRedLabel.Location = new Point(0, 0);
            this.settingsBackgroundColorChangerRedLabel.Size = new Size(0, 0);
            this.settingsBackgroundColorChangerRedLabel.Visible = false;
            //
            //settingsBackgroundColorChangerGreen
            //
            this.Controls.Add(settingsBackgroundColorChangerGreen);
            this.settingsBackgroundColorChangerGreen.Name = "settingsBackgroundColorChangerGreen";
            this.settingsBackgroundColorChangerGreen.Location = new Point(0, 0);
            this.settingsBackgroundColorChangerGreen.Size = new Size(0, 0);
            this.settingsBackgroundColorChangerGreen.Visible = false;
            this.settingsBackgroundColorChangerGreen.TextChanged += new EventHandler(this.BackgroundColorChangerGreen_Text_Changed);
            this.settingsBackgroundColorChangerGreen.MaxLength = 3;
            //
            //settingsBackgroundColorChangerGreenLabel
            //
            this.Controls.Add(settingsBackgroundColorChangerGreenLabel);
            this.settingsBackgroundColorChangerGreenLabel.Name = "settingsBackgroundColorChangerGreenLabel";
            this.settingsBackgroundColorChangerGreenLabel.Location = new Point(0, 0);
            this.settingsBackgroundColorChangerGreenLabel.Size = new Size(0, 0);
            this.settingsBackgroundColorChangerGreenLabel.Visible = false;
            //
            //settingsBackgroundColorChangerBlue
            //
            this.Controls.Add(settingsBackgroundColorChangerBlue);
            this.settingsBackgroundColorChangerBlue.Name = "settingsBackgroundColorChangerBlue";
            this.settingsBackgroundColorChangerBlue.Location = new Point(0, 0);
            this.settingsBackgroundColorChangerBlue.Size = new Size(0, 0);
            this.settingsBackgroundColorChangerBlue.Visible = false;
            this.settingsBackgroundColorChangerBlue.TextChanged += new EventHandler(this.BackgroundColorChangerBlue_Text_Changed);
            this.settingsBackgroundColorChangerBlue.MaxLength = 3;
            //
            //settingsBackgroundColorChangerBlueLabel
            //
            this.Controls.Add(settingsBackgroundColorChangerBlueLabel);
            this.settingsBackgroundColorChangerBlueLabel.Name = "settingsBackgroundColorChangerBlueLabel";
            this.settingsBackgroundColorChangerBlueLabel.Location = new Point(0, 0);
            this.settingsBackgroundColorChangerBlueLabel.Size = new Size(0, 0);
            this.settingsBackgroundColorChangerBlueLabel.Visible = false;
            // 
            // visiblityButton
            // 
            this.visiblityButton.Location = new Point(0, 40);
            this.visiblityButton.Name = "visiblityButton";
            this.visiblityButton.Size = new Size(35, 30);
            this.visiblityButton.TabIndex = 2;
            this.visiblityButton.Text = "V";
            this.visiblityButtonInfo.SetToolTip(this.visiblityButton, "Visiblity");
            this.visiblityButton.UseVisualStyleBackColor = true;
            this.visiblityButton.Click += new EventHandler(this.VisiblityButton_Cllick);
            // 
            // closeButton
            // 
            this.closeButton.Location = new Point(0, 80);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new Size(35, 30);
            this.closeButton.TabIndex = 3;
            this.closeButton.Text = "Χ";
            this.closeButtonInfo.SetToolTip(this.closeButton, "Close");
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new EventHandler(this.CloseButton_Cllick);
            // 
            // SideBarPrimaryButtonPanel
            // 
            this.SideBarPrimaryButtonPanel.Controls.Add(this.settingsButton);
            this.SideBarPrimaryButtonPanel.Controls.Add(this.visiblityButton);
            this.SideBarPrimaryButtonPanel.Controls.Add(this.closeButton);        
            this.SideBarPrimaryButtonPanel.Location = new Point(0, Screen.PrimaryScreen.Bounds.Height-110);
            this.SideBarPrimaryButtonPanel.Name = "SideBarPrimaryButtonPanel";
            this.SideBarPrimaryButtonPanel.Size = new Size(40, 110);
            // 
            // SideBar
            // 
            this.ClientSize = new Size(40, Screen.PrimaryScreen.Bounds.Height);
            this.Controls.Add(this.SideBarPrimaryButtonPanel);
            this.Controls.Add(this.ControlBox);
            this.FormBorderStyle = FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SideBar";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = FormStartPosition.Manual;
            this.Location = Location = new Point(Screen.PrimaryScreen.Bounds.Width - 1, 0);
            this.Text = "SideBar";
            this.TopMost = true;
            this.Load += new EventHandler(this.SideBar_Load);
            this.SideBarPrimaryButtonPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private new Label ControlBox;
        private Button settingsButton;
        private TextBox settingsBackgroundColorChangerRed;
        private Label settingsBackgroundColorChangerRedLabel;
        private TextBox settingsBackgroundColorChangerGreen;
        private Label settingsBackgroundColorChangerGreenLabel;
        private TextBox settingsBackgroundColorChangerBlue;
        private Label settingsBackgroundColorChangerBlueLabel;
        private Button visiblityButton;
        private Button closeButton;
        private ToolTip closeButtonInfo;
        private ToolTip visiblityButtonInfo;
        private ToolTip settingsButtonInfo;
        private FlowLayoutPanel SideBarPrimaryButtonPanel;
    }
}