using System.ComponentModel;

namespace POOF_00014419_00101519
{
    partial class UserView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserView));
            this.tabControlUserView = new System.Windows.Forms.TabControl();
            this.SuspendLayout();
            // 
            // tabControlUserView
            // 
            this.tabControlUserView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlUserView.Location = new System.Drawing.Point(0, 0);
            this.tabControlUserView.Name = "tabControlUserView";
            this.tabControlUserView.SelectedIndex = 0;
            this.tabControlUserView.Size = new System.Drawing.Size(802, 451);
            this.tabControlUserView.TabIndex = 0;
            // 
            // UserView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(802, 451);
            this.Controls.Add(this.tabControlUserView);
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UserView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserView";
            this.Load += new System.EventHandler(this.UserView_Load);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.TabControl tabControlUserView;

        #endregion
    }
}