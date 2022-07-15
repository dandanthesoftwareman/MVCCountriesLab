using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCCountriesLab
{
    internal class CountryController
    {
        //Properties
        public List<Country> CountryDb = new List<Country>()
        {
            new Country("U.S.A", "North America"),
            new Country("Canada", "North America"),
            new Country("Mexico", "South America"),
            new Country("Brazil", "South America"),
            new Country("Germany", "Europe"),
            new Country("China", "Asia"),
            new Country("Egypt", "Africa")
        };

        //Methods
        public void CountryAction(Country c)
        {
            CountryView view = new CountryView(c);
            view.Display();
        }
        public void WelcomeAction()
        {
            CountryListView view = new CountryListView(CountryDb);
            Console.WriteLine("Hello, welcome to the country app. Please select a country from the following list:");
            view.Display();
            CountryAction(CountryDb[int.Parse(Console.ReadLine())]);
        }
    }
}
