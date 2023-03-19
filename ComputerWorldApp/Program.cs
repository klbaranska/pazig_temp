using ComputerWorldApp.Shop.Supplier;
using System;

namespace ComputerWorldApp
{
    class Program
    {
        static void Main(string[] args)
        {
            /* ShopManager */
            // Konfiguracja sklepu
            ISupplier supplier = new xKom();

            // Utworzenie obiektu klasy reprezentującego sklep komputerowy
            Shop.ShopManager shopManager = new Shop.ShopManager(supplier);

            // Dodanie kolejnych zamównien
            shopManager.OrderComputer();
            shopManager.OrderComputer();
            shopManager.OrderComputer();

            // Odbiór produktu o id 10
            Computer c3 = shopManager.PickUpComputer(10);
            Console.WriteLine(c3);

            // Odbiór produktu o id 1
            Computer c4 = shopManager.PickUpComputer(1);
            Console.WriteLine(c4);

            /* Computer */
            // Porównanie dwóch produktów ze względu na ich 'ProductCode' 
            Computer c1 = new Computer();
            Computer c2 = new Computer();

            Console.WriteLine(c1);
            Console.WriteLine(c2);
            //Console.WriteLine("compare: " + c1.CompareTo(c2)); (NALEŻY ODKOMENTOWAĆ)

            /* Warehouse */
            // Utworzenie obiektu klasy reprezentującego magazyn
            Warehouse.Warehouse warehouse = new Warehouse.Warehouse();

            // Dodanie nowego produktu do magazynu
            warehouse.Add(new Computer());
            Console.WriteLine(warehouse);

            // Wykorzystanie indeksera (NALEŻY ODKOMENTOWAĆ)
            //int index = 2;
            //Console.WriteLine(warehouse[index]); // wyświetlenie informacji o danym produkcie
            //warehouse[index] = new Computer(); // nadpisanie danego produktu

            // Sortowanie ze względu na kraj pochodzenia produktu (NALEŻY ODKOMENTOWAĆ)
            //warehouse.SortByCountry();
            //foreach (var computer in warehouse)
            //{
            //    Console.WriteLine(computer);
            //}

            // Sortowanie ze względu na kod produktu (NALEŻY ODKOMENTOWAĆ)
            //warehouse.SortByProductCode();
            //foreach (var computer in warehouse)
            //{
            //    Console.WriteLine(computer);
            //}

            // Sortowanie ze względu na cenę (NALEŻY ODKOMENTOWAĆ)
            //warehouse.SortByPrice();
            //foreach (var computer in warehouse) 
            //{
            //    Console.WriteLine(computer);
            //}
        }
    }
}
 