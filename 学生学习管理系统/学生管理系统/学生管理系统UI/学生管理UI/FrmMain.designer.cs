namespace 学生管理UI
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.系统ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tmiModifyPwd = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tmiClose = new System.Windows.Forms.ToolStripMenuItem();
            this.学员管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAddStudent = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiManageStudent = new System.Windows.Forms.ToolStripMenuItem();
            this.成绩管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiQueryAndAnalysis = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiQuery = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_AttendanceQuery = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Card = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmi_AQuery = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助HToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_linkxkt = new System.Windows.Forms.ToolStripMenuItem();
            this.txmi_update = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmi_about = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblVersion = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblCurrentUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbAddStudent = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbScoreAnalysis = new System.Windows.Forms.ToolStripButton();
            this.tsbQuery = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbModifyPwd = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbExit = new System.Windows.Forms.ToolStripButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panelForm = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.btnStuInsert = new System.Windows.Forms.Button();
            this.btnStunInfos = new System.Windows.Forms.Button();
            this.btnCard = new System.Windows.Forms.Button();
            this.btnCardInfos = new System.Windows.Forms.Button();
            this.btnScoreInfos = new System.Windows.Forms.Button();
            this.btnScore = new System.Windows.Forms.Button();
            this.btnAdminPwd = new System.Windows.Forms.Button();
            this.btnAdminUser = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panelForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.系统ToolStripMenuItem,
            this.学员管理ToolStripMenuItem,
            this.成绩管理ToolStripMenuItem,
            this.tsmi_AttendanceQuery,
            this.帮助HToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1578, 28);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 系统ToolStripMenuItem
            // 
            this.系统ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tmiModifyPwd,
            this.toolStripSeparator3,
            this.tmiClose});
            this.系统ToolStripMenuItem.Name = "系统ToolStripMenuItem";
            this.系统ToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.系统ToolStripMenuItem.Text = "系统(&S)";
            // 
            // tmiModifyPwd
            // 
            this.tmiModifyPwd.Image = ((System.Drawing.Image)(resources.GetObject("tmiModifyPwd.Image")));
            this.tmiModifyPwd.Name = "tmiModifyPwd";
            this.tmiModifyPwd.Size = new System.Drawing.Size(172, 26);
            this.tmiModifyPwd.Text = "密码修改(&C)";
            this.tmiModifyPwd.Click += new System.EventHandler(this.tmiModifyPwd_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(169, 6);
            // 
            // tmiClose
            // 
            this.tmiClose.Image = ((System.Drawing.Image)(resources.GetObject("tmiClose.Image")));
            this.tmiClose.Name = "tmiClose";
            this.tmiClose.Size = new System.Drawing.Size(172, 26);
            this.tmiClose.Text = "退出(&E)";
            this.tmiClose.Click += new System.EventHandler(this.tmiClose_Click);
            // 
            // 学员管理ToolStripMenuItem
            // 
            this.学员管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAddStudent,
            this.toolStripSeparator2,
            this.tsmiManageStudent});
            this.学员管理ToolStripMenuItem.Name = "学员管理ToolStripMenuItem";
            this.学员管理ToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.学员管理ToolStripMenuItem.Text = "学员管理(&M)";
            // 
            // tsmiAddStudent
            // 
            this.tsmiAddStudent.Image = ((System.Drawing.Image)(resources.GetObject("tsmiAddStudent.Image")));
            this.tsmiAddStudent.Name = "tsmiAddStudent";
            this.tsmiAddStudent.Size = new System.Drawing.Size(204, 26);
            this.tsmiAddStudent.Text = "添加学员(&A)";
            this.tsmiAddStudent.Click += new System.EventHandler(this.tsmiAddStudent_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(201, 6);
            // 
            // tsmiManageStudent
            // 
            this.tsmiManageStudent.Image = ((System.Drawing.Image)(resources.GetObject("tsmiManageStudent.Image")));
            this.tsmiManageStudent.Name = "tsmiManageStudent";
            this.tsmiManageStudent.Size = new System.Drawing.Size(204, 26);
            this.tsmiManageStudent.Text = "学员信息管理(&Q)";
            this.tsmiManageStudent.Click += new System.EventHandler(this.tsmiManageStudent_Click);
            // 
            // 成绩管理ToolStripMenuItem
            // 
            this.成绩管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiQueryAndAnalysis,
            this.toolStripSeparator1,
            this.tsmiQuery});
            this.成绩管理ToolStripMenuItem.Name = "成绩管理ToolStripMenuItem";
            this.成绩管理ToolStripMenuItem.Size = new System.Drawing.Size(99, 24);
            this.成绩管理ToolStripMenuItem.Text = "成绩管理(&J)";
            // 
            // tsmiQueryAndAnalysis
            // 
            this.tsmiQueryAndAnalysis.Image = ((System.Drawing.Image)(resources.GetObject("tsmiQueryAndAnalysis.Image")));
            this.tsmiQueryAndAnalysis.Name = "tsmiQueryAndAnalysis";
            this.tsmiQueryAndAnalysis.Size = new System.Drawing.Size(219, 26);
            this.tsmiQueryAndAnalysis.Text = "成绩查询与分析(&Q)";
            this.tsmiQueryAndAnalysis.Click += new System.EventHandler(this.tsmiQueryAndAnalysis_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(216, 6);
            // 
            // tsmiQuery
            // 
            this.tsmiQuery.Image = ((System.Drawing.Image)(resources.GetObject("tsmiQuery.Image")));
            this.tsmiQuery.Name = "tsmiQuery";
            this.tsmiQuery.Size = new System.Drawing.Size(219, 26);
            this.tsmiQuery.Text = "成绩快速查询(&S)";
            this.tsmiQuery.Click += new System.EventHandler(this.tsmiQuery_Click);
            // 
            // tsmi_AttendanceQuery
            // 
            this.tsmi_AttendanceQuery.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_Card,
            this.toolStripSeparator7,
            this.tsmi_AQuery});
            this.tsmi_AttendanceQuery.Name = "tsmi_AttendanceQuery";
            this.tsmi_AttendanceQuery.Size = new System.Drawing.Size(104, 24);
            this.tsmi_AttendanceQuery.Text = "考勤管理(&A)";
            // 
            // tsmi_Card
            // 
            this.tsmi_Card.Image = ((System.Drawing.Image)(resources.GetObject("tsmi_Card.Image")));
            this.tsmi_Card.Name = "tsmi_Card";
            this.tsmi_Card.Size = new System.Drawing.Size(172, 26);
            this.tsmi_Card.Text = "考勤打卡(&R)";
            this.tsmi_Card.Click += new System.EventHandler(this.tsmi_Card_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(169, 6);
            // 
            // tsmi_AQuery
            // 
            this.tsmi_AQuery.Image = ((System.Drawing.Image)(resources.GetObject("tsmi_AQuery.Image")));
            this.tsmi_AQuery.Name = "tsmi_AQuery";
            this.tsmi_AQuery.Size = new System.Drawing.Size(172, 26);
            this.tsmi_AQuery.Text = "考勤查询";
            this.tsmi_AQuery.Click += new System.EventHandler(this.tsmi_AQuery_Click);
            // 
            // 帮助HToolStripMenuItem
            // 
            this.帮助HToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_linkxkt,
            this.txmi_update,
            this.toolStripSeparator8,
            this.tsmi_about});
            this.帮助HToolStripMenuItem.Name = "帮助HToolStripMenuItem";
            this.帮助HToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.帮助HToolStripMenuItem.Text = "帮助(&H)";
            // 
            // tsmi_linkxkt
            // 
            this.tsmi_linkxkt.Image = ((System.Drawing.Image)(resources.GetObject("tsmi_linkxkt.Image")));
            this.tsmi_linkxkt.Name = "tsmi_linkxkt";
            this.tsmi_linkxkt.Size = new System.Drawing.Size(173, 26);
            this.tsmi_linkxkt.Text = "访问官网(&X)";
            this.tsmi_linkxkt.Click += new System.EventHandler(this.tsmi_linkxkt_Click);
            // 
            // txmi_update
            // 
            this.txmi_update.Image = ((System.Drawing.Image)(resources.GetObject("txmi_update.Image")));
            this.txmi_update.Name = "txmi_update";
            this.txmi_update.Size = new System.Drawing.Size(173, 26);
            this.txmi_update.Text = "系统升级(&U)";
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(170, 6);
            // 
            // tsmi_about
            // 
            this.tsmi_about.Image = ((System.Drawing.Image)(resources.GetObject("tsmi_about.Image")));
            this.tsmi_about.Name = "tsmi_about";
            this.tsmi_about.Size = new System.Drawing.Size(173, 26);
            this.tsmi_about.Text = "关于我们(&A)";
            this.tsmi_about.Click += new System.EventHandler(this.tsmi_about_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblVersion,
            this.toolStripStatusLabel1,
            this.lblCurrentUser});
            this.statusStrip1.Location = new System.Drawing.Point(0, 848);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1578, 26);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblVersion
            // 
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(105, 20);
            this.lblVersion.Text = " 版本号：V2.0";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(123, 20);
            this.toolStripStatusLabel1.Text = " [当前用登录户：";
            // 
            // lblCurrentUser
            // 
            this.lblCurrentUser.Name = "lblCurrentUser";
            this.lblCurrentUser.Size = new System.Drawing.Size(59, 20);
            this.lblCurrentUser.Text = "王晓军]";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAddStudent,
            this.toolStripButton1,
            this.toolStripSeparator5,
            this.tsbScoreAnalysis,
            this.tsbQuery,
            this.toolStripSeparator4,
            this.tsbModifyPwd,
            this.toolStripSeparator6,
            this.tsbExit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1578, 27);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbAddStudent
            // 
            this.tsbAddStudent.Image = ((System.Drawing.Image)(resources.GetObject("tsbAddStudent.Image")));
            this.tsbAddStudent.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAddStudent.Name = "tsbAddStudent";
            this.tsbAddStudent.Size = new System.Drawing.Size(93, 24);
            this.tsbAddStudent.Text = "添加学员";
            this.tsbAddStudent.Click += new System.EventHandler(this.tsbAddStudent_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(93, 24);
            this.toolStripButton1.Text = "学员管理";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 27);
            // 
            // tsbScoreAnalysis
            // 
            this.tsbScoreAnalysis.Image = ((System.Drawing.Image)(resources.GetObject("tsbScoreAnalysis.Image")));
            this.tsbScoreAnalysis.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbScoreAnalysis.Name = "tsbScoreAnalysis";
            this.tsbScoreAnalysis.Size = new System.Drawing.Size(138, 24);
            this.tsbScoreAnalysis.Text = "成绩查询与分析";
            this.tsbScoreAnalysis.Click += new System.EventHandler(this.tsbScoreAnalysis_Click);
            // 
            // tsbQuery
            // 
            this.tsbQuery.Image = ((System.Drawing.Image)(resources.GetObject("tsbQuery.Image")));
            this.tsbQuery.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbQuery.Name = "tsbQuery";
            this.tsbQuery.Size = new System.Drawing.Size(123, 24);
            this.tsbQuery.Text = "成绩快速查询";
            this.tsbQuery.Click += new System.EventHandler(this.tsbQuery_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 27);
            // 
            // tsbModifyPwd
            // 
            this.tsbModifyPwd.Image = ((System.Drawing.Image)(resources.GetObject("tsbModifyPwd.Image")));
            this.tsbModifyPwd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbModifyPwd.Name = "tsbModifyPwd";
            this.tsbModifyPwd.Size = new System.Drawing.Size(93, 24);
            this.tsbModifyPwd.Text = "修改密码";
            this.tsbModifyPwd.Click += new System.EventHandler(this.tsbModifyPwd_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 27);
            // 
            // tsbExit
            // 
            this.tsbExit.Image = ((System.Drawing.Image)(resources.GetObject("tsbExit.Image")));
            this.tsbExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbExit.Name = "tsbExit";
            this.tsbExit.Size = new System.Drawing.Size(93, 24);
            this.tsbExit.Text = "退出系统";
            this.tsbExit.Click += new System.EventHandler(this.tsbExit_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // panelForm
            // 
            this.panelForm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelForm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelForm.Controls.Add(this.lblTitle);
            this.panelForm.Location = new System.Drawing.Point(489, 59);
            this.panelForm.Margin = new System.Windows.Forms.Padding(4);
            this.panelForm.Name = "panelForm";
            this.panelForm.Size = new System.Drawing.Size(1066, 758);
            this.panelForm.TabIndex = 8;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("华文彩云", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblTitle.Location = new System.Drawing.Point(133, 31);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(759, 63);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "欢迎使用学员信息管理系统";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(79, 78);
            this.monthCalendar1.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 20;
            // 
            // btnStuInsert
            // 
            this.btnStuInsert.Image = ((System.Drawing.Image)(resources.GetObject("btnStuInsert.Image")));
            this.btnStuInsert.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStuInsert.Location = new System.Drawing.Point(82, 355);
            this.btnStuInsert.Margin = new System.Windows.Forms.Padding(4);
            this.btnStuInsert.Name = "btnStuInsert";
            this.btnStuInsert.Size = new System.Drawing.Size(111, 36);
            this.btnStuInsert.TabIndex = 21;
            this.btnStuInsert.Text = "添加学员";
            this.btnStuInsert.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStuInsert.UseVisualStyleBackColor = true;
            this.btnStuInsert.Click += new System.EventHandler(this.tsmiAddStudent_Click);
            // 
            // btnStunInfos
            // 
            this.btnStunInfos.Image = ((System.Drawing.Image)(resources.GetObject("btnStunInfos.Image")));
            this.btnStunInfos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStunInfos.Location = new System.Drawing.Point(249, 355);
            this.btnStunInfos.Margin = new System.Windows.Forms.Padding(4);
            this.btnStunInfos.Name = "btnStunInfos";
            this.btnStunInfos.Size = new System.Drawing.Size(111, 36);
            this.btnStunInfos.TabIndex = 22;
            this.btnStunInfos.Text = "学员管理";
            this.btnStunInfos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStunInfos.UseVisualStyleBackColor = true;
            this.btnStunInfos.Click += new System.EventHandler(this.tsmiManageStudent_Click);
            // 
            // btnCard
            // 
            this.btnCard.Image = ((System.Drawing.Image)(resources.GetObject("btnCard.Image")));
            this.btnCard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCard.Location = new System.Drawing.Point(82, 431);
            this.btnCard.Margin = new System.Windows.Forms.Padding(4);
            this.btnCard.Name = "btnCard";
            this.btnCard.Size = new System.Drawing.Size(111, 36);
            this.btnCard.TabIndex = 23;
            this.btnCard.Text = "考勤打卡";
            this.btnCard.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCard.UseVisualStyleBackColor = true;
            this.btnCard.Click += new System.EventHandler(this.tsmi_Card_Click);
            // 
            // btnCardInfos
            // 
            this.btnCardInfos.Image = ((System.Drawing.Image)(resources.GetObject("btnCardInfos.Image")));
            this.btnCardInfos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCardInfos.Location = new System.Drawing.Point(249, 431);
            this.btnCardInfos.Margin = new System.Windows.Forms.Padding(4);
            this.btnCardInfos.Name = "btnCardInfos";
            this.btnCardInfos.Size = new System.Drawing.Size(111, 36);
            this.btnCardInfos.TabIndex = 24;
            this.btnCardInfos.Text = "考勤查询";
            this.btnCardInfos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCardInfos.UseVisualStyleBackColor = true;
            this.btnCardInfos.Click += new System.EventHandler(this.tsmi_AQuery_Click);
            // 
            // btnScoreInfos
            // 
            this.btnScoreInfos.Image = ((System.Drawing.Image)(resources.GetObject("btnScoreInfos.Image")));
            this.btnScoreInfos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnScoreInfos.Location = new System.Drawing.Point(82, 530);
            this.btnScoreInfos.Margin = new System.Windows.Forms.Padding(4);
            this.btnScoreInfos.Name = "btnScoreInfos";
            this.btnScoreInfos.Size = new System.Drawing.Size(111, 36);
            this.btnScoreInfos.TabIndex = 25;
            this.btnScoreInfos.Text = "成绩浏览";
            this.btnScoreInfos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnScoreInfos.UseVisualStyleBackColor = true;
            this.btnScoreInfos.Click += new System.EventHandler(this.tsbScoreAnalysis_Click);
            // 
            // btnScore
            // 
            this.btnScore.Image = ((System.Drawing.Image)(resources.GetObject("btnScore.Image")));
            this.btnScore.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnScore.Location = new System.Drawing.Point(249, 530);
            this.btnScore.Margin = new System.Windows.Forms.Padding(4);
            this.btnScore.Name = "btnScore";
            this.btnScore.Size = new System.Drawing.Size(111, 36);
            this.btnScore.TabIndex = 26;
            this.btnScore.Text = "成绩分析";
            this.btnScore.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnScore.UseVisualStyleBackColor = true;
            this.btnScore.Click += new System.EventHandler(this.tsmiQuery_Click);
            // 
            // btnAdminPwd
            // 
            this.btnAdminPwd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdminPwd.Image")));
            this.btnAdminPwd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdminPwd.Location = new System.Drawing.Point(82, 614);
            this.btnAdminPwd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdminPwd.Name = "btnAdminPwd";
            this.btnAdminPwd.Size = new System.Drawing.Size(111, 36);
            this.btnAdminPwd.TabIndex = 27;
            this.btnAdminPwd.Text = "密码修改";
            this.btnAdminPwd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdminPwd.UseVisualStyleBackColor = true;
            this.btnAdminPwd.Click += new System.EventHandler(this.tmiModifyPwd_Click);
            // 
            // btnAdminUser
            // 
            this.btnAdminUser.Image = ((System.Drawing.Image)(resources.GetObject("btnAdminUser.Image")));
            this.btnAdminUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdminUser.Location = new System.Drawing.Point(249, 614);
            this.btnAdminUser.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdminUser.Name = "btnAdminUser";
            this.btnAdminUser.Size = new System.Drawing.Size(111, 36);
            this.btnAdminUser.TabIndex = 28;
            this.btnAdminUser.Text = "账号切换";
            this.btnAdminUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdminUser.UseVisualStyleBackColor = true;
            this.btnAdminUser.Click += new System.EventHandler(this.btnAdminUser_Click);
            // 
            // btn1
            // 
            this.btn1.Image = ((System.Drawing.Image)(resources.GetObject("btn1.Image")));
            this.btn1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn1.Location = new System.Drawing.Point(82, 707);
            this.btn1.Margin = new System.Windows.Forms.Padding(4);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(111, 36);
            this.btn1.TabIndex = 29;
            this.btn1.Text = "系统升级";
            this.btn1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.tsmi_about_Click);
            // 
            // btn2
            // 
            this.btn2.Image = ((System.Drawing.Image)(resources.GetObject("btn2.Image")));
            this.btn2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn2.Location = new System.Drawing.Point(249, 707);
            this.btn2.Margin = new System.Windows.Forms.Padding(4);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(111, 36);
            this.btn2.TabIndex = 30;
            this.btn2.Text = "批量导入";
            this.btn2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.Image = ((System.Drawing.Image)(resources.GetObject("btn3.Image")));
            this.btn3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn3.Location = new System.Drawing.Point(82, 781);
            this.btn3.Margin = new System.Windows.Forms.Padding(4);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(111, 36);
            this.btn3.TabIndex = 31;
            this.btn3.Text = "访问官网";
            this.btn3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn3.UseVisualStyleBackColor = true;
            // 
            // btn4
            // 
            this.btn4.Image = ((System.Drawing.Image)(resources.GetObject("btn4.Image")));
            this.btn4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn4.Location = new System.Drawing.Point(249, 781);
            this.btn4.Margin = new System.Windows.Forms.Padding(4);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(111, 36);
            this.btn4.TabIndex = 32;
            this.btn4.Text = "退出系统";
            this.btn4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.tmiClose_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1578, 874);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btnAdminUser);
            this.Controls.Add(this.btnAdminPwd);
            this.Controls.Add(this.btnScore);
            this.Controls.Add(this.btnScoreInfos);
            this.Controls.Add(this.btnCardInfos);
            this.Controls.Add(this.btnCard);
            this.Controls.Add(this.btnStunInfos);
            this.Controls.Add(this.btnStuInsert);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.panelForm);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "[学员信息管理系统]--喜科堂专用教学项目";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panelForm.ResumeLayout(false);
            this.panelForm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 系统ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tmiModifyPwd;
        private System.Windows.Forms.ToolStripMenuItem tmiClose;
        private System.Windows.Forms.ToolStripMenuItem 学员管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiAddStudent;
        private System.Windows.Forms.ToolStripMenuItem tsmiManageStudent;
        private System.Windows.Forms.ToolStripMenuItem 成绩管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiQueryAndAnalysis;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblCurrentUser;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmiQuery;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbAddStudent;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton tsbScoreAnalysis;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton tsbModifyPwd;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton tsbExit;
        private System.Windows.Forms.ToolStripStatusLabel lblVersion;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripButton tsbQuery;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmi_AttendanceQuery;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Card;
        private System.Windows.Forms.Panel panelForm;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem tsmi_AQuery;
        private System.Windows.Forms.ToolStripMenuItem 帮助HToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmi_linkxkt;
        private System.Windows.Forms.ToolStripMenuItem txmi_update;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripMenuItem tsmi_about;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button btnStuInsert;
        private System.Windows.Forms.Button btnStunInfos;
        private System.Windows.Forms.Button btnCard;
        private System.Windows.Forms.Button btnCardInfos;
        private System.Windows.Forms.Button btnScoreInfos;
        private System.Windows.Forms.Button btnScore;
        private System.Windows.Forms.Button btnAdminPwd;
        private System.Windows.Forms.Button btnAdminUser;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
    }
}

