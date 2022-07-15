using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCCountriesLab
{
    internal class CountryView
    {
        //Properties
        public Country DisplayCountry { get; set; }
        //Constructor
        public CountryView(Country _displayCountry)
        {
            DisplayCountry = _displayCountry;
        }
        //Method
        public void Display()
        {
            Console.WriteLine(DisplayCountry.Name);
            Console.WriteLine(DisplayCountry.Continent);
            foreach(string color in DisplayCountry.Colors)
            {
                Console.WriteLine(color);
            }
        }

    }
}
