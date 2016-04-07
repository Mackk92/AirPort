using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirPort
{
    public partial class Bilet : Form
    {
        int i = 0;
        object[] rejsnumer = new object[100];
        internal string Rezerwacja="nie";
        internal string IDRejs = "nie";
        public Bilet()
        {
            
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
            SqlCommand cmdDataBase = new SqlCommand(sql,connection);
            SqlDataReader myReader;
            try
            {
                connection.Open();
                myReader = cmdDataBase.ExecuteReader();
                while(myReader.Read())
                {
                    object rejsy = myReader.GetValue(1);
                    comboBoxRejs.Items.Add(rejsy.ToString());
                    Console.WriteLine(rejsy.ToString()); 
                    rejsnumer[i]= myReader.GetValue(0);
                    i = i + 1;
                    Console.WriteLine(myReader.GetValue(0));
                    Console.WriteLine(i+"ikre");
                }



                connection.Close();

            }
            catch (Exception ex)
                {
                MessageBox.Show(ex.Message);

            }

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click_1(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click_2(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            lool();
           



        }

        void lool()
        {
            string spr = comboBoxRejs.SelectedIndex.ToString();
            int id_rejsu = Int32.Parse(spr);

            SqlDateTime date1 = new SqlDateTime();

            date1 = Convert.ToDateTime(textBoxDataUrodz.Text);
            string connectionString = Connection.GetConnectionString();
            string sql = "INSERT INTO Bilety([id_biletu],[cena_biletu],[rodzaj_biletu],[znizki],[id_rejsu],[status],[rezerwacja]) VALUES(" + textBoxIDbilet.Text + "," + textBoxCena.Text + ",'" + textBoxRodzaj.Text + "','" + textBoxZnizki.Text + "'," + rejsnumer[id_rejsu] + ",'" + textBoxStatus.Text + "','" + comboBoxRez.SelectedText + "'); INSERT INTO Pasazer([id_pasazera], [waga_bagazu], [imie], [nazwisko], [pesel], [nr_dowodu], [data_urodzenia], [waga_pasazera], [adres], [tel_kom], [id_biletu], [id_rejsu]) VALUES(" + textBoxIDbilet.Text + "," + textBoxWagaPasa.Text + ",'" + textBoxImie.Text + "','" + textBoxNaz.Text + "','" + textBoxPESEL.Text + "','" + textBoxDowod.Text + "','" + date1 + "'," + textBoxWagaPasa.Text + ",'" + textBoxAdres.Text + "'," + textBoxTel.Text + "," + textBoxIDbilet.Text + "," + rejsnumer[id_rejsu] + ");";

            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand cmdDataBase = new SqlCommand(sql, connection);
            SqlDataReader myReader;
            try
            {
                connection.Open();
                myReader = cmdDataBase.ExecuteReader();
                connection.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            MessageBox.Show("Zakończono  powodzeniem","Status");
        }

        private void Bilet_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBoxRejs_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
