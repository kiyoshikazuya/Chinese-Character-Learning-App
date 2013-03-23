namespace Kanjimusou
{
    partial class achievement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(achievement));
            this.nameOfAch = new System.Windows.Forms.Label();
            this.course = new System.Windows.Forms.Label();
            this.ach = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.allHanzi = new System.Windows.Forms.Label();
            this.share = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameOfAch
            // 
            this.nameOfAch.AutoSize = true;
            this.nameOfAch.Location = new System.Drawing.Point(100, 62);
            this.nameOfAch.Name = "nameOfAch";
            this.nameOfAch.Size = new System.Drawing.Size(29, 12);
            this.nameOfAch.TabIndex = 0;
            this.nameOfAch.Text = "name";
            // 
            // course
            // 
            this.course.AutoSize = true;
            this.course.Location = new System.Drawing.Point(184, 110);
            this.course.Name = "course";
            this.course.Size = new System.Drawing.Size(41, 12);
            this.course.TabIndex = 1;
            this.course.Text = "course";
            // 
            // ach
            // 
            this.ach.AutoSize = true;
            this.ach.Location = new System.Drawing.Point(79, 301);
            this.ach.Name = "ach";
            this.ach.Size = new System.Drawing.Size(125, 12);
            this.ach.TabIndex = 2;
            this.ach.Text = "achievement of today";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(2, -1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(17, 17);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // allHanzi
            // 
            this.allHanzi.AutoSize = true;
            this.allHanzi.Location = new System.Drawing.Point(79, 218);
            this.allHanzi.Name = "allHanzi";
            this.allHanzi.Size = new System.Drawing.Size(41, 12);
            this.allHanzi.TabIndex = 4;
            this.allHanzi.Text = "label1";
            // 
            // share
            // 
            this.share.BackColor = System.Drawing.Color.Transparent;
            this.share.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("share.BackgroundImage")));
            this.share.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.share.FlatAppearance.BorderSize = 0;
            this.share.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.share.Location = new System.Drawing.Point(330, 402);
            this.share.Name = "share";
            this.share.Size = new System.Drawing.Size(34, 59);
            this.share.TabIndex = 5;
            this.share.UseVisualStyleBackColor = false;
            this.share.Click += new System.EventHandler(this.share_Click);
            // 
            // achievement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(367, 473);
            this.Controls.Add(this.share);
            this.Controls.Add(this.allHanzi);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ach);
            this.Controls.Add(this.course);
            this.Controls.Add(this.nameOfAch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "achievement";
            this.Opacity = 0.9D;
            this.Text = "achievement";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.achievement_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameOfAch;
        private System.Windows.Forms.Label course;
        private System.Windows.Forms.Label ach;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label allHanzi;
        private System.Windows.Forms.Button share;
    }
}