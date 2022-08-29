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
            this.settingsBackgroundColorChanger = new TextBox();
            this.settingsBackgroundColorChangerButton = new Button();
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
            //settingsBackgroundColorChanger
            //
            this.Controls.Add(settingsBackgroundColorChanger);
            this.settingsBackgroundColorChanger.Name = "settingsBackgroundColorChanger";
            this.settingsBackgroundColorChanger.Location = new Point(0, 0);
            this.settingsBackgroundColorChanger.Size = new Size(0, 0);
            this.settingsBackgroundColorChanger.Visible = false;
            this.settingsBackgroundColorChanger.Text = "#hex color";
            this.settingsBackgroundColorChanger.TextChanged += new EventHandler(this.BackgroundColorChanger_Text_Changed);
            //
            //settingsBackgroundColorChangerButton
            //
            this.Controls.Add(settingsBackgroundColorChangerButton);
            this.settingsBackgroundColorChangerButton.Name = "settingsBackgroundColorChangerButton";
            this.settingsBackgroundColorChangerButton.Location = new Point(0, 0);
            this.settingsBackgroundColorChangerButton.Size = new Size(0, 0);
            this.settingsBackgroundColorChangerButton.Visible = false;
            this.settingsBackgroundColorChangerButton.UseVisualStyleBackColor= true;
            this.settingsBackgroundColorChangerButton.Text = "Submit";
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
        private TextBox settingsBackgroundColorChanger;
        private Button settingsBackgroundColorChangerButton;
        private Button visiblityButton;
        private Button closeButton;
        private ToolTip closeButtonInfo;
        private ToolTip visiblityButtonInfo;
        private ToolTip settingsButtonInfo;
        private FlowLayoutPanel SideBarPrimaryButtonPanel;
    }
}