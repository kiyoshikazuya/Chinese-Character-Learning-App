namespace Kanjimusou
{
    partial class welcome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(welcome));
            this.start = new System.Windows.Forms.Button();
            this.information = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.challengeMode = new System.Windows.Forms.Button();
            this.userName = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // start
            // 
            this.start.BackColor = System.Drawing.Color.Transparent;
            this.start.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("start.BackgroundImage")));
            this.start.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.start.FlatAppearance.BorderSize = 0;
            this.start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.start.ForeColor = System.Drawing.Color.Transparent;
            this.start.Location = new System.Drawing.Point(118, 153);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(114, 29);
            this.start.TabIndex = 1;
            this.start.UseVisualStyleBackColor = false;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // information
            // 
            this.information.BackColor = System.Drawing.Color.Transparent;
            this.information.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("information.BackgroundImage")));
            this.information.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.information.FlatAppearance.BorderSize = 0;
            this.information.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.information.Location = new System.Drawing.Point(111, 233);
            this.information.Name = "information";
            this.information.Size = new System.Drawing.Size(122, 39);
            this.information.TabIndex = 2;
            this.information.UseVisualStyleBackColor = false;
            this.information.Click += new System.EventHandler(this.information_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(1, -1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(19, 18);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // challengeMode
            // 
            this.challengeMode.BackColor = System.Drawing.Color.Transparent;
            this.challengeMode.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("challengeMode.BackgroundImage")));
            this.challengeMode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.challengeMode.FlatAppearance.BorderSize = 0;
            this.challengeMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.challengeMode.ForeColor = System.Drawing.Color.Transparent;
            this.challengeMode.Location = new System.Drawing.Point(127, 198);
            this.challengeMode.Name = "challengeMode";
            this.challengeMode.Size = new System.Drawing.Size(94, 29);
            this.challengeMode.TabIndex = 5;
            this.challengeMode.UseVisualStyleBackColor = false;
            this.challengeMode.Click += new System.EventHandler(this.challengeMode_Click);
            // 
            // userName
            // 
            this.userName.BackColor = System.Drawing.Color.Transparent;
            this.userName.Enabled = false;
            this.userName.FlatAppearance.BorderSize = 0;
            this.userName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userName.Font = new System.Drawing.Font("新宋体", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.userName.Location = new System.Drawing.Point(88, 97);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(177, 39);
            this.userName.TabIndex = 6;
            this.userName.UseVisualStyleBackColor = false;
            // 
            // welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(368, 293);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.challengeMode);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.information);
            this.Controls.Add(this.start);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "welcome";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "welcome";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.welcome_MouseDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Button information;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button challengeMode;
        private System.Windows.Forms.Button userName;
    }
}