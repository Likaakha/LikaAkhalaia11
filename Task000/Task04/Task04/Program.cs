using System.Threading.Channels;
using static System.Runtime.InteropServices.JavaScript.JSType;

internal class Program
{
    private static void Main(string[] args)
    {


        //   1.Switch Case: Week Days
        //   From 1 to 7, print weekdays, for other options negative status: "araswori ricxvi"

        //int day = int.Parse(Console.ReadLine());

        //switch (day)
        //{
        //    case 1:
        //        Console.WriteLine("orshabati");
        //        break;
        //    case 2:
        //        Console.WriteLine("samshabati");
        //        break;
        //    case 3:
        //        Console.WriteLine("otxshabati");
        //        break;
        //    case 4:
        //        Console.WriteLine("xutshabati");
        //        break;
        //    case 5:
        //        Console.WriteLine("paraskevi");
        //        break;
        //    case 6:
        //        Console.WriteLine("shabati");
        //        break;
        //    case 7:
        //        Console.WriteLine("kvira");
        //        break;

        //    default:
        //        Console.WriteLine("araswori ricxvi");
        //        break;

        //}


        //        2.While Loop: დადებითი რიცხვების ჯამი

        //დაწერეთ პროგრამა, რომელიც while ციკლის გამოყენებით ითხოვს მომხმარებლისგან დადებითი რიცხვების შეყვანას. გააგრძელე რიცხვების დამატება, სანამ მომხმარებელი არ შეიყვანს უარყოფით რიცხვს. ამის შემდეგ დაბეჭდე ჯამი.

        //მაგალითად
        //// შეყვანილი რიცხვები: 5, 10, -1
        //// პასუხი: "ჯამი: 15"


        //int Number = int.Parse(Console.ReadLine());

        //while (Number > 0)
        //{
        //    if { Number

        //    }
        //    Console.WriteLine();
        //}




        int total = 0;
        Console.WriteLine("Введите положительные числа для сложения. Введите отрицательное число, чтобы завершить и увидеть сумму.");

        while (true)
        {
            Console.Write("Введите число: ");
            int number = Convert.ToInt32(Console.ReadLine());

            // Прерываем цикл, если введено отрицательное число
            if (number < 0)
            {
                break;
            }

            // Добавляем положительное число к общей сумме
            total += number;
        }

        // Выводим общую сумму
        Console.WriteLine($"Сумма: {total}");

        //int Sum = 0;
        //Console.WriteLine("Enter positive numbers to continue entering, to stop enter negative number");

        //while (true)
        //{

        //    int number = int.Parse(Console.ReadLine());

        //    if (number < 0)
        //    {
        //        Console.WriteLine("Number is negative");
        //        break;

        //    } number = Sum++;



        //}





        //for (int i=0; i<10; i++)
        //{
        //    Console.WriteLine(i);
        //}


        //int j = 0;
        //for (; j <=10; )
        //{
        //    Console.WriteLine(j);
        //    j = j = j + 2;
        //}

        //Console.WriteLine("Hello, World!");

        //int day = int.Parse(Console.ReadLine());
        //int weekday = day % 7;


        //Random random = new Random();
        //int randNumber = random.Next(1, 10);

        //while (true)
        //{
        //    Console.WriteLine("new number:");
        //    int num = int.Parse(Console.ReadLine());

        //    if (num == randNumber)
        //    {
        //        Console.WriteLine("bingo");
        //        break;
        //    } 
        //}



        //switch (weekday)
        //      {
        //          case 0:
        //          case 1:
        //          case 2:
        //              Console.WriteLine("kviris dge");
        //              break;
        //          case 5:
        //          case 6:
        //              Console.WriteLine("shabat-kvira");
        //              break;


        //      }


        //if (weekday == 0)
        //{
        //    Console.WriteLine("orshabati");

        //}
        //else if (weekday == 1)
        //{
        //    Console.WriteLine("samshabati");
        //}else if (weekday == 2)
        //{
        //    Console.WriteLine("otxshabati");
        //}else if (weekday == 6)
        //{
        //    Console.WriteLine("kvira");
        //}


        //if (weekday == 0)
        //{
        //    Console.WriteLine("orshabati");

        //}
        //else
        //{
        //    if (weekday == 1)
        //    {
        //        Console.WriteLine("samshabati");


        //    }
        //    else
        //    {
        //        if (weekday == 6)
        //        {
        //            Console.WriteLine("kvira");

        //        }
        //    }

        //}





    }
}