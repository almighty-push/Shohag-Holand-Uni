namespace assignment4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calVat_Click(object sender, EventArgs e)
        {
            var price = double.Parse(price_box.Text);
            var vat = Math.Round((price /100) * 21.00,2);
            var total = Math.Round(price + vat,2);
            price_lvl.Text = price.ToString();
            vat_lvl.Text = vat.ToString();
            total_lvl.Text = total.ToString();
            
        }
    }
}