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
    public partial class france_meals_to_visit_5 : Form
    {
        public france_meals_to_visit_5()
        {
            InitializeComponent();
        }

        private void france_meals_to_visit_5_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            france france = new france();
            france.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            france_meals_to_visit_4 france = new france_meals_to_visit_4();
            france.Show();
            this.Hide();
        }
    }
}
