﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingList.Commands
{
    public class CommandFactory
    {
        public static ICommand GetIceCream(int option)
        {
            switch (option)
            {
                case 1:
                    return new AddCommand();
                case 2:
                    return new RedoCommand();
                case 3:
                    return new UndoCommand();
                case 4:
                    return new ClearCommand();
                default:
                    return new AddCommand();
            }
        }
    }
}
