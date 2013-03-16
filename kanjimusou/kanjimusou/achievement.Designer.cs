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
            this.nameOfAch = new System.Windows.Forms.Label();
            this.course = new System.Windows.Forms.Label();
            this.ach = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nameOfAch
            // 
            this.nameOfAch.AutoSize = true;
            this.nameOfAch.Location = new System.Drawing.Point(50, 88);
            this.nameOfAch.Name = "nameOfAch";
            this.nameOfAch.Size = new System.Drawing.Size(29, 12);
            this.nameOfAch.TabIndex = 0;
            this.nameOfAch.Text = "name";
            // 
            // course
            // 
            this.course.AutoSize = true;
            this.course.Location = new System.Drawing.Point(50, 143);
            this.course.Name = "course";
            this.course.Size = new System.Drawing.Size(41, 12);
            this.course.TabIndex = 1;
            this.course.Text = "course";
            // 
            // ach
            // 
            this.ach.AutoSize = true;
            this.ach.Location = new System.Drawing.Point(50, 228);
            this.ach.Name = "ach";
            this.ach.Size = new System.Drawing.Size(125, 12);
            this.ach.TabIndex = 2;
            this.ach.Text = "achievement of today";
            // 
            // achievement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 389);
            this.Controls.Add(this.ach);
            this.Controls.Add(this.course);
            this.Controls.Add(this.nameOfAch);
            this.Name = "achievement";
            this.Text = "achievement";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameOfAch;
        private System.Windows.Forms.Label course;
        private System.Windows.Forms.Label ach;
    }
}