using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingList.Commands
{
    public class AddCommand : ICommand
    {
        public void Execute(Stack<IceCream> iceCreams, IceCream newIceCream)
        {
            iceCreams.Push(newIceCream);
        }
    }
}
