using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLy_HS_GV_THPT
{
    public partial class Thông_Tin_Giảng_Dạy : Form
    {

        //Ket noi SQL
        SqlConnection connection;
        SqlCommand command;
       // string dataSource = @"Data Source=DESKTOP-9JCB5HS;Initial Catalog=quanly_Hs_Gv_THPT_3F;Integrated Security=True";
        //SqlDataReader sqlReader;
        SqlDataAdapter adapter = new SqlDataAdapter();

        //Datasourse (khac nhau)

        DataTable table = new DataTable();


        void loadData()
        {
            command = connection.CreateCommand();
            command.CommandText = "select MaHS, TenHS, GioiTinh, Date, LOP.MaLop, TenLop, MaGV from HOCSINH,LOP where HOCSINH.MaLop = LOP.MaLop order by MaHS";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dataGridView1.DataSource = table;

        }

        private void TTGiangDay_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(Helper.Define.dataSource);
            connection.Open();
            loadData();
        }

        public Thông_Tin_Giảng_Dạy()
        {
            InitializeComponent();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManHinhChinh manhinhchinh = new ManHinhChinh();
            manhinhchinh.ShowDialog();
        }

        private void InDS_Click(object sender, EventArgs e)
        {
            MessageBox.Show("In danh sách thành công!");
        }

        private void searchtt_Click(object sender, EventArgs e)
        {
            if (cmbtt.SelectedItem == "Mã lớp")
            {
                SqlConnection connection = new SqlConnection(Helper.Define.dataSource);
                connection.Open();
                string sql = "select * from LOP where MaLop = '" + txttt.Text + "'";

                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.ExecuteNonQuery();
                SqlDataReader data = cmd.ExecuteReader();

                if (data.Read() == true)
                {
                    data.Close();
                    command = connection.CreateCommand();
                    command.CommandText = "select MaHS, TenHS, GioiTinh, Date, LOP.MaLop, TenLop, MaGV from HOCSINH,LOP where HOCSINH.MaLop = LOP.MaLop and LOP.MaLop='" + txttt.Text + "'";
                    adapter.SelectCommand = command;
                    table.Clear();
                    adapter.Fill(table);
                    dataGridView1.DataSource = table;
                }
                else { MessageBox.Show("Không có thông tin cần tìm!"); }
            }

            if (cmbtt.SelectedItem == "Tên lớp")
            {
                SqlConnection connection = new SqlConnection(Helper.Define.dataSource);
                connection.Open();
                string sql = "select * from LOP where TenLop = '" + txttt.Text + "'";

                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.ExecuteNonQuery();
                SqlDataReader data = cmd.ExecuteReader();

                if (data.Read() == true)
                {
                    data.Close();
                    command = connection.CreateCommand();
                    command.CommandText = "MaHS, TenHS, GioiTinh, Date, LOP.MaLop, TenLop, MaGV from HOCSINH,LOP where HOCSINH.MaLop = LOP.MaLop and TenLop='" + txttt.Text + "'";
                    adapter.SelectCommand = command;
                    table.Clear();
                    adapter.Fill(table);
                    dataGridView1.DataSource = table;
                }
                else { MessageBox.Show("Không có thông tin cần tìm!"); }
            }
        }
    }
}
