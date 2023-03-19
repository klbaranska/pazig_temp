using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ComputerWorldApp.Warehouse
{
    class Warehouse
    {
        //TODO:
        //- collection (correct the code) 
        //- interface (IEnumerable)

        private int _numOfElementa = 100;

        private Computer[] _stock = null;

        public int NumOfElements
        { get { return _stock.Length; } }

        public Warehouse()
        {
            _stock = new Computer[_numOfElementa];

            Generate();
        }

        private void Generate()
        {
            for (int i = 0; i < _numOfElementa; i++)
            {
                Computer computer = new Computer();
                _stock[i] = computer;
            }
        }

        public void Add(Computer computer)
        {
            //TODO:
            //- add
        }

        public void SortByProductCode()
        {
            //TODO:
            //- sort by ProductCode (default)
        }

        public void SortByCountry()
        {
            //TODO:
            //- sort by Country (use external comparator)
        }

        public void SortByPrice()
        {
            //TODO:
            //- sort by Price (use external comparator)
        }

        //TODO:
        //- indexer

        public override string ToString()
        {
            return string.Format("Warehouse: {0}", _stock.Length);
        }
    }
}