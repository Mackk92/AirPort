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
    public partial class Rezerwa : Form
    {

        int i = 0;
        object[] rejsnumer = new object[100];
        internal string Rezerwacja = "nie";
        internal string IDRejs = "nie";
        public Rezerwa()
        {
            InitializeComponent();
            InitializeComponent();
            fillCombo();
            Random random = new Random();
            int randomNumber1 = random.Next(9, 10000);
            int randomNumber2 = random.Next(9, 10000);
            String str1 = randomNumber1.ToString();
            String str2 = randomNumber2.ToString();

            textBoxIDbilet.Text = str1;
            textBoxIdKlient.Text = str2;

        }
        void fillCombo()
        {
            string connectionString = Connection.GetConnectionString();
            string sql = "SELECT * FROM Rejs";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand cmdDataBase = new SqlCommand(sql, connection);
            SqlDataReader myReader;
            try
            {
                connection.Open();
                myReader = cmdDataBase.ExecuteReader();
                while (myReader.Read())
                {
                    object rejsy = myReader.GetValue(1);
                    comboBoxRejs.Items.Add(rejsy.ToString());
                    Console.WriteLine(rejsy.ToString());
                    rejsnumer[i] = myReader.GetValue(0);
                    i = i + 1;
                    Console.WriteLine(myReader.GetValue(0));
                    Console.WriteLine(i + "ikre");
                }
            }
            catch { }
            }

        private void Rezerwa_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
