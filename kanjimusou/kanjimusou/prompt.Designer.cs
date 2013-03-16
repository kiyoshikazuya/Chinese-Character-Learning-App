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
            this.exitprompt = new System.Windows.Forms.Label();
            this.closeAll = new System.Windows.Forms.Button();
            this.doNotClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // exitprompt
            // 
            this.exitprompt.AutoSize = true;
            this.exitprompt.Location = new System.Drawing.Point(78, 74);
            this.exitprompt.Name = "exitprompt";
            this.exitprompt.Size = new System.Drawing.Size(101, 12);
            this.exitprompt.TabIndex = 0;
            this.exitprompt.Text = "是否关闭本软件？";
            // 
            // closeAll
            // 
            this.closeAll.Location = new System.Drawing.Point(22, 136);
            this.closeAll.Name = "closeAll";
            this.closeAll.Size = new System.Drawing.Size(39, 23);
            this.closeAll.TabIndex = 1;
            this.closeAll.Text = "是";
            this.closeAll.UseVisualStyleBackColor = true;
            // 
            // doNotClose
            // 
            this.doNotClose.Location = new System.Drawing.Point(134, 138);
            this.doNotClose.Name = "doNotClose";
            this.doNotClose.Size = new System.Drawing.Size(125, 21);
            this.doNotClose.TabIndex = 2;
            this.doNotClose.Text = "否，返回欢迎界面";
            this.doNotClose.UseVisualStyleBackColor = true;
            // 
            // prompt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(284, 217);
            this.Controls.Add(this.doNotClose);
            this.Controls.Add(this.closeAll);
            this.Controls.Add(this.exitprompt);
            this.Name = "prompt";
            this.Text = "prompt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label exitprompt;
        private System.Windows.Forms.Button closeAll;
        private System.Windows.Forms.Button doNotClose;
    }
}