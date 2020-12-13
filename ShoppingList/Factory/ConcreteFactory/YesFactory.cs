﻿using ShoppingList.Contracts;
using ShoppingList.Payment;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingList.Factory.ConcreteFactory
{
    public class YesFactory : SizeFactory
    {
        public override ISize GetSize(string sizeType)
        {
            if (sizeType.ToLower() == "smal")
            {
                return new Smal();
            }
            else if (sizeType.ToLower() == "big")
            {
                return new Big();
            }

            return null;
        }
    }
}
