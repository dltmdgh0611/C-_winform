namespace windowform_db
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.lvView = new System.Windows.Forms.ListView();
            this.chNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chGender = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.plGroup = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPushup = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbLongrun = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb100M = new System.Windows.Forms.TextBox();
            this.gbAddress = new System.Windows.Forms.GroupBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.lbAddress = new System.Windows.Forms.Label();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.lbTel = new System.Windows.Forms.Label();
            this.tbTel = new System.Windows.Forms.TextBox();
            this.tbID = new System.Windows.Forms.TextBox();
            this.lbID = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gbBirthday = new System.Windows.Forms.GroupBox();
            this.lbDay = new System.Windows.Forms.Label();
            this.cbDay = new System.Windows.Forms.ComboBox();
            this.lbMonth = new System.Windows.Forms.Label();
            this.lbYear = new System.Windows.Forms.Label();
            this.cbMonth = new System.Windows.Forms.ComboBox();
            this.tbYear = new System.Windows.Forms.TextBox();
            this.lbBlood = new System.Windows.Forms.Label();
            this.cbBlood = new System.Windows.Forms.ComboBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lbName = new System.Windows.Forms.Label();
            this.lbGender = new System.Windows.Forms.Label();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tbPullup = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbGasmask = new System.Windows.Forms.TextBox();
            this.chBlood = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chBirthday = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chTel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch100m = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chLongrun = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPushup = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPullup = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chGasmask = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.plGroup.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gbAddress.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbBirthday.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvView
            // 
            this.lvView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chNum,
            this.chID,
            this.chName,
            this.chGender,
            this.chBlood,
            this.chBirthday,
            this.chTel,
            this.chAddress,
            this.email,
            this.ch100m,
            this.chLongrun,
            this.chPushup,
            this.chPullup,
            this.chGasmask});
            this.lvView.FullRowSelect = true;
            this.lvView.GridLines = true;
            this.lvView.Location = new System.Drawing.Point(12, 12);
            this.lvView.Name = "lvView";
            this.lvView.Size = new System.Drawing.Size(938, 260);
            this.lvView.TabIndex = 0;
            this.lvView.UseCompatibleStateImageBehavior = false;
            this.lvView.View = System.Windows.Forms.View.Details;
            this.lvView.Click += new System.EventHandler(this.lvView_Click);
            // 
            // chNum
            // 
            this.chNum.Text = "일련번호";
            // 
            // chID
            // 
            this.chID.Text = "ID";
            // 
            // chName
            // 
            this.chName.Text = "성명";
            this.chName.Width = 100;
            // 
            // chGender
            // 
            this.chGender.Text = "성별";
            // 
            // plGroup
            // 
            this.plGroup.BackColor = System.Drawing.Color.White;
            this.plGroup.Controls.Add(this.groupBox2);
            this.plGroup.Controls.Add(this.gbAddress);
            this.plGroup.Controls.Add(this.tbID);
            this.plGroup.Controls.Add(this.lbID);
            this.plGroup.Controls.Add(this.groupBox1);
            this.plGroup.Location = new System.Drawing.Point(12, 281);
            this.plGroup.Name = "plGroup";
            this.plGroup.Size = new System.Drawing.Size(859, 174);
            this.plGroup.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.tbGasmask);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.tbPullup);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.tbPushup);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.tbLongrun);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.tb100M);
            this.groupBox2.Location = new System.Drawing.Point(619, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(237, 136);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Address";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 12);
            this.label1.TabIndex = 18;
            this.label1.Text = "pushup :";
            // 
            // tbPushup
            // 
            this.tbPushup.Location = new System.Drawing.Point(67, 52);
            this.tbPushup.Name = "tbPushup";
            this.tbPushup.Size = new System.Drawing.Size(62, 21);
            this.tbPushup.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(106, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 12);
            this.label2.TabIndex = 16;
            this.label2.Text = "longrun :";
            // 
            // tbLongrun
            // 
            this.tbLongrun.Location = new System.Drawing.Point(167, 23);
            this.tbLongrun.Name = "tbLongrun";
            this.tbLongrun.Size = new System.Drawing.Size(64, 21);
            this.tbLongrun.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 12);
            this.label3.TabIndex = 14;
            this.label3.Text = "100m : ";
            // 
            // tb100M
            // 
            this.tb100M.Location = new System.Drawing.Point(54, 23);
            this.tb100M.Name = "tb100M";
            this.tb100M.Size = new System.Drawing.Size(49, 21);
            this.tb100M.TabIndex = 13;
            // 
            // gbAddress
            // 
            this.gbAddress.Controls.Add(this.lbEmail);
            this.gbAddress.Controls.Add(this.tbEmail);
            this.gbAddress.Controls.Add(this.lbAddress);
            this.gbAddress.Controls.Add(this.tbAddress);
            this.gbAddress.Controls.Add(this.lbTel);
            this.gbAddress.Controls.Add(this.tbTel);
            this.gbAddress.Location = new System.Drawing.Point(416, 26);
            this.gbAddress.Name = "gbAddress";
            this.gbAddress.Size = new System.Drawing.Size(197, 136);
            this.gbAddress.TabIndex = 7;
            this.gbAddress.TabStop = false;
            this.gbAddress.Text = "Address";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(34, 92);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(51, 12);
            this.lbEmail.TabIndex = 18;
            this.lbEmail.Text = "E-mail :";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(91, 88);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(78, 21);
            this.tbEmail.TabIndex = 17;
            // 
            // lbAddress
            // 
            this.lbAddress.AutoSize = true;
            this.lbAddress.Location = new System.Drawing.Point(25, 65);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(60, 12);
            this.lbAddress.TabIndex = 16;
            this.lbAddress.Text = "Address :";
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(91, 61);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(78, 21);
            this.tbAddress.TabIndex = 15;
            // 
            // lbTel
            // 
            this.lbTel.AutoSize = true;
            this.lbTel.Location = new System.Drawing.Point(54, 39);
            this.lbTel.Name = "lbTel";
            this.lbTel.Size = new System.Drawing.Size(35, 12);
            this.lbTel.TabIndex = 14;
            this.lbTel.Text = "Tel : ";
            // 
            // tbTel
            // 
            this.tbTel.Location = new System.Drawing.Point(91, 34);
            this.tbTel.Name = "tbTel";
            this.tbTel.Size = new System.Drawing.Size(78, 21);
            this.tbTel.TabIndex = 13;
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(33, 4);
            this.tbID.Name = "tbID";
            this.tbID.ReadOnly = true;
            this.tbID.Size = new System.Drawing.Size(100, 21);
            this.tbID.TabIndex = 3;
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(3, 7);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(24, 12);
            this.lbID.TabIndex = 0;
            this.lbID.Text = "ID :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gbBirthday);
            this.groupBox1.Controls.Add(this.lbBlood);
            this.groupBox1.Controls.Add(this.cbBlood);
            this.groupBox1.Controls.Add(this.tbName);
            this.groupBox1.Controls.Add(this.lbName);
            this.groupBox1.Controls.Add(this.lbGender);
            this.groupBox1.Controls.Add(this.cbGender);
            this.groupBox1.Location = new System.Drawing.Point(33, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(377, 136);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "person";
            // 
            // gbBirthday
            // 
            this.gbBirthday.Controls.Add(this.lbDay);
            this.gbBirthday.Controls.Add(this.cbDay);
            this.gbBirthday.Controls.Add(this.lbMonth);
            this.gbBirthday.Controls.Add(this.lbYear);
            this.gbBirthday.Controls.Add(this.cbMonth);
            this.gbBirthday.Controls.Add(this.tbYear);
            this.gbBirthday.ForeColor = System.Drawing.Color.Black;
            this.gbBirthday.Location = new System.Drawing.Point(185, 20);
            this.gbBirthday.Name = "gbBirthday";
            this.gbBirthday.Size = new System.Drawing.Size(173, 100);
            this.gbBirthday.TabIndex = 8;
            this.gbBirthday.TabStop = false;
            this.gbBirthday.Text = "Birthday";
            // 
            // lbDay
            // 
            this.lbDay.AutoSize = true;
            this.lbDay.Location = new System.Drawing.Point(97, 63);
            this.lbDay.Name = "lbDay";
            this.lbDay.Size = new System.Drawing.Size(13, 12);
            this.lbDay.TabIndex = 11;
            this.lbDay.Text = "D";
            // 
            // cbDay
            // 
            this.cbDay.FormattingEnabled = true;
            this.cbDay.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.cbDay.Location = new System.Drawing.Point(115, 57);
            this.cbDay.Name = "cbDay";
            this.cbDay.Size = new System.Drawing.Size(43, 20);
            this.cbDay.TabIndex = 12;
            // 
            // lbMonth
            // 
            this.lbMonth.AutoSize = true;
            this.lbMonth.Location = new System.Drawing.Point(19, 63);
            this.lbMonth.Name = "lbMonth";
            this.lbMonth.Size = new System.Drawing.Size(16, 12);
            this.lbMonth.TabIndex = 9;
            this.lbMonth.Text = "M";
            // 
            // lbYear
            // 
            this.lbYear.AutoSize = true;
            this.lbYear.Location = new System.Drawing.Point(37, 26);
            this.lbYear.Name = "lbYear";
            this.lbYear.Size = new System.Drawing.Size(43, 12);
            this.lbYear.TabIndex = 9;
            this.lbYear.Text = "Year : ";
            // 
            // cbMonth
            // 
            this.cbMonth.FormattingEnabled = true;
            this.cbMonth.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cbMonth.Location = new System.Drawing.Point(37, 58);
            this.cbMonth.Name = "cbMonth";
            this.cbMonth.Size = new System.Drawing.Size(43, 20);
            this.cbMonth.TabIndex = 10;
            // 
            // tbYear
            // 
            this.tbYear.Location = new System.Drawing.Point(80, 22);
            this.tbYear.Name = "tbYear";
            this.tbYear.Size = new System.Drawing.Size(78, 21);
            this.tbYear.TabIndex = 0;
            // 
            // lbBlood
            // 
            this.lbBlood.AutoSize = true;
            this.lbBlood.Location = new System.Drawing.Point(17, 103);
            this.lbBlood.Name = "lbBlood";
            this.lbBlood.Size = new System.Drawing.Size(45, 12);
            this.lbBlood.TabIndex = 6;
            this.lbBlood.Text = "Blood :";
            // 
            // cbBlood
            // 
            this.cbBlood.FormattingEnabled = true;
            this.cbBlood.Items.AddRange(new object[] {
            "A",
            "B",
            "O",
            "AB"});
            this.cbBlood.Location = new System.Drawing.Point(79, 100);
            this.cbBlood.Name = "cbBlood";
            this.cbBlood.Size = new System.Drawing.Size(100, 20);
            this.cbBlood.TabIndex = 7;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(79, 25);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(100, 21);
            this.tbName.TabIndex = 4;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(18, 30);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(47, 12);
            this.lbName.TabIndex = 1;
            this.lbName.Text = "Name :";
            // 
            // lbGender
            // 
            this.lbGender.AutoSize = true;
            this.lbGender.Location = new System.Drawing.Point(17, 64);
            this.lbGender.Name = "lbGender";
            this.lbGender.Size = new System.Drawing.Size(54, 12);
            this.lbGender.TabIndex = 2;
            this.lbGender.Text = "Gender :";
            // 
            // cbGender
            // 
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cbGender.Location = new System.Drawing.Point(79, 61);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(100, 20);
            this.cbGender.TabIndex = 5;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(877, 285);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(73, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "추가";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(877, 359);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(73, 23);
            this.btnModify.TabIndex = 3;
            this.btnModify.Text = "수정";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(877, 429);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(73, 23);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "삭제";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 12);
            this.label4.TabIndex = 20;
            this.label4.Text = "pullup :";
            // 
            // tbPullup
            // 
            this.tbPullup.Location = new System.Drawing.Point(67, 80);
            this.tbPullup.Name = "tbPullup";
            this.tbPullup.Size = new System.Drawing.Size(62, 21);
            this.tbPullup.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 22;
            this.label5.Text = "gasmask :";
            // 
            // tbGasmask
            // 
            this.tbGasmask.Location = new System.Drawing.Point(67, 107);
            this.tbGasmask.Name = "tbGasmask";
            this.tbGasmask.Size = new System.Drawing.Size(94, 21);
            this.tbGasmask.TabIndex = 21;
            // 
            // chBlood
            // 
            this.chBlood.Text = "혈액형";
            // 
            // chBirthday
            // 
            this.chBirthday.Text = "생년월일";
            this.chBirthday.Width = 100;
            // 
            // chTel
            // 
            this.chTel.Text = "전화번호";
            this.chTel.Width = 120;
            // 
            // chAddress
            // 
            this.chAddress.Text = "주소";
            this.chAddress.Width = 180;
            // 
            // email
            // 
            this.email.Text = "chEmail";
            this.email.Width = 120;
            // 
            // ch100m
            // 
            this.ch100m.Text = "100m달리기";
            this.ch100m.Width = 80;
            // 
            // chLongrun
            // 
            this.chLongrun.Text = "오래달리기";
            this.chLongrun.Width = 80;
            // 
            // chPushup
            // 
            this.chPushup.Text = "팔굽혀펴기";
            this.chPushup.Width = 80;
            // 
            // chPullup
            // 
            this.chPullup.Text = "턱걸이";
            // 
            // chGasmask
            // 
            this.chGasmask.Text = "방독면";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 467);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.plGroup);
            this.Controls.Add(this.lvView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "인명부";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.plGroup.ResumeLayout(false);
            this.plGroup.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gbAddress.ResumeLayout(false);
            this.gbAddress.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbBirthday.ResumeLayout(false);
            this.gbBirthday.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvView;
        private System.Windows.Forms.ColumnHeader chNum;
        private System.Windows.Forms.ColumnHeader chID;
        private System.Windows.Forms.ColumnHeader chName;
        private System.Windows.Forms.ColumnHeader chGender;
        private System.Windows.Forms.Panel plGroup;
        private System.Windows.Forms.ComboBox cbGender;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label lbGender;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox gbAddress;
        private System.Windows.Forms.Label lbAddress;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.Label lbTel;
        private System.Windows.Forms.TextBox tbTel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gbBirthday;
        private System.Windows.Forms.Label lbDay;
        private System.Windows.Forms.ComboBox cbDay;
        private System.Windows.Forms.Label lbMonth;
        private System.Windows.Forms.Label lbYear;
        private System.Windows.Forms.ComboBox cbMonth;
        private System.Windows.Forms.TextBox tbYear;
        private System.Windows.Forms.Label lbBlood;
        private System.Windows.Forms.ComboBox cbBlood;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPushup;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbLongrun;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb100M;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbGasmask;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbPullup;
        private System.Windows.Forms.ColumnHeader chBlood;
        private System.Windows.Forms.ColumnHeader chBirthday;
        private System.Windows.Forms.ColumnHeader chTel;
        private System.Windows.Forms.ColumnHeader chAddress;
        private System.Windows.Forms.ColumnHeader email;
        private System.Windows.Forms.ColumnHeader ch100m;
        private System.Windows.Forms.ColumnHeader chLongrun;
        private System.Windows.Forms.ColumnHeader chPushup;
        private System.Windows.Forms.ColumnHeader chPullup;
        private System.Windows.Forms.ColumnHeader chGasmask;
    }
}

