namespace NCKU_DORM_FORM
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_login = new System.Windows.Forms.Button();
            this.wb_1 = new System.Windows.Forms.WebBrowser();
            this.tb_account = new System.Windows.Forms.TextBox();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_checkNet = new System.Windows.Forms.Button();
            this.lb_ip = new System.Windows.Forms.Label();
            this.lb_netstatus = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(14, 68);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(145, 23);
            this.btn_login.TabIndex = 0;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // wb_1
            // 
            this.wb_1.Location = new System.Drawing.Point(173, 12);
            this.wb_1.MinimumSize = new System.Drawing.Size(20, 20);
            this.wb_1.Name = "wb_1";
            this.wb_1.ScrollBarsEnabled = false;
            this.wb_1.Size = new System.Drawing.Size(792, 258);
            this.wb_1.TabIndex = 1;
            this.wb_1.NewWindow += new System.ComponentModel.CancelEventHandler(this.wb_1_NewWindow);
            // 
            // tb_account
            // 
            this.tb_account.Location = new System.Drawing.Point(59, 12);
            this.tb_account.Name = "tb_account";
            this.tb_account.Size = new System.Drawing.Size(100, 22);
            this.tb_account.TabIndex = 2;
            // 
            // tb_password
            // 
            this.tb_password.Location = new System.Drawing.Point(59, 40);
            this.tb_password.Name = "tb_password";
            this.tb_password.PasswordChar = '*';
            this.tb_password.Size = new System.Drawing.Size(100, 22);
            this.tb_password.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "帳號：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "密碼：";
            // 
            // btn_checkNet
            // 
            this.btn_checkNet.Location = new System.Drawing.Point(14, 97);
            this.btn_checkNet.Name = "btn_checkNet";
            this.btn_checkNet.Size = new System.Drawing.Size(145, 23);
            this.btn_checkNet.TabIndex = 6;
            this.btn_checkNet.Text = "Check Net";
            this.btn_checkNet.UseVisualStyleBackColor = true;
            this.btn_checkNet.Click += new System.EventHandler(this.button1_Click);
            // 
            // lb_ip
            // 
            this.lb_ip.AutoSize = true;
            this.lb_ip.Location = new System.Drawing.Point(12, 133);
            this.lb_ip.Name = "lb_ip";
            this.lb_ip.Size = new System.Drawing.Size(87, 12);
            this.lb_ip.TabIndex = 7;
            this.lb_ip.Text = "您的IP為：未知";
            // 
            // lb_netstatus
            // 
            this.lb_netstatus.AutoSize = true;
            this.lb_netstatus.Location = new System.Drawing.Point(12, 157);
            this.lb_netstatus.Name = "lb_netstatus";
            this.lb_netstatus.Size = new System.Drawing.Size(113, 12);
            this.lb_netstatus.TabIndex = 8;
            this.lb_netstatus.Text = "網際網路連線：未知";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 277);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(975, 22);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(839, 17);
            this.toolStripStatusLabel2.Text = "出現DHCP BoradCast Failed或者沒有跳轉頁面的情況皆為認證成功，稍等幾秒鐘後即可連線 | 作者Email:s99115247@stu.edu.t" +
    "w | Last update:2014/03/27";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 299);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.lb_netstatus);
            this.Controls.Add(this.lb_ip);
            this.Controls.Add(this.btn_checkNet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.tb_account);
            this.Controls.Add(this.wb_1);
            this.Controls.Add(this.btn_login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NCKU SUCCESS DORM 4 LOGGER 0.1 beta";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.WebBrowser wb_1;
        private System.Windows.Forms.TextBox tb_account;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_checkNet;
        private System.Windows.Forms.Label lb_ip;
        private System.Windows.Forms.Label lb_netstatus;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
    }
}

