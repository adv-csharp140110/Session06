using Session06.Model;

namespace Session06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAddCountry_Click(object sender, EventArgs e)
        {
            using (var contex = new AppDbContext()) {
                var model = new Country { Name = "Iran" };
                contex.Countries.Add(model);
                contex.SaveChanges();
            }
            MessageBox.Show("🚀");
        }
    }
}