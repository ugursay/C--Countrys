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
    public partial class turkey_meals_to_eat_3 : Form
    {
        public turkey_meals_to_eat_3()
        {
            InitializeComponent();
        }

        private void turkey_meals_to_eat_3_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            turkey turkey = new turkey();
            turkey.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            turkey_meals_to_eat_2 meals = new turkey_meals_to_eat_2();
            meals.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            turkey_meals_to_eat_4 meals = new turkey_meals_to_eat_4();
            meals.Show();
            this.Hide();
        }
    }
}
