using System;
using System.Collections.Generic;
using System.Text;

namespace ComputerWorldApp.Shop.Supplier
{
    public interface ISupplier
    {
        Computer Create(string json);
        Computer Create();
    }
}
