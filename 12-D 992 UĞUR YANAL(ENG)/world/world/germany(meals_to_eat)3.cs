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
    public partial class germany_meals_to_eat_3 : Form
    {
        public germany_meals_to_eat_3()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            germany germany = new germany();
            germany.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            germany_meals_to_eat_2 germany = new germany_meals_to_eat_2();
            germany.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            germany_meals_to_eat_4 germany = new germany_meals_to_eat_4();
            germany.Show();
            this.Hide();
        }
    }
}
