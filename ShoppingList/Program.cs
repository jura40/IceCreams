using ShoppingList.Contracts;
using ShoppingList.Factory;
using System;

namespace ShoppingList
{
    class Program
    {
        static void Main(string[] args)
        {
            var user = new Customer();

            user.SetCommandOption(1 /*Add command*/);
            user.SetIceCream(new IceCream("Dining table", 1500, 2));
            user.RunCommand();

            user.SetCommandOption(1 /*Add command*/);
            user.SetIceCream(new IceCream("dishwasher", 6000, 3));
            user.RunCommand();
            user.ShowOrder();

            SetPayment("Chokolade", "MasterCard");

            user.SetCommandOption(2 /*Redo command*/);
            user.RunCommand();
            user.ShowOrder();

            SetPayment("Credit", "Visa");

            user.SetCommandOption(3 /*Undo command*/);
            user.RunCommand();
            user.ShowOrder();

            SetPayment("Debit", "Maestro");

            user.SetCommandOption(4 /*Clear command*/);
            user.RunCommand();
            user.ShowOrder();

            Console.ReadLine();
        }

        private static void SetPayment(string paymentType, string bankCard)
        {
            var type = SizeFactory.CreateSizeFactory(paymentType);
            var card = type.GetSize(bankCard);
            Console.WriteLine(card.Size() + "\n----------------------------------");
        }
    }
}
