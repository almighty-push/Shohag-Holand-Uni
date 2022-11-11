namespace assignment7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cal_btn_Click(object sender, EventArgs e)
        {
            var start_km = Convert.ToDouble(startkm_tbox.Text);
            var end_km = Convert.ToDouble(endkm_tbox.Text);
            var pricePerkm = Convert.ToDouble(pricePerkm_tbox.Text);

            var totalKm = (end_km - start_km);

            var totalCost = Math.Round( (totalKm * pricePerkm),2);

            //cost with vat
            var vat = Math.Round( (totalCost / 100) * 21.00,2);
            var costWithVat = Math.Round((totalCost + vat),2);

            priceExcVat.Text = totalCost.ToString();
            priceIncVat_lvl.Text = costWithVat.ToString();
            vat_lvl.Text = vat.ToString();




        }

        private void erase_btn_Click(object sender, EventArgs e)
        {
            pricePerkm_tbox.Text = "";
            startkm_tbox.Text = "";
            endkm_tbox.Text = "";
            
        }
    }
}