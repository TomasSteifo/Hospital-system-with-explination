namespace Hospital_system
{
    public class Program
    {
        public static void Main()
        {
            // Create hospital
            Hospital hospital = new Hospital("TomTom is the best hospital");

            // Create department
            Department cardiology = new Department("Cardiology");
            hospital.AddDepartment(cardiology);

            // Create doctor and nurse
            Doctor doctor = new Doctor("Dr. Love", new List<string> { "Heart healer", "Cardiology" });
            Nurse nurse = new Nurse("Sydney Sweeney");

            // Create patient
            Patient patient = new Patient("Karl johansson");
            patient.Journal.AddDiagnosis("Broken heart");
            patient.Journal.AddTreatment("5 shots of vodka");

            // Add doctor, nurse, and patient to the department
            cardiology.AddDoctor(doctor);
            cardiology.AddNurse(nurse);
            cardiology.AddPatient(patient);

            // Print information
            doctor.Info();
            nurse.Info();
            patient.Info();
        }
    }
}
    