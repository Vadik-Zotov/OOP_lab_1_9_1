using System;

namespace OOP_lab_1_9_1
{
    public class Program
    {
        public static int Reverse(char[] array)
        {
            for (int i = 0; i < array.Length / 2; ++i)
            {
                char c = array[i];
                array[i] = array[array.Length - 1 - i];
                array[array.Length - 1 - i] = c;
            }

            int a = int.Parse(array);

            return a;
        }

        static void Main()
        {
            Console.WriteLine(Reverse(Console.ReadLine().ToCharArray()));
        }
    }
}
