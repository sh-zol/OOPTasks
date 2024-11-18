using TransactionConsole.Model;

namespace TransactionConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool flg = true;
            while (flg)
            {
                Console.WriteLine("1.Credit card payment");
                Console.WriteLine("2.Paypal Type");
                Console.WriteLine("3.Exit");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch(choice)
                {
                    case 1:
                        CardPay cardPay = new();
                        cardPay.Transaction();
                        break;
                    case 2:
                        PayPal payPal = new();
                        payPal.Transaction();
                        break;
                    case 3:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("enter the right command!");
                        break;

                }
            }
        }
    }
}
