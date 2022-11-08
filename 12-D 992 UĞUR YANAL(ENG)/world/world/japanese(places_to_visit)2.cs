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
    public partial class japanese_places_to_visit_2 : Form
    {
        public japanese_places_to_visit_2()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            japanese japanese = new japanese();
            japanese.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            japanese_places_to_visit_ japanese = new japanese_places_to_visit_();
            japanese.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            japanese_places_to_visit_3 japanese = new japanese_places_to_visit_3();
            japanese.Show();
            this.Hide();
        }
    }
}
