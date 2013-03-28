namespace Kanjimusou
{
    partial class challenge
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(challenge));
            this.next = new System.Windows.Forms.Button();
            this.hanziPictureBox1 = new Kanjimusou.Lib.HanziPictureBox();
            this.resttime = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.nowLevel = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.hanziPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resttime)).BeginInit();
            this.SuspendLayout();
            // 
            // next
            // 
            this.next.BackColor = System.Drawing.Color.Transparent;
            this.next.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("next.BackgroundImage")));
            this.next.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.next.FlatAppearance.BorderSize = 0;
            this.next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.next.ForeColor = System.Drawing.Color.Transparent;
            this.next.Location = new System.Drawing.Point(250, 596);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(73, 74);
            this.next.TabIndex = 0;
            this.next.UseVisualStyleBackColor = false;
            this.next.Visible = false;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // hanziPictureBox1
            // 
            this.hanziPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.hanziPictureBox1.Hanzi = null;
            this.hanziPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("hanziPictureBox1.Image")));
            this.hanziPictureBox1.IsInkMode = true;
            this.hanziPictureBox1.IsShowHelper = false;
            this.hanziPictureBox1.Location = new System.Drawing.Point(28, 90);
            this.hanziPictureBox1.Name = "hanziPictureBox1";
            this.hanziPictureBox1.Size = new System.Drawing.Size(500, 500);
            this.hanziPictureBox1.TabIndex = 1;
            this.hanziPictureBox1.TabStop = false;
            // 
            // resttime
            // 
            this.resttime.BackColor = System.Drawing.Color.Transparent;
            this.resttime.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("resttime.BackgroundImage")));
            this.resttime.Location = new System.Drawing.Point(99, 681);
            this.resttime.Name = "resttime";
            this.resttime.Size = new System.Drawing.Size(440, 20);
            this.resttime.TabIndex = 2;
            this.resttime.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(0, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(19, 19);
            this.button1.TabIndex = 5;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // nowLevel
            // 
            this.nowLevel.AutoSize = true;
            this.nowLevel.BackColor = System.Drawing.Color.Transparent;
            this.nowLevel.Font = new System.Drawing.Font("楷体", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.nowLevel.Location = new System.Drawing.Point(186, 21);
            this.nowLevel.Name = "nowLevel";
            this.nowLevel.Size = new System.Drawing.Size(53, 56);
            this.nowLevel.TabIndex = 6;
            this.nowLevel.Text = "0";
            this.nowLevel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Enabled = false;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(274, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(78, 72);
            this.button2.TabIndex = 8;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Enabled = false;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(28, 644);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(65, 72);
            this.button3.TabIndex = 9;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // challenge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(571, 739);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.nowLevel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.resttime);
            this.Controls.Add(this.hanziPictureBox1);
            this.Controls.Add(this.next);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "challenge";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "chanllenge";
            ((System.ComponentModel.ISupportInitialize)(this.hanziPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resttime)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button next;
        private Lib.HanziPictureBox hanziPictureBox1;
        private System.Windows.Forms.PictureBox resttime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label nowLevel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}