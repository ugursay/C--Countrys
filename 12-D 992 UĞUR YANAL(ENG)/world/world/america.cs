﻿using System;
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
    public partial class america : Form
    {
        public america()
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
            america_meals_to_eat_ america = new america_meals_to_eat_();
            america.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            america_places_to_visit_ america = new america_places_to_visit_();
            america.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            america_historical_ america = new america_historical_();
            america.Show();
            this.Hide();
        }
    }
}
