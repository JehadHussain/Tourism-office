namespace Tourism_office
{
    partial class frmlebanon
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homePageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.destinationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jprdanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.egyptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lebanonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hotelsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.signInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.signUpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homePageToolStripMenuItem,
            this.destinationToolStripMenuItem,
            this.hotelsToolStripMenuItem,
            this.accountToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homePageToolStripMenuItem
            // 
            this.homePageToolStripMenuItem.Name = "homePageToolStripMenuItem";
            this.homePageToolStripMenuItem.Size = new System.Drawing.Size(102, 24);
            this.homePageToolStripMenuItem.Text = "Home page";
            this.homePageToolStripMenuItem.Click += new System.EventHandler(this.homePageToolStripMenuItem_Click);
            // 
            // destinationToolStripMenuItem
            // 
            this.destinationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jprdanToolStripMenuItem,
            this.egyptToolStripMenuItem,
            this.lebanonToolStripMenuItem});
            this.destinationToolStripMenuItem.Name = "destinationToolStripMenuItem";
            this.destinationToolStripMenuItem.Size = new System.Drawing.Size(99, 24);
            this.destinationToolStripMenuItem.Text = "Destination";
            // 
            // jprdanToolStripMenuItem
            // 
            this.jprdanToolStripMenuItem.Name = "jprdanToolStripMenuItem";
            this.jprdanToolStripMenuItem.Size = new System.Drawing.Size(149, 26);
            this.jprdanToolStripMenuItem.Text = "Jprdan";
            // 
            // egyptToolStripMenuItem
            // 
            this.egyptToolStripMenuItem.Name = "egyptToolStripMenuItem";
            this.egyptToolStripMenuItem.Size = new System.Drawing.Size(149, 26);
            this.egyptToolStripMenuItem.Text = "Egypt";
            // 
            // lebanonToolStripMenuItem
            // 
            this.lebanonToolStripMenuItem.Name = "lebanonToolStripMenuItem";
            this.lebanonToolStripMenuItem.Size = new System.Drawing.Size(149, 26);
            this.lebanonToolStripMenuItem.Text = "Lebanon";
            // 
            // hotelsToolStripMenuItem
            // 
            this.hotelsToolStripMenuItem.Name = "hotelsToolStripMenuItem";
            this.hotelsToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.hotelsToolStripMenuItem.Text = "hotels";
            this.hotelsToolStripMenuItem.Click += new System.EventHandler(this.hotelsToolStripMenuItem_Click);
            // 
            // accountToolStripMenuItem
            // 
            this.accountToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.signInToolStripMenuItem,
            this.signUpToolStripMenuItem});
            this.accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            this.accountToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.accountToolStripMenuItem.Text = "Account";
            // 
            // signInToolStripMenuItem
            // 
            this.signInToolStripMenuItem.Name = "signInToolStripMenuItem";
            this.signInToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.signInToolStripMenuItem.Text = "sign in";
            this.signInToolStripMenuItem.Click += new System.EventHandler(this.signInToolStripMenuItem_Click);
            // 
            // signUpToolStripMenuItem
            // 
            this.signUpToolStripMenuItem.Name = "signUpToolStripMenuItem";
            this.signUpToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.signUpToolStripMenuItem.Text = "sign up";
            this.signUpToolStripMenuItem.Click += new System.EventHandler(this.signUpToolStripMenuItem_Click);
            // 
            // frmlebanon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frmlebanon";
            this.Text = "Lebanon";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homePageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem destinationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jprdanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem egyptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lebanonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hotelsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem signInToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem signUpToolStripMenuItem;
    }
}