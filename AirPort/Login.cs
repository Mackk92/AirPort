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
    public partial class Login : Form
    {
        

        public Login()
        {
            InitializeComponent();


        }



        
        

        private void button2_Click(object sender, EventArgs e)
        {
            
           
            Connection.checkUser(textBoxLogin.Text, textBoxPass.Text);

            if (Connection.k == 1)
            {
                Menu m = new Menu();
                this.Hide();
                m.Show();
                
            }
            if (Connection.k == -1)
            {
                MessageBox.Show("Wystąpił problem.Skontaktuj się z administratorem.", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (Connection.k== -2)
            {
                MessageBox.Show("Złe hasło lub/i login", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            }



        }

        private void button1_Click(object sender, EventArgs e)
        {




           
       
           
            Con_Spec connspec = new Con_Spec();
        
            this.Hide();
            connspec.Show();
            
        }
    }
}
