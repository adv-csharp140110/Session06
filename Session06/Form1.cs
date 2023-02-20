using Session06.Model;
using Session06.Repository;

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
            //CRUD+, Creat
            // Respository Pattern
            //using (var contex = new AppDbContext()) {
            //    var model = new Country { Name = "Iran" };
            //    contex.Countries.Add(model);
            //    contex.SaveChanges();
            //}

            ////var countryRepository = new CountryRepository();
            ////countryRepository.Create(new Country { Name = "Iran" });

            //var countryRepository = new GenericRepository<Country>();
            //var provinceRepository = new GenericRepository<Province>();

            //Country country = new Country { Name = "Iran" };
            //countryRepository.Create(country);

            //provinceRepository.Create(new Province { Name = "Tehran", CountryId = country.Id });
            //provinceRepository.Create(new Province { Name = "Shiraz", CountryId = country.Id });


            var repository = new GenericRepositoryNew();

            Country country = new Country { Name = "Iran" };
            repository.Create(country);
            //repository.Create<Country>(country);

            repository.Create(new Province { Name = "Tehran", CountryId = country.Id });
            repository.Create(new Province { Name = "Shiraz", CountryId = country.Id });

            MessageBox.Show("🚀");
        }
    }
}