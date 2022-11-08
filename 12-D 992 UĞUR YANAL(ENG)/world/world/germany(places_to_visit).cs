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
    public partial class germany_places_to_visit_ : Form
    {
        public germany_places_to_visit_()
        {
            InitializeComponent();
        }

        private void germany_places_to_visit__Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            germany america = new germany();
            america.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            germany_places_to_visit_2 germany = new germany_places_to_visit_2();
            germany.Show();
            this.Hide();
        }
    }
}
