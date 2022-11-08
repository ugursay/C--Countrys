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
    public partial class america_places_to_visit_ : Form
    {
        public america_places_to_visit_()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            america america = new america();
            america.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            america_places_to_visit_2 america = new america_places_to_visit_2();
            america.Show();
            this.Hide();
        }
    }
}
