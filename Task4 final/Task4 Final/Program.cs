namespace Task4_Final
{


    internal class Program
    {


        static void Main(string[] args)
        {
            //1.Switch Case: Week Days
            //From 1 to 7, print weekdays, for other options negative status: "araswori ricxvi"

            int day = int.Parse(Console.ReadLine());

            switch (day)
            {
                case 1:
                    Console.WriteLine("orshabati");
                    break;
                case 2:
                    Console.WriteLine("samshabati");
                    break;
                case 3:
                    Console.WriteLine("otxshabati");
                    break;
                case 4:
                    Console.WriteLine("xutshabati");
                    break;
                case 5:
                    Console.WriteLine("paraskevi");
                    break;
                case 6:
                    Console.WriteLine("shabati");
                    break;
                case 7:
                    Console.WriteLine("kvira");
                    break;

                default:
                    Console.WriteLine("araswori ricxvi");
                    break;

            }



            //N2 While Loop: Sum of positive numbers
            int total = 0;

            Console.WriteLine("Enter positive numbers to continue, or enter a negative number to stop and see the total.");

            while (true)
            {
                Console.Write("Enter a number: ");
                int number = int.Parse(Console.ReadLine());

                if (number < 0)
                {
                    break;
                }

                total = total + number;
            }

            Console.WriteLine(total);



            //N3 For Loop: Multiplication table

            Console.Write("Enter a number: ");
            int numberN = int.Parse(Console.ReadLine());

            Console.WriteLine($"\nMultiplication table for {numberN}:");

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{numberN} x {i} = {numberN * i}");
            }

        }


    }



}
