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
    public partial class japanese : Form
    {
        public japanese()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            japanese_meals_to_visit_ japanese = new japanese_meals_to_visit_();
            japanese.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            japanese_places_to_visit_ japanese = new japanese_places_to_visit_();
            japanese.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            japanese_historical_ japanese = new japanese_historical_();
            japanese.Show();
            this.Hide();
        }
    }
}
