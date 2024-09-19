using Hospital_system;

namespace Hospital_system
{
    public class Patient : Person
    {
        public MedicalJournal Journal { get; set; }

        public Patient(string name) : base(name)
        {
            Journal = new MedicalJournal();
        }

        public override void Info()
        {
            base.Info();
            Console.WriteLine($"Medical Journal: {Journal.ToString()}");
        }
    }
}
