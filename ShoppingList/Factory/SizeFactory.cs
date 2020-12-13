using ShoppingList.Contracts;
using ShoppingList.Factory.ConcreteFactory;
using ShoppingList.Payment;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingList.Factory
{
    public abstract class SizeFactory
    {
        public abstract ISize GetSize(string sizeType);

        public static SizeFactory CreateSizeFactory(string factoryType)
        {
            if (factoryType.ToLower() == "no")
                return new NoFactory();

            return new YesFactory();
        }
    }
}
