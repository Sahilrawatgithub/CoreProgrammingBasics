internal class Fibonacci
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter a number");
        int num=Convert.ToInt32(Console.ReadLine());
        int first = 0, second = 1,next;
        for(int i = 1; i <= num; i++)
        {
            Console.Write(first+" ");
            next = first + second;
            first = second;
            second = next;
        }
    }
}