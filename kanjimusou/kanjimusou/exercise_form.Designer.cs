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
            ((System.ComponentModel.ISupportInitialize)(this.hanziPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // backspace
            // 
            this.backspace.Location = new System.Drawing.Point(526, 36);
            this.backspace.Name = "backspace";
            this.backspace.Size = new System.Drawing.Size(43, 36);
            this.backspace.TabIndex = 1;
            this.backspace.Text = "backspace";
            this.backspace.UseVisualStyleBackColor = true;
            this.backspace.Click += new System.EventHandler(this.backspace_Click);
            // 
            // clean
            // 
            this.clean.Location = new System.Drawing.Point(526, 248);
            this.clean.Name = "clean";
            this.clean.Size = new System.Drawing.Size(43, 45);
            this.clean.TabIndex = 2;
            this.clean.Text = "clean";
            this.clean.UseVisualStyleBackColor = true;
            this.clean.Click += new System.EventHandler(this.clean_Click);
            // 
            // close
            // 
            this.close.Location = new System.Drawing.Point(527, 453);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(42, 44);
            this.close.TabIndex = 3;
            this.close.Text = "close";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // tips
            // 
            this.tips.AutoSize = true;
            this.tips.Location = new System.Drawing.Point(38, 526);
            this.tips.Name = "tips";
            this.tips.Size = new System.Drawing.Size(41, 12);
            this.tips.TabIndex = 4;
            this.tips.Text = "label1";
            // 
            // hanziPictureBox1
            // 
            this.hanziPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.hanziPictureBox1.Hanzi = null;
            this.hanziPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("hanziPictureBox1.Image")));
            this.hanziPictureBox1.IsShowHelper = false;
            this.hanziPictureBox1.Location = new System.Drawing.Point(12, 12);
            this.hanziPictureBox1.Name = "hanziPictureBox1";
            this.hanziPictureBox1.Size = new System.Drawing.Size(500, 500);
            this.hanziPictureBox1.TabIndex = 0;
            this.hanziPictureBox1.TabStop = false;
            // 
            // exercise_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(579, 547);
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
    }
}