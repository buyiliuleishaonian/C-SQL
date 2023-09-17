namespace StudentManager
{
    partial class FrmStudentInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStudentInfo));
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.lblBirthday = new System.Windows.Forms.Label();
            this.lblStudentIdNo = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblClass = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblCardNo = new System.Windows.Forms.Label();
            this.pbStu = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.student = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bithday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GeridNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GardNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClassID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pbStu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "家庭住址：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 6;
            this.label5.Text = "联系电话：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(226, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 7;
            this.label7.Text = "班级：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "身份证号：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "出生日期：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(226, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "性别：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "学生姓名：";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(302, 254);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "关闭窗口";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblStudentName
            // 
            this.lblStudentName.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblStudentName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblStudentName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblStudentName.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblStudentName.Location = new System.Drawing.Point(77, 18);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(132, 23);
            this.lblStudentName.TabIndex = 9;
            this.lblStudentName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBirthday
            // 
            this.lblBirthday.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblBirthday.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBirthday.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblBirthday.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblBirthday.Location = new System.Drawing.Point(77, 58);
            this.lblBirthday.Name = "lblBirthday";
            this.lblBirthday.Size = new System.Drawing.Size(132, 23);
            this.lblBirthday.TabIndex = 9;
            this.lblBirthday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStudentIdNo
            // 
            this.lblStudentIdNo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblStudentIdNo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblStudentIdNo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblStudentIdNo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblStudentIdNo.Location = new System.Drawing.Point(77, 104);
            this.lblStudentIdNo.Name = "lblStudentIdNo";
            this.lblStudentIdNo.Size = new System.Drawing.Size(300, 23);
            this.lblStudentIdNo.TabIndex = 9;
            this.lblStudentIdNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPhoneNumber.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPhoneNumber.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPhoneNumber.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblPhoneNumber.Location = new System.Drawing.Point(77, 178);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(300, 23);
            this.lblPhoneNumber.TabIndex = 9;
            this.lblPhoneNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAddress
            // 
            this.lblAddress.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAddress.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAddress.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAddress.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblAddress.Location = new System.Drawing.Point(77, 214);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(300, 23);
            this.lblAddress.TabIndex = 9;
            this.lblAddress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblGender
            // 
            this.lblGender.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblGender.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblGender.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblGender.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblGender.Location = new System.Drawing.Point(277, 18);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(100, 23);
            this.lblGender.TabIndex = 9;
            this.lblGender.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblClass
            // 
            this.lblClass.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblClass.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblClass.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblClass.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblClass.Location = new System.Drawing.Point(277, 58);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(100, 23);
            this.lblClass.TabIndex = 9;
            this.lblClass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 147);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 6;
            this.label8.Text = "考勤卡号：";
            // 
            // lblCardNo
            // 
            this.lblCardNo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCardNo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCardNo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCardNo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblCardNo.Location = new System.Drawing.Point(77, 142);
            this.lblCardNo.Name = "lblCardNo";
            this.lblCardNo.Size = new System.Drawing.Size(300, 23);
            this.lblCardNo.TabIndex = 9;
            this.lblCardNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pbStu
            // 
            this.pbStu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbStu.Location = new System.Drawing.Point(397, 18);
            this.pbStu.Name = "pbStu";
            this.pbStu.Size = new System.Drawing.Size(189, 202);
            this.pbStu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbStu.TabIndex = 29;
            this.pbStu.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.student,
            this.studentName,
            this.Gender,
            this.bithday,
            this.GeridNO,
            this.GardNO,
            this.ClassID});
            this.dataGridView1.Location = new System.Drawing.Point(18, 313);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(877, 299);
            this.dataGridView1.TabIndex = 30;
            // 
            // student
            // 
            this.student.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.student.DataPropertyName = "studentid";
            this.student.HeaderText = "学员";
            this.student.Name = "student";
            this.student.ReadOnly = true;
            this.student.Width = 134;
            // 
            // studentName
            // 
            this.studentName.DataPropertyName = "studentname";
            this.studentName.HeaderText = "姓名";
            this.studentName.Name = "studentName";
            this.studentName.ReadOnly = true;
            // 
            // Gender
            // 
            this.Gender.DataPropertyName = "gender";
            this.Gender.HeaderText = "性别";
            this.Gender.Name = "Gender";
            this.Gender.ReadOnly = true;
            // 
            // bithday
            // 
            this.bithday.DataPropertyName = "bithday";
            this.bithday.HeaderText = "出生日期";
            this.bithday.Name = "bithday";
            this.bithday.ReadOnly = true;
            // 
            // GeridNO
            // 
            this.GeridNO.DataPropertyName = "studentidno";
            this.GeridNO.HeaderText = "身份证号";
            this.GeridNO.Name = "GeridNO";
            this.GeridNO.ReadOnly = true;
            this.GeridNO.Width = 150;
            // 
            // GardNO
            // 
            this.GardNO.DataPropertyName = "cardno";
            this.GardNO.HeaderText = "考勤卡号";
            this.GardNO.Name = "GardNO";
            this.GardNO.ReadOnly = true;
            this.GardNO.Width = 150;
            // 
            // ClassID
            // 
            this.ClassID.DataPropertyName = "classname";
            this.ClassID.HeaderText = "班级";
            this.ClassID.Name = "ClassID";
            this.ClassID.ReadOnly = true;
            // 
            // FrmStudentInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 656);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pbStu);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblCardNo);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.lblStudentIdNo);
            this.Controls.Add(this.lblBirthday);
            this.Controls.Add(this.lblClass);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblStudentName);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmStudentInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "当前学员详细信息";
            ((System.ComponentModel.ISupportInitialize)(this.pbStu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.Label lblBirthday;
        private System.Windows.Forms.Label lblStudentIdNo;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblCardNo;
        private System.Windows.Forms.PictureBox pbStu;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn student;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn bithday;
        private System.Windows.Forms.DataGridViewTextBoxColumn GeridNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn GardNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassID;
    }
}