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
print(abbbababbabbababa)
namespace QuanLy_HS_GV_THPT
{
    public partial class DangKy : Form
    {
        //Data source(khac nhau)
        string dataSource = @"Data Source=DESKTOP-9JCB5HS;Initial Catalog=quanly_Hs_Gv_THPT_3F;Integrated Security=True";
        SqlConnection connection;
        SqlCommand command;
        public DangKy()
        {
            InitializeComponent();
        }

        private void DangKy_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(dataSource);
            connection.Open();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDangky_Click(object sender, EventArgs e)
        {
            try
            {
                command = connection.CreateCommand();
                string taiKhoan = txtTaikhoan.Text;
                string matKhau = txtMatkhau.Text;
                command.CommandText = "INSERT INTO DANGNHAP (TaiKhoan, MatKhau) VALUES ('" + taiKhoan + "', '" + matKhau + "')";
                command.ExecuteNonQuery();

                this.Hide();
                DangNhap dangNhap = new DangNhap();
                dangNhap.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi kết nối");
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            DangNhap dangNhap = new DangNhap();
            dangNhap.ShowDialog();
        }
    }
}
