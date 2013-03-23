namespace Kanjimusou
{
    partial class ZC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ZC));
            this.Username = new System.Windows.Forms.TextBox();
            this.passwd1 = new System.Windows.Forms.TextBox();
            this.passwd2 = new System.Windows.Forms.TextBox();
            this.submit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Error = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Error)).BeginInit();
            this.SuspendLayout();
            // 
            // Username
            // 
            this.Username.Location = new System.Drawing.Point(102, 105);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(179, 21);
            this.Username.TabIndex = 1;
            // 
            // passwd1
            // 
            this.passwd1.Location = new System.Drawing.Point(101, 152);
            this.passwd1.Name = "passwd1";
            this.passwd1.Size = new System.Drawing.Size(179, 21);
            this.passwd1.TabIndex = 2;
            this.passwd1.TextChanged += new System.EventHandler(this.passwd1_TextChanged);
            // 
            // passwd2
            // 
            this.passwd2.Location = new System.Drawing.Point(101, 193);
            this.passwd2.Name = "passwd2";
            this.passwd2.Size = new System.Drawing.Size(179, 21);
            this.passwd2.TabIndex = 3;
            this.passwd2.TextChanged += new System.EventHandler(this.passwd2_TextChanged);
            // 
            // submit
            // 
            this.submit.BackColor = System.Drawing.Color.Transparent;
            this.submit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("submit.BackgroundImage")));
            this.submit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.submit.FlatAppearance.BorderSize = 0;
            this.submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submit.ForeColor = System.Drawing.Color.Transparent;
            this.submit.Location = new System.Drawing.Point(265, 229);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(35, 52);
            this.submit.TabIndex = 4;
            this.submit.UseVisualStyleBackColor = false;
            this.submit.Visible = false;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(3, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(17, 16);
            this.button1.TabIndex = 5;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Error
            // 
            this.Error.BackColor = System.Drawing.Color.Transparent;
            this.Error.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Error.BackgroundImage")));
            this.Error.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Error.Location = new System.Drawing.Point(283, 193);
            this.Error.Name = "Error";
            this.Error.Size = new System.Drawing.Size(20, 20);
            this.Error.TabIndex = 6;
            this.Error.TabStop = false;
            this.Error.Visible = false;
            // 
            // ZC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(324, 289);
            this.Controls.Add(this.Error);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.passwd2);
            this.Controls.Add(this.passwd1);
            this.Controls.Add(this.Username);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ZC";
            this.Opacity = 0.9D;
            this.Text = "logon";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.logon_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.Error)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.TextBox passwd1;
        private System.Windows.Forms.TextBox passwd2;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox Error;
    }
}