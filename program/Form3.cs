using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace program
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void lblBicycle_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int start; // Stores the starting hour.
            int end; // Stores the ending hour.

            if (!int.TryParse(txtStart.Text, out start)) // Checks whether starting hour is a valid whole number.
            {
                MessageBox.Show("Please enter a valid starting hour."); // Displays an error message.
                return; // Stops the calculation.
            }

            if (!int.TryParse(txtEnd.Text, out end)) // Checks whether ending hour is a valid whole number.
            {
                MessageBox.Show("Please enter a valid ending hour."); // Displays an error message.
                return; // Stops the calculation.
            }

            if (start < 0 || start > 23) // Checks whether starting hour is outside the allowed range.
            {
                MessageBox.Show("Invalid starting hour."); // Displays the starting-hour error.
                return; // Stops the calculation.
            }

            if (end < 1 || end > 24) // Checks whether ending hour is outside the allowed range.
            {
                MessageBox.Show("Invalid ending hour."); // Displays the ending-hour error.
                return; // Stops the calculation.
            }

            if (start >= end) // Checks whether starting hour is greater than or equal to ending hour.
            {
                MessageBox.Show("Starting hour must be less than ending hour."); // Displays the error.
                return; // Stops the calculation.
            }

            int total = 0; // Starts the total cost at zero.

            for (int hour = start; hour < end; hour++) // Repeats once for every rented hour.
            {
                int price; // Stores the price for the current hour.

                if (hour < 7 || hour >= 21) // Checks whether the hour is before 7 or from 21 onward.
                {
                    price = 500; // Charges 500 RWF for that hour.
                }
                else if (hour < 14 || hour >= 19) // Checks whether the hour is before 14 or from 19 onward.
                {
                    price = 1000; // Charges 1000 RWF for that hour.
                }
                else // Runs for the remaining hours, from 14 through 18.
                {
                    price = 1500; // Charges 1500 RWF for that hour.
                }

                total = total + price; // Adds the current hour's price to the total.
            }

            txtTotal.Text = total + " RWF";
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1(); 
            login.Show(); 
            this.Hide();
        }
    }
}
