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
    public partial class japanese_meals_to_visit_ : Form
    {
        public japanese_meals_to_visit_()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            japanese japanese = new japanese();
            japanese.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            japanese_meals_to_visit_2 japanese = new japanese_meals_to_visit_2();
            japanese.Show();
            this.Hide();
        }
    }
}
