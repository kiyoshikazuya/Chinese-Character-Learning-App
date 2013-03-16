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
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.sound = new System.Windows.Forms.Button();
            this.write = new System.Windows.Forms.Button();
            this.exercise = new System.Windows.Forms.Button();
            this.next = new System.Windows.Forms.Button();
            this.paraphrase = new System.Windows.Forms.Label();
            this.more = new System.Windows.Forms.LinkLabel();
            this.close_it = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(893, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 25);
            this.button1.TabIndex = 4;
            this.button1.Text = "close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 300);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // sound
            // 
            this.sound.Location = new System.Drawing.Point(330, 29);
            this.sound.Name = "sound";
            this.sound.Size = new System.Drawing.Size(55, 34);
            this.sound.TabIndex = 6;
            this.sound.Text = "sound";
            this.sound.UseVisualStyleBackColor = true;
            // 
            // write
            // 
            this.write.Location = new System.Drawing.Point(331, 108);
            this.write.Name = "write";
            this.write.Size = new System.Drawing.Size(54, 38);
            this.write.TabIndex = 7;
            this.write.Text = "write";
            this.write.UseVisualStyleBackColor = true;
            // 
            // exercise
            // 
            this.exercise.Location = new System.Drawing.Point(331, 182);
            this.exercise.Name = "exercise";
            this.exercise.Size = new System.Drawing.Size(54, 32);
            this.exercise.TabIndex = 8;
            this.exercise.Text = "exercise";
            this.exercise.UseVisualStyleBackColor = true;
            this.exercise.Click += new System.EventHandler(this.exercise_Click);
            // 
            // next
            // 
            this.next.Location = new System.Drawing.Point(330, 282);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(54, 30);
            this.next.TabIndex = 9;
            this.next.Text = "next";
            this.next.UseVisualStyleBackColor = true;
            // 
            // paraphrase
            // 
            this.paraphrase.AutoSize = true;
            this.paraphrase.Location = new System.Drawing.Point(12, 343);
            this.paraphrase.Name = "paraphrase";
            this.paraphrase.Size = new System.Drawing.Size(65, 12);
            this.paraphrase.TabIndex = 10;
            this.paraphrase.Text = "paraphrase";
            // 
            // more
            // 
            this.more.AutoSize = true;
            this.more.Location = new System.Drawing.Point(283, 399);
            this.more.Name = "more";
            this.more.Size = new System.Drawing.Size(101, 12);
            this.more.TabIndex = 11;
            this.more.TabStop = true;
            this.more.Text = "more information";
            // 
            // close_it
            // 
            this.close_it.BackColor = System.Drawing.Color.Transparent;
            this.close_it.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("close_it.BackgroundImage")));
            this.close_it.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.close_it.Location = new System.Drawing.Point(360, -1);
            this.close_it.Name = "close_it";
            this.close_it.Size = new System.Drawing.Size(24, 24);
            this.close_it.TabIndex = 12;
            this.close_it.UseVisualStyleBackColor = false;
            this.close_it.Click += new System.EventHandler(this.button2_Click);
            // 
            // learn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 425);
            this.Controls.Add(this.close_it);
            this.Controls.Add(this.more);
            this.Controls.Add(this.paraphrase);
            this.Controls.Add(this.next);
            this.Controls.Add(this.exercise);
            this.Controls.Add(this.write);
            this.Controls.Add(this.sound);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "learn";
            this.Text = "learn";
            this.TransparencyKey = System.Drawing.Color.White;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.learn_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button sound;
        private System.Windows.Forms.Button write;
        private System.Windows.Forms.Button exercise;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.Label paraphrase;
        private System.Windows.Forms.LinkLabel more;
        private System.Windows.Forms.Button close_it;
    }
}