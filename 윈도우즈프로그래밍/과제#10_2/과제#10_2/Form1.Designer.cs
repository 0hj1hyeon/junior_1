namespace 과제_10_2
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            button2 = new Button();
            button1 = new Button();
            label2 = new Label();
            label1 = new Label();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            tabPage2 = new TabPage();
            pictureBox1 = new PictureBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(30, 26);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(614, 298);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(button2);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(dateTimePicker2);
            tabPage1.Controls.Add(dateTimePicker1);
            tabPage1.Location = new Point(4, 34);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(606, 260);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "알람 설정";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(425, 148);
            button2.Name = "button2";
            button2.Size = new Size(106, 37);
            button2.TabIndex = 5;
            button2.Text = "해제";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(425, 52);
            button1.Name = "button1";
            button1.Size = new Size(106, 37);
            button1.TabIndex = 4;
            button1.Text = "설정";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 126);
            label2.Name = "label2";
            label2.Size = new Size(90, 25);
            label2.TabIndex = 3;
            label2.Text = "시간 설정";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 30);
            label1.Name = "label1";
            label1.Size = new Size(90, 25);
            label1.TabIndex = 2;
            label1.Text = "날짜 설정";
            label1.Click += label1_Click;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Format = DateTimePickerFormat.Time;
            dateTimePicker2.Location = new Point(35, 154);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(300, 31);
            dateTimePicker2.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(35, 58);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(300, 31);
            dateTimePicker1.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(pictureBox1);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(label3);
            tabPage2.Location = new Point(4, 34);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(606, 260);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "디지털 시계";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.KakaoTalk_20240517_112547165;
            pictureBox1.Location = new Point(386, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(149, 123);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(49, 70);
            label7.Name = "label7";
            label7.Size = new Size(69, 25);
            label7.TabIndex = 4;
            label7.Text = "Alarm :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(199, 185);
            label6.Name = "label6";
            label6.Size = new Size(52, 25);
            label6.TabIndex = 3;
            label6.Text = "Time";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(49, 162);
            label5.Name = "label5";
            label5.Size = new Size(50, 25);
            label5.TabIndex = 2;
            label5.Text = "Date";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(49, 110);
            label4.Name = "label4";
            label4.Size = new Size(90, 25);
            label4.TabIndex = 1;
            label4.Text = "현재 시각";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(49, 34);
            label3.Name = "label3";
            label3.Size = new Size(90, 25);
            label3.TabIndex = 0;
            label3.Text = "알람 설정";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private Button button2;
        private Button button1;
        private Label label2;
        private Label label1;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private TabPage tabPage2;
        private Label label4;
        private Label label3;
        private Label label7;
        private Label label6;
        private Label label5;
        private PictureBox pictureBox1;
    }
}