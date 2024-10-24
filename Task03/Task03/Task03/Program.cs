using System.ComponentModel.Design;

internal class Program
{
    private static void Main(string[] args)
    {

        Random random = new Random();
        int randomNumber1 = random.Next(1, 10);
        int randomNumber2 = random.Next(1, 10);
        int randomNumber3 = random.Next(1, 10);

        Console.WriteLine("Enter your first number:");
        int a = int.Parse(Console.ReadLine());

        // Check the first number
        if (a == randomNumber1)
        {
            Console.WriteLine("True! First number matched.");
            Console.WriteLine("Random Number was:" + randomNumber1); // double-checking
        }
        else
        {
            Console.WriteLine("Enter your second number:");
            int b = int.Parse(Console.ReadLine());

            // Check the second number
            if (b == randomNumber2)
            {
                Console.WriteLine("True! Second number matched.");
                Console.WriteLine("Random Number was:" + randomNumber2); //double-checking
            }
            else
            {
                Console.WriteLine("Enter your third number:");
                int c = int.Parse(Console.ReadLine());

                // Check the third number
                if (c == randomNumber3)
                {
                    Console.WriteLine("True! Third number matched.");
                    Console.WriteLine("Random Number was:" + randomNumber3); //double-checking
                }
                else
                {
                    Console.WriteLine("False! None of your numbers matched.");
                }
            }
        }

        // Check again
        //string sp = ", ";
        //Console.WriteLine("Random Numbers: " + randomNumber1 + sp + randomNumber2 +sp + randomNumber3);

        //kitxva: Check again-istvis avige 3-ve rendom chawerili ricxvi, rom davrcmunebuliyavi, namdvilad scorad adarebda dacerili kodi, 
        //tumca kitxva gamichnda, radganac samive ricxvs mibechdavs nishnavs imas, rom miuxedavad scori pasuxisa, meramdenec ar unda yofiliyo,
        //mainc gadioda samive rendom ricxvis dagenerirebas?



    }
}

