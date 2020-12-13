using ShoppingList.Commands;
using ShoppingList.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingList
{
    /* The Receiver */
    public class Order
    {
        public Stack<IceCream> listOficeCreams { get; set; }

        public Order()
        {
            listOficeCreams = new Stack<IceCream>();
        }

        public void RunCommand(ICommand command, IceCream iceCream)
        {
            command.Execute(listOficeCreams, iceCream);
        }

        public void ShowCurrentIceCream()
        {
            foreach (var prod in listOficeCreams)
            {
                prod.DisplayIceCream();
            }

            if (!listOficeCreams.Any())
            {
                Console.WriteLine("\nEmpty shopping list :(\n");
            }

            Console.WriteLine("----------------------------------");
        }
    }
}