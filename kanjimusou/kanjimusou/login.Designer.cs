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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.button1 = new System.Windows.Forms.Button();
            this.log_in = new System.Windows.Forms.Button();
            this.log_on = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.TextBox();
            this.passwd = new System.Windows.Forms.TextBox();
            this.Atimer = new System.Windows.Forms.Timer(this.components);
            this.closethis = new System.Windows.Forms.Button();
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
            // log_in
            // 
            this.log_in.BackColor = System.Drawing.Color.Transparent;
            this.log_in.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("log_in.BackgroundImage")));
            this.log_in.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.log_in.FlatAppearance.BorderSize = 0;
            this.log_in.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.log_in.Location = new System.Drawing.Point(332, 208);
            this.log_in.Name = "log_in";
            this.log_in.Size = new System.Drawing.Size(46, 29);
            this.log_in.TabIndex = 4;
            this.log_in.UseVisualStyleBackColor = false;
            this.log_in.Click += new System.EventHandler(this.log_in_Click);
            // 
            // log_on
            // 
            this.log_on.BackColor = System.Drawing.Color.Transparent;
            this.log_on.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("log_on.BackgroundImage")));
            this.log_on.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.log_on.FlatAppearance.BorderSize = 0;
            this.log_on.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.log_on.ForeColor = System.Drawing.Color.Transparent;
            this.log_on.Location = new System.Drawing.Point(269, 208);
            this.log_on.Name = "log_on";
            this.log_on.Size = new System.Drawing.Size(46, 29);
            this.log_on.TabIndex = 5;
            this.log_on.UseVisualStyleBackColor = false;
            this.log_on.Click += new System.EventHandler(this.log_on_Click);
            // 
            // name
            // 
            this.name.BackColor = System.Drawing.Color.White;
            this.name.Location = new System.Drawing.Point(71, 159);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(136, 21);
            this.name.TabIndex = 6;
            // 
            // passwd
            // 
            this.passwd.Location = new System.Drawing.Point(71, 187);
            this.passwd.Name = "passwd";
            this.passwd.PasswordChar = '*';
            this.passwd.Size = new System.Drawing.Size(136, 21);
            this.passwd.TabIndex = 7;
            // 
            // Atimer
            // 
            this.Atimer.Tick += new System.EventHandler(this.Atimer_Tick);
            // 
            // closethis
            // 
            this.closethis.BackColor = System.Drawing.Color.Transparent;
            this.closethis.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("closethis.BackgroundImage")));
            this.closethis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.closethis.FlatAppearance.BorderSize = 0;
            this.closethis.Location = new System.Drawing.Point(1, -1);
            this.closethis.Name = "closethis";
            this.closethis.Size = new System.Drawing.Size(22, 21);
            this.closethis.TabIndex = 8;
            this.closethis.UseVisualStyleBackColor = false;
            this.closethis.Click += new System.EventHandler(this.closethis_Click);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(390, 249);
            this.Controls.Add(this.closethis);
            this.Controls.Add(this.passwd);
            this.Controls.Add(this.name);
            this.Controls.Add(this.log_on);
            this.Controls.Add(this.log_in);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "login";
            this.Opacity = 0.85D;
            this.Text = "CCLF";
            this.Load += new System.EventHandler(this.login_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.login_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button log_in;
        private System.Windows.Forms.Button log_on;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox passwd;
        private System.Windows.Forms.Timer Atimer;
        private System.Windows.Forms.Button closethis;


    }
}

