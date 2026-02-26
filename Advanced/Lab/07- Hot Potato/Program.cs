

using System.Threading.Channels;

var kids = Console.ReadLine().Split();

int n = int.Parse(Console.ReadLine());

var queue = new Queue<string>(kids);

while (queue.Count > 1)
{
    for (int i = 0; i < n - 1; i++)
    {
        var currentKid = queue.Dequeue();
        queue.Enqueue(currentKid);
    }

    Console.WriteLine($"Removed {queue.Dequeue()}");
}

Console.WriteLine($"Last is {queue.Dequeue()}");