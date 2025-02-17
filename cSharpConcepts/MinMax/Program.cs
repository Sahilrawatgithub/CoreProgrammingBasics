using System;

 class MinMax
{
       static void Main(string[] args)
    {
        Console.Write("Give the size of the array: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = new int[n];

        Console.WriteLine("Enter the array elements:");

        for (int i = 0; i < n; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        int max = arr[0];
        int min = arr[0];

        foreach (int i in arr)
        {
            if (i > max)
            {
                max = i;
            }

            if (i < min)
            {
                min = i;
            }
        }

        Console.WriteLine($"Maximum value: {max}");
        Console.WriteLine($"Minimum value: {min}");
    }
}

