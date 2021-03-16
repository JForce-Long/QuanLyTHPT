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
    public partial class QuanLyHS : Form
    {
        //Ket noi SQL
        SqlConnection connection;
        SqlCommand command;
        string dataSource = @"Data Source=DESKTOP-3PP3KKO;Initial Catalog=quanly_Hs_Gv_THPT_3F;Integrated Security=True";
       // SqlDataReader sqlReader;
        SqlDataAdapter adapter = new SqlDataAdapter();

        //Datasourse (khac nhau)

        DataTable table = new DataTable();

        

        void loadData()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from HOCSINH";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dataGridView1.DataSource = table;

        }
        public QuanLyHS()
        {
            InitializeComponent();
            this.KeyDown += new KeyEventHandler(Form_KeyDown);
            dataGridView1.KeyDown += new KeyEventHandler(Form_KeyDown);
        }

        private void Form_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F1")
            {
                var helperDialog = new Helper.Helpers();
                helperDialog.ShowDialog();
            }
        }
        private void QuanLyHS_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(dataSource);
            connection.Open();
            loadData();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

            int i;
            i = dataGridView1.CurrentRow.Index;
            txtMaHS.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            txtTenHS.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            txtGioiTinh.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            txtDiaChi.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
            txtPhone.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();

        }

        private void txtTenHS_TextChanged(object sender, EventArgs e)
        {

        }

        private void ReturnHS_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManHinhChinh manhinhchinh = new ManHinhChinh();
            manhinhchinh.ShowDialog();
        }

        private void Xoa_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "delete from HOCSINH where MaHS ='" + txtMaHS.Text + "'";
            command.ExecuteNonQuery();
            loadData();
        }

        private void Sua_Click(object sender, EventArgs e)
        {
            txtMaHS.ReadOnly = true;
            command = connection.CreateCommand();
            command.CommandText = "update HOCSINH set MaHS = N'" + txtMaHS.Text + "', TenHS = '" + txtTenHS.Text + "', GioiTinh = N'" + txtGioiTinh.Text + "' , DiaChi = '" + txtDiaChi.Text + "', SDT = '" + txtPhone.Text +  "' where MaHS = '" + txtMaHS.Text + "'";
            command.ExecuteNonQuery();
            loadData();
        }

        private void txtGioiTinh_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void helpBTN_Click(object sender, EventArgs e)
        {
            var helperDialog = new Helper.Helpers();
            helperDialog.ShowDialog();
        }
    }
}
