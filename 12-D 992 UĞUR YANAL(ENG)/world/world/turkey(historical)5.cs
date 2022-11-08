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
    public partial class turkey_historical_5 : Form
    {
        public turkey_historical_5()
        {
            InitializeComponent();
        }

        private void turkey_historical_5_Load(object sender, EventArgs e)
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
            turkey_historical_4 historical = new turkey_historical_4();
            historical.Show();
            this.Hide();
        }
    }
}
