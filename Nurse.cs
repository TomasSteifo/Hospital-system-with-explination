using Hospital_system;
using System.Numerics;
using System.Xml.Linq;

namespace Hospital_system
{
    public class Nurse : Person
    {
        public Nurse(string name) : base(name) { }

        public void CareForPatient(Patient patient)
        {
            Console.WriteLine($"{Name} is taking care of patient: {patient.Name}");
        }

        public void AssistDoctor(Doctor doctor)
        {
            Console.WriteLine($"{Name} is assisting doctor: {doctor.Name}");
        }

        public override void Info()
        {
            base.Info();
            Console.WriteLine("Role: Nurse");
        }
    }
}




