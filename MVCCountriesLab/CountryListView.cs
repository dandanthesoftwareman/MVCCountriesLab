using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCCountriesLab
{
    internal class CountryListView
    {
        //Property
        public List<Country> Countries;
        //Constructor
        public CountryListView(List<Country> _countryList)
        {
            Countries = _countryList;
        }
        //Method
        public void Display()
        {

            for (int i = 0; i < Countries.Count; i++)
            {
                Console.WriteLine($"{i}: {Countries[i].Name}");
            }
        }
    }
}
