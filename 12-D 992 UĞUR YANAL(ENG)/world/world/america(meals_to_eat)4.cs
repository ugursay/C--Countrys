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
    public partial class america_meals_to_eat_4 : Form
    {
        public america_meals_to_eat_4()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            america america = new america();
            america.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            america_meals_to_eat_3 america = new america_meals_to_eat_3();
            america.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            america_meals_to_eat_5 america = new america_meals_to_eat_5();
            america.Show();
            this.Hide();
        }

        private void america_meals_to_eat_4_Load(object sender, EventArgs e)
        {

        }
    }
}
