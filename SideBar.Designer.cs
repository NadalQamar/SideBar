using System.Windows.Forms;
using System.Drawing;

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
            this.ControlBox = new Label();
            this.SuspendLayout();

            //
            // ControlBox
            //

            this.ControlBox.Size = new Size(10, Screen.PrimaryScreen.Bounds.Height);
            this.ControlBox.BringToFront();
            this.ControlBox.Location = new Point(0, 0);
            this.ControlBox.MouseEnter += new System.EventHandler(this.Mouse_Enter);
            
            // 
            // SideBar
            //

            this.ClientSize = new Size(40, Screen.PrimaryScreen.Bounds.Height);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.StartPosition = FormStartPosition.Manual;
            this.Location = Location = new System.Drawing.Point(Screen.PrimaryScreen.Bounds.Width - 1, 0);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SideBar";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "SideBar";
            this.TopMost = true;
            this.Controls.Add(this.ControlBox);
            this.Load += new System.EventHandler(this.SideBar_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Label ControlBox;
    }
}