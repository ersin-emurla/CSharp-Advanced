using System.ComponentModel.Design;
using System.Runtime.CompilerServices;

namespace _02_Basic_Queue_Operations
{
    internal class Program
    {
        private const int maxValue = int.MaxValue;

        static void Main(string[] args)
        {
            int[] parameters = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int[] elements = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int n = parameters[0], s = parameters[1], x = parameters[2];

            var queue = new Queue<int>();

            for (int i = 0; i < n; i++)
            {
                queue.Enqueue(elements[i]);
            }

            for (int i = 0; i < s; i++)
            {
                queue.Dequeue();
            }

           

            bool num = false;

            foreach (int i in queue)
            {
                if (i == x)
                {
                    num = true;
                    break;
                }
                
            }

            if (num)
            {
                Console.WriteLine("true");
            }

            else if (queue.Count == 0)
            {
                Console.WriteLine(0);
            }

            else
            {
                int minnum = int.MaxValue;

                foreach (int i in queue)
                {
                    if (i < minnum)
                    {
                        minnum = i; 
                    }
                }
                Console.WriteLine(minnum);

            }

        }
    }
}
