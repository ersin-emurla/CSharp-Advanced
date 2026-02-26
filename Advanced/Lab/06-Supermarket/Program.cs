


var queue = new Queue<string>();    

while (true)
{
    string command = Console.ReadLine();

    if (command == "End")
    {

        Console.WriteLine($"{queue.Count} people remaining.");
        break;      
        
    }

    if (command == "Paid")
    {
        while (queue.Count > 0)
        {
            Console.WriteLine(queue.Dequeue());
        }

        

    }

    else
    {
        queue.Enqueue(command);
    }
}