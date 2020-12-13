using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingList.Commands
{
    public class ClearCommand : ICommand
    {
        public void Execute(Stack<IceCream> iceCreams, IceCream iceCream = null)
        {
            iceCreams.Clear();
        }
    }
}
