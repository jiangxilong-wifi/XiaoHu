namespace XiaoHu
{
    partial class Frm_UserManage
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
            this.components = new System.ComponentModel.Container();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmbAdmin = new System.Windows.Forms.ComboBox();
            this.cmbVip = new System.Windows.Forms.ComboBox();
            this.lblAD = new System.Windows.Forms.Label();
            this.lblVIP = new System.Windows.Forms.Label();
            this.btnSelect = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.CustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerPwd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerTel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VIP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImageString = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Admin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerBalance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnImage = new System.Windows.Forms.Button();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.lblID = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rdoNoVIP = new System.Windows.Forms.RadioButton();
            this.rdoYesVIP = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdoNoAdmin = new System.Windows.Forms.RadioButton();
            this.rdoYesAdmin = new System.Windows.Forms.RadioButton();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.txtCustomerUser = new System.Windows.Forms.TextBox();
            this.txtCustomerTel = new System.Windows.Forms.TextBox();
            this.rdoWoman = new System.Windows.Forms.RadioButton();
            this.rdoMan = new System.Windows.Forms.RadioButton();
            this.txtCustomerPwd = new System.Windows.Forms.TextBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.Balance = new System.Windows.Forms.Label();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.lblSex = new System.Windows.Forms.Label();
            this.lblImage = new System.Windows.Forms.Label();
            this.lblYNVIP = new System.Windows.Forms.Label();
            this.lblCustomerTel = new System.Windows.Forms.Label();
            this.lblCustomerPwd = new System.Windows.Forms.Label();
            this.lblCustomerUser = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnShuaXin = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.cmbAdmin);
            this.groupBox3.Controls.Add(this.cmbVip);
            this.groupBox3.Controls.Add(this.lblAD);
            this.groupBox3.Controls.Add(this.lblVIP);
            this.groupBox3.Controls.Add(this.btnSelect);
            this.groupBox3.Controls.Add(this.txtName);
            this.groupBox3.Controls.Add(this.lblName);
            this.groupBox3.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(483, 14);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Size = new System.Drawing.Size(214, 310);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "用户查询";
            // 
            // cmbAdmin
            // 
            this.cmbAdmin.FormattingEnabled = true;
            this.cmbAdmin.Items.AddRange(new object[] {
            "是",
            "否"});
            this.cmbAdmin.Location = new System.Drawing.Point(16, 209);
            this.cmbAdmin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbAdmin.Name = "cmbAdmin";
            this.cmbAdmin.Size = new System.Drawing.Size(186, 22);
            this.cmbAdmin.TabIndex = 33;
            // 
            // cmbVip
            // 
            this.cmbVip.FormattingEnabled = true;
            this.cmbVip.Items.AddRange(new object[] {
            "是",
            "否"});
            this.cmbVip.Location = new System.Drawing.Point(16, 133);
            this.cmbVip.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbVip.Name = "cmbVip";
            this.cmbVip.Size = new System.Drawing.Size(186, 22);
            this.cmbVip.TabIndex = 31;
            // 
            // lblAD
            // 
            this.lblAD.AutoSize = true;
            this.lblAD.Location = new System.Drawing.Point(13, 178);
            this.lblAD.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAD.Name = "lblAD";
            this.lblAD.Size = new System.Drawing.Size(67, 15);
            this.lblAD.TabIndex = 28;
            this.lblAD.Text = "是否管理";
            // 
            // lblVIP
            // 
            this.lblVIP.AutoSize = true;
            this.lblVIP.Location = new System.Drawing.Point(13, 109);
            this.lblVIP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVIP.Name = "lblVIP";
            this.lblVIP.Size = new System.Drawing.Size(61, 15);
            this.lblVIP.TabIndex = 26;
            this.lblVIP.Text = "是否VIP";
            // 
            // btnSelect
            // 
            this.btnSelect.ForeColor = System.Drawing.Color.Black;
            this.btnSelect.Location = new System.Drawing.Point(71, 265);
            this.btnSelect.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 31);
            this.btnSelect.TabIndex = 24;
            this.btnSelect.Text = "查询";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(16, 56);
            this.txtName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(186, 24);
            this.txtName.TabIndex = 24;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(13, 30);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(52, 15);
            this.lblName.TabIndex = 24;
            this.lblName.Text = "用户名";
            // 
            // groupBox2
            // 
            this.groupBox2.BackgroundImage = global::XiaoHuHouTai.Properties.Resources.activity_bg_wash;
            this.groupBox2.Controls.Add(this.dgv);
            this.groupBox2.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.ForeColor = System.Drawing.Color.Gray;
            this.groupBox2.Location = new System.Drawing.Point(24, 329);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(673, 225);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "影片信息";
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CustomerID,
            this.CustomerName,
            this.CustomerUser,
            this.CustomerPwd,
            this.CustomerTel,
            this.VIP,
            this.ImageString,
            this.Sex,
            this.Admin,
            this.CustomerBalance});
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.Location = new System.Drawing.Point(2, 19);
            this.dgv.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgv.Name = "dgv";
            this.dgv.RowTemplate.Height = 27;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(669, 204);
            this.dgv.TabIndex = 0;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            // 
            // CustomerID
            // 
            this.CustomerID.DataPropertyName = "CustomerID";
            this.CustomerID.HeaderText = "用户ID";
            this.CustomerID.Name = "CustomerID";
            // 
            // CustomerName
            // 
            this.CustomerName.DataPropertyName = "CustomerName";
            this.CustomerName.HeaderText = "用户名";
            this.CustomerName.Name = "CustomerName";
            // 
            // CustomerUser
            // 
            this.CustomerUser.DataPropertyName = "CustomerUser";
            this.CustomerUser.HeaderText = "登录账号";
            this.CustomerUser.Name = "CustomerUser";
            // 
            // CustomerPwd
            // 
            this.CustomerPwd.DataPropertyName = "CustomerPwd";
            this.CustomerPwd.HeaderText = "密码";
            this.CustomerPwd.Name = "CustomerPwd";
            // 
            // CustomerTel
            // 
            this.CustomerTel.DataPropertyName = "Tel";
            this.CustomerTel.HeaderText = "手机号";
            this.CustomerTel.Name = "CustomerTel";
            // 
            // VIP
            // 
            this.VIP.DataPropertyName = "Vip";
            this.VIP.HeaderText = "是否VIP";
            this.VIP.Name = "VIP";
            // 
            // ImageString
            // 
            this.ImageString.DataPropertyName = "Customer_ImgString";
            this.ImageString.HeaderText = "头像链接";
            this.ImageString.Name = "ImageString";
            // 
            // Sex
            // 
            this.Sex.DataPropertyName = "Sex";
            this.Sex.HeaderText = "性别";
            this.Sex.Name = "Sex";
            // 
            // Admin
            // 
            this.Admin.DataPropertyName = "Admin";
            this.Admin.HeaderText = "是否管理";
            this.Admin.Name = "Admin";
            // 
            // CustomerBalance
            // 
            this.CustomerBalance.DataPropertyName = "Balance";
            this.CustomerBalance.HeaderText = "余额";
            this.CustomerBalance.Name = "CustomerBalance";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.BackgroundImage = global::XiaoHuHouTai.Properties.Resources.activity_bg_wash;
            this.groupBox1.Controls.Add(this.btnImage);
            this.groupBox1.Controls.Add(this.pbImage);
            this.groupBox1.Controls.Add(this.lblID);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.txtBalance);
            this.groupBox1.Controls.Add(this.txtCustomerUser);
            this.groupBox1.Controls.Add(this.txtCustomerTel);
            this.groupBox1.Controls.Add(this.rdoWoman);
            this.groupBox1.Controls.Add(this.rdoMan);
            this.groupBox1.Controls.Add(this.txtCustomerPwd);
            this.groupBox1.Controls.Add(this.txtCustomerName);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.btnInsert);
            this.groupBox1.Controls.Add(this.Balance);
            this.groupBox1.Controls.Add(this.lblAdmin);
            this.groupBox1.Controls.Add(this.lblSex);
            this.groupBox1.Controls.Add(this.lblImage);
            this.groupBox1.Controls.Add(this.lblYNVIP);
            this.groupBox1.Controls.Add(this.lblCustomerTel);
            this.groupBox1.Controls.Add(this.lblCustomerPwd);
            this.groupBox1.Controls.Add(this.lblCustomerUser);
            this.groupBox1.Controls.Add(this.lblCustomerName);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(23, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(442, 284);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "新增以及修改用户信息";
            // 
            // btnImage
            // 
            this.btnImage.ForeColor = System.Drawing.Color.Black;
            this.btnImage.Location = new System.Drawing.Point(222, 60);
            this.btnImage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnImage.Name = "btnImage";
            this.btnImage.Size = new System.Drawing.Size(83, 30);
            this.btnImage.TabIndex = 32;
            this.btnImage.Text = "选择头像";
            this.btnImage.UseVisualStyleBackColor = true;
            this.btnImage.Click += new System.EventHandler(this.button1_Click);
            // 
            // pbImage
            // 
            this.pbImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbImage.Location = new System.Drawing.Point(319, 15);
            this.pbImage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(98, 92);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImage.TabIndex = 31;
            this.pbImage.TabStop = false;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(27, 253);
            this.lblID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(23, 15);
            this.lblID.TabIndex = 30;
            this.lblID.Text = "ID";
            this.lblID.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rdoNoVIP);
            this.panel2.Controls.Add(this.rdoYesVIP);
            this.panel2.Location = new System.Drawing.Point(78, 203);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(122, 31);
            this.panel2.TabIndex = 29;
            // 
            // rdoNoVIP
            // 
            this.rdoNoVIP.AutoSize = true;
            this.rdoNoVIP.Checked = true;
            this.rdoNoVIP.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rdoNoVIP.Location = new System.Drawing.Point(82, 7);
            this.rdoNoVIP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdoNoVIP.Name = "rdoNoVIP";
            this.rdoNoVIP.Size = new System.Drawing.Size(35, 16);
            this.rdoNoVIP.TabIndex = 26;
            this.rdoNoVIP.TabStop = true;
            this.rdoNoVIP.Text = "否";
            this.rdoNoVIP.UseVisualStyleBackColor = true;
            // 
            // rdoYesVIP
            // 
            this.rdoYesVIP.AutoSize = true;
            this.rdoYesVIP.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rdoYesVIP.Location = new System.Drawing.Point(9, 7);
            this.rdoYesVIP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdoYesVIP.Name = "rdoYesVIP";
            this.rdoYesVIP.Size = new System.Drawing.Size(35, 16);
            this.rdoYesVIP.TabIndex = 25;
            this.rdoYesVIP.Text = "是";
            this.rdoYesVIP.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdoNoAdmin);
            this.panel1.Controls.Add(this.rdoYesAdmin);
            this.panel1.Location = new System.Drawing.Point(285, 150);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(124, 42);
            this.panel1.TabIndex = 28;
            // 
            // rdoNoAdmin
            // 
            this.rdoNoAdmin.AutoSize = true;
            this.rdoNoAdmin.Checked = true;
            this.rdoNoAdmin.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rdoNoAdmin.Location = new System.Drawing.Point(83, 13);
            this.rdoNoAdmin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdoNoAdmin.Name = "rdoNoAdmin";
            this.rdoNoAdmin.Size = new System.Drawing.Size(35, 16);
            this.rdoNoAdmin.TabIndex = 18;
            this.rdoNoAdmin.TabStop = true;
            this.rdoNoAdmin.Text = "否";
            this.rdoNoAdmin.UseVisualStyleBackColor = true;
            // 
            // rdoYesAdmin
            // 
            this.rdoYesAdmin.AutoSize = true;
            this.rdoYesAdmin.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rdoYesAdmin.Location = new System.Drawing.Point(10, 13);
            this.rdoYesAdmin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdoYesAdmin.Name = "rdoYesAdmin";
            this.rdoYesAdmin.Size = new System.Drawing.Size(35, 16);
            this.rdoYesAdmin.TabIndex = 17;
            this.rdoYesAdmin.Text = "是";
            this.rdoYesAdmin.UseVisualStyleBackColor = true;
            // 
            // txtBalance
            // 
            this.txtBalance.Location = new System.Drawing.Point(296, 202);
            this.txtBalance.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Size = new System.Drawing.Size(137, 24);
            this.txtBalance.TabIndex = 27;
            // 
            // txtCustomerUser
            // 
            this.txtCustomerUser.Location = new System.Drawing.Point(80, 72);
            this.txtCustomerUser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCustomerUser.Name = "txtCustomerUser";
            this.txtCustomerUser.Size = new System.Drawing.Size(133, 24);
            this.txtCustomerUser.TabIndex = 24;
            // 
            // txtCustomerTel
            // 
            this.txtCustomerTel.Location = new System.Drawing.Point(79, 162);
            this.txtCustomerTel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCustomerTel.Name = "txtCustomerTel";
            this.txtCustomerTel.Size = new System.Drawing.Size(133, 24);
            this.txtCustomerTel.TabIndex = 22;
            // 
            // rdoWoman
            // 
            this.rdoWoman.AutoSize = true;
            this.rdoWoman.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rdoWoman.Location = new System.Drawing.Point(368, 119);
            this.rdoWoman.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdoWoman.Name = "rdoWoman";
            this.rdoWoman.Size = new System.Drawing.Size(35, 16);
            this.rdoWoman.TabIndex = 20;
            this.rdoWoman.TabStop = true;
            this.rdoWoman.Text = "女";
            this.rdoWoman.UseVisualStyleBackColor = true;
            // 
            // rdoMan
            // 
            this.rdoMan.AutoSize = true;
            this.rdoMan.Checked = true;
            this.rdoMan.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rdoMan.Location = new System.Drawing.Point(296, 119);
            this.rdoMan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdoMan.Name = "rdoMan";
            this.rdoMan.Size = new System.Drawing.Size(35, 16);
            this.rdoMan.TabIndex = 19;
            this.rdoMan.TabStop = true;
            this.rdoMan.Text = "男";
            this.rdoMan.UseVisualStyleBackColor = true;
            // 
            // txtCustomerPwd
            // 
            this.txtCustomerPwd.Location = new System.Drawing.Point(79, 114);
            this.txtCustomerPwd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCustomerPwd.Name = "txtCustomerPwd";
            this.txtCustomerPwd.Size = new System.Drawing.Size(133, 24);
            this.txtCustomerPwd.TabIndex = 15;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(79, 30);
            this.txtCustomerName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(133, 24);
            this.txtCustomerName.TabIndex = 13;
            // 
            // btnUpdate
            // 
            this.btnUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnUpdate.Location = new System.Drawing.Point(330, 240);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(85, 39);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "修改";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.ForeColor = System.Drawing.Color.Black;
            this.btnInsert.Location = new System.Drawing.Point(228, 240);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(83, 39);
            this.btnInsert.TabIndex = 10;
            this.btnInsert.Text = "新增";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // Balance
            // 
            this.Balance.AutoSize = true;
            this.Balance.Location = new System.Drawing.Point(242, 204);
            this.Balance.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Balance.Name = "Balance";
            this.Balance.Size = new System.Drawing.Size(37, 15);
            this.Balance.TabIndex = 8;
            this.Balance.Text = "余额";
            // 
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.Location = new System.Drawing.Point(221, 163);
            this.lblAdmin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(67, 15);
            this.lblAdmin.TabIndex = 7;
            this.lblAdmin.Text = "是否管理";
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Location = new System.Drawing.Point(242, 114);
            this.lblSex.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(37, 15);
            this.lblSex.TabIndex = 6;
            this.lblSex.Text = "性别";
            // 
            // lblImage
            // 
            this.lblImage.AutoSize = true;
            this.lblImage.Location = new System.Drawing.Point(242, 33);
            this.lblImage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblImage.Name = "lblImage";
            this.lblImage.Size = new System.Drawing.Size(37, 15);
            this.lblImage.TabIndex = 5;
            this.lblImage.Text = "头像";
            // 
            // lblYNVIP
            // 
            this.lblYNVIP.AutoSize = true;
            this.lblYNVIP.Location = new System.Drawing.Point(8, 210);
            this.lblYNVIP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblYNVIP.Name = "lblYNVIP";
            this.lblYNVIP.Size = new System.Drawing.Size(61, 15);
            this.lblYNVIP.TabIndex = 4;
            this.lblYNVIP.Text = "是否VIP";
            // 
            // lblCustomerTel
            // 
            this.lblCustomerTel.AutoSize = true;
            this.lblCustomerTel.Location = new System.Drawing.Point(8, 167);
            this.lblCustomerTel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCustomerTel.Name = "lblCustomerTel";
            this.lblCustomerTel.Size = new System.Drawing.Size(67, 15);
            this.lblCustomerTel.TabIndex = 3;
            this.lblCustomerTel.Text = "手机号码";
            // 
            // lblCustomerPwd
            // 
            this.lblCustomerPwd.AutoSize = true;
            this.lblCustomerPwd.Location = new System.Drawing.Point(20, 119);
            this.lblCustomerPwd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCustomerPwd.Name = "lblCustomerPwd";
            this.lblCustomerPwd.Size = new System.Drawing.Size(37, 15);
            this.lblCustomerPwd.TabIndex = 2;
            this.lblCustomerPwd.Text = "密码";
            // 
            // lblCustomerUser
            // 
            this.lblCustomerUser.AutoSize = true;
            this.lblCustomerUser.Location = new System.Drawing.Point(8, 74);
            this.lblCustomerUser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCustomerUser.Name = "lblCustomerUser";
            this.lblCustomerUser.Size = new System.Drawing.Size(67, 15);
            this.lblCustomerUser.TabIndex = 1;
            this.lblCustomerUser.Text = "登录账号";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.BackColor = System.Drawing.Color.Transparent;
            this.lblCustomerName.Location = new System.Drawing.Point(10, 33);
            this.lblCustomerName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(67, 15);
            this.lblCustomerName.TabIndex = 0;
            this.lblCustomerName.Text = "用户昵称";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.删除ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(101, 26);
            // 
            // 删除ToolStripMenuItem
            // 
            this.删除ToolStripMenuItem.Name = "删除ToolStripMenuItem";
            this.删除ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.删除ToolStripMenuItem.Text = "删除";
            this.删除ToolStripMenuItem.Click += new System.EventHandler(this.删除ToolStripMenuItem_Click);
            // 
            // btnShuaXin
            // 
            this.btnShuaXin.Location = new System.Drawing.Point(302, 303);
            this.btnShuaXin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnShuaXin.Name = "btnShuaXin";
            this.btnShuaXin.Size = new System.Drawing.Size(124, 31);
            this.btnShuaXin.TabIndex = 31;
            this.btnShuaXin.Text = "刷新数据";
            this.btnShuaXin.UseVisualStyleBackColor = true;
            this.btnShuaXin.Click += new System.EventHandler(this.btnShuaXin_Click);
            // 
            // Frm_UserManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::XiaoHuHouTai.Properties.Resources.activity_bg_wash;
            this.ClientSize = new System.Drawing.Size(720, 568);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.btnShuaXin);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Frm_UserManage";
            this.Text = "Frm_UserManage";
            this.Load += new System.EventHandler(this.Frm_UserManage_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblVIP;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCustomerTel;
        private System.Windows.Forms.RadioButton rdoWoman;
        private System.Windows.Forms.RadioButton rdoMan;
        private System.Windows.Forms.RadioButton rdoNoAdmin;
        private System.Windows.Forms.RadioButton rdoYesAdmin;
        private System.Windows.Forms.TextBox txtCustomerPwd;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Label Balance;
        private System.Windows.Forms.Label lblAdmin;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.Label lblImage;
        private System.Windows.Forms.Label lblYNVIP;
        private System.Windows.Forms.Label lblCustomerTel;
        private System.Windows.Forms.Label lblCustomerPwd;
        private System.Windows.Forms.Label lblCustomerUser;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.TextBox txtCustomerUser;
        private System.Windows.Forms.RadioButton rdoNoVIP;
        private System.Windows.Forms.RadioButton rdoYesVIP;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.Label lblAD;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerPwd;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerTel;
        private System.Windows.Forms.DataGridViewTextBoxColumn VIP;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImageString;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sex;
        private System.Windows.Forms.DataGridViewTextBoxColumn Admin;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerBalance;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 删除ToolStripMenuItem;
        private System.Windows.Forms.ComboBox cmbAdmin;
        private System.Windows.Forms.ComboBox cmbVip;
        private System.Windows.Forms.Button btnImage;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Button btnShuaXin;
    }
}