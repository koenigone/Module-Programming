namespace Exercise_3
{
    public partial class x : Form
    {
        public x()
        {
            InitializeComponent();
        }

        private void person1_Click(object sender, EventArgs e)
        {
            Person person1 = new Person();
            person1.name = "Koenig";
            person1.age = "23";
            person1.birthCountry = "saudi arabia";

            nameLabel.Text = person1.name;
            ageLabel.Text = person1.age;
            birthCountryLabel.Text = person1.birthCountry;
        }

        private void person2_Click(object sender, EventArgs e)
        {
            Person person2 = new Person();
            person2.name = "One";
            person2.age = "69";
            person2.birthCountry = "United Kingdom";

            nameLabel.Text = person2.name;
            ageLabel.Text = person2.age;
            birthCountryLabel.Text = person2.birthCountry;
        }
    }
}
