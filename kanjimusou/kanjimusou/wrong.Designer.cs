namespace Kanjimusou
{
    partial class wrong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wrong));
            this.button1 = new System.Windows.Forms.Button();
            this.wrongInfo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(1, -2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(16, 16);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // wrongInfo
            // 
            this.wrongInfo.BackColor = System.Drawing.Color.Transparent;
            this.wrongInfo.Enabled = false;
            this.wrongInfo.FlatAppearance.BorderSize = 0;
            this.wrongInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.wrongInfo.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.wrongInfo.ForeColor = System.Drawing.Color.Red;
            this.wrongInfo.Location = new System.Drawing.Point(12, 102);
            this.wrongInfo.Name = "wrongInfo";
            this.wrongInfo.Size = new System.Drawing.Size(253, 60);
            this.wrongInfo.TabIndex = 2;
            this.wrongInfo.UseVisualStyleBackColor = false;
            // 
            // wrong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(281, 217);
            this.Controls.Add(this.wrongInfo);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "wrong";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "wrong";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.wrong_MouseDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button wrongInfo;

    }
}