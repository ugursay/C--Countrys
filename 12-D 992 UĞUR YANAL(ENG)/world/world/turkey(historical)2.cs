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
    public partial class turkey_historical_2 : Form
    {
        public turkey_historical_2()
        {
            InitializeComponent();
        }

        private void turkey_historical_2_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            turkey turkey = new turkey();
            turkey.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            turkey_historical_ historical = new turkey_historical_();
            historical.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            turkey_historical_3 historical = new turkey_historical_3();
            historical.Show();
            this.Hide();
        }
    }
}
