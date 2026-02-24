namespace _04_Matching_Brackets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string exporession = Console.ReadLine();

            var stack = new Stack<int>();

            for (int i = 0; i < exporession.Length; i++)
            {
                var symbol = exporession[i];

                if (symbol == '(')
                {
                    stack.Push(i);
                }

                else if (symbol == ')')
                {
                    var openingBracketIndex = stack.Pop();
                    var closingBracketIndex = i; 

                    var result = exporession.Substring(openingBracketIndex, closingBracketIndex - openingBracketIndex + 1);

                    Console.WriteLine(result);


                }
            }
        }
    }
}
