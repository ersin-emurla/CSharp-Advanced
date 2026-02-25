namespace _05_Print_Even_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var queue = new Queue<int>(numbers);  
            var result =new List<int>();

          
      

            while (queue.Count > 0)
            {
                var number = queue.Dequeue();

                if (number % 2 == 0)
                {
                    result.Add(number);  
                }
            }

            Console.WriteLine(string.Join(", ", result));
        

        }
    }
}
