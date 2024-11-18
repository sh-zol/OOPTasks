using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransactionConsole.Model
{
    public class CardPay : Payment
    {
        public override void Transaction()
        {
            Console.WriteLine("enter your credit card number:");
            SenderCard = Console.ReadLine();
            Console.WriteLine("enter the reciever credit card number:");
            RecieverCard = Console.ReadLine();
            Console.WriteLine("enter the amount of funds:");
            Amount = Console.ReadLine();
            Console.WriteLine("enter your cvv2:");
            CVV2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"sender:{SenderCard}, reciever:{RecieverCard}, amount:{Amount}, cvv2:{CVV2}");
        }
    }
}
