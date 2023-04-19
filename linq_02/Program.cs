using System.Text;

namespace Requests
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            int[] array = { 15, 24, 27, 12, 44, 12, 21, 108, 25, 33, 41 };
            Random random = new();

            var query = from i in array 
                        select i;

            Console.WriteLine("усі елементи джерела даних\nдо зміни певного значень:\n");
            foreach (int елемент in query)
                Console.WriteLine($"{елемент}");
            
            for (int i = 0; i < array.Length; i++)
            {
                if (random.Next(1, 3) == 2)
                    array[i] = random.Next(0, 99);
            }

            Console.WriteLine("\nусі елементи джерела даних\nпісля зміни певних значень:\n");
            foreach (int елемент in query)
                Console.WriteLine($"{елемент}\t");
            
        }
    }
}