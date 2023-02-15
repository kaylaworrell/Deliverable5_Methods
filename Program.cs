using System;

namespace Deliverable5_Methods
{
    class Program
    {
        static int[] random(int length)
        {
            int[] array = new int[length];
            Random r = new Random();
            int i = 0;
            for (; i < length; i++) array[i] = r.Next(10, 50);
            return array;
        }
        static int sum(int[] array)
        {
            int i = 0, total = 0;
            for (; i < array.Length; i++) total += array[i];
            return total;
        }
        static void Main()
        {
            int length = -1;
            bool isValid = true;
            do
            {
                try
                {
                    length = Int32.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    isValid = false;
                    Console.WriteLine("Invalid Input!!");
                }
                if (isValid && (length < 5 || length > 15))
                    Console.WriteLine("Integer number must be between 5 and 15.");
                isValid = true;

            } while (!isValid || (length < 5 || length > 15));
            int[] array = random(length);
            Console.Write("The elements of the arrays are: ");
            int i = 0;
            for (; i < length; i++) Console.Write(array[i] + " ");
            Console.WriteLine();
            Console.WriteLine();
            int total = sum(array);
            Console.Write("The sum is: " + total);
        }
    }
}
