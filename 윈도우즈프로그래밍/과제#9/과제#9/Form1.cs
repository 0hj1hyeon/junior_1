namespace 과제_9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lbox_2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ;
        }

        private void btn_summary_Click(object sender, EventArgs e)
        {
            lbox_2.Items.Add("콤보 박스 항목 개수: " + cbox.Items.Count);
            lbox_2.Items.Add("콤보 박스 선택 항목: " + cbox.SelectedIndex);
            lbox_2.Items.Add("리스트 박스 항목 개수: " + lbox_1.Items.Count);
            lbox_2.Items.Add("리스트 박스 선택 항목: " + lbox_1.SelectedIndex);
            lbox_2.Items.Add("체크 리스트 박스 항목 개수: " + chbox.Items.Count);
            lbox_2.Items.Add("체크 리스트 박스 선택 항목: " + chbox.SelectedIndex);
            lbox_2.Items.Add("체크 리스트 박스 체크 상태 목록: ");
            for (int i = 0; i <= (chbox.Items.Count - 1); i++)
            {
                if (chbox.GetItemChecked(i)) lbox_2.Items.Add(chbox.Items[i].ToString());
            }

        }

        private void chbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lb_msg_Click(object sender, EventArgs e)
        {

        }

        private void btn_remove2_Click(object sender, EventArgs e)
        {
            lb_msg.Text = "리스트박스 삭제 항목 변경, 인덱스: " + lbox_1.SelectedIndex + "Text: " + lbox_1.SelectedItem;
            lbox_1.Items.Remove(lbox_1.SelectedItem);

        }

        private void btn_add1_Click(object sender, EventArgs e)
        {
            cbox.Items.Add(cbox.Text);
            lb_msg.Text = "체크박스 추가 항목 변경, 인덱스: " + cbox.Items.IndexOf(cbox.Text) + "Text: " + cbox.Text;
        }
        private void btn_remove1_Click(object sender, EventArgs e)
        {
            lb_msg.Text = "체크박스 삭제 항목 변경, 인덱스: " + cbox.SelectedIndex + "Text: " + cbox.SelectedItem;
            cbox.Items.Remove(cbox.SelectedItem);

        }

        private void btn_add2_Click(object sender, EventArgs e)
        {
            lbox_1.Items.Add(tbox_1.Text);
            lb_msg.Text = "리스트박스 추가 항목 변경, 인덱스: " + lbox_1.Items.IndexOf(tbox_1.Text) + "Text: " + tbox_1.Text;
        }

        private void btn_add3_Click(object sender, EventArgs e)
        {
            chbox.Items.Add(tbox_2.Text);
            lb_msg.Text = "체크리스트박스 추가 항목 변경, 인덱스: " + chbox.Items.IndexOf(tbox_2.Text) + "Text: " + tbox_2.Text;
        }

        private void btn_remove3_Click(object sender, EventArgs e)
        {
            lb_msg.Text = "체크리스트박스 삭제 항목 변경, 인덱스: " + chbox.SelectedIndex + "Text: " + chbox.SelectedItem;
            chbox.Items.Remove(chbox.SelectedItem);

        }
    }
}