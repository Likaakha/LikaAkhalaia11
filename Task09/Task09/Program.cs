using System.Security.Cryptography.X509Certificates;

namespace Task09
{
    public interface IAnimal
    {
        string MakeSound();
    }

    public abstract class Animal : IAnimal
    {

        public string Name { get; set; }
        public int Age { get; set; }

        public Animal(string name, int age)
        {
            Name = name;
            Age = age;

        }
        public abstract string MakeSound();

    }
    public class Dog : Animal
    {
        public Dog(string name, int age) : base(name, age) { } //base >>ar gagvivlia tumca rogorc davserche da vnaxe
                                                               //gamartivebuli forma iyo da amitomac agar davadublire Name=name, age=age

        public override string MakeSound()
        {
            return "WOOF";

        }

    }

    public class Cat : Animal
    {
        public Cat(string name, int age) : base(name, age) { } 
         

        public override string MakeSound()
        {
            return "Meow";
        }
    }

    public class Cow : Animal
    {
        public Cow(string name, int age) : base(name, age) { }

        public override string MakeSound()
        {
            return "Moo";
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            IAnimal[] animals = new IAnimal[]
            {
                new Dog("Jeka", 2),
                new Cat("Fiso", 7),  
                new Cow("Bochola", 3) 
            };

            foreach (var animal in animals)
            {
                Console.WriteLine($"{animal.GetType().Name} says: {animal.MakeSound()}");
            }
        }

    }

}
