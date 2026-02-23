namespace _02_StackSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var stack = new Stack<int>();

            foreach(var  number in numbers)
            {
                stack.Push(number);
            }

            while (true)
            {
                string command = Console.ReadLine().ToLower();
                
                if (command == "end")
                {
                    break;
                }

                if(command.StartsWith("add"))
                {
                    var commandParts = command.Split(' ');
                    int firstNumber = int.Parse(commandParts[1]);
                    int secondNumber = int.Parse(commandParts[2]);

                    stack.Push(firstNumber);
                    stack.Push(secondNumber);

                }

                if(command.StartsWith("remove"))
                {
                    var commandParts = command.Split(' ');
                    int elements = int.Parse(commandParts[1]);

                    if (elements <= stack.Count)
                    {
                        for (int i = 0; i < elements; i++)
                        {
                            stack.Pop();
                        }
                    }
                }
            }
            
            Console.WriteLine(stack.Sum());

        }
    }
}
