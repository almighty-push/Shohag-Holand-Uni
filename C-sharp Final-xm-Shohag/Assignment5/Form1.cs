using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment5
{
    public partial class Form1 : Form
    {
        double firstClass = 87.46;
        double secondClass = 53.00;
        double railRunner = 2.50;
        public Form1()
        {
            InitializeComponent();
        }

        private void calculate_btn_Click(object sender, EventArgs e)
        {
            var tickets = int.Parse(ticket_box.Text);
            var runner = int.Parse(runner_box.Text);
            var price = 0.00;
            if (Rdo_1st_class.Checked)
                price = firstClass;
            if (Rdo_2nd_class.Checked)
                price = secondClass;
            var total = (tickets * price) + (runner * railRunner);
            price_lvl.Text = total.ToString("0.00");

        }
    }
}
