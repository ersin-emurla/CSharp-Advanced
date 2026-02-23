using System.Security.Cryptography.X509Certificates;

namespace _1._Reverse_a_String
{
    internal class Program
    {


        static void Main(string[] args)
        {

            string text = Console.ReadLine();

            Stack<char> stack = new Stack<char>();

            foreach (char symbol in text)
            {
                stack.Push(symbol);
            }

            while (stack.Count > 0)
            {
                var symbol = stack.Pop();
                Console.Write(symbol);
            }
        }
    }
}
