internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine("My name is Lika, and here is some information about myself:");

        byte b = 31; // Age
        Console.WriteLine("Age: " + b);

        string N = "01010101011";
        Console.WriteLine("ID: " + N);

        string Country = "Georgia";
        string City = "Tbilisi";
        string Address = "Iosebidze N123";
        short Zip = 1171;
        string comma = ", ";
        Console.WriteLine("Address: " + Country + comma + City + comma + Address + comma + Zip);

        float H = 1.7F; //Hight;
        Console.WriteLine("height: " + H + " meters");

        bool IsMarried = true;
        Console.WriteLine("Marital Status:" + IsMarried);

        String DC = "Debit Card";
        bool D = true;
        Console.WriteLine(DC + ":" + D);

        string NameC = "Account Number: ";
        string Iban = "CD";
        string code = "GE40";
        string codeF = "033000001111111";
        Console.WriteLine(NameC + code + Iban + codeF);


    }
}