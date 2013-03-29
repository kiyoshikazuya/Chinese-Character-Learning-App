namespace Kanjimusou
{
    partial class learn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(learn));
            this.sound = new System.Windows.Forms.Button();
            this.close_it = new System.Windows.Forms.Button();
            this.prev = new System.Windows.Forms.Button();
            this.next = new System.Windows.Forms.Button();
            this.paraphrase = new System.Windows.Forms.Label();
            this.more = new System.Windows.Forms.LinkLabel();
            this.backspace = new System.Windows.Forms.Button();
            this.clean = new System.Windows.Forms.Button();
            this.tips = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.hanziPictureBox1 = new Kanjimusou.Lib.HanziPictureBox();
            this.infoLabel = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.hanziPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // sound
            // 
            this.sound.BackColor = System.Drawing.Color.Transparent;
            this.sound.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sound.BackgroundImage")));
            this.sound.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sound.Location = new System.Drawing.Point(548, 518);
            this.sound.Name = "sound";
            this.sound.Size = new System.Drawing.Size(48, 51);
            this.sound.TabIndex = 1;
            this.sound.UseVisualStyleBackColor = false;
            this.sound.Click += new System.EventHandler(this.sound_Click);
            // 
            // close_it
            // 
            this.close_it.BackColor = System.Drawing.Color.Transparent;
            this.close_it.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("close_it.BackgroundImage")));
            this.close_it.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.close_it.FlatAppearance.BorderSize = 0;
            this.close_it.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close_it.ForeColor = System.Drawing.Color.Transparent;
            this.close_it.Location = new System.Drawing.Point(2, 0);
            this.close_it.Name = "close_it";
            this.close_it.Size = new System.Drawing.Size(20, 18);
            this.close_it.TabIndex = 2;
            this.close_it.UseVisualStyleBackColor = false;
            this.close_it.Click += new System.EventHandler(this.close_it_Click);
            // 
            // prev
            // 
            this.prev.BackColor = System.Drawing.Color.Transparent;
            this.prev.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("prev.BackgroundImage")));
            this.prev.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.prev.FlatAppearance.BorderSize = 0;
            this.prev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.prev.Location = new System.Drawing.Point(548, 252);
            this.prev.Name = "prev";
            this.prev.Size = new System.Drawing.Size(48, 56);
            this.prev.TabIndex = 3;
            this.prev.UseVisualStyleBackColor = false;
            this.prev.Click += new System.EventHandler(this.prev_Click);
            // 
            // next
            // 
            this.next.BackColor = System.Drawing.Color.Transparent;
            this.next.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("next.BackgroundImage")));
            this.next.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.next.FlatAppearance.BorderSize = 0;
            this.next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.next.Location = new System.Drawing.Point(548, 389);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(48, 56);
            this.next.TabIndex = 5;
            this.next.UseVisualStyleBackColor = false;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // paraphrase
            // 
            this.paraphrase.AutoSize = true;
            this.paraphrase.BackColor = System.Drawing.Color.Transparent;
            this.paraphrase.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.paraphrase.Location = new System.Drawing.Point(295, 613);
            this.paraphrase.Name = "paraphrase";
            this.paraphrase.Size = new System.Drawing.Size(115, 24);
            this.paraphrase.TabIndex = 6;
            this.paraphrase.Text = "paraphrase";
            // 
            // more
            // 
            this.more.AutoSize = true;
            this.more.BackColor = System.Drawing.Color.Transparent;
            this.more.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.more.ForeColor = System.Drawing.Color.Transparent;
            this.more.Location = new System.Drawing.Point(471, 607);
            this.more.Name = "more";
            this.more.Size = new System.Drawing.Size(60, 25);
            this.more.TabIndex = 7;
            this.more.TabStop = true;
            this.more.Text = "more";
            this.more.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.more_LinkClicked);
            // 
            // backspace
            // 
            this.backspace.BackColor = System.Drawing.Color.Transparent;
            this.backspace.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backspace.BackgroundImage")));
            this.backspace.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backspace.FlatAppearance.BorderSize = 0;
            this.backspace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backspace.Location = new System.Drawing.Point(52, 22);
            this.backspace.Name = "backspace";
            this.backspace.Size = new System.Drawing.Size(43, 41);
            this.backspace.TabIndex = 8;
            this.backspace.UseVisualStyleBackColor = false;
            this.backspace.Click += new System.EventHandler(this.backspace_Click);
            // 
            // clean
            // 
            this.clean.BackColor = System.Drawing.Color.Transparent;
            this.clean.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("clean.BackgroundImage")));
            this.clean.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.clean.FlatAppearance.BorderSize = 0;
            this.clean.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clean.Location = new System.Drawing.Point(146, 22);
            this.clean.Name = "clean";
            this.clean.Size = new System.Drawing.Size(43, 41);
            this.clean.TabIndex = 9;
            this.clean.UseVisualStyleBackColor = false;
            this.clean.Click += new System.EventHandler(this.clean_Click);
            // 
            // tips
            // 
            this.tips.BackColor = System.Drawing.Color.Transparent;
            this.tips.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tips.BackgroundImage")));
            this.tips.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tips.FlatAppearance.BorderSize = 0;
            this.tips.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tips.Location = new System.Drawing.Point(243, 22);
            this.tips.Name = "tips";
            this.tips.Size = new System.Drawing.Size(43, 41);
            this.tips.TabIndex = 10;
            this.tips.UseVisualStyleBackColor = false;
            this.tips.Click += new System.EventHandler(this.tips_Click);
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.Color.Transparent;
            this.save.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("save.BackgroundImage")));
            this.save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.save.FlatAppearance.BorderSize = 0;
            this.save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save.Location = new System.Drawing.Point(344, 22);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(43, 41);
            this.save.TabIndex = 11;
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // hanziPictureBox1
            // 
            this.hanziPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.hanziPictureBox1.Hanzi = null;
            this.hanziPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("hanziPictureBox1.Image")));
            this.hanziPictureBox1.IsInkMode = true;
            this.hanziPictureBox1.IsShowHelper = false;
            this.hanziPictureBox1.Location = new System.Drawing.Point(31, 88);
            this.hanziPictureBox1.Name = "hanziPictureBox1";
            this.hanziPictureBox1.Size = new System.Drawing.Size(500, 500);
            this.hanziPictureBox1.TabIndex = 12;
            this.hanziPictureBox1.TabStop = false;
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.BackColor = System.Drawing.Color.Transparent;
            this.infoLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.infoLabel.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.infoLabel.ForeColor = System.Drawing.Color.Red;
            this.infoLabel.Location = new System.Drawing.Point(26, 609);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(48, 25);
            this.infoLabel.TabIndex = 13;
            this.infoLabel.Text = "info";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "png图片|*.png";
            this.saveFileDialog1.RestoreDirectory = true;
            // 
            // learn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(615, 675);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.hanziPictureBox1);
            this.Controls.Add(this.save);
            this.Controls.Add(this.tips);
            this.Controls.Add(this.clean);
            this.Controls.Add(this.backspace);
            this.Controls.Add(this.more);
            this.Controls.Add(this.paraphrase);
            this.Controls.Add(this.next);
            this.Controls.Add(this.prev);
            this.Controls.Add(this.close_it);
            this.Controls.Add(this.sound);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "learn";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "learn";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.learn_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.hanziPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sound;
        private System.Windows.Forms.Button close_it;
        private System.Windows.Forms.Button prev;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.Label paraphrase;
        private System.Windows.Forms.LinkLabel more;
        private System.Windows.Forms.Button backspace;
        private System.Windows.Forms.Button clean;
        private System.Windows.Forms.Button tips;
        private System.Windows.Forms.Button save;
        private Lib.HanziPictureBox hanziPictureBox1;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}