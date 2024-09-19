
using System.Xml.Linq;

namespace Hospital_system
{   // Base class for all the persons within the hospital (Doctors, Nurses patients etc )
    public class Person
    {
        public string Name { get; set; }

        public Person(string name)
        {
            Name = name;
        }

        public virtual void Info()
        {
            Console.WriteLine($"Name: {Name}");
        }
    }
}




