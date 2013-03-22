namespace Kanjimusou
{
    partial class prompt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(prompt));
            this.closeAll = new System.Windows.Forms.Button();
            this.doNotClose = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // closeAll
            // 
            this.closeAll.BackColor = System.Drawing.Color.Transparent;
            this.closeAll.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("closeAll.BackgroundImage")));
            this.closeAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.closeAll.FlatAppearance.BorderSize = 0;
            this.closeAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeAll.Location = new System.Drawing.Point(14, 175);
            this.closeAll.Name = "closeAll";
            this.closeAll.Size = new System.Drawing.Size(77, 30);
            this.closeAll.TabIndex = 1;
            this.closeAll.UseVisualStyleBackColor = false;
            this.closeAll.Click += new System.EventHandler(this.closeAll_Click);
            // 
            // doNotClose
            // 
            this.doNotClose.BackColor = System.Drawing.Color.Transparent;
            this.doNotClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("doNotClose.BackgroundImage")));
            this.doNotClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.doNotClose.FlatAppearance.BorderSize = 0;
            this.doNotClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.doNotClose.Location = new System.Drawing.Point(134, 175);
            this.doNotClose.Name = "doNotClose";
            this.doNotClose.Size = new System.Drawing.Size(144, 27);
            this.doNotClose.TabIndex = 2;
            this.doNotClose.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(0, -2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(16, 16);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // prompt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(328, 239);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.doNotClose);
            this.Controls.Add(this.closeAll);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "prompt";
            this.Opacity = 0.9D;
            this.Text = "prompt";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.prompt_MouseDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button closeAll;
        private System.Windows.Forms.Button doNotClose;
        private System.Windows.Forms.Button button1;
    }
}