using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingList.Commands
{
    public class UndoCommand : ICommand
    {
        public void Execute(Stack<IceCream> iceCreams, IceCream newIceCream = null)
        {
            iceCreams.Pop();
        }
    }
}
