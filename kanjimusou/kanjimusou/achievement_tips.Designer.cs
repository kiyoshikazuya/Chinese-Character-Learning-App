namespace Kanjimusou
{
    partial class achievement_tips
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(achievement_tips));
            this.closee = new System.Windows.Forms.Button();
            this.arcInfo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // closee
            // 
            this.closee.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("closee.BackgroundImage")));
            this.closee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.closee.FlatAppearance.BorderSize = 0;
            this.closee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closee.Location = new System.Drawing.Point(1, -1);
            this.closee.Name = "closee";
            this.closee.Size = new System.Drawing.Size(16, 18);
            this.closee.TabIndex = 1;
            this.closee.UseVisualStyleBackColor = true;
            this.closee.Click += new System.EventHandler(this.closee_Click);
            // 
            // arcInfo
            // 
            this.arcInfo.BackColor = System.Drawing.Color.Transparent;
            this.arcInfo.Enabled = false;
            this.arcInfo.FlatAppearance.BorderSize = 0;
            this.arcInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.arcInfo.Font = new System.Drawing.Font("新宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.arcInfo.ForeColor = System.Drawing.Color.Black;
            this.arcInfo.Location = new System.Drawing.Point(36, 134);
            this.arcInfo.Name = "arcInfo";
            this.arcInfo.Size = new System.Drawing.Size(276, 82);
            this.arcInfo.TabIndex = 2;
            this.arcInfo.UseVisualStyleBackColor = false;
            // 
            // achievement_tips
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(344, 274);
            this.Controls.Add(this.arcInfo);
            this.Controls.Add(this.closee);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "achievement_tips";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "achievement_tips";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.achievement_tips_MouseDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button closee;
        private System.Windows.Forms.Button arcInfo;
    }
}