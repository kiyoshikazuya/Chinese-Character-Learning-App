namespace Kanjimusou
{
    partial class DL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DL));
            this.button1 = new System.Windows.Forms.Button();
            this.log_on = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.TextBox();
            this.passwd = new System.Windows.Forms.TextBox();
            this.Atimer = new System.Windows.Forms.Timer(this.components);
            this.closethis = new System.Windows.Forms.Button();
            this.dlu = new System.Windows.Forms.Button();
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
            // log_on
            // 
            this.log_on.BackColor = System.Drawing.Color.Transparent;
            this.log_on.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("log_on.BackgroundImage")));
            this.log_on.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.log_on.FlatAppearance.BorderSize = 0;
            this.log_on.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.log_on.ForeColor = System.Drawing.Color.Transparent;
            this.log_on.Location = new System.Drawing.Point(269, 216);
            this.log_on.Name = "log_on";
            this.log_on.Size = new System.Drawing.Size(38, 21);
            this.log_on.TabIndex = 5;
            this.log_on.UseVisualStyleBackColor = false;
            this.log_on.Click += new System.EventHandler(this.log_on_Click);
            // 
            // name
            // 
            this.name.BackColor = System.Drawing.Color.White;
            this.name.Location = new System.Drawing.Point(71, 160);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(136, 21);
            this.name.TabIndex = 6;
            this.name.TextChanged += new System.EventHandler(this.name_TextChanged);
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
            this.closethis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.closethis.ForeColor = System.Drawing.Color.Transparent;
            this.closethis.Location = new System.Drawing.Point(3, 1);
            this.closethis.Name = "closethis";
            this.closethis.Size = new System.Drawing.Size(18, 17);
            this.closethis.TabIndex = 8;
            this.closethis.UseVisualStyleBackColor = false;
            this.closethis.Click += new System.EventHandler(this.closethis_Click);
            // 
            // dlu
            // 
            this.dlu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("dlu.BackgroundImage")));
            this.dlu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dlu.FlatAppearance.BorderSize = 0;
            this.dlu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dlu.Location = new System.Drawing.Point(326, 216);
            this.dlu.Name = "dlu";
            this.dlu.Size = new System.Drawing.Size(38, 21);
            this.dlu.TabIndex = 9;
            this.dlu.UseVisualStyleBackColor = true;
            this.dlu.Click += new System.EventHandler(this.dlu_Click);
            // 
            // DL
            // 
            this.AcceptButton = this.dlu;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(390, 249);
            this.Controls.Add(this.dlu);
            this.Controls.Add(this.closethis);
            this.Controls.Add(this.passwd);
            this.Controls.Add(this.name);
            this.Controls.Add(this.log_on);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DL";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CCLF";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.login_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button log_on;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox passwd;
        private System.Windows.Forms.Timer Atimer;
        private System.Windows.Forms.Button closethis;
        private System.Windows.Forms.Button dlu;


    }
}

