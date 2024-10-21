namespace CarConcept
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CCar car = new();
            char decision;
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("1.Make your Car");
                Console.WriteLine("2.Exit");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch(choice)
                {
                    case 1:
                        Console.WriteLine("Name of the car:");
                        car.Name = Console.ReadLine();
                        Console.WriteLine("Manufactured date:");
                        car.ManufacturedDate = Console.ReadLine();
                        Console.WriteLine("Color:");
                        car.Color = Console.ReadLine();
                        Console.WriteLine("Say something about your car(optional):");
                        car.Description = Console.ReadLine();
                        Console.WriteLine("do you want to start the car?(y/n)");
                        decision = Convert.ToChar(Console.ReadLine());
                        if(decision == 'y')
                        {
                            car.Start();
                        }
                        else
                        {
                            Console.WriteLine("your car is off");
                        }
                        break;
                    case 2:
                        Console.WriteLine("Goodbye!");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Enter the right Command!");
                        break;
                }
            }
        }
    }
}
