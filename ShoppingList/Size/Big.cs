using ShoppingList.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingList.Payment
{
    public class Big : ISize
    {
        public string Size()
        {
            return "Size: Big (Yes)";
        }
    }
}
