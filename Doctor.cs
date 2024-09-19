using Hospital_system;
using System.Xml.Linq;

namespace Hospital_system
{// Doctor class ärver From person and have spefici attributes and mwthods for doctors 

    public class Doctor : Person
    {
        public List<string> Specializations { get; set; }

        public Doctor(string name, List<string> specializations) : base(name)
        {
            Specializations = specializations;
        }

        public void ProvideTreatment(string treatment)
        {
            Console.WriteLine($"{Name} is providing treatment: {treatment}");
        }

        public override void Info()
        {
            base.Info();
            Console.WriteLine("Specializations: " + string.Join(", ", Specializations));
        }
    }
}

