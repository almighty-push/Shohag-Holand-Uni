using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment6
{
    public partial class Form1 : Form
    {
        int[] array = new int[20];
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //generate 20 
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(0,500);
            }

            //display the array on the label
            string arrayString = "";
            for (int i = 0; i < array.Length; i++)
            {
                arrayString += "Elment "+ i + "=" + array[i] + " \n";
            }
            PrevElements.Text = arrayString;
            
        }

        private void compare_btn_Click(object sender, EventArgs e)
        {
            int compare = Convert.ToInt32(compare_txt.Text);
            //compare if the element is greater than the compare number add 10 or minus 5
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >= compare)
                {
                    array[i] += 10;
                }
                else
                {
                    array[i] -= 5;
                }
            }
            string arrayString = "";
            for (int i = 0; i < array.Length; i++)
            {
                arrayString += "Elment " + i + "=" + array[i] + " \n";
            }
            element_after_lvl.Text = arrayString;

        }
    }
}
