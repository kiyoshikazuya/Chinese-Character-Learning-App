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
            this.hanziPictureBox1 = new Kanjimusou.Lib.HanziPictureBox();
            this.backspace = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.write = new System.Windows.Forms.Button();
            this.clean = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.tips = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.hanziPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // hanziPictureBox1
            // 
            this.hanziPictureBox1.Hanzi = null;
            this.hanziPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("hanziPictureBox1.Image")));
            this.hanziPictureBox1.IsInkMode = true;
            this.hanziPictureBox1.IsShowHelper = false;
            this.hanziPictureBox1.Location = new System.Drawing.Point(12, 12);
            this.hanziPictureBox1.Name = "hanziPictureBox1";
            this.hanziPictureBox1.Size = new System.Drawing.Size(500, 500);
            this.hanziPictureBox1.TabIndex = 0;
            this.hanziPictureBox1.TabStop = false;
            this.hanziPictureBox1.Click += new System.EventHandler(this.hanziPictureBox1_Click);
            // 
            // backspace
            // 
            this.backspace.Location = new System.Drawing.Point(537, 24);
            this.backspace.Name = "backspace";
            this.backspace.Size = new System.Drawing.Size(65, 58);
            this.backspace.TabIndex = 1;
            this.backspace.Text = "backspace";
            this.backspace.UseVisualStyleBackColor = true;
            this.backspace.Click += new System.EventHandler(this.backspace_Click);
            // 
            // close
            // 
            this.close.Location = new System.Drawing.Point(542, 120);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(59, 61);
            this.close.TabIndex = 2;
            this.close.Text = "close";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // write
            // 
            this.write.Location = new System.Drawing.Point(548, 207);
            this.write.Name = "write";
            this.write.Size = new System.Drawing.Size(53, 65);
            this.write.TabIndex = 3;
            this.write.Text = "write";
            this.write.UseVisualStyleBackColor = true;
            this.write.Click += new System.EventHandler(this.write_Click);
            // 
            // clean
            // 
            this.clean.Location = new System.Drawing.Point(551, 299);
            this.clean.Name = "clean";
            this.clean.Size = new System.Drawing.Size(50, 69);
            this.clean.TabIndex = 4;
            this.clean.Text = "clean";
            this.clean.UseVisualStyleBackColor = true;
            this.clean.Click += new System.EventHandler(this.clean_Click);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(548, 399);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(62, 74);
            this.save.TabIndex = 5;
            this.save.Text = "save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // tips
            // 
            this.tips.AutoSize = true;
            this.tips.Location = new System.Drawing.Point(549, 500);
            this.tips.Name = "tips";
            this.tips.Size = new System.Drawing.Size(41, 12);
            this.tips.TabIndex = 6;
            this.tips.Text = "label1";
            // 
            // exercise_form
            // 
            this.ClientSize = new System.Drawing.Size(658, 527);
            this.Controls.Add(this.tips);
            this.Controls.Add(this.save);
            this.Controls.Add(this.clean);
            this.Controls.Add(this.write);
            this.Controls.Add(this.close);
            this.Controls.Add(this.backspace);
            this.Controls.Add(this.hanziPictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "exercise_form";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.exercise_form_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.hanziPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Lib.HanziPictureBox hanziPictureBox1;
        private System.Windows.Forms.Button backspace;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Button write;
        private System.Windows.Forms.Button clean;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Label tips;
    }
}