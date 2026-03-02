

int n = int.Parse(Console.ReadLine());

var cars  = new Queue<string>();
    

int totalCars = 0;
while(true)
{
    string command = Console.ReadLine();

    if (command == "end")
    {
        break;
    }

    else if (command == "green")
    {
        for (int i = 0; i < n; i++)
        {
            if (cars.Any())
            {
                var currentCar = cars.Dequeue();
                Console.WriteLine($"{currentCar} passed!");

                totalCars++;
            }
        }
    }

    else
    {
        cars.Enqueue(command);
    }



}

Console.WriteLine($"{totalCars} cars passed the crossroads.");
