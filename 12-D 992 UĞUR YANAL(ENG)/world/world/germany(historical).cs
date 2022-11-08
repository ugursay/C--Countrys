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
    public partial class germany_historical_ : Form
    {
        public germany_historical_()
        {
            InitializeComponent();
        }

        private void germany_historical__Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            germany germany = new germany();
            germany.Show();
            this.Hide();
        }
    }
}
