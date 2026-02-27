
using System.Runtime.ExceptionServices;

internal class Program
{
       static void Main(string[] args)

       {

        int[] parameters = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int n = parameters[0], s = parameters[1], x = parameters[2];

        Stack<int> stack = new Stack<int>();

        int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

        for (int i = 0; i < n; i++)
        {
            stack.Push(numbers[i]);
      
        }

        for (int i = 0; i < s ; i++)
        {
            stack.Pop();
        }

        if (stack.Count == 0)
        {
            Console.WriteLine(0);
        }

        else if (stack.Contains(x)) 
        {
            Console.WriteLine("true");
        }

        else
        {
            Console.WriteLine(stack.Min());
        }
        
       }
}

