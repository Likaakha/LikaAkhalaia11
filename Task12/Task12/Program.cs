namespace Task12
{
  
//Step 1
    public class Box<T>
    {
        private T value;

        public void SetValue(T newValue)
        {
            value = newValue;
        }

        public T GetValue()
        {
            return value;
        }
    }

//Step 2
    public static class Utility
    {
        public static int GetListCount<T>(List<T> list)
        {
            return list.Count;
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            // Box<T> (int)
            Box<int> intBox = new Box<int>();
            intBox.SetValue(55);
            Console.WriteLine($"Box<int> value: {intBox.GetValue()}");

            // Box<T> (string)
            Box<string> stringBox = new Box<string>();
            stringBox.SetValue("Merry Christmas and Happy new Year");
            Console.WriteLine($"Box<string> value: {stringBox.GetValue()}");

            // Utility method (List<int>)
            List<int> intList = new List<int> { 3, 5, 7, 10, 15 };
            Console.WriteLine($"List<int> count: {Utility.GetListCount(intList)}");

            // Utility method (List<string>)
            List<string> stringList = new List<string> { "Lika", "Nika", "Giga", "Keti" };
            Console.WriteLine($"List<string> count: {Utility.GetListCount(stringList)}");
        }
    }
}
