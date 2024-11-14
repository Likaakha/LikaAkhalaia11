namespace Task10
{
    public class Fraction
    {
        private int _numerator;
        private int _denominator;

        public Fraction(int numerator, int denominator)
        {
            if (denominator == 0)
            {
                Console.WriteLine("0-ze gayofa ar sheidzleba");

            }
            else
            {
                _numerator = numerator;
                _denominator = denominator;
            }
        }

        public override string ToString()
        {
            return $"{_numerator}/{_denominator}";
        }

        public static Fraction operator +(Fraction f1, Fraction f2)
        {
            int numerator = f1._numerator * f2._denominator + f2._numerator * f1._denominator;
            int denominator = f1._denominator * f2._denominator;
            return new Fraction(numerator, denominator);
        }

        public static bool operator ==(Fraction f1, Fraction f2)
        {
            return f1._numerator * f2._denominator == f2._numerator * f1._denominator;
        }

        public static bool operator !=(Fraction f1, Fraction f2)
        {
            return !(f1 == f2);
        }

        public override int GetHashCode()
        {
            return (_numerator, _denominator).GetHashCode();
        }

    }

    //Examples:
    class Program
    {
        static void Main()
        {
            //Example 1:
            Fraction f1 = new Fraction(3, 5);
            Fraction f2 = new Fraction(1, 4);

            Fraction sum = f1 + f2;
            Console.WriteLine($"Sum: {sum}"); // Output: 17/20

            Console.WriteLine(f1 == f2); // Output: False
            Console.WriteLine(f1 != f2); // Output: True


            ////Example 2:
            //Fraction f1 = new Fraction(3, 5);
            //Fraction f2 = new Fraction(6, 10);

            //Fraction sum = f1 + f2;
            //Console.WriteLine($"Sum: {sum}"); // Output: 6/5 tumca radganac shekveca ar gvaqvs 60/50

            //Console.WriteLine(f1 == f2); // Output: True
            //Console.WriteLine(f1 != f2); // Output: False
        }
    }
}
