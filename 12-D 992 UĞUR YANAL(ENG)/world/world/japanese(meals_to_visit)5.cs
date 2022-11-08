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
    public partial class japanese_meals_to_visit_5 : Form
    {
        public japanese_meals_to_visit_5()
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
            japanese_meals_to_visit_4 japanese = new japanese_meals_to_visit_4();
            japanese.Show();
            this.Hide();
        }
    }
}
