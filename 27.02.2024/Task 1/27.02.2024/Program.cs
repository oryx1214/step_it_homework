class Program
{
    public static void CountAndSave()
    {
        
        FileStream fileStream = new FileStream("HomeWork.txt", FileMode.Create);
        StreamWriter streamWriter = new StreamWriter(fileStream);

        Random r = new Random();
        List<int> ints = new List<int>();

        for (int i = 0; i < 10; i++)
        {
            ints.Add(r.Next(1, 9));
        }

        streamWriter.WriteLine("Numbers :");
        foreach (int item in ints)
        {
            streamWriter.Write($"{item}");
        }

        streamWriter.Close();
        fileStream.Close();
    }

    public static void CountPlusСouple()
    {

        FileStream fileStream1 = new FileStream("HomeWork.txt", FileMode.Open);
        StreamReader streamReader = new StreamReader(fileStream1);

        string allNumber = streamReader.ReadToEnd();

        streamReader.Close();
        fileStream1.Close();

        using FileStream fileStream2 = new FileStream("HomeWork.txt", FileMode.Append);


        StreamWriter streamWriter = new StreamWriter(fileStream2);

        streamWriter.WriteLine("\n\nCoupled Number (+):");
        for (int i = 0; i < allNumber.Length; i++)
        {
            if (i == allNumber.Length - 1)
            {
                break;
            }

            if (allNumber[i] >= 48 && allNumber[i] <= 57 && allNumber[i + 1] >= 48 && allNumber[i + 1] <= 57)
            {
                streamWriter.Write((allNumber[i] - 48) + ((allNumber[i + 1] - 48)));
                i += 1;
            }
        }
        
        streamWriter.Close();
        fileStream2.Close(); 
    }


    public static void CountMulptipleCouple()
    {
        FileStream fileStream1 = new FileStream("HomeWork.txt", FileMode.Open);
        StreamReader streamReader = new StreamReader(fileStream1);

        string allNumber = streamReader.ReadToEnd();

        streamReader.Close();
        fileStream1.Close();

        using FileStream fileStream2 = new FileStream("HomeWork.txt", FileMode.Append);


        StreamWriter streamWriter = new StreamWriter(fileStream2);

        streamWriter.WriteLine("\n\nCoupled Number (*):");

        int StopCount = 0;

        for (int i = 0; i < allNumber.Length; i++)
        {
            if (StopCount == 2) break; 
            

            if (allNumber[i] == ' ' ) StopCount++;

            if (allNumber[i] >= 48 && allNumber[i] <= 57 && allNumber[i + 1] >= 48 && allNumber[i + 1] <= 57)
            {
                streamWriter.Write((allNumber[i] - 48) * ((allNumber[i + 1] - 48)));
                i += 1;
            }
        }
        
        streamWriter.Close();
        fileStream2.Close(); 
    }


    public static void Main(string[] args)
    {
        using var countDownEvent = new CountdownEvent(3);

        Thread thread1 = new(c =>
        {
            CountAndSave();
            Console.WriteLine("Counted and Saved ");


            countDownEvent.Signal();

        });
       


        Thread thread2 = new(c =>
        {
            CountMulptipleCouple();
            Console.WriteLine("Counted with Multiple ");

            countDownEvent.Signal();

        });


        Thread thread3 = new(c =>
        {
            CountPlusСouple();
            Console.WriteLine("Counted with Plus ");

            countDownEvent.Signal();

        });

        thread1.Start();
        Thread.Sleep(1000); 


        thread2.Start();
        Thread.Sleep(1000);


        thread3.Start();

        countDownEvent.Wait();
        Console.WriteLine("End of main");
    }

}