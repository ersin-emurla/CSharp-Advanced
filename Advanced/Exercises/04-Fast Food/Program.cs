int food = int.Parse(Console.ReadLine());




//option 1
Queue<int> orders = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));

//option 2
//int[] data = Console.ReadLine().Split().Select(int.Parse).ToArray();

//Queue<int> orders = new Queue<int>();
//foreach (int el in data) orders.Enqueue(el);

int biggestOrder = orders.Max();
while (orders.Count > 0)
{
    if (food >= orders.Peek())
        food -= orders.Dequeue();     //break
    else                              //food -= orders.Dequeue(); --> bez "else" :-)
        break;
}

Console.WriteLine(biggestOrder);

if (orders.Count == 0) Console.WriteLine("Orders complete");
else Console.WriteLine($"Orders left: {string.Join(' ', orders)}"); 

