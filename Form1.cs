using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace tuankecuoi
{
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection();
        string strConn = "Data Source=A209PC40;Initial Catalog=Bai14;Integrated Security=True";
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Ban co chac chac muon thoat khong?",
                 "Thoat", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                 MessageBoxDefaultButton.Button1);
            if (r == DialogResult.Yes)
                Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "A209PC40" && textBox2.Text == "Bai14") {
                using (SqlConnection connection = new SqlConnection(strConn))
                {
                    try
                    {
                        connection.Open();
                        MessageBox.Show("Thanh cong roi em yeu");
                        Form2 frmGiaoVien = new Form2();
                        frmGiaoVien.Show();
                        this.Hide();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(Convert.ToString(ex));
                    }
                }
            }
            else
            {
                if(textBox1.Text == "") {
                    MessageBox.Show("Thieu thong tin Ten may");
                    textBox1.Focus();
                }
                else if  (textBox2.Text == ""){
                    MessageBox.Show("Thieu thong tin Ten CSDL");
                    textBox2.Focus();
                }
                else
                {
                    MessageBox.Show("Vui long nhap lai thong tin cho dung!!");
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
