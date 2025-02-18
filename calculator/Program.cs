

namespace CalculatorProgram
{
    internal class Program
    {
        static int Add(int a, int b)
        {
            return a + b;
        }
        static int Subtract(int a, int b)
        {
            return a - b;
        }
        static int Multiply(int a, int b)
        {
            return a * b;
        }
        static int Divide(int a, int b)
        {
            return a / b;
        }
        static int Remainder(int a, int b)
        {
            return a % b;
        }
        static void Main(string[] args)
        {
            
            Console.WriteLine("Press the buttons according to what you need to calculate:");
            Console.WriteLine("Press 1 if Addition");
            Console.WriteLine("Press 2 if Subtraction");
            Console.WriteLine("Press 3 if Multiplication");
            Console.WriteLine("Press 4 if Division");
            Console.WriteLine("Press 5 if you want remainder");
            Console.WriteLine("Press 6 if you want to stop");
            while (true)
            {
                int result = 0;
                Console.Write("Enter first number: ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter second number: ");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Press any button:");
                int button = Convert.ToInt32(Console.ReadLine());
                if (button == 6)
                {
                    Console.WriteLine("Exiting Calculator");
                    break;
                }
                switch (button)
                {
                    case 1:
                        result = Add(a, b);
                        break;
                    case 2:
                        result = Subtract(a, b);
                        break;
                    case 3:
                        result = Multiply(a, b);
                        break;
                    case 4:
                        if (b == 0)
                        {
                            Console.WriteLine("Can't divide by zero");
                            break;
                        }
                        result = Divide(a, b);
                        break;
                    case 5:
                        if (b == 0)
                        {
                            Console.WriteLine("Can't divide by zero");
                            break;
                        }
                        result=Remainder(a, b);
                        break;
                    default:
                        Console.WriteLine("Invalid button. Please try again.");
                        break;
                }
                Console.WriteLine($"The result is: {result}");
                Console.WriteLine("Do you wish to continue (y/n)?");
                string? @continue = Console.ReadLine();
                if (@continue == "n" || @continue == "N")
                {
                    Console.WriteLine("Thank You For Using Our Calculator. GoodBye!");
                    break;
                }
            }
        }
    }
}