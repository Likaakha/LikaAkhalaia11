internal class Program
{
    static void Main(string[] args)
    {

        ////Task 1:

        //string[] students = new string[3];

        //for (int i = 0; i < students.Length; i++)
        //{
        //    string input = Console.ReadLine();
        //    students[i] = input;

        //}
        //for (int i = 0; i < students.Length; i++)
        //{
        //    Console.Write(students[i] + ", ");
        //}


        //Task N2

        int[,] grades = new int[3, 2];
        string[] studentNames = { " Lika", " Nika", " Vika " };

        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("Enter scores for" + studentNames[i] + ":");

            for (int j = 0; j < 2; j++)
            {
                Console.Write("Score for Subject" + (j + 1) + ": ");
                grades[i, j] = int.Parse(Console.ReadLine());
            }
        }

        Console.WriteLine("Student Grades:");

        for (int i = 0; i < 3; i++)
        {
            Console.Write(studentNames[i] + "- ");
            for (int j = 0; j < 2; j++)
            {
                Console.Write(grades[i, j] + "  ");
            }
            Console.WriteLine();



        }
    }
}
