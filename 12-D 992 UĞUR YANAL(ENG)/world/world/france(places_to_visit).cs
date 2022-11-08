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
    public partial class france_places_to_visit_ : Form
    {
        public france_places_to_visit_()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            france france = new france();
            france.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            france_places_to_visit_2 france = new france_places_to_visit_2();
            france.Show();
            this.Hide();
        }
    }
}
