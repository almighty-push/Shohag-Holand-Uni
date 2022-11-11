namespace assignment8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void cal_btn_Click(object sender, EventArgs e)
        {
            const double tShartPrice = 30.00;
            const double jeansPrice = 100.00;
            const double vatp = 21.00;
            var tsharts = Convert.ToInt32(tshart_tbox.Text);
            var jeans = Convert.ToInt32(jeans_tbox.Text);

            var total = Math.Round((tsharts * tShartPrice) + (jeans * jeansPrice), 2);
            var vat = Math.Round((total / 100) * vatp, 2);

            date_lvl.Text = DateTime.Now.ToString("HH:mm:ss dd/MM/yyyy");
            price_lvl.Text = "€ " + total.ToString();
            vat_lvl.Text = "€ " + vat.ToString();
            total_price_lvl.Text = "€ " + (total + vat).ToString();


        }
    }
}