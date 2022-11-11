namespace assignment5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calAvg_Click(object sender, EventArgs e)
        {
            var number1 = (float)Convert.ToDouble(num1_tbox.Text);
            var number2 = (float)Convert.ToDouble(num2_tbox.Text);
            var number3 = (float)Convert.ToDouble(num3_tbox.Text);

            var average = (float)(number1 + number2 + number3) / 3.00;

            avg_lvl.Text = average.ToString();

        }
    }
}