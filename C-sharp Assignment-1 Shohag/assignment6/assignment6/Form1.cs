namespace assignment6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calcTime_Click(object sender, EventArgs e)
        {
            var seconds = Convert.ToInt32(sec_tbox.Text);
            //convert seconds to hh:mm:ss
            var hours = seconds / 3600;
            var minutes = (seconds % 3600) / 60;
            var secondsLeft = (seconds % 3600) % 60;
            //display hh:mm:ss
            hms.Text = hours + ":" + minutes + ":" + secondsLeft;
            
        }
    }
}