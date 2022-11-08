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
    public partial class turkey_places_to_visit_5 : Form
    {
        public turkey_places_to_visit_5()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            turkey turkey = new turkey();
            turkey.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            turkey_places_to_visit_4 places = new turkey_places_to_visit_4();
            places.Show();
            this.Hide();
        }
    }
}
