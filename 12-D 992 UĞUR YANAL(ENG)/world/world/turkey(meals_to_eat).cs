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
    public partial class turkey_meals_to_eat_ : Form
    {
        public turkey_meals_to_eat_()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            turkey turkey = new turkey();
            turkey.Show();
            this.Hide();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            turkey_meals_to_eat_2 meals = new turkey_meals_to_eat_2();
            meals.Show();
            this.Hide();
        }
    }
}
