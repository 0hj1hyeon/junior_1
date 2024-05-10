namespace 과제_8
{
    partial class pn1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            namebox = new TextBox();
            이름 = new Label();
            성별 = new Label();
            아이디 = new Label();
            비밀번호 = new Label();
            비밀번호재입력 = new Label();
            주소 = new Label();
            이메일 = new Label();
            전화번호 = new Label();
            취미 = new Label();
            자기소개 = new Label();
            id = new TextBox();
            male = new RadioButton();
            female = new RadioButton();
            pw = new TextBox();
            rpw = new TextBox();
            여행 = new CheckBox();
            쇼핑 = new CheckBox();
            게임 = new CheckBox();
            기타 = new CheckBox();
            selfit = new RichTextBox();
            addmember = new Button();
            addr = new TextBox();
            a = new Label();
            emailid = new TextBox();
            emailc = new TextBox();
            emaill = new ComboBox();
            pn2 = new TextBox();
            pn3 = new TextBox();
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // namebox
            // 
            namebox.Location = new Point(159, 42);
            namebox.Name = "namebox";
            namebox.Size = new Size(319, 31);
            namebox.TabIndex = 0;
            namebox.TextChanged += namebox_TextChanged;
            // 
            // 이름
            // 
            이름.AutoSize = true;
            이름.Location = new Point(18, 42);
            이름.Name = "이름";
            이름.Size = new Size(48, 25);
            이름.TabIndex = 1;
            이름.Text = "이름";
            // 
            // 성별
            // 
            성별.AutoSize = true;
            성별.Location = new Point(18, 98);
            성별.Name = "성별";
            성별.Size = new Size(48, 25);
            성별.TabIndex = 2;
            성별.Text = "성별";
            성별.Click += label1_Click;
            // 
            // 아이디
            // 
            아이디.AutoSize = true;
            아이디.Location = new Point(12, 152);
            아이디.Name = "아이디";
            아이디.Size = new Size(66, 25);
            아이디.TabIndex = 3;
            아이디.Text = "아이디";
            아이디.Click += label2_Click;
            // 
            // 비밀번호
            // 
            비밀번호.AutoSize = true;
            비밀번호.Location = new Point(12, 205);
            비밀번호.Name = "비밀번호";
            비밀번호.Size = new Size(84, 25);
            비밀번호.TabIndex = 4;
            비밀번호.Text = "비밀번호";
            비밀번호.Click += label3_Click;
            // 
            // 비밀번호재입력
            // 
            비밀번호재입력.AutoSize = true;
            비밀번호재입력.Location = new Point(12, 267);
            비밀번호재입력.Name = "비밀번호재입력";
            비밀번호재입력.Size = new Size(144, 25);
            비밀번호재입력.TabIndex = 5;
            비밀번호재입력.Text = "비밀번호 재입력";
            // 
            // 주소
            // 
            주소.AutoSize = true;
            주소.Location = new Point(18, 325);
            주소.Name = "주소";
            주소.Size = new Size(48, 25);
            주소.TabIndex = 6;
            주소.Text = "주소";
            // 
            // 이메일
            // 
            이메일.AutoSize = true;
            이메일.Location = new Point(18, 372);
            이메일.Name = "이메일";
            이메일.Size = new Size(66, 25);
            이메일.TabIndex = 7;
            이메일.Text = "이메일";
            이메일.Click += label6_Click;
            // 
            // 전화번호
            // 
            전화번호.AutoSize = true;
            전화번호.Location = new Point(18, 415);
            전화번호.Name = "전화번호";
            전화번호.Size = new Size(84, 25);
            전화번호.TabIndex = 8;
            전화번호.Text = "전화번호";
            // 
            // 취미
            // 
            취미.AutoSize = true;
            취미.Location = new Point(18, 465);
            취미.Name = "취미";
            취미.Size = new Size(48, 25);
            취미.TabIndex = 9;
            취미.Text = "취미";
            취미.Click += label8_Click;
            // 
            // 자기소개
            // 
            자기소개.AutoSize = true;
            자기소개.Location = new Point(18, 515);
            자기소개.Name = "자기소개";
            자기소개.Size = new Size(84, 25);
            자기소개.TabIndex = 10;
            자기소개.Text = "자기소개";
            // 
            // id
            // 
            id.Location = new Point(159, 149);
            id.Name = "id";
            id.Size = new Size(319, 31);
            id.TabIndex = 11;
            // 
            // male
            // 
            male.AutoSize = true;
            male.Location = new Point(159, 96);
            male.Name = "male";
            male.Size = new Size(55, 29);
            male.TabIndex = 12;
            male.TabStop = true;
            male.Text = "남";
            male.UseVisualStyleBackColor = true;
            male.CheckedChanged += 남_CheckedChanged;
            // 
            // female
            // 
            female.AutoSize = true;
            female.Location = new Point(315, 96);
            female.Name = "female";
            female.Size = new Size(55, 29);
            female.TabIndex = 13;
            female.TabStop = true;
            female.Text = "여";
            female.UseVisualStyleBackColor = true;
            female.CheckedChanged += 여_CheckedChanged;
            // 
            // pw
            // 
            pw.Location = new Point(159, 205);
            pw.Name = "pw";
            pw.Size = new Size(319, 31);
            pw.TabIndex = 14;
            // 
            // rpw
            // 
            rpw.Location = new Point(159, 267);
            rpw.Name = "rpw";
            rpw.Size = new Size(319, 31);
            rpw.TabIndex = 15;
            rpw.TextChanged += repassword_TextChanged;
            // 
            // 여행
            // 
            여행.AutoSize = true;
            여행.Location = new Point(112, 461);
            여행.Name = "여행";
            여행.Size = new Size(74, 29);
            여행.TabIndex = 16;
            여행.Text = "여행";
            여행.UseVisualStyleBackColor = true;
            // 
            // 쇼핑
            // 
            쇼핑.AutoSize = true;
            쇼핑.Location = new Point(208, 461);
            쇼핑.Name = "쇼핑";
            쇼핑.Size = new Size(74, 29);
            쇼핑.TabIndex = 17;
            쇼핑.Text = "쇼핑";
            쇼핑.UseVisualStyleBackColor = true;
            쇼핑.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // 게임
            // 
            게임.AutoSize = true;
            게임.Location = new Point(315, 461);
            게임.Name = "게임";
            게임.Size = new Size(74, 29);
            게임.TabIndex = 18;
            게임.Text = "게임";
            게임.UseVisualStyleBackColor = true;
            // 
            // 기타
            // 
            기타.AutoSize = true;
            기타.Location = new Point(420, 461);
            기타.Name = "기타";
            기타.Size = new Size(74, 29);
            기타.TabIndex = 19;
            기타.Text = "기타";
            기타.UseVisualStyleBackColor = true;
            // 
            // selfit
            // 
            selfit.Location = new Point(112, 515);
            selfit.Name = "selfit";
            selfit.Size = new Size(424, 100);
            selfit.TabIndex = 20;
            selfit.Text = "";
            // 
            // addmember
            // 
            addmember.Location = new Point(208, 645);
            addmember.Name = "addmember";
            addmember.Size = new Size(184, 50);
            addmember.TabIndex = 21;
            addmember.Text = "회원가입";
            addmember.UseVisualStyleBackColor = true;
            addmember.Click += addmember_Click;
            // 
            // addr
            // 
            addr.Location = new Point(159, 322);
            addr.Name = "addr";
            addr.Size = new Size(319, 31);
            addr.TabIndex = 22;
            // 
            // a
            // 
            a.AutoSize = true;
            a.Location = new Point(267, 372);
            a.Name = "a";
            a.Size = new Size(30, 25);
            a.TabIndex = 23;
            a.Text = "@";
            // 
            // emailid
            // 
            emailid.Location = new Point(137, 372);
            emailid.Name = "emailid";
            emailid.Size = new Size(124, 31);
            emailid.TabIndex = 24;
            // 
            // emailc
            // 
            emailc.Location = new Point(303, 372);
            emailc.Name = "emailc";
            emailc.Size = new Size(175, 31);
            emailc.TabIndex = 25;
            emailc.TextChanged += emailc_TextChanged;
            // 
            // emaill
            // 
            emaill.FormattingEnabled = true;
            emaill.Items.AddRange(new object[] { "naver.com", "gmail.com", "daum.net" });
            emaill.Location = new Point(508, 372);
            emaill.Name = "emaill";
            emaill.Size = new Size(148, 33);
            emaill.TabIndex = 26;
            emaill.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // pn2
            // 
            pn2.Location = new Point(265, 417);
            pn2.Name = "pn2";
            pn2.Size = new Size(124, 31);
            pn2.TabIndex = 28;
            pn2.TextChanged += textBox1_TextChanged;
            // 
            // pn3
            // 
            pn3.Location = new Point(395, 417);
            pn3.Name = "pn3";
            pn3.Size = new Size(124, 31);
            pn3.TabIndex = 29;
            pn3.TextChanged += textBox2_TextChanged_1;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "010", "011", "070" });
            comboBox1.Location = new Point(158, 417);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(101, 33);
            comboBox1.TabIndex = 30;
            // 
            // pn1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 707);
            Controls.Add(comboBox1);
            Controls.Add(pn3);
            Controls.Add(pn2);
            Controls.Add(emaill);
            Controls.Add(emailc);
            Controls.Add(emailid);
            Controls.Add(a);
            Controls.Add(addr);
            Controls.Add(addmember);
            Controls.Add(selfit);
            Controls.Add(기타);
            Controls.Add(게임);
            Controls.Add(쇼핑);
            Controls.Add(여행);
            Controls.Add(rpw);
            Controls.Add(pw);
            Controls.Add(female);
            Controls.Add(male);
            Controls.Add(id);
            Controls.Add(자기소개);
            Controls.Add(취미);
            Controls.Add(전화번호);
            Controls.Add(이메일);
            Controls.Add(주소);
            Controls.Add(비밀번호재입력);
            Controls.Add(비밀번호);
            Controls.Add(아이디);
            Controls.Add(성별);
            Controls.Add(이름);
            Controls.Add(namebox);
            Name = "pn1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox namebox;
        private Label 이름;
        private Label 성별;
        private Label 아이디;
        private Label 비밀번호;
        private Label 비밀번호재입력;
        private Label 주소;
        private Label 이메일;
        private Label 전화번호;
        private Label 취미;
        private Label 자기소개;
        private TextBox id;
        private RadioButton male;
        private RadioButton female;
        private TextBox pw;
        private TextBox rpw;
        private CheckBox 여행;
        private CheckBox 쇼핑;
        private CheckBox 게임;
        private CheckBox 기타;
        private RichTextBox selfit;
        private Button addmember;
        private TextBox addr;
        private Label a;
        private TextBox emailid;
        private TextBox emailc;
        private ComboBox emaill;
        private ComboBox pnstart;
        private TextBox pn2;
        private TextBox pn3;
        private ComboBox comboBox1;
    }
}