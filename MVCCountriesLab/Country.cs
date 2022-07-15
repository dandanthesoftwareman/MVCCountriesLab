using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCCountriesLab
{
    internal class Country
    {
        //Properties
        public string Name { get; set; }
        public string Continent { get; set; }
        public List<string> Colors;
        
        public Country(string _name, string _continent)
        {
            Name = _name;
            Continent = _continent;
            
        }
    }
}
