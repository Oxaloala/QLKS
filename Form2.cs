using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace QLKS
{
    public partial class Form2 : Form
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
        public Form2()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = @"np:\\.\pipe\LOCALDB#037CE15E\tsql\query";
            SqlConnection conn = new SqlConnection(path);
            string sql = "Select* from KHACHHANG";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            server = "127.0.0.1";
            database = "DA_PTTK";
            user = "Ngoc";
            password = "14022023";
            port = "3306";
            sslM = "none";

            connectionString = String.Format("server={0};port={1};user id={2}; password={3}; database={4}; SslMode={5}", server, port, user, password, database, sslM);

            connection = new MySqlConnection(connectionString);
            connection.Open();
            cmd = new MySqlCommand("CALL XEM_TT_NHANVIEN;", connection);
            adapter = new MySqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            connection.Close();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f3 = new Form3();
            f3.Show();
        }
    }
}
