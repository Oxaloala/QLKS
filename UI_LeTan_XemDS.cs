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
using MySql.Data.MySqlClient;

namespace QLKS
{
    public partial class UI_LeTan_XemDS : Form
    {
        MySqlConnection connection;
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        private string server;
        private string database;
        private string user;
        private string password;
        private string port;
        string connectionString;
        private string sslM;
        public UI_LeTan_XemDS()
        {
            InitializeComponent();
        }

        List<string> listItem = new List<string>() {"null", "GetListDSNhanVien", "GetListLeTan", "GetListBellman", "GetListNhanVienDV", "GetListBaoVe",
                "GetListKeToan", "GetListVeSinh"};
        private void Form1_Load(object sender, EventArgs e)
        {
            ComboBox1.DataSource = listItem;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            server = "127.0.0.1";
            database = "DA_PTTK";
            user = "root";
            password = "14022023";
            port = "3306";
            sslM = "none";

            connectionString = String.Format("server={0};port={1};user id={2}; password={3}; database={4}; SslMode={5}", server, port, user, password, database, sslM);

            //MySqlDataAdapter adapter1;
            connection = new MySqlConnection(connectionString);
            connection.Open();
            cmd = new MySqlCommand("CALL XEM_DS_KHACHHANG;", connection);
            adapter = new MySqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            connection.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string a = ComboBox1.SelectedItem.ToString();
            if (a == "null")
            {
            }
            else if (a == "GetListDSNhanVien")
            {
                server = "127.0.0.1";
                database = "DA_PTTK";
                user = "root";
                password = "14022023";
                port = "3306";
                sslM = "none";

                connectionString = String.Format("server={0};port={1};user id={2}; password={3}; database={4}; SslMode={5}", server, port, user, password, database, sslM);

                connection = new MySqlConnection(connectionString);
                connection.Open();
                cmd = new MySqlCommand("CALL XEM_DS_NHANVIEN;", connection);
                adapter = new MySqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
                connection.Close();
            }
            else if (a == "GetListLeTan")
            {
                server = "127.0.0.1";
                database = "DA_PTTK";
                user = "root";
                password = "14022023";
                port = "3306";
                sslM = "none";

                connectionString = String.Format("server={0};port={1};user id={2}; password={3}; database={4}; SslMode={5}", server, port, user, password, database, sslM);

                connection = new MySqlConnection(connectionString);
                connection.Open();
                cmd = new MySqlCommand("CALL XEM_DS_LETAN;", connection);
                adapter = new MySqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
                connection.Close();
            }
            else if (a == "GetListBellman")
            {
                server = "127.0.0.1";
                database = "DA_PTTK";
                user = "root";
                password = "14022023";
                port = "3306";
                sslM = "none";

                connectionString = String.Format("server={0};port={1};user id={2}; password={3}; database={4}; SslMode={5}", server, port, user, password, database, sslM);

                connection = new MySqlConnection(connectionString);
                connection.Open();
                cmd = new MySqlCommand("CALL XEM_DS_BELLMAN;", connection);
                adapter = new MySqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
                connection.Close();
            }
            else if (a == "GetListNhanVienDV")
            {
                server = "127.0.0.1";
                database = "DA_PTTK";
                user = "root";
                password = "14022023";
                port = "3306";
                sslM = "none";

                connectionString = String.Format("server={0};port={1};user id={2}; password={3}; database={4}; SslMode={5}", server, port, user, password, database, sslM);

                connection = new MySqlConnection(connectionString);
                connection.Open();
                cmd = new MySqlCommand("CALL XEM_DS_NVDICHVU;", connection);
                adapter = new MySqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
                connection.Close();
            }
            else if (a == "GetListBaoVe")
            {
                server = "127.0.0.1";
                database = "DA_PTTK";
                user = "root";
                password = "14022023";
                port = "3306";
                sslM = "none";

                connectionString = String.Format("server={0};port={1};user id={2}; password={3}; database={4}; SslMode={5}", server, port, user, password, database, sslM);

                connection = new MySqlConnection(connectionString);
                connection.Open();
                cmd = new MySqlCommand("CALL XEM_DS_NVBAOVE;", connection);
                adapter = new MySqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
                connection.Close();
            }
            else if (a == "GetListKeToan")
            {
                server = "127.0.0.1";
                database = "DA_PTTK";
                user = "root";
                password = "14022023";
                port = "3306";
                sslM = "none";

                connectionString = String.Format("server={0};port={1};user id={2}; password={3}; database={4}; SslMode={5}", server, port, user, password, database, sslM);

                connection = new MySqlConnection(connectionString);
                connection.Open();
                cmd = new MySqlCommand("CALL XEM_DS_NVKETOAN;", connection);
                adapter = new MySqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
                connection.Close();
            }
            else if (a == "GetListVeSinh")
            {
                server = "127.0.0.1";
                database = "DA_PTTK";
                user = "root";
                password = "14022023";
                port = "3306";
                sslM = "none";

                connectionString = String.Format("server={0};port={1};user id={2}; password={3}; database={4}; SslMode={5}", server, port, user, password, database, sslM);

                connection = new MySqlConnection(connectionString);
                connection.Open();
                cmd = new MySqlCommand("CALL XEM_DS_NVVESINH;", connection);
                adapter = new MySqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
                connection.Close();
            }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            server = "127.0.0.1";
            database = "DA_PTTK";
            user = "root";
            password = "14022023";
            port = "3306";
            sslM = "none";

            connectionString = String.Format("server={0};port={1};user id={2}; password={3}; database={4}; SslMode={5}", server, port, user, password, database, sslM);

            connection = new MySqlConnection(connectionString);
            connection.Open();
            cmd = new MySqlCommand("CALL XEM_DS_DOAN;", connection);
            adapter = new MySqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            connection.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            server = "127.0.0.1";
            database = "DA_PTTK";
            user = "root";
            password = "14022023";
            port = "3306";
            sslM = "none";

            connectionString = String.Format("server={0};port={1};user id={2}; password={3}; database={4}; SslMode={5}", server, port, user, password, database, sslM);

           //MySqlDataAdapter adapter3;
            connection = new MySqlConnection(connectionString);
            connection.Open();
            cmd = new MySqlCommand("CALL XEM_DS_SANPHAM;", connection);
            adapter = new MySqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            connection.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            server = "127.0.0.1";
            database = "DA_PTTK";
            user = "root";
            password = "14022023";
            port = "3306";
            sslM = "none";

            connectionString = String.Format("server={0};port={1};user id={2}; password={3}; database={4}; SslMode={5}", server, port, user, password, database, sslM);

            connection = new MySqlConnection(connectionString);
            connection.Open();
            cmd = new MySqlCommand("CALL XEM_DS_PHONG;", connection);
            adapter = new MySqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            connection.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            server = "127.0.0.1";
            database = "DA_PTTK";
            user = "root";
            password = "14022023";
            port = "3306";
            sslM = "none";

            connectionString = String.Format("server={0};port={1};user id={2}; password={3}; database={4}; SslMode={5}", server, port, user, password, database, sslM);

            connection = new MySqlConnection(connectionString);
            connection.Open();
            cmd = new MySqlCommand("CALL XEM_DS_DOITACLUHANH;", connection);
            adapter = new MySqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            connection.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            server = "127.0.0.1";
            database = "DA_PTTK";
            user = "root";
            password = "14022023";
            port = "3306";
            sslM = "none";

            connectionString = String.Format("server={0};port={1};user id={2}; password={3}; database={4}; SslMode={5}", server, port, user, password, database, sslM);

            connection = new MySqlConnection(connectionString);
            connection.Open();
            cmd = new MySqlCommand("CALL XEM_DS_DICHVULUHANH;", connection);
            adapter = new MySqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            connection.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            server = "127.0.0.1";
            database = "DA_PTTK";
            user = "root";
            password = "14022023";
            port = "3306";
            sslM = "none";

            connectionString = String.Format("server={0};port={1};user id={2}; password={3}; database={4}; SslMode={5}", server, port, user, password, database, sslM);

            connection = new MySqlConnection(connectionString);
            connection.Open();
            cmd = new MySqlCommand("CALL XEM_DS_DICHVUKHACHSAN;", connection);
            adapter = new MySqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            connection.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            server = "127.0.0.1";
            database = "DA_PTTK";
            user = "root";
            password = "14022023";
            port = "3306";
            sslM = "none";

            connectionString = String.Format("server={0};port={1};user id={2}; password={3}; database={4}; SslMode={5}", server, port, user, password, database, sslM);

            connection = new MySqlConnection(connectionString);
            connection.Open();
            cmd = new MySqlCommand("CALL XEM_DS_DAILYTRUNGGIAN;", connection);
            adapter = new MySqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            connection.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            server = "127.0.0.1";
            database = "DA_PTTK";
            user = "root";
            password = "14022023";
            port = "3306";
            sslM = "none";

            connectionString = String.Format("server={0};port={1};user id={2}; password={3}; database={4}; SslMode={5}", server, port, user, password, database, sslM);

            connection = new MySqlConnection(connectionString);
            connection.Open();
            cmd = new MySqlCommand("CALL XEM_DS_PHIEUSUDUNG;", connection);
            adapter = new MySqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            connection.Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            server = "127.0.0.1";
            database = "DA_PTTK";
            user = "root";
            password = "14022023";
            port = "3306";
            sslM = "none";

            connectionString = String.Format("server={0};port={1};user id={2}; password={3}; database={4}; SslMode={5}", server, port, user, password, database, sslM);

            connection = new MySqlConnection(connectionString);
            connection.Open();
            cmd = new MySqlCommand("CALL XEM_DS_PHIEUDANGKYNHANPHONG;", connection);
            adapter = new MySqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            connection.Close();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            server = "127.0.0.1";
            database = "DA_PTTK";
            user = "root";
            password = "14022023";
            port = "3306";
            sslM = "none";

            connectionString = String.Format("server={0};port={1};user id={2}; password={3}; database={4}; SslMode={5}", server, port, user, password, database, sslM);

            connection = new MySqlConnection(connectionString);
            connection.Open();
            cmd = new MySqlCommand("CALL XEM_DS_PHIEUDATPHONG;", connection);
            adapter = new MySqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            connection.Close();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            server = "127.0.0.1";
            database = "DA_PTTK";
            user = "root";
            password = "14022023";
            port = "3306";
            sslM = "none";

            connectionString = String.Format("server={0};port={1};user id={2}; password={3}; database={4}; SslMode={5}", server, port, user, password, database, sslM);

            connection = new MySqlConnection(connectionString);
            connection.Open();
            cmd = new MySqlCommand("CALL XEM_DS_CHITIETPHIEUDAT;", connection);
            adapter = new MySqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            connection.Close();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            server = "127.0.0.1";
            database = "DA_PTTK";
            user = "root";
            password = "14022023";
            port = "3306";
            sslM = "none";

            connectionString = String.Format("server={0};port={1};user id={2}; password={3}; database={4}; SslMode={5}", server, port, user, password, database, sslM);

            connection = new MySqlConnection(connectionString);
            connection.Open();
            cmd = new MySqlCommand("CALL XEM_DS_HOADON;", connection);
            adapter = new MySqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            connection.Close();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            server = "127.0.0.1";
            database = "DA_PTTK";
            user = "root";
            password = "14022023";
            port = "3306";
            sslM = "none";

            connectionString = String.Format("server={0};port={1};user id={2}; password={3}; database={4}; SslMode={5}", server, port, user, password, database, sslM);

            connection = new MySqlConnection(connectionString);
            connection.Open();
            cmd = new MySqlCommand("CALL XEM_DS_CHITIETHOADON;", connection);
            adapter = new MySqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            connection.Close();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            server = "127.0.0.1";
            database = "DA_PTTK";
            user = "root";
            password = "14022023";
            port = "3306";
            sslM = "none";

            connectionString = String.Format("server={0};port={1};user id={2}; password={3}; database={4}; SslMode={5}", server, port, user, password, database, sslM);

            connection = new MySqlConnection(connectionString);
            connection.Open();
            cmd = new MySqlCommand("CALL XEM_DS_HANHLY;", connection);
            adapter = new MySqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            connection.Close();
        }

        private void button16_Click(object sender, EventArgs e)
        {

        }
    } 
}
