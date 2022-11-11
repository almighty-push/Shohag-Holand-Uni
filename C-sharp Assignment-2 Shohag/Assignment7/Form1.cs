using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment7
{
    public partial class Form1 : Form
    {
        private readonly int[] value = new int[6] { 0, 0, 0, 0, 0, 0 };
        public Form1()
        {
            InitializeComponent();
        }

        private void throw_btn_Click(object sender, EventArgs e)
        {
            int dice = 0;
            Random rand = new Random();
            for (int i = 0; i < 6000; i++)
            {
                dice = rand.Next(1, 7);
            }
            switch (dice)
            {
                case 1:
                    value[0]++;
                    break;
                case 2:
                    value[1]++;
                    break;
                case 3:
                    value[2]++;
                    break;
                case 4:
                    value[3]++;
                    break;
                case 5:
                    value[4]++;
                    break;
                case 6:
                    value[5]++;
                    break;
            }
            value_1.Text = value[0].ToString();
            value_2.Text = value[1].ToString();
            value_3.Text = value[2].ToString();
            value_4.Text = value[3].ToString();
            value_5.Text = value[4].ToString();
            value_6.Text = value[5].ToString();
            

        }
    }
}
