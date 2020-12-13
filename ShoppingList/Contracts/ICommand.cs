using ShoppingList.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingList.Commands
{
    public interface ICommand
    {
        void Execute(Stack<IceCream> order, IceCream newIceCream);
    }
}
