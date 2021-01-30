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
    public partial class ManHinhChinh : Form
    {
        public ManHinhChinh()
        {
            InitializeComponent();
        }

        private void ManHinhChinh_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void QLGV_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuanLyGV quanLyGV = new QuanLyGV();
            quanLyGV.ShowDialog();
        }

        private void QLHS_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuanLyHS quanLyHS = new QuanLyHS();
            quanLyHS.ShowDialog();
        }


        private void btnReturn_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            DangNhap dangNhap = new DangNhap();
            dangNhap.ShowDialog();
        }

        private void QLLOP_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuanLyLop quanlylop = new QuanLyLop();
            quanlylop.ShowDialog();
        }

        private void TTGD_Click(object sender, EventArgs e)
        {
            this.Hide();
            Thông_Tin_Giảng_Dạy ttgd = new Thông_Tin_Giảng_Dạy();
            ttgd.ShowDialog();
        }
    }
}
