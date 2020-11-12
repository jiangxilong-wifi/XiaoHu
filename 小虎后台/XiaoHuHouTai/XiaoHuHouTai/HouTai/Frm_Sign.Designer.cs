namespace XiaoHu
{
    partial class Frm_Sign
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
            this.plTop = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.plDown = new System.Windows.Forms.Panel();
            this.lklblForget = new System.Windows.Forms.LinkLabel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSign = new System.Windows.Forms.Button();
            this.ckbDisplay = new System.Windows.Forms.CheckBox();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.lblPwd = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.plTop.SuspendLayout();
            this.plDown.SuspendLayout();
            this.SuspendLayout();
            // 
            // plTop
            // 
            this.plTop.BackgroundImage = global::XiaoHuHouTai.Properties.Resources.activity_bg_wash;
            this.plTop.Controls.Add(this.lblTitle);
            this.plTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.plTop.Location = new System.Drawing.Point(0, 0);
            this.plTop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.plTop.Name = "plTop";
            this.plTop.Size = new System.Drawing.Size(600, 70);
            this.plTop.TabIndex = 0;
            this.plTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.plTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("幼圆", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(104, 18);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(397, 38);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "小虎影院后台管理系统";
            // 
            // plDown
            // 
            this.plDown.BackgroundImage = global::XiaoHuHouTai.Properties.Resources.activity_bg_wash;
            this.plDown.Controls.Add(this.lklblForget);
            this.plDown.Controls.Add(this.btnCancel);
            this.plDown.Controls.Add(this.btnSign);
            this.plDown.Controls.Add(this.ckbDisplay);
            this.plDown.Controls.Add(this.txtPwd);
            this.plDown.Controls.Add(this.txtUser);
            this.plDown.Controls.Add(this.lblPwd);
            this.plDown.Controls.Add(this.lblUser);
            this.plDown.Location = new System.Drawing.Point(0, 70);
            this.plDown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.plDown.Name = "plDown";
            this.plDown.Size = new System.Drawing.Size(600, 330);
            this.plDown.TabIndex = 1;
            this.plDown.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            // 
            // lklblForget
            // 
            this.lklblForget.AutoSize = true;
            this.lklblForget.BackColor = System.Drawing.Color.Transparent;
            this.lklblForget.LinkColor = System.Drawing.Color.White;
            this.lklblForget.Location = new System.Drawing.Point(521, 306);
            this.lklblForget.Name = "lklblForget";
            this.lklblForget.Size = new System.Drawing.Size(67, 15);
            this.lklblForget.TabIndex = 9;
            this.lklblForget.TabStop = true;
            this.lklblForget.Text = "忘记密码";
            this.lklblForget.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklblForget_LinkClicked);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Location = new System.Drawing.Point(323, 230);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(117, 42);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "退出";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSign
            // 
            this.btnSign.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSign.ForeColor = System.Drawing.Color.Black;
            this.btnSign.Location = new System.Drawing.Point(163, 230);
            this.btnSign.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSign.Name = "btnSign";
            this.btnSign.Size = new System.Drawing.Size(117, 42);
            this.btnSign.TabIndex = 6;
            this.btnSign.Text = "登录";
            this.btnSign.UseVisualStyleBackColor = true;
            this.btnSign.Click += new System.EventHandler(this.btnSign_Click);
            // 
            // ckbDisplay
            // 
            this.ckbDisplay.AutoSize = true;
            this.ckbDisplay.BackColor = System.Drawing.Color.Transparent;
            this.ckbDisplay.Location = new System.Drawing.Point(219, 175);
            this.ckbDisplay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ckbDisplay.Name = "ckbDisplay";
            this.ckbDisplay.Size = new System.Drawing.Size(89, 19);
            this.ckbDisplay.TabIndex = 5;
            this.ckbDisplay.Text = "显示密码";
            this.ckbDisplay.UseVisualStyleBackColor = false;
            this.ckbDisplay.CheckedChanged += new System.EventHandler(this.ckbDisplay_CheckedChanged);
            // 
            // txtPwd
            // 
            this.txtPwd.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtPwd.Location = new System.Drawing.Point(219, 128);
            this.txtPwd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '*';
            this.txtPwd.Size = new System.Drawing.Size(263, 34);
            this.txtPwd.TabIndex = 3;
            // 
            // txtUser
            // 
            this.txtUser.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtUser.Location = new System.Drawing.Point(219, 49);
            this.txtUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(263, 34);
            this.txtUser.TabIndex = 2;
            // 
            // lblPwd
            // 
            this.lblPwd.AutoSize = true;
            this.lblPwd.BackColor = System.Drawing.Color.Transparent;
            this.lblPwd.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblPwd.ForeColor = System.Drawing.Color.White;
            this.lblPwd.Location = new System.Drawing.Point(131, 131);
            this.lblPwd.Name = "lblPwd";
            this.lblPwd.Size = new System.Drawing.Size(82, 24);
            this.lblPwd.TabIndex = 1;
            this.lblPwd.Text = "密码：";
            this.lblPwd.Click += new System.EventHandler(this.lblPwd_Click);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.BackColor = System.Drawing.Color.Transparent;
            this.lblUser.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblUser.ForeColor = System.Drawing.Color.White;
            this.lblUser.Location = new System.Drawing.Point(121, 54);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(106, 24);
            this.lblUser.TabIndex = 0;
            this.lblUser.Text = "登录名：";
            // 
            // Frm_Sign
            // 
            this.AcceptButton = this.btnSign;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.plDown);
            this.Controls.Add(this.plTop);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Frm_Sign";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Sign";
            this.Load += new System.EventHandler(this.Frm_Sign_Load);
            this.plTop.ResumeLayout(false);
            this.plTop.PerformLayout();
            this.plDown.ResumeLayout(false);
            this.plDown.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel plTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel plDown;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label lblPwd;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.LinkLabel lklblForget;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSign;
        private System.Windows.Forms.CheckBox ckbDisplay;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}