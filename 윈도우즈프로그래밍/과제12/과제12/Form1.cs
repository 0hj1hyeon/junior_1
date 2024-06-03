using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 과제12
{
    public partial class Form1 : Form
    {
        SQLiteConnection connection;
        SQLiteCommand command;
        DataTable dataTable;
        public Form1()
        {
            InitializeComponent();

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;

            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Items.Add("아이디로");
            comboBox1.Items.Add("이름으로");
            comboBox1.Items.Add("생일로");
            comboBox1.SelectedIndex = 0;

            try
            {
                connection = new SQLiteConnection("Data Source=" + Application.StartupPath + "/member.db");
                connection.Open();

                command = new SQLiteCommand(connection);
                command.CommandText = "CREATE TABLE IF NOT EXISTS member (" +
                    "id TEXT UNIQUE NOT NULL, " +
                    "name TEXT NOT NULL, " +
                    "birthday TEXT NOT NULL)";
                command.ExecuteNonQuery();

                command.CommandText = "SELECT * FROM member";
                SQLiteDataReader reader = command.ExecuteReader();
                dataTable = new DataTable();
                dataTable.Load(reader);
                dataGridView1.DataSource = dataTable;
                reader.Close();

                dataGridView1.Columns[0].HeaderText = "아이디";
                dataGridView1.Columns[1].HeaderText = "이름";
                dataGridView1.Columns[2].HeaderText = "생일";

                connection.Close();

                label4.Text = "총 회원수: " + dataGridView1.Rows.Count;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try // 회원 정보 수정
            {
                foreach (DataGridViewRow row in dataGridView1.Rows) // 아이디(변경불가 상황 가정)를 바꾸려 시도하는 경우 체크
                {
                    if (row.Cells[0].Value.ToString() == textBox1.Text.Trim()) // 아이디 비교
                    {
                        if (MessageBox.Show(row.Cells[1].Value + "의 데이터를 수정 합니다. 수정하시겠습니까?",
                            "수정", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            connection = new SQLiteConnection("Data Source=" + Application.StartupPath + "/member.db");
                            connection.Open();

                            command = new SQLiteCommand(connection);
                            command.CommandText = "UPDATE member set name=:name, birthday=:birthday WHERE id=:id";
                            command.Parameters.Add("name", DbType.String).Value = textBox2.Text.Trim();
                            command.Parameters.Add("birthday", DbType.String).Value = textBox3.Text.Trim();
                            command.Parameters.Add("id", DbType.String).Value = textBox1.Text.Trim();
                            command.ExecuteNonQuery();

                            connection.Close();

                            row.Cells[0].Value = textBox1.Text.Trim();
                            row.Cells[1].Value = textBox2.Text.Trim();
                            row.Cells[2].Value = textBox3.Text.Trim();

                            return;
                        }
                        else
                        {
                            //MessageBox.Show("바뀌지 않았습니다.");
                            return;
                        }
                    }
                }
                MessageBox.Show(textBox1.Text + "는 존재하지 않는 ID 입니다.");
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            // 프로그램 시작 시 인덱스 에러 방지
            if (dataGridView1.SelectedRows.Count < 1)
                return;

            DataGridViewRow row = dataGridView1.SelectedRows[0];
            textBox1.Text = row.Cells[0].Value.ToString();
            textBox2.Text = row.Cells[1].Value.ToString();
            textBox3.Text = row.Cells[2].Value.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try // 회원 추가
            {
                connection = new SQLiteConnection("Data Source=" + Application.StartupPath + "/member.db");
                connection.Open();

                command = new SQLiteCommand(connection);
                command.CommandText = $"INSERT INTO member (id, name, birthday) VALUES (" +
                    $"'{textBox1.Text.Trim()}', '{textBox2.Text.Trim()}', '{textBox3.Text.Trim()}')";
                command.ExecuteNonQuery();

                connection.Close();

                dataTable.Rows.Add(textBox1.Text.Trim(), textBox2.Text.Trim(), textBox3.Text.Trim());
                label4.Text = "총 회원수: " + dataGridView1.Rows.Count;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try // 회원 삭제
            {
                if (MessageBox.Show($"{dataGridView1.SelectedRows[0].Cells[1].Value}의 데이터를 정말 삭제 하시겠습니까?",
                    "삭제", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    connection = new SQLiteConnection("Data Source=" + Application.StartupPath + "/member.db");
                    connection.Open();

                    command = new SQLiteCommand(connection);
                    command.CommandText = "DELETE from member WHERE id=:id";
                    command.Parameters.Add("id", DbType.String).Value = textBox1.Text.Trim();
                    command.ExecuteNonQuery();

                    connection.Close();

                    DataGridViewRow row = dataGridView1.SelectedRows[0];
                    dataGridView1.Rows.Remove(row);

                    label4.Text = "총 회원수: " + dataGridView1.Rows.Count;
                }
                else
                {
                    //MessageBox.Show("삭제하지 않았습니다");
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try // 검색
            {
                string filter;
                switch (comboBox1.SelectedIndex)
                {
                    case 0:
                        filter = "id";
                        break;

                    case 1:
                        filter = "name";
                        break;

                    case 2:
                        filter = "birthday";
                        break;

                    default:
                        filter = "id";
                        break;
                }

                connection = new SQLiteConnection("Data Source=" + Application.StartupPath + "/member.db");
                connection.Open();
                command = new SQLiteCommand(connection);

                if (textBox4.Text.Trim().Length == 0)
                {
                    command.CommandText = $"SELECT * FROM member";
                }
                else
                {
                    command.CommandText = $"SELECT * FROM member where {filter}='{textBox4.Text.Trim()}'";
                }
                SQLiteDataReader reader = command.ExecuteReader();
                dataTable = new DataTable();
                dataTable.Load(reader);
                dataGridView1.DataSource = dataTable;
                reader.Close();

                connection.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            // 항목 번호 그리기
            String rowIndex = (e.RowIndex + 1).ToString();

            StringFormat centerFormat = new StringFormat()
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };

            Rectangle headerBound = new Rectangle(e.RowBounds.Left, e.RowBounds.Top,
                dataGridView1.RowHeadersWidth, e.RowBounds.Height);
            e.Graphics.DrawString(rowIndex, Font, SystemBrushes.ControlText, headerBound, centerFormat);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
