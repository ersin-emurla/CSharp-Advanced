namespace _03_Sumple_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var tokens = Console.ReadLine().Split().Reverse().ToArray();

            var stack = new Stack<string>(tokens);

            bool isAddition = true;

            int sum = 0;

            while(stack.Count > 0)
            {
                var currenToken = stack.Pop();

                if (currenToken == "+")
                {
                    isAddition = true ;
                }
                else if(currenToken == "-")
                {
                    isAddition = false ;
                }
                else
                {
                    int number = int.Parse(currenToken);

                    if(!isAddition )
                    {
                        number *= -1;
                    }

                    sum += number;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
