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
    public partial class america_meals_to_eat_3 : Form
    {
        public america_meals_to_eat_3()
        {
            InitializeComponent();
        }

        private void america_meals_to_eat_3_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            america america = new america();
            america.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            america_meals_to_eat_2 america = new america_meals_to_eat_2();
            america.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            america_meals_to_eat_4 america = new america_meals_to_eat_4();
            america.Show();
            this.Hide();
        }
    }
}
