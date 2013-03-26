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
            this.picture = new System.Windows.Forms.PictureBox();
            this.sound = new System.Windows.Forms.Button();
            this.close_it = new System.Windows.Forms.Button();
            this.write = new System.Windows.Forms.Button();
            this.exercise = new System.Windows.Forms.Button();
            this.next = new System.Windows.Forms.Button();
            this.paraphrase = new System.Windows.Forms.Label();
            this.more = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.SuspendLayout();
            // 
            // picture
            // 
            this.picture.BackColor = System.Drawing.Color.Transparent;
            this.picture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picture.Location = new System.Drawing.Point(8, 20);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(500, 500);
            this.picture.TabIndex = 0;
            this.picture.TabStop = false;
            // 
            // sound
            // 
            this.sound.BackColor = System.Drawing.Color.Transparent;
            this.sound.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sound.BackgroundImage")));
            this.sound.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sound.Location = new System.Drawing.Point(520, 460);
            this.sound.Name = "sound";
            this.sound.Size = new System.Drawing.Size(29, 29);
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
            // write
            // 
            this.write.Location = new System.Drawing.Point(520, 307);
            this.write.Name = "write";
            this.write.Size = new System.Drawing.Size(49, 21);
            this.write.TabIndex = 3;
            this.write.Text = "w";
            this.write.UseVisualStyleBackColor = true;
            this.write.Click += new System.EventHandler(this.write_Click);
            // 
            // exercise
            // 
            this.exercise.Location = new System.Drawing.Point(520, 379);
            this.exercise.Name = "exercise";
            this.exercise.Size = new System.Drawing.Size(48, 22);
            this.exercise.TabIndex = 4;
            this.exercise.Text = "e";
            this.exercise.UseVisualStyleBackColor = true;
            this.exercise.Click += new System.EventHandler(this.exercise_Click);
            // 
            // next
            // 
            this.next.Location = new System.Drawing.Point(521, 244);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(48, 21);
            this.next.TabIndex = 5;
            this.next.Text = "next";
            this.next.UseVisualStyleBackColor = true;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // paraphrase
            // 
            this.paraphrase.AutoSize = true;
            this.paraphrase.BackColor = System.Drawing.Color.Transparent;
            this.paraphrase.Location = new System.Drawing.Point(518, 178);
            this.paraphrase.Name = "paraphrase";
            this.paraphrase.Size = new System.Drawing.Size(65, 12);
            this.paraphrase.TabIndex = 6;
            this.paraphrase.Text = "paraphrase";
            // 
            // more
            // 
            this.more.AutoSize = true;
            this.more.BackColor = System.Drawing.Color.Transparent;
            this.more.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.more.ForeColor = System.Drawing.Color.Transparent;
            this.more.Location = new System.Drawing.Point(525, 502);
            this.more.Name = "more";
            this.more.Size = new System.Drawing.Size(60, 25);
            this.more.TabIndex = 7;
            this.more.TabStop = true;
            this.more.Text = "more";
            this.more.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.more_LinkClicked);
            // 
            // learn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(597, 536);
            this.Controls.Add(this.more);
            this.Controls.Add(this.paraphrase);
            this.Controls.Add(this.next);
            this.Controls.Add(this.exercise);
            this.Controls.Add(this.write);
            this.Controls.Add(this.close_it);
            this.Controls.Add(this.sound);
            this.Controls.Add(this.picture);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "learn";
            this.Opacity = 0.9D;
            this.Text = "learn";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.learn_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.Button sound;
        private System.Windows.Forms.Button close_it;
        private System.Windows.Forms.Button write;
        private System.Windows.Forms.Button exercise;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.Label paraphrase;
        private System.Windows.Forms.LinkLabel more;
    }
}