namespace Task08
{
  
        public class Person
        {

            public Person(int age, string name)
            {
                Age = age;
                Name = name;
            }

            public int Age { get; set; }
            public string Name { get; set; }

        }

        internal class Program1
        {

            static void Main()
            {
                Person person1 = new Person(31, "Lika");

                ChangePerson(person1);
                Console.WriteLine(person1.Age + " " + person1.Name);
            }

            static void ChangePerson(Person p)
            {
                p.Age++;
                p.Name = "Nika";
            }
        }
    }



