namespace Exercise_4
{
    public partial class Form1 : Form
    {
        private int counterValue = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Space)
            {
                counterValue++;
            }

            if (e.KeyData == Keys.R)
            {
                counterValue = 0;
            }
            counter.Text = counterValue.ToString();
        }

    }
}
