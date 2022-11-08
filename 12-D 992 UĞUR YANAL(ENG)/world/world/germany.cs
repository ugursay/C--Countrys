using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace world
{
    public partial class germany : Form
    {
        public germany()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            germany_meals_to_eat_ germany = new germany_meals_to_eat_();
            germany.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            germany_places_to_visit_ germany = new germany_places_to_visit_();
            germany.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            germany_historical_ germany = new germany_historical_();
            germany.Show();
            this.Hide();
        }
    }
}
