using System.Security.Cryptography.Xml;

namespace Week_8_Textboxes__labels__forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void moveBtn_Click(object sender, EventArgs e)
        {
            MoveButtonTemplate(actorBtn);
        }

        private void actorBtn_Click(object sender, EventArgs e)
        {
            MoveButtonTemplate(moveBtn);
        }

        void MoveButtonTemplate(Control btn)
        {
            Random random = new Random();
            int randomLeft = random.Next(0, this.ClientSize.Width - btn.Width);
            int randomTop = random.Next(0, this.ClientSize.Height - btn.Height);
            btn.Left = randomLeft;
            btn.Top = randomTop;
        }
    }
}
