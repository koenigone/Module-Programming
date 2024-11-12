namespace Exercise_5
{
    public partial class Form1 : Form
    {
        private int p1Counter = 0;
        private int p2Counter = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.A)
            {
                p1Counter++;
            }
            if (e.KeyData == Keys.L)
            {
                p2Counter++;
            }
            player1.Text = p1Counter.ToString();
            player2.Text = p2Counter.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void stopBtn_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }
    }
}
