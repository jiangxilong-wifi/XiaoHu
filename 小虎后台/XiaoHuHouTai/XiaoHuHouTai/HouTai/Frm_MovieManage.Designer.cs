namespace XiaoHu
{
    partial class Frm_MovieManage
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pbCover = new System.Windows.Forms.PictureBox();
            this.btnCover = new System.Windows.Forms.Button();
            this.btnMovie = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.lblminute = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdoNoPlay = new System.Windows.Forms.RadioButton();
            this.rdoYesPlay = new System.Windows.Forms.RadioButton();
            this.txtPlayString = new System.Windows.Forms.TextBox();
            this.txtMoveiRatings = new System.Windows.Forms.TextBox();
            this.rdoNoTick = new System.Windows.Forms.RadioButton();
            this.rdoYesTick = new System.Windows.Forms.RadioButton();
            this.txtIntroduced = new System.Windows.Forms.TextBox();
            this.txtMovieTime = new System.Windows.Forms.TextBox();
            this.cmbMovieType = new System.Windows.Forms.ComboBox();
            this.txtMovieName = new System.Windows.Forms.TextBox();
            this.dtpMovieDate = new System.Windows.Forms.DateTimePicker();
            this.btnInsert = new System.Windows.Forms.Button();
            this.lblIntroduced = new System.Windows.Forms.Label();
            this.lblMovieDate = new System.Windows.Forms.Label();
            this.lblPlay = new System.Windows.Forms.Label();
            this.lblTick = new System.Windows.Forms.Label();
            this.lblCover = new System.Windows.Forms.Label();
            this.lblPlayString = new System.Windows.Forms.Label();
            this.lblMovieRatings = new System.Windows.Forms.Label();
            this.lblMovieTime = new System.Windows.Forms.Label();
            this.lblMovieType = new System.Windows.Forms.Label();
            this.lblMovieName = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.MovieID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MovieName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MovieType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MovieTypeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MovieTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MovieRatings = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlayString = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MovieCover = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MovieTick = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MoviePlay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MovieDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MovieIntroduced = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtRatings = new System.Windows.Forms.TextBox();
            this.lblRatings = new System.Windows.Forms.Label();
            this.btnSelect = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ofDlg = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCover)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.pbCover);
            this.groupBox1.Controls.Add(this.btnCover);
            this.groupBox1.Controls.Add(this.btnMovie);
            this.groupBox1.Controls.Add(this.lblID);
            this.groupBox1.Controls.Add(this.lblminute);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.txtPlayString);
            this.groupBox1.Controls.Add(this.txtMoveiRatings);
            this.groupBox1.Controls.Add(this.rdoNoTick);
            this.groupBox1.Controls.Add(this.rdoYesTick);
            this.groupBox1.Controls.Add(this.txtIntroduced);
            this.groupBox1.Controls.Add(this.txtMovieTime);
            this.groupBox1.Controls.Add(this.cmbMovieType);
            this.groupBox1.Controls.Add(this.txtMovieName);
            this.groupBox1.Controls.Add(this.dtpMovieDate);
            this.groupBox1.Controls.Add(this.btnInsert);
            this.groupBox1.Controls.Add(this.lblIntroduced);
            this.groupBox1.Controls.Add(this.lblMovieDate);
            this.groupBox1.Controls.Add(this.lblPlay);
            this.groupBox1.Controls.Add(this.lblTick);
            this.groupBox1.Controls.Add(this.lblCover);
            this.groupBox1.Controls.Add(this.lblPlayString);
            this.groupBox1.Controls.Add(this.lblMovieRatings);
            this.groupBox1.Controls.Add(this.lblMovieTime);
            this.groupBox1.Controls.Add(this.lblMovieType);
            this.groupBox1.Controls.Add(this.lblMovieName);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(22, 19);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(442, 310);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "新增以及修改影片";
            // 
            // pbCover
            // 
            this.pbCover.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbCover.Location = new System.Drawing.Point(302, 14);
            this.pbCover.Margin = new System.Windows.Forms.Padding(2);
            this.pbCover.Name = "pbCover";
            this.pbCover.Size = new System.Drawing.Size(107, 130);
            this.pbCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCover.TabIndex = 29;
            this.pbCover.TabStop = false;
            // 
            // btnCover
            // 
            this.btnCover.ForeColor = System.Drawing.Color.Black;
            this.btnCover.Location = new System.Drawing.Point(216, 83);
            this.btnCover.Margin = new System.Windows.Forms.Padding(2);
            this.btnCover.Name = "btnCover";
            this.btnCover.Size = new System.Drawing.Size(86, 26);
            this.btnCover.TabIndex = 28;
            this.btnCover.Text = "选择封面";
            this.btnCover.UseVisualStyleBackColor = true;
            this.btnCover.Click += new System.EventHandler(this.btnCover_Click);
            // 
            // btnMovie
            // 
            this.btnMovie.ForeColor = System.Drawing.Color.Black;
            this.btnMovie.Location = new System.Drawing.Point(66, 224);
            this.btnMovie.Margin = new System.Windows.Forms.Padding(2);
            this.btnMovie.Name = "btnMovie";
            this.btnMovie.Size = new System.Drawing.Size(85, 28);
            this.btnMovie.TabIndex = 27;
            this.btnMovie.Text = "选择电影";
            this.btnMovie.UseVisualStyleBackColor = true;
            this.btnMovie.Click += new System.EventHandler(this.btnMovie_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(209, 283);
            this.lblID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(23, 15);
            this.lblID.TabIndex = 26;
            this.lblID.Text = "ID";
            this.lblID.Visible = false;
            // 
            // lblminute
            // 
            this.lblminute.AutoSize = true;
            this.lblminute.Location = new System.Drawing.Point(16, 129);
            this.lblminute.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblminute.Name = "lblminute";
            this.lblminute.Size = new System.Drawing.Size(53, 15);
            this.lblminute.TabIndex = 25;
            this.lblminute.Text = "(分钟)";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdoNoPlay);
            this.panel1.Controls.Add(this.rdoYesPlay);
            this.panel1.Location = new System.Drawing.Point(292, 176);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(122, 30);
            this.panel1.TabIndex = 24;
            // 
            // rdoNoPlay
            // 
            this.rdoNoPlay.AutoSize = true;
            this.rdoNoPlay.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rdoNoPlay.Location = new System.Drawing.Point(82, 9);
            this.rdoNoPlay.Margin = new System.Windows.Forms.Padding(2);
            this.rdoNoPlay.Name = "rdoNoPlay";
            this.rdoNoPlay.Size = new System.Drawing.Size(35, 16);
            this.rdoNoPlay.TabIndex = 18;
            this.rdoNoPlay.Text = "否";
            this.rdoNoPlay.UseVisualStyleBackColor = true;
            // 
            // rdoYesPlay
            // 
            this.rdoYesPlay.AutoSize = true;
            this.rdoYesPlay.Checked = true;
            this.rdoYesPlay.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rdoYesPlay.Location = new System.Drawing.Point(10, 9);
            this.rdoYesPlay.Margin = new System.Windows.Forms.Padding(2);
            this.rdoYesPlay.Name = "rdoYesPlay";
            this.rdoYesPlay.Size = new System.Drawing.Size(35, 16);
            this.rdoYesPlay.TabIndex = 17;
            this.rdoYesPlay.TabStop = true;
            this.rdoYesPlay.Text = "是";
            this.rdoYesPlay.UseVisualStyleBackColor = true;
            // 
            // txtPlayString
            // 
            this.txtPlayString.Location = new System.Drawing.Point(79, 194);
            this.txtPlayString.Margin = new System.Windows.Forms.Padding(2);
            this.txtPlayString.Name = "txtPlayString";
            this.txtPlayString.Size = new System.Drawing.Size(133, 24);
            this.txtPlayString.TabIndex = 23;
            // 
            // txtMoveiRatings
            // 
            this.txtMoveiRatings.Location = new System.Drawing.Point(79, 150);
            this.txtMoveiRatings.Margin = new System.Windows.Forms.Padding(2);
            this.txtMoveiRatings.Name = "txtMoveiRatings";
            this.txtMoveiRatings.Size = new System.Drawing.Size(133, 24);
            this.txtMoveiRatings.TabIndex = 22;
            // 
            // rdoNoTick
            // 
            this.rdoNoTick.AutoSize = true;
            this.rdoNoTick.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rdoNoTick.Location = new System.Drawing.Point(372, 153);
            this.rdoNoTick.Margin = new System.Windows.Forms.Padding(2);
            this.rdoNoTick.Name = "rdoNoTick";
            this.rdoNoTick.Size = new System.Drawing.Size(35, 16);
            this.rdoNoTick.TabIndex = 20;
            this.rdoNoTick.Text = "否";
            this.rdoNoTick.UseVisualStyleBackColor = true;
            // 
            // rdoYesTick
            // 
            this.rdoYesTick.AutoSize = true;
            this.rdoYesTick.Checked = true;
            this.rdoYesTick.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rdoYesTick.Location = new System.Drawing.Point(300, 153);
            this.rdoYesTick.Margin = new System.Windows.Forms.Padding(2);
            this.rdoYesTick.Name = "rdoYesTick";
            this.rdoYesTick.Size = new System.Drawing.Size(35, 16);
            this.rdoYesTick.TabIndex = 19;
            this.rdoYesTick.TabStop = true;
            this.rdoYesTick.Text = "是";
            this.rdoYesTick.UseVisualStyleBackColor = true;
            // 
            // txtIntroduced
            // 
            this.txtIntroduced.Location = new System.Drawing.Point(236, 256);
            this.txtIntroduced.Margin = new System.Windows.Forms.Padding(2);
            this.txtIntroduced.Multiline = true;
            this.txtIntroduced.Name = "txtIntroduced";
            this.txtIntroduced.Size = new System.Drawing.Size(190, 43);
            this.txtIntroduced.TabIndex = 16;
            // 
            // txtMovieTime
            // 
            this.txtMovieTime.Location = new System.Drawing.Point(79, 105);
            this.txtMovieTime.Margin = new System.Windows.Forms.Padding(2);
            this.txtMovieTime.Name = "txtMovieTime";
            this.txtMovieTime.Size = new System.Drawing.Size(133, 24);
            this.txtMovieTime.TabIndex = 15;
            // 
            // cmbMovieType
            // 
            this.cmbMovieType.FormattingEnabled = true;
            this.cmbMovieType.Items.AddRange(new object[] {
            "爱情电影",
            "动作电影",
            "美国大片",
            "免费电影",
            "欧洲电影",
            "喜剧电影",
            "悬疑电影"});
            this.cmbMovieType.Location = new System.Drawing.Point(80, 67);
            this.cmbMovieType.Margin = new System.Windows.Forms.Padding(2);
            this.cmbMovieType.Name = "cmbMovieType";
            this.cmbMovieType.Size = new System.Drawing.Size(132, 22);
            this.cmbMovieType.TabIndex = 14;
            // 
            // txtMovieName
            // 
            this.txtMovieName.Location = new System.Drawing.Point(79, 30);
            this.txtMovieName.Margin = new System.Windows.Forms.Padding(2);
            this.txtMovieName.Name = "txtMovieName";
            this.txtMovieName.Size = new System.Drawing.Size(133, 24);
            this.txtMovieName.TabIndex = 13;
            // 
            // dtpMovieDate
            // 
            this.dtpMovieDate.CalendarForeColor = System.Drawing.Color.DarkOrchid;
            this.dtpMovieDate.Location = new System.Drawing.Point(282, 210);
            this.dtpMovieDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpMovieDate.Name = "dtpMovieDate";
            this.dtpMovieDate.Size = new System.Drawing.Size(154, 24);
            this.dtpMovieDate.TabIndex = 12;
            // 
            // btnInsert
            // 
            this.btnInsert.ForeColor = System.Drawing.Color.Black;
            this.btnInsert.Location = new System.Drawing.Point(68, 264);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(2);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(83, 34);
            this.btnInsert.TabIndex = 10;
            this.btnInsert.Text = "新增";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // lblIntroduced
            // 
            this.lblIntroduced.AutoSize = true;
            this.lblIntroduced.Location = new System.Drawing.Point(233, 239);
            this.lblIntroduced.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIntroduced.Name = "lblIntroduced";
            this.lblIntroduced.Size = new System.Drawing.Size(37, 15);
            this.lblIntroduced.TabIndex = 9;
            this.lblIntroduced.Text = "介绍";
            // 
            // lblMovieDate
            // 
            this.lblMovieDate.AutoSize = true;
            this.lblMovieDate.Location = new System.Drawing.Point(215, 213);
            this.lblMovieDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMovieDate.Name = "lblMovieDate";
            this.lblMovieDate.Size = new System.Drawing.Size(67, 15);
            this.lblMovieDate.TabIndex = 8;
            this.lblMovieDate.Text = "上映时间";
            // 
            // lblPlay
            // 
            this.lblPlay.AutoSize = true;
            this.lblPlay.Location = new System.Drawing.Point(225, 184);
            this.lblPlay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPlay.Name = "lblPlay";
            this.lblPlay.Size = new System.Drawing.Size(67, 15);
            this.lblPlay.TabIndex = 7;
            this.lblPlay.Text = "可播放？";
            // 
            // lblTick
            // 
            this.lblTick.AutoSize = true;
            this.lblTick.Location = new System.Drawing.Point(225, 153);
            this.lblTick.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTick.Name = "lblTick";
            this.lblTick.Size = new System.Drawing.Size(67, 15);
            this.lblTick.TabIndex = 6;
            this.lblTick.Text = "可购票？";
            // 
            // lblCover
            // 
            this.lblCover.AutoSize = true;
            this.lblCover.Location = new System.Drawing.Point(225, 56);
            this.lblCover.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCover.Name = "lblCover";
            this.lblCover.Size = new System.Drawing.Size(67, 15);
            this.lblCover.TabIndex = 5;
            this.lblCover.Text = "封面链接";
            // 
            // lblPlayString
            // 
            this.lblPlayString.AutoSize = true;
            this.lblPlayString.Location = new System.Drawing.Point(10, 196);
            this.lblPlayString.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPlayString.Name = "lblPlayString";
            this.lblPlayString.Size = new System.Drawing.Size(67, 15);
            this.lblPlayString.TabIndex = 4;
            this.lblPlayString.Text = "播放链接";
            // 
            // lblMovieRatings
            // 
            this.lblMovieRatings.AutoSize = true;
            this.lblMovieRatings.Location = new System.Drawing.Point(8, 156);
            this.lblMovieRatings.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMovieRatings.Name = "lblMovieRatings";
            this.lblMovieRatings.Size = new System.Drawing.Size(67, 15);
            this.lblMovieRatings.TabIndex = 3;
            this.lblMovieRatings.Text = "电影评分";
            // 
            // lblMovieTime
            // 
            this.lblMovieTime.AutoSize = true;
            this.lblMovieTime.Location = new System.Drawing.Point(8, 109);
            this.lblMovieTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMovieTime.Name = "lblMovieTime";
            this.lblMovieTime.Size = new System.Drawing.Size(67, 15);
            this.lblMovieTime.TabIndex = 2;
            this.lblMovieTime.Text = "电影时长";
            // 
            // lblMovieType
            // 
            this.lblMovieType.AutoSize = true;
            this.lblMovieType.Location = new System.Drawing.Point(8, 69);
            this.lblMovieType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMovieType.Name = "lblMovieType";
            this.lblMovieType.Size = new System.Drawing.Size(67, 15);
            this.lblMovieType.TabIndex = 1;
            this.lblMovieType.Text = "电影类型";
            // 
            // lblMovieName
            // 
            this.lblMovieName.AutoSize = true;
            this.lblMovieName.Location = new System.Drawing.Point(22, 33);
            this.lblMovieName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMovieName.Name = "lblMovieName";
            this.lblMovieName.Size = new System.Drawing.Size(52, 15);
            this.lblMovieName.TabIndex = 0;
            this.lblMovieName.Text = "电影名";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.dgv);
            this.groupBox2.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.ForeColor = System.Drawing.Color.Gray;
            this.groupBox2.Location = new System.Drawing.Point(23, 334);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(673, 225);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "影片信息";
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MovieID,
            this.MovieName,
            this.MovieType,
            this.MovieTypeID,
            this.MovieTime,
            this.MovieRatings,
            this.PlayString,
            this.MovieCover,
            this.MovieTick,
            this.MoviePlay,
            this.MovieDate,
            this.MovieIntroduced});
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.Location = new System.Drawing.Point(2, 19);
            this.dgv.Margin = new System.Windows.Forms.Padding(2);
            this.dgv.Name = "dgv";
            this.dgv.RowTemplate.Height = 27;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(669, 204);
            this.dgv.TabIndex = 0;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            // 
            // MovieID
            // 
            this.MovieID.DataPropertyName = "MovieID";
            this.MovieID.HeaderText = "电影编号";
            this.MovieID.Name = "MovieID";
            // 
            // MovieName
            // 
            this.MovieName.DataPropertyName = "MovieName";
            this.MovieName.HeaderText = "电影名";
            this.MovieName.Name = "MovieName";
            // 
            // MovieType
            // 
            this.MovieType.DataPropertyName = "MovieTypeName";
            this.MovieType.HeaderText = "电影类型";
            this.MovieType.Name = "MovieType";
            // 
            // MovieTypeID
            // 
            this.MovieTypeID.DataPropertyName = "MovieTypeID";
            this.MovieTypeID.HeaderText = "电影类型编号";
            this.MovieTypeID.Name = "MovieTypeID";
            // 
            // MovieTime
            // 
            this.MovieTime.DataPropertyName = "MovieTime";
            this.MovieTime.HeaderText = "电影时长";
            this.MovieTime.Name = "MovieTime";
            // 
            // MovieRatings
            // 
            this.MovieRatings.DataPropertyName = "Movie_Ratings";
            this.MovieRatings.HeaderText = "电影评分";
            this.MovieRatings.Name = "MovieRatings";
            // 
            // PlayString
            // 
            this.PlayString.DataPropertyName = "Movie_PlayString";
            this.PlayString.HeaderText = "播放链接";
            this.PlayString.Name = "PlayString";
            // 
            // MovieCover
            // 
            this.MovieCover.DataPropertyName = "Movie_Cover";
            this.MovieCover.HeaderText = "封面链接";
            this.MovieCover.Name = "MovieCover";
            // 
            // MovieTick
            // 
            this.MovieTick.DataPropertyName = "Movie_Tick";
            this.MovieTick.HeaderText = "可购票？";
            this.MovieTick.Name = "MovieTick";
            // 
            // MoviePlay
            // 
            this.MoviePlay.DataPropertyName = "Movie_Play";
            this.MoviePlay.HeaderText = "可播放？";
            this.MoviePlay.Name = "MoviePlay";
            // 
            // MovieDate
            // 
            this.MovieDate.DataPropertyName = "Date";
            this.MovieDate.HeaderText = "上映时间";
            this.MovieDate.Name = "MovieDate";
            // 
            // MovieIntroduced
            // 
            this.MovieIntroduced.DataPropertyName = "Movie_Introduced";
            this.MovieIntroduced.HeaderText = "介绍";
            this.MovieIntroduced.Name = "MovieIntroduced";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.txtRatings);
            this.groupBox3.Controls.Add(this.lblRatings);
            this.groupBox3.Controls.Add(this.btnSelect);
            this.groupBox3.Controls.Add(this.txtName);
            this.groupBox3.Controls.Add(this.lblName);
            this.groupBox3.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(482, 19);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(214, 266);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "影片查询";
            // 
            // txtRatings
            // 
            this.txtRatings.Location = new System.Drawing.Point(14, 142);
            this.txtRatings.Margin = new System.Windows.Forms.Padding(2);
            this.txtRatings.Name = "txtRatings";
            this.txtRatings.Size = new System.Drawing.Size(133, 24);
            this.txtRatings.TabIndex = 26;
            // 
            // lblRatings
            // 
            this.lblRatings.AutoSize = true;
            this.lblRatings.Location = new System.Drawing.Point(13, 108);
            this.lblRatings.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRatings.Name = "lblRatings";
            this.lblRatings.Size = new System.Drawing.Size(37, 15);
            this.lblRatings.TabIndex = 27;
            this.lblRatings.Text = "评分";
            // 
            // btnSelect
            // 
            this.btnSelect.ForeColor = System.Drawing.Color.Black;
            this.btnSelect.Location = new System.Drawing.Point(71, 210);
            this.btnSelect.Margin = new System.Windows.Forms.Padding(2);
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
            this.txtName.Margin = new System.Windows.Forms.Padding(2);
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
            this.lblName.Size = new System.Drawing.Size(67, 15);
            this.lblName.TabIndex = 24;
            this.lblName.Text = "影片名称";
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
            // ofDlg
            // 
            this.ofDlg.FileName = "openFileDialog1";
            // 
            // Frm_MovieManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::XiaoHuHouTai.Properties.Resources.activity_bg_wash;
            this.ClientSize = new System.Drawing.Size(720, 568);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Frm_MovieManage";
            this.Text = "Frm_MovieManage";
            this.Load += new System.EventHandler(this.Frm_MovieManage_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCover)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPlayString;
        private System.Windows.Forms.TextBox txtMoveiRatings;
        private System.Windows.Forms.RadioButton rdoNoTick;
        private System.Windows.Forms.RadioButton rdoYesTick;
        private System.Windows.Forms.RadioButton rdoNoPlay;
        private System.Windows.Forms.RadioButton rdoYesPlay;
        private System.Windows.Forms.TextBox txtIntroduced;
        private System.Windows.Forms.TextBox txtMovieTime;
        private System.Windows.Forms.ComboBox cmbMovieType;
        private System.Windows.Forms.TextBox txtMovieName;
        private System.Windows.Forms.DateTimePicker dtpMovieDate;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Label lblIntroduced;
        private System.Windows.Forms.Label lblMovieDate;
        private System.Windows.Forms.Label lblPlay;
        private System.Windows.Forms.Label lblTick;
        private System.Windows.Forms.Label lblCover;
        private System.Windows.Forms.Label lblPlayString;
        private System.Windows.Forms.Label lblMovieRatings;
        private System.Windows.Forms.Label lblMovieTime;
        private System.Windows.Forms.Label lblMovieType;
        private System.Windows.Forms.Label lblMovieName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblRatings;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblminute;
        private System.Windows.Forms.DataGridViewTextBoxColumn MovieID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MovieName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MovieType;
        private System.Windows.Forms.DataGridViewTextBoxColumn MovieTypeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MovieTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn MovieRatings;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlayString;
        private System.Windows.Forms.DataGridViewTextBoxColumn MovieCover;
        private System.Windows.Forms.DataGridViewTextBoxColumn MovieTick;
        private System.Windows.Forms.DataGridViewTextBoxColumn MoviePlay;
        private System.Windows.Forms.DataGridViewTextBoxColumn MovieDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn MovieIntroduced;
        private System.Windows.Forms.TextBox txtRatings;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 删除ToolStripMenuItem;
        private System.Windows.Forms.Button btnCover;
        private System.Windows.Forms.Button btnMovie;
        private System.Windows.Forms.PictureBox pbCover;
        private System.Windows.Forms.OpenFileDialog ofDlg;
    }
}