namespace 과제_8
{
    public partial class pn1 : Form
    {
        public pn1()
        {
            InitializeComponent();
        }

        private void namebox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void 여_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void repassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {




        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            emailc.Text = emaill.Text;
        }

        private void addmember_Click(object sender, EventArgs e)
        {
            string gender = "";
            if (male.Checked == true) gender = "남";
            if (female.Checked == true) gender = "여";
            string hobby = "";
            if (여행.Checked == true) hobby += 여행 + " ";
            if (쇼핑.Checked == true) hobby += 쇼핑 + " ";
            if (게임.Checked == true) hobby += 게임 + " ";
            if (기타.Checked == true) hobby += 기타 + " ";
            MessageBox.Show("이름: " + namebox.Text +
                "\n성별: " + gender +
                "\n아이디: " + id.Text +
                "\n 비밀번호: " + pw.Text +
                "\n 비밀번호 재입력: " + rpw.Text +
                "\n 주소: " + addr.Text +
                "\n 이메일: " + emailid.Text + "@" + emailc.Text +
                "\n 전화번호: " + comboBox1.Text + pn2.Text + pn3.Text +
                "\n 취미: " + "아직 공석" +
                "\n 자기소개: " + selfit.Text
                );


        }

        private void 남_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void emailc_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void phn1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
        }
    }
}