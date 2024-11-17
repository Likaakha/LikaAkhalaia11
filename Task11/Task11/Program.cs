using System.Data;

namespace Task11
{

    //Task N1
    class Counter
    {

        public static int Count = 0;

        public Counter()
        {
            Count++;
        }

        public static int GetCount()
        {
            return Count;
        }

        public static void ResetCount()
        {
            Count = 0;
        }
    }

    // orive davalebis "Main" -metods qvemot davcer, ertad rom sheidzlebodes gashveba
    // da ak komentarad chavsvam agkmadi rom iyos 

    //class Program 
    //{
    //    static void Main(string[] args)
    //    {
    //        // Creating Counter objects
    //        Console.WriteLine("first Counter object:");
    //        Counter counter1 = new Counter();
    //        Console.WriteLine($"count1: {Counter.GetCount()}");

    //        Console.WriteLine("second Counter object:");
    //        Counter counter2 = new Counter();
    //        Console.WriteLine($"count2: {Counter.GetCount()}");

    //        Console.WriteLine("third Counter object:");
    //        Counter counter3 = new Counter();
    //        Console.WriteLine($"count3: {Counter.GetCount()}");

    //        // Reset the count to 0
    //        Console.WriteLine("Resetting count:");
    //        Counter.ResetCount();
    //        Console.WriteLine($"Count after reset: {Counter.GetCount()}");

    //    }
    //}


    //Task N2

    static class MathHelper
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static int Subtract(int a, int b)
        {
            return a - b;
        }

        public static int Multiply(int a, int b)
        {
            return a * b;
        }

        public static double Divide(int a, int b)
        {
            if (b == 0)
            {
                Console.WriteLine("Division by 0 is not allowed");
            }

            return (double)a / b;
        }

        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine($"Addition: {MathHelper.Add(5, 3)}");
                Console.WriteLine($"Subtraction: {MathHelper.Subtract(9, 5)}");
                Console.WriteLine($"Multiply: {MathHelper.Multiply(5, 3)}");
                Console.WriteLine($"Allowed Division: {MathHelper.Divide(25, 5)}");
                Console.WriteLine($"Not Allowed Division: {MathHelper.Divide(25, 0)}");

                //Task N1

                //Creating Counter objects
                Console.WriteLine("first Counter object:");
                Counter counter1 = new Counter();
                Console.WriteLine($"count1: {Counter.GetCount()}");

                Console.WriteLine("second Counter object:");
                Counter counter2 = new Counter();
                Console.WriteLine($"count2: {Counter.GetCount()}");

                Console.WriteLine("third Counter object:");
                Counter counter3 = new Counter();
                Console.WriteLine($"count3: {Counter.GetCount()}");

                // Reset the count to 0
                Console.WriteLine("Resetting count:");
                Counter.ResetCount();
                Console.WriteLine($"Count after reset: {Counter.GetCount()}");
            }
        }

    }


}
