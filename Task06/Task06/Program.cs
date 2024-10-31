namespace Task06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //5 elementiani masivis shekmna 
            int[] arr = new int[5];

            // ricxvebis sheyvana
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Enter Numbers: ");
                int num = int.Parse(Console.ReadLine());
                arr[i] = num;
            }

            // indeqsis sheyvana
            Console.WriteLine("Now enter index: ");
            int index = int.Parse(Console.ReadLine());

            // shedegis dabechdva
            Console.WriteLine("Shedegi: " + CalculateNumberSum(arr, index));


        }

        static int CalculateNumberSum(int[] array, int idx) //axali metodi
        {
            int n = 0;

            {
                n = array[idx]; // rac unda davamushavot
            }

            int result = 0;

            while (true)
            {
                if (n == 0)
                {
                    break;
                }

                result += n % 10;
                n /= 10;
            }

            return result;
        }

    }
}

