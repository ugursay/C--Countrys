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
    public partial class france : Form
    {
        public france()
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
            france_meals_to_visit_ france = new france_meals_to_visit_();
            france.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            france_places_to_visit_ france = new france_places_to_visit_();
            france.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            france_historical_ france = new france_historical_();
            france.Show();
            this.Hide();
        }
    }
}
