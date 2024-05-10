namespace 과제_9
{
    partial class Form1
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
            cbox = new ComboBox();
            btn_add1 = new Button();
            btn_remove1 = new Button();
            tbox_1 = new TextBox();
            btn_add2 = new Button();
            btn_remove2 = new Button();
            lbox_1 = new ListBox();
            btn_add3 = new Button();
            btn_remove3 = new Button();
            tbox_2 = new TextBox();
            btn_summary = new Button();
            lbox_2 = new ListBox();
            lb_msg = new Label();
            chbox = new CheckedListBox();
            SuspendLayout();
            // 
            // cbox
            // 
            cbox.FormattingEnabled = true;
            cbox.Items.AddRange(new object[] { "고양이", "강아지", "사자 ", "호랑이", "푸바오" });
            cbox.Location = new Point(24, 37);
            cbox.Name = "cbox";
            cbox.Size = new Size(182, 33);
            cbox.TabIndex = 0;
            cbox.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // btn_add1
            // 
            btn_add1.Location = new Point(221, 35);
            btn_add1.Name = "btn_add1";
            btn_add1.Size = new Size(112, 34);
            btn_add1.TabIndex = 1;
            btn_add1.Text = "추가";
            btn_add1.UseVisualStyleBackColor = true;
            btn_add1.Click += btn_add1_Click;
            // 
            // btn_remove1
            // 
            btn_remove1.Location = new Point(221, 87);
            btn_remove1.Name = "btn_remove1";
            btn_remove1.Size = new Size(112, 34);
            btn_remove1.TabIndex = 2;
            btn_remove1.Text = "삭제";
            btn_remove1.UseVisualStyleBackColor = true;
            btn_remove1.Click += btn_remove1_Click;
            // 
            // tbox_1
            // 
            tbox_1.Location = new Point(12, 231);
            tbox_1.Name = "tbox_1";
            tbox_1.Size = new Size(150, 31);
            tbox_1.TabIndex = 3;
            // 
            // btn_add2
            // 
            btn_add2.Location = new Point(221, 231);
            btn_add2.Name = "btn_add2";
            btn_add2.Size = new Size(112, 34);
            btn_add2.TabIndex = 4;
            btn_add2.Text = "추가";
            btn_add2.UseVisualStyleBackColor = true;
            btn_add2.Click += btn_add2_Click;
            // 
            // btn_remove2
            // 
            btn_remove2.Location = new Point(221, 271);
            btn_remove2.Name = "btn_remove2";
            btn_remove2.Size = new Size(112, 34);
            btn_remove2.TabIndex = 5;
            btn_remove2.Text = "삭제";
            btn_remove2.UseVisualStyleBackColor = true;
            btn_remove2.Click += btn_remove2_Click;
            // 
            // lbox_1
            // 
            lbox_1.FormattingEnabled = true;
            lbox_1.ItemHeight = 25;
            lbox_1.Items.AddRange(new object[] { "제주", "서울", "천안", "수원" });
            lbox_1.Location = new Point(12, 287);
            lbox_1.Name = "lbox_1";
            lbox_1.Size = new Size(180, 129);
            lbox_1.TabIndex = 6;
            // 
            // btn_add3
            // 
            btn_add3.Location = new Point(631, 33);
            btn_add3.Name = "btn_add3";
            btn_add3.Size = new Size(112, 34);
            btn_add3.TabIndex = 7;
            btn_add3.Text = "추가";
            btn_add3.UseVisualStyleBackColor = true;
            btn_add3.Click += btn_add3_Click;
            // 
            // btn_remove3
            // 
            btn_remove3.Location = new Point(631, 87);
            btn_remove3.Name = "btn_remove3";
            btn_remove3.Size = new Size(112, 34);
            btn_remove3.TabIndex = 8;
            btn_remove3.Text = "삭제";
            btn_remove3.UseVisualStyleBackColor = true;
            btn_remove3.Click += btn_remove3_Click;
            // 
            // tbox_2
            // 
            tbox_2.Location = new Point(434, 33);
            tbox_2.Name = "tbox_2";
            tbox_2.Size = new Size(172, 31);
            tbox_2.TabIndex = 9;
            // 
            // btn_summary
            // 
            btn_summary.Location = new Point(434, 263);
            btn_summary.Name = "btn_summary";
            btn_summary.Size = new Size(112, 34);
            btn_summary.TabIndex = 11;
            btn_summary.Text = "요약";
            btn_summary.UseVisualStyleBackColor = true;
            btn_summary.Click += btn_summary_Click;
            // 
            // lbox_2
            // 
            lbox_2.FormattingEnabled = true;
            lbox_2.ItemHeight = 25;
            lbox_2.Location = new Point(434, 309);
            lbox_2.Name = "lbox_2";
            lbox_2.Size = new Size(376, 229);
            lbox_2.TabIndex = 12;
            lbox_2.SelectedIndexChanged += lbox_2_SelectedIndexChanged;
            // 
            // lb_msg
            // 
            lb_msg.AutoSize = true;
            lb_msg.Location = new Point(24, 630);
            lb_msg.Name = "lb_msg";
            lb_msg.Size = new Size(0, 25);
            lb_msg.TabIndex = 13;
            lb_msg.Click += lb_msg_Click;
            // 
            // chbox
            // 
            chbox.FormattingEnabled = true;
            chbox.Items.AddRange(new object[] { "가나다", "라마바", "사아자", "차카타" });
            chbox.Location = new Point(434, 87);
            chbox.Name = "chbox";
            chbox.Size = new Size(180, 144);
            chbox.TabIndex = 14;
            chbox.SelectedIndexChanged += chbox_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(901, 687);
            Controls.Add(chbox);
            Controls.Add(lb_msg);
            Controls.Add(lbox_2);
            Controls.Add(btn_summary);
            Controls.Add(tbox_2);
            Controls.Add(btn_remove3);
            Controls.Add(btn_add3);
            Controls.Add(lbox_1);
            Controls.Add(btn_remove2);
            Controls.Add(btn_add2);
            Controls.Add(tbox_1);
            Controls.Add(btn_remove1);
            Controls.Add(btn_add1);
            Controls.Add(cbox);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbox;
        private Button btn_add1;
        private Button btn_remove1;
        private TextBox tbox_1;
        private Button btn_add2;
        private Button btn_remove2;
        private ListBox lbox_1;
        private Button btn_add3;
        private Button btn_remove3;
        private TextBox tbox_2;
        private Button btn_summary;
        private ListBox lbox_2;
        private Label lb_msg;
        private CheckedListBox chbox;
    }
}