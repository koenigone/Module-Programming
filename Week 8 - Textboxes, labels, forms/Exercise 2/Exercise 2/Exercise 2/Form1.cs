namespace Exercise_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textbox_TextChanged(object sender, EventArgs e)
        {
            label.Text = textbox.Text;
        }

        private void label_Click(object sender, EventArgs e)
        {

        }
    }
}
