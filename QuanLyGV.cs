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

    public partial class QuanLyGV : Form
    {
        //Ket noi SQL
        SqlConnection connection;
        SqlCommand command;
        string dataSource = @"Data Source=DESKTOP-9JCB5HS;Initial Catalog=quanly_Hs_Gv_THPT_3F;Integrated Security=True";
        //SqlDataReader sqlReader;
        SqlDataAdapter adapter = new SqlDataAdapter();

        //Datasourse (khac nhau)

        DataTable table = new DataTable();

        
       
        void loadData()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from GIAOVIEN";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dataGridView1.DataSource = table;

        }


        public QuanLyGV()
        {
            InitializeComponent();
        }

         private void QuanLyGV_Load(object sender, EventArgs e)
         {
             connection = new SqlConnection(dataSource);
             connection.Open();
             loadData();
         }


        private void ReturnGV_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManHinhChinh manhinhchinh = new ManHinhChinh();
            manhinhchinh.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridView1.CurrentRow.Index;
            txtMaGV.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            txtTenGV.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            txtGioiTinh.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            txtDate.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            txtPhone.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
            txtDiaChi.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
        }

        private void Xoa_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "update LOP set MaGV = null where MaGV = '" + txtMaGV.Text + "'";
            command.ExecuteNonQuery();

            command.CommandText = "delete from GIAOVIEN where MaGV ='" + txtMaGV.Text + "'";
            command.ExecuteNonQuery();
            loadData();
        }

        private void Sua_Click(object sender, EventArgs e)
        {
            txtMaGV.ReadOnly = true;
            command = connection.CreateCommand();
            command.CommandText = "update GIAOVIEN set MaGV = N'" + txtMaGV.Text + "', TenGV = '" + txtTenGV.Text + "', GioiTinh = N'" + txtGioiTinh.Text + "' , DiaChi = '" + txtDiaChi.Text + "', SDT = '" + txtPhone.Text + "' where MaGV = '" + txtMaGV.Text + "'";
            command.ExecuteNonQuery();
            loadData();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDiaChi_TextChanged(object sender, EventArgs e)
        {

        }

        private void DiaChi_Click(object sender, EventArgs e)
        {

        }

        private void txtGioiTinh_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void reset_Click(object sender, EventArgs e)
        {
            txtMaGV.Text = "";
            txtTenGV.Text = "";
            txtGioiTinh.Text = "";
            txtDate.Text = "1/1/1900";
            txtPhone.Text = "";
            txtDiaChi.Text = "";
        }

        private void textTim_TextChanged(object sender, EventArgs e)
        {

        }

        private void TimKiem_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(dataSource);
            connection.Open();
            string magiaovien = txtSearch.Text;
            string sql = "select MaGV from GIAOVIEN where MaGV = '" + txtSearch.Text + "'";

            SqlCommand cmd = new SqlCommand(sql, connection);
            SqlDataReader data = cmd.ExecuteReader();

            if (data.Read() == true)
            {
                data.Close();
                command = connection.CreateCommand();
                command.CommandText = "select * from GIAOVIEN where MaGV='" + txtSearch.Text + "'";
                adapter.SelectCommand = command;
                table.Clear();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
            }
            else
            {
                MessageBox.Show("Không có mã giáo viên cần tìm!");
            }
        }
    }
}
