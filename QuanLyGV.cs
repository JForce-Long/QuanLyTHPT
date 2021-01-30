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
        string dataSource = @"Data Source=DESKTOP-C33GCG4;Initial Catalog=quanly_Hs_Gv_THPT_3F;Integrated Security=True";
        SqlDataReader sqlReader;
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

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
            int i;
            i = dataGridView1.CurrentRow.Index;
            txtMaGV.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            txtTenGV.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            dtpDate.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            txtDiaChi.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            txtGioiTinh.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
            txtPhone.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
        
        }

        private void ReturnGV_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManHinhChinh manhinhchinh = new ManHinhChinh();
            manhinhchinh.ShowDialog();
        }

    }
}
