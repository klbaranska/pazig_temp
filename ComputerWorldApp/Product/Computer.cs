using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerWorldApp
{
    public class Computer
    {
        //TODO:
        //- interface (IComparable)

        private static Random _random = new Random();
        private static string[] _countries = new string[] { "Polska", "Niemcy", "Czechy", "USA", "Anglia" };

        private double _price = 0;
        private string _country = null;
        private int _productCode = 0;

        public int ProductCode
        { get { return _productCode; } }

        public string Country
        { get { return _country; } }

        public Computer()
        {
            _country = _countries[_random.Next(0, _countries.Length)];
            _price = _random.Next(0, 5000);
            _productCode = _random.Next(1000, 1100);
        }

        public double GetPrice()
        {
            return _price;
        }

        public override string ToString()
        {
            return string.Format("Computer #{0}: {1} PLN, {2}", _productCode, _price, _country );
        }
    }
}
