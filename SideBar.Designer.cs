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
            this.components = new System.ComponentModel.Container();
            this.ControlBox = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.visiblityButton = new System.Windows.Forms.Button();
            this.settingsButton = new System.Windows.Forms.Button();
            this.closeButtonInfo = new System.Windows.Forms.ToolTip(this.components);
            this.visiblityButtonInfo = new System.Windows.Forms.ToolTip(this.components);
            this.settingsButtonInfo = new System.Windows.Forms.ToolTip(this.components);
            this.SideBarPrimaryButtonPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SideBarPrimaryButtonPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ControlBox
            // 
            this.ControlBox.BackColor = System.Drawing.Color.Transparent;
            this.ControlBox.Location = new System.Drawing.Point(0, 0);
            this.ControlBox.Name = "ControlBox";
            this.ControlBox.Size = new System.Drawing.Size(10, Screen.PrimaryScreen.Bounds.Height);
            this.ControlBox.TabIndex = 2;
            this.ControlBox.MouseEnter += new System.EventHandler(this.Mouse_Enter);    
            // 
            // settingsButton
            // 
            this.settingsButton.Location = new System.Drawing.Point(0, 0);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(35, 30);
            this.settingsButton.TabIndex = 1;
            this.settingsButton.Text = "Ѕ";
            this.settingsButtonInfo.SetToolTip(this.settingsButton, "Settings");
            this.settingsButton.UseVisualStyleBackColor = true;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // visiblityButton
            // 
            this.visiblityButton.Location = new System.Drawing.Point(0, 40);
            this.visiblityButton.Name = "visiblityButton";
            this.visiblityButton.Size = new System.Drawing.Size(35, 30);
            this.visiblityButton.TabIndex = 2;
            this.visiblityButton.Text = "V";
            this.visiblityButtonInfo.SetToolTip(this.visiblityButton, "Visiblity");
            this.visiblityButton.UseVisualStyleBackColor = true;
            this.visiblityButton.Click += new System.EventHandler(this.visiblityButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(0, 80);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(35, 30);
            this.closeButton.TabIndex = 3;
            this.closeButton.Text = "Χ";
            this.closeButtonInfo.SetToolTip(this.closeButton, "Close");
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // SideBarPrimaryButtonPanel
            // 
            this.SideBarPrimaryButtonPanel.Controls.Add(this.settingsButton);
            this.SideBarPrimaryButtonPanel.Controls.Add(this.visiblityButton);
            this.SideBarPrimaryButtonPanel.Controls.Add(this.closeButton);        
            this.SideBarPrimaryButtonPanel.Location = new System.Drawing.Point(0, Screen.PrimaryScreen.Bounds.Height-110);
            this.SideBarPrimaryButtonPanel.Name = "SideBarPrimaryButtonPanel";
            this.SideBarPrimaryButtonPanel.Size = new System.Drawing.Size(40, 110);
            // 
            // SideBar
            // 
            this.ClientSize = new System.Drawing.Size(40, Screen.PrimaryScreen.Bounds.Height);
            this.Controls.Add(this.SideBarPrimaryButtonPanel);
            this.Controls.Add(this.ControlBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SideBar";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Location = Location = new System.Drawing.Point(Screen.PrimaryScreen.Bounds.Width - 1, 0);
            this.Text = "SideBar";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.SideBar_Load);
            this.SideBarPrimaryButtonPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private new Label ControlBox;
        private Button closeButton;
        private Button visiblityButton;
        private Button settingsButton;
        private ToolTip closeButtonInfo;
        private ToolTip visiblityButtonInfo;
        private ToolTip settingsButtonInfo;
        private FlowLayoutPanel SideBarPrimaryButtonPanel;
    }
}