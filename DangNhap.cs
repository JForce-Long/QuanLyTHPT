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

namespace QuanLy_HS_GV_THPT
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }


        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-C33GCG4;Initial Catalog=quanly_Hs_Gv_THPT_3F;Integrated Security=True");
            try
            {
                connection.Open();
                
                string taiKhoan = textBox1.Text;
                string matKhau = textBox2.Text;
                string sql = "select * from DANGNHAP where TaiKhoan = '" + taiKhoan + "' and MatKhau = '" + matKhau + "'";

                SqlCommand cmd = new SqlCommand(sql, connection);

                SqlDataReader dta = cmd.ExecuteReader();
                if (dta.Read() == true)
                {
                    this.Hide();
                    ManHinhChinh manHinhChinh = new ManHinhChinh();
                    manHinhChinh.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi kết nối");
            }
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            this.Hide();
            DangKy dangKy = new DangKy();
            dangKy.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
