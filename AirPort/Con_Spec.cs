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
    public partial class Con_Spec : Form
    {
       

        public Con_Spec()
        {
            InitializeComponent();
            
            textBoxLogin.Text  =Connection.login;
           textBoxPass.Text =Connection.pass;
           textBoxNet.Text =Connection.net;
           textBoxBase.Text =  Connection.datab;
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Connection.login = textBoxLogin.Text;
            Connection.pass = textBoxPass.Text;
            Connection.net = textBoxNet.Text;
            Connection.datab = textBoxBase.Text;

            this.Hide();
            Login logo = new Login();
            logo.Show();



        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            
           
           
            

            Connection.login = textBoxLogin.Text;
            Connection.pass = textBoxPass.Text;
            Connection.net = textBoxNet.Text;
            Connection.datab = textBoxBase.Text;
            try
            {
             //   Connection.IsServerConnected(Connection.GetConnectionString());
               
            }
            catch (SqlException)
            {
                throw;
            }
          //  if (Connection.IsServerConnected(Connection.GetConnectionString()) == true)
          
            {
                
                checkBox1.Checked= true;
            }
         //   if (Connection.IsServerConnected(Connection.GetConnectionString()) == false)

            {
                checkBox1.Checked = false;
            }
        }

       
    }

    
}
