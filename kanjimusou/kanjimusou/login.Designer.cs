namespace Kanjimusou
{
    partial class login
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.log_in = new System.Windows.Forms.Button();
            this.log_on = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.TextBox();
            this.passwd = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(663, -2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 22);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "账号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "密码";
            // 
            // log_in
            // 
            this.log_in.Location = new System.Drawing.Point(49, 240);
            this.log_in.Name = "log_in";
            this.log_in.Size = new System.Drawing.Size(69, 31);
            this.log_in.TabIndex = 4;
            this.log_in.Text = "登陆";
            this.log_in.UseVisualStyleBackColor = true;
            this.log_in.Click += new System.EventHandler(this.log_in_Click);
            // 
            // log_on
            // 
            this.log_on.Location = new System.Drawing.Point(202, 241);
            this.log_on.Name = "log_on";
            this.log_on.Size = new System.Drawing.Size(67, 30);
            this.log_on.TabIndex = 5;
            this.log_on.Text = "注册";
            this.log_on.UseVisualStyleBackColor = true;
            this.log_on.Click += new System.EventHandler(this.log_on_Click);
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(97, 99);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(136, 21);
            this.name.TabIndex = 6;
            // 
            // passwd
            // 
            this.passwd.Location = new System.Drawing.Point(97, 174);
            this.passwd.Name = "passwd";
            this.passwd.PasswordChar = '*';
            this.passwd.Size = new System.Drawing.Size(136, 21);
            this.passwd.TabIndex = 7;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 306);
            this.Controls.Add(this.passwd);
            this.Controls.Add(this.name);
            this.Controls.Add(this.log_on);
            this.Controls.Add(this.log_in);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "login";
            this.Text = "CCLF";
            this.Load += new System.EventHandler(this.login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button log_in;
        private System.Windows.Forms.Button log_on;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox passwd;


    }
}

