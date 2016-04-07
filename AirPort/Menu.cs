using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirPort
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Przyloty przy = new Przyloty();
            przy.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Odloty odl = new Odloty();
            odl.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bilet bil = new Bilet();
            bil.Show();
        }
    }
}
