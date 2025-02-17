using System;
using System.Globalization;
class ArmstrongNumber
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number");
        int num=int.Parse(Console.ReadLine());

        int sum = 0, temp = num, digits = num.ToString().Length;

        while (temp > 0)
        {
            int remainder = temp % 10;
            sum += (int)Math.Pow(remainder, digits);
            temp = temp / 10;
        }

        if (num == sum)
        {
            Console.WriteLine(num +" is an Armstrong Number");
        }
        else
        {
            Console.WriteLine(num + " is not Armstrong Number");
        }
    }
}