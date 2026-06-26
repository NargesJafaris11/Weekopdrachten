namespace Weekopdrachten.Opdracht24;

public static class Weekopdracht24
{
    private static readonly Mutex Mutex = new Mutex();

    public static void Run()
    {
        Console.Clear();
        Console.WriteLine("Weekopdracht 24: Queue met threads");
        Console.WriteLine();

        Console.WriteLine("ZONDER Mutex:");
        RunWithoutMutex();

        Console.WriteLine();
        Console.WriteLine("MET Mutex:");
        RunWithMutex();

        Console.WriteLine();
        Console.WriteLine("Druk op een toets...");
        Console.ReadKey();
    }

    private static void RunWithoutMutex()
    {
        Queue<string> queue = CreateQueue();

        List<Task> tasks = new()
        {
            Task.Run(() => ReadQueueWithoutMutex(queue, "Thread 1")),
            Task.Run(() => ReadQueueWithoutMutex(queue, "Thread 2")),
            Task.Run(() => ReadQueueWithoutMutex(queue, "Thread 3"))
        };

        Task.WaitAll(tasks.ToArray());
    }

    private static void RunWithMutex()
    {
        Queue<string> queue = CreateQueue();

        List<Task> tasks = new()
        {
            Task.Run(() => ReadQueueWithMutex(queue, "Thread 1")),
            Task.Run(() => ReadQueueWithMutex(queue, "Thread 2")),
            Task.Run(() => ReadQueueWithMutex(queue, "Thread 3"))
        };

        Task.WaitAll(tasks.ToArray());
    }

    private static Queue<string> CreateQueue()
    {
        Queue<string> queue = new Queue<string>();

        for (int i = 1; i <= 20; i++)
        {
            queue.Enqueue($"Item {i}");
        }

        return queue;
    }

    private static void ReadQueueWithoutMutex(Queue<string> queue, string threadName)
    {
        while (queue.Count > 0)
        {
            string item = queue.Peek();

            Thread.Sleep(10);

            if (queue.Count > 0)
            {
                queue.Dequeue();
                Console.WriteLine($"{threadName} leest {item}");
            }
        }
    }

    private static void ReadQueueWithMutex(Queue<string> queue, string threadName)
    {
        while (true)
        {
            Mutex.WaitOne();

            try
            {
                if (queue.Count == 0)
                {
                    break;
                }

                string item = queue.Dequeue();
                Console.WriteLine($"{threadName} leest {item}");
            }
            finally
            {
                Mutex.ReleaseMutex();
            }

            Thread.Sleep(10);
        }
    }
}