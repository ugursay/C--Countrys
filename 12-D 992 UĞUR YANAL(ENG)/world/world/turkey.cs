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
    public partial class turkey : Form
    {
        public turkey()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            turkey_historical_ historical = new turkey_historical_();
            historical.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            turkey_meals_to_eat_ meals = new turkey_meals_to_eat_();
            meals.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            turkey_places_to_visit_ places = new turkey_places_to_visit_();
            places.Show();
            this.Hide();
        }
    }
}
