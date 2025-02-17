internal class CheckPrime
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter a number");
        int num=Convert.ToInt32(Console.ReadLine());

        bool isPrime = num > 1;
        
        for(int i = 2; i * i < num; i++)
        {
            if (num % i == 0)
            {
                isPrime = false;
                break;
            }
            
        }

        if (isPrime)
        {
            Console.WriteLine(num + " is Prime");

        }
        else
        {
            Console.WriteLine(num + " is not Prime");
        }

    }
}