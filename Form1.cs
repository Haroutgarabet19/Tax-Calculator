using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace empcal
{
    public partial class Form1 : Form
    {
        // Declare variables to store financial data
        double sal, etf, epf, etfamount, epfamount, gsal, allow, nsal;

        // Constructor for the Form1 class
        public Form1()
        {
            InitializeComponent();
        }

        // Event handler for the button click event
        private void button1_Click(object sender, EventArgs e)
        {
            // Retrieve the salary value entered by the user from the textbox
            sal = Double.Parse(txtsal.Text);

            // Calculate ETF amount if the corresponding checkbox is checked
            if(chketf.Checked == true)
            {
                etfamount = sal * 10 / 100;
            }

            // Calculate EPF amount if the corresponding checkbox is checked
            if (chkepf.Checked == true)
            {
                epfamount = sal * 5 / 100;
            }

            // Display ETF and EPF amounts in their respective textboxes
            txtetf.Text = etfamount.ToString();
            txtepf.Text = epfamount.ToString();

            // Calculate gross salary by subtracting ETF amount from the salary
            // (Note: The original calculation adds the ETF amount back, which seems redundant)
            gsal = sal - etfamount + etfamount;

            // Display gross salary in the corresponding textbox
            txtgsal.Text = gsal.ToString();

            // Determine the allowance based on the salary range
            if(sal > 50000)
            {
                allow = 2000;
            }
            else  if(sal > 30000)
            {
                allow = 1000;
            }
            else
            {
                allow = 0;
            }

            // Display allowance in the corresponding textbox
            txtallo.Text = allow.ToString();

            // Calculate net salary by adding allowance to the gross salary
            nsal = gsal + allow;

            // Display net salary in the corresponding textbox
            txtnsal.Text = nsal.ToString();
        }
    }
}
