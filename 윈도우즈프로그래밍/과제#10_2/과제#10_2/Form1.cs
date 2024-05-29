using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace 과제_10_2
{
    public partial class Form1 : Form
    {
        //소스 코드 추가
        private System.Windows.Forms.Timer myTimer = new System.Windows.Forms.Timer();



        private DateTime dDay;
        private DateTime tTime;
        private bool setAlarm;
        public Form1()
        {
            InitializeComponent();
            label4.ForeColor = Color.Gray;
            label3.ForeColor = Color.Gray;

            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "tt hh:mm";
            myTimer.Interval = 1000;
            myTimer.Tick += MyTimer_Tick;
            myTimer.Start();
            tabControl1.SelectedTab = tabPage2;
        }

        private void MyTimer_Tick(object sender, EventArgs e)
        {
            DateTime cTime = DateTime.Now;
            label5.Text = cTime.ToShortDateString();
            label6.Text = cTime.ToLongTimeString();

            if (setAlarm == true)
            {
                if (dDay == DateTime.Today &&
                    cTime.Hour == tTime.Hour &&
                    cTime.Minute == tTime.Minute)
                {
                    setAlarm = false;
                    MessageBox.Show("알람 시각을 알려줍니다!", "알람 통보",
                        MessageBoxButtons.YesNoCancel,
                        MessageBoxIcon.Information);
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dDay = DateTime.Parse(dateTimePicker1.Text);
            tTime = DateTime.Parse(dateTimePicker2.Text);

            setAlarm = true;
            label3.ForeColor = Color.Red;
            label4.ForeColor = Color.Blue;
            label4.Text = "Alarm: " + dDay.ToShortDateString() + " " + tTime.ToLongTimeString();
            tabControl1.SelectedTab = tabPage2;
        }
    }
}