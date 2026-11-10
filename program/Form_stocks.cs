using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace program
{
    public partial class Form_stocks : Form
    {
        public Form_stocks()
        {
            InitializeComponent();
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            login.Show();
            this.Hide();
        }

        private void Form_stocks_Load(object sender, EventArgs e)
        {

        }

        private void btnBicycle_Click(object sender, EventArgs e)
        {
            Form3 bicycle = new Form3(); 
            bicycle.Show(); 
            this.Hide();
        }

        private void btnMushroom_Click(object sender, EventArgs e)
        {
            Form5 mushroom = new Form5(); 
            mushroom.Show(); 
            this.Hide();
        }
    }
}
