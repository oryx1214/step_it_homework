class Program
{

	static void Main(string[] args)
	{
		Random random = new Random();
		int waiter = random.Next(10,25);

		using CountdownEvent countdownEvent = new CountdownEvent(3);


        Thread Bus1 = new(() =>
		{

			int Passenger = 4;
			int Capacity = 10;
			Console.WriteLine($"At the bus station are : {waiter} waiter \nFirst \"175\" bus is here\n Max Capacity : {Capacity} \n Passenger now : {Passenger}  ");
			for (int i = 0; i <= waiter; i++)
			{
				if (Passenger + waiter - i <= Capacity)
				{
					Passenger += waiter - i;
					waiter -= waiter - i;
				}
			}

			Console.WriteLine($"First Bus is going away \n Passenger now : {Passenger}\n waiters at the station : {waiter}");

            countdownEvent.Signal();
		}

		);
		Thread Bus2 = new(() => 
		{
			int Passenger = 7;
			int Capacity = 10;

            Console.WriteLine($"At the bus station are : {waiter} waiter \nSecond \"175\" bus is here\n Max Capacity : {Capacity} \n Passenger now : {Passenger}  ");
            for (int i = 0; i <= waiter; i++)
            {
                if (Passenger + waiter - i <= Capacity)
                {
                    Passenger += waiter - i;
                    waiter -= waiter - i;
                }
            }

            Console.WriteLine($"Second Bus is going away \n Passenger now : {Passenger}\n waiters at the station : {waiter}");

            countdownEvent.Signal();
        });
		Thread Bus3 = new(() => 
		{
			int Passenger = 2;
			int Capacity = 10;

            Console.WriteLine($"At the bus station are : {waiter} waiter \nThird \"175\" bus is here\n Max Capacity : {Capacity} \n Passenger now : {Passenger}  ");
            for (int i = 0; i <= waiter; i++)
            {
                if (Passenger + waiter - i <= Capacity)
                {
                    Passenger += waiter - i;
                    waiter -= waiter - i;
                }
            }

            Console.WriteLine($"Third Bus is going away \n Passenger now : {Passenger}\n waiters at the station : {waiter}");

	

            countdownEvent.Signal();
        });

        Bus1.Start();
        Console.WriteLine("1");
        Bus2.Start();
        Console.WriteLine("2");
        Bus3.Start();
        Console.WriteLine("3");

        countdownEvent.Wait();
        Console.WriteLine("\n\nEnd of main");
    }

}
