namespace Kanjimusou
{
    partial class success
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(success));
            this.closeButton = new System.Windows.Forms.Button();
            this.resultButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.Transparent;
            this.closeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("closeButton.BackgroundImage")));
            this.closeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Location = new System.Drawing.Point(126, 163);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(66, 66);
            this.closeButton.TabIndex = 4;
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // resultButton
            // 
            this.resultButton.BackColor = System.Drawing.Color.Transparent;
            this.resultButton.Enabled = false;
            this.resultButton.FlatAppearance.BorderSize = 0;
            this.resultButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resultButton.Font = new System.Drawing.Font("楷体", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.resultButton.ForeColor = System.Drawing.Color.Red;
            this.resultButton.Location = new System.Drawing.Point(65, 49);
            this.resultButton.Name = "resultButton";
            this.resultButton.Size = new System.Drawing.Size(201, 83);
            this.resultButton.TabIndex = 5;
            this.resultButton.UseVisualStyleBackColor = false;
            // 
            // success
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(327, 259);
            this.Controls.Add(this.resultButton);
            this.Controls.Add(this.closeButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "success";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "success";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button resultButton;

    }
}