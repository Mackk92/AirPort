using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirPort
{
    public partial class Odloty : Form
    {
        public Odloty()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu men = new Menu();
            men.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connectionString = Connection.GetConnectionString();
            string sql = "SELECT [nazwa_rejsu],[odlot],[przylot],[status_lotu],[terminal],[bramka] FROM [AirPort].[dbo].[Rejs] Where id_lotniska<>'124411'";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter dataadapter = new SqlDataAdapter(sql, connection);
            DataSet ds = new DataSet();
            connection.Open();
            dataadapter.Fill(ds, "Logins");
            connection.Close();
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "Logins";
            dataGridView1.AllowUserToAddRows = false;





        }
    }
}
