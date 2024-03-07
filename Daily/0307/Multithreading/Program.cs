class Program {
    static void Main(string[] args) {
        Console.WriteLine("Program started");
        Console.WriteLine($"Thread no.: {Thread.CurrentThread.ManagedThreadId}");



        // Threads without input parameter
        Thread th1 = new Thread(Printer1);
        Thread th2 = new Thread(Printer2);



        // Threads with input parameter
        // Methods need to be wrapped using lambda function
        Thread t1 = new Thread(() => Printer(1));
        Thread t2 = new Thread(() => Printer(2));
        Thread t3 = new Thread(() => Printer(3));
        Thread t4 = new Thread(() => Printer(4));
        Thread t5 = new Thread(() => Printer(5));
        Thread t6 = new Thread(() => Printer(6));
        Thread t7 = new Thread(() => Printer(7));
        Thread t8 = new Thread(() => Printer(8));
        Thread t9 = new Thread(() => Printer(9));
        Thread t10 = new Thread(() => Printer(10));



        // Threads with return value
        // Methods need to be wrapped using lambda function
        int result = 0;
        Thread tv1 = new Thread(() => result = Printer3(1));
        Thread tv2 = new Thread(() => result = Printer3(result));



        // Threads that return exception
        // Needs to be handled by try/catch in lambda function
        Thread te1 = new Thread(() => {
            try {
                ExceptionMaker();
            } catch (Exception e) {
                Console.WriteLine(e.Message);
            }
        });



        // Using Start enables the threads to start
        th2.Start();
        t1.Start();
        t2.Start();
        tv1.Start();
        t3.Start();
        t4.Start();
        t5.Start();
        th1.Start();

        Console.WriteLine("Main thread sleep");
        Thread.Sleep(1000);
        Console.WriteLine("Main thread wake up");

        t6.Start();
        t7.Start();
        tv2.Start();
        t8.Start();
        t9.Start();
        t10.Start();
        te1.Start();

        // Using Join makes sure that all threads have finished before ending the program
        // th2.Join();
        // t1.Join();
        // t2.Join();
        // tv1.Join();
        // t3.Join();
        // t4.Join();
        // t5.Join();
        // th1.Join();
        // t6.Join();
        // t7.Join();
        // tv2.Join();
        // t8.Join();
        // t9.Join();
        // t10.Join();
        // te1.Join();

        /**

            DON'T USE BELOW
            t1.Priority = ThreadPriority.Highest;
            // Leave the time slicing to be done automatically
            
            t1.Abort();
            // Kills the thread without safety. Can lead to corruption
        
        */
        
        Console.WriteLine("Program finished");
    }

    static void Printer(int num) {
        Console.WriteLine(num);
    }

    static void Printer1() {
        for(int i = 0; i < 100; i++) {
            Console.Write("+");
            if (i == 50) Console.WriteLine(i);
            if (i == 99) Console.WriteLine(i);
        }
    }
    static void Printer2() {
        for(int i = 0; i < 100; i++) {
            Console.Write("-");
            if (i == 50) Console.WriteLine(i);
            if (i == 99) Console.WriteLine(i);
        }
    }
    static int Printer3(int num) {
        Console.WriteLine("Printer 3");
        return num + 1;
    }
    static void ExceptionMaker() {
        Console.WriteLine("ExceptionMaker");
        throw new Exception();
    }
}