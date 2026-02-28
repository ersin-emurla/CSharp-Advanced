using System.Runtime.CompilerServices;

namespace _05_Fashion_Boutique;

public class Program
{
    static void Main(string[] args)
    {
        Stack<int> clothes = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));
        int capacity =int.Parse(Console.ReadLine());

        int racks = 0, free = 0;
        while (clothes.Count > 0)
        {
            int currentElements = clothes.Pop();

            if (free < currentElements)
            {
                racks++;
                free = capacity;
            }

            free -= currentElements;
        }

        Console.WriteLine(racks);
    }
}
