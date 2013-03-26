namespace Kanjimusou
{
    partial class exercise_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(exercise_form));
            this.backspace = new System.Windows.Forms.Button();
            this.clean = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.tips = new System.Windows.Forms.Label();
            this.hanziPictureBox1 = new Kanjimusou.Lib.HanziPictureBox();
            this.write = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.hanziPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // backspace
            // 
            this.backspace.BackColor = System.Drawing.Color.Transparent;
            this.backspace.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backspace.BackgroundImage")));
            this.backspace.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backspace.FlatAppearance.BorderSize = 0;
            this.backspace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backspace.Location = new System.Drawing.Point(20, 19);
            this.backspace.Name = "backspace";
            this.backspace.Size = new System.Drawing.Size(43, 41);
            this.backspace.TabIndex = 1;
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
            this.clean.Location = new System.Drawing.Point(110, 18);
            this.clean.Name = "clean";
            this.clean.Size = new System.Drawing.Size(43, 41);
            this.clean.TabIndex = 2;
            this.clean.UseVisualStyleBackColor = false;
            this.clean.Click += new System.EventHandler(this.clean_Click);
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.Transparent;
            this.close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("close.BackgroundImage")));
            this.close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.close.FlatAppearance.BorderSize = 0;
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close.Location = new System.Drawing.Point(301, 18);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(43, 41);
            this.close.TabIndex = 3;
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // tips
            // 
            this.tips.AutoSize = true;
            this.tips.BackColor = System.Drawing.Color.Transparent;
            this.tips.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tips.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tips.ForeColor = System.Drawing.Color.Red;
            this.tips.Location = new System.Drawing.Point(15, 585);
            this.tips.Name = "tips";
            this.tips.Size = new System.Drawing.Size(67, 25);
            this.tips.TabIndex = 4;
            this.tips.Text = "label1";
            // 
            // hanziPictureBox1
            // 
            this.hanziPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.hanziPictureBox1.Hanzi = null;
            this.hanziPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("hanziPictureBox1.Image")));
            this.hanziPictureBox1.IsInkMode = true;
            this.hanziPictureBox1.IsShowHelper = false;
            this.hanziPictureBox1.Location = new System.Drawing.Point(12, 70);
            this.hanziPictureBox1.Name = "hanziPictureBox1";
            this.hanziPictureBox1.Size = new System.Drawing.Size(500, 500);
            this.hanziPictureBox1.TabIndex = 0;
            this.hanziPictureBox1.TabStop = false;
            this.hanziPictureBox1.Click += new System.EventHandler(this.hanziPictureBox1_Click);
            // 
            // write
            // 
            this.write.BackColor = System.Drawing.Color.Transparent;
            this.write.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("write.BackgroundImage")));
            this.write.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.write.FlatAppearance.BorderSize = 0;
            this.write.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.write.Location = new System.Drawing.Point(200, 18);
            this.write.Name = "write";
            this.write.Size = new System.Drawing.Size(43, 41);
            this.write.TabIndex = 5;
            this.write.UseVisualStyleBackColor = false;
            this.write.Click += new System.EventHandler(this.write_Click);
            // 
            // exercise_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(535, 619);
            this.Controls.Add(this.write);
            this.Controls.Add(this.tips);
            this.Controls.Add(this.close);
            this.Controls.Add(this.clean);
            this.Controls.Add(this.backspace);
            this.Controls.Add(this.hanziPictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "exercise_form";
            this.Opacity = 0.9D;
            this.Text = "exercise_form";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.exercise_form_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.hanziPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Lib.HanziPictureBox hanziPictureBox1;
        private System.Windows.Forms.Button backspace;
        private System.Windows.Forms.Button clean;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Label tips;
        private System.Windows.Forms.Button write;
    }
}