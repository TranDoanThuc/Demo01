using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            String query = "select * from Khoa1";
            dataGridView1.DataSource = executeQuery(query);
            textBox3.Hide();
        }

        public DataTable executeQuery(string query)
        {
            DataTable data = new DataTable();

            using (SqlConnection url = new SqlConnection(@"Data Source=DESKTOP-P51T87R\SQLEXPRESS;Initial Catalog=qlkhoa;Integrated Security=True"))
            {
                url.Open();
                SqlCommand command = new SqlCommand(query, url);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);
                url.Close();
                return data;
            }
        }
        SqlConnection sql = new SqlConnection(@"Data Source=DESKTOP-P51T87R\SQLEXPRESS;Initial Catalog=qlkhoa;Integrated Security=True");


        private void button1_Click_1(object sender, EventArgs e)
        {
            sql.Open();
            String s = "insert into Khoa1(makhoa,tenkhoa) values (N'" + textBox1.Text + "',N'" + textBox2.Text + "')";
            SqlCommand con = new SqlCommand(s, sql);
            con.ExecuteNonQuery();
            sql.Close();
            String query = "select * from Khoa1";
            dataGridView1.DataSource = executeQuery(query);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                sql.Open();
                String s = "update Khoa1 set makhoa=N'" + textBox1.Text + "' where id='" + textBox3.Text + "'";
                SqlCommand con = new SqlCommand(s, sql);
                con.ExecuteNonQuery();
                sql.Close();
            }
            if (textBox2.Text != "")
            {
                sql.Open();
                String s = "update Khoa1 set tenkhoa=N'" + textBox2.Text + "' where id='" + textBox3.Text + "'";
                SqlCommand con = new SqlCommand(s, sql);
                con.ExecuteNonQuery();
                sql.Close();
            }
            String query = "select * from Khoa1";
            dataGridView1.DataSource = executeQuery(query);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sql.Open();
            String s = "delete from Khoa1 where id='" + textBox3.Text + "'";
            SqlCommand con = new SqlCommand(s, sql);
            con.ExecuteNonQuery();
            sql.Close();
            String query = "select * from Khoa1";
            dataGridView1.DataSource = executeQuery(query);
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                //Lưu lại dòng dữ liệu vừa kích chọn
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                //Đưa dữ liệu vào textbox
                textBox3.Text = row.Cells[0].Value.ToString();
                textBox1.Text = row.Cells[1].Value.ToString();
                textBox2.Text = row.Cells[2].Value.ToString();

                //Không cho phép sửa trường STT
                //textBox6.Enabled = false;
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Bạn có muốn thoát không", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK))
            {
                Application.Exit();
            }
        }
    }
}
