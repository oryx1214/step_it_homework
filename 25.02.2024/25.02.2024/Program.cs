using System.Threading;


#region ManualReset
//class Program
//{
//    private static ManualResetEvent _ManualResetEvent = new ManualResetEvent(false);

//    public static void Example()
//    {
//        string word = "Hello";

//        Mutex mutex = new Mutex();
    
//        mutex.WaitOne();

//        for (int i = 0; i < word.Length; i++) 
//        {
//            Console.WriteLine($"Letter : {word[i]} from Thread : {Thread.CurrentThread.ManagedThreadId} ");
//        }
//        mutex.ReleaseMutex();

//        _ManualResetEvent.Set();
    
//    }

//    public static void Main()
//    {

//        var mutex = new Mutex();

//        for (int i = 0; i < 2; i++)
//        {
//            ThreadPool.QueueUserWorkItem(
//            (p) =>
//            {
//                Example();
//            });
//        }

//        WaitHandle.WaitAll(new WaitHandle[]{_ManualResetEvent}); // Without this main will end before example will done


//        Console.WriteLine("End of main");
//    }
//}

#endregion



#region

class Program
{
    private static AutoResetEvent _AutoResetEvent = new AutoResetEvent(false);

    public static void Example()
    {
        string word = "Hello";

        Mutex mutex = new Mutex();

        mutex.WaitOne();

        for (int i = 0; i < word.Length; i++)
        {
            Console.WriteLine($"Letter : {word[i]} from Thread : {Thread.CurrentThread.ManagedThreadId} ");
        }
        mutex.ReleaseMutex();

        _AutoResetEvent.Set();

    }

    public static void Main()
    {

        var mutex = new Mutex();

        for (int i = 0; i < 2; i++)
        {
            ThreadPool.QueueUserWorkItem(
            (p) =>
            {
                Example();
            });
        }

        _AutoResetEvent.WaitOne();


        Console.WriteLine("End of main");
    }
}

#endregion