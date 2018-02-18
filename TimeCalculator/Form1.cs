using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox about = new AboutBox();
            about.Show();
        }

        private void txtDays_TextChanged(object sender, EventArgs e)
        {
            // Variables
            float days = 0;
            float weeks = 0;
            float months = 0;
            float years = 0;

            // Get Days
            if(txtDays.Text != "")
            {
                try
                {
                    days = Int32.Parse(txtDays.Text);
                }
                catch
                {
                    Console.Write("Invalid Value.");
                }
            } else
            {
                MessageBox.Show("Value cannot be empty.");
            }

            // Convert to weeks and months
            weeks = days / 7;
            months = days / 30;
            years = days / 365;

            // Output results
            lblWeekslbl.Text = weeks.ToString("0.##");
            lblMonthslbl.Text = months.ToString("0.##");
            lblYearslbl.Text = years.ToString("0.##");
        }
    }
}
