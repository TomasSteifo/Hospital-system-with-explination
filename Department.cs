using System.Numerics;

namespace Hospital_system
{
    // Departments have doctors, nurses and patients 
    public class Department
    {
        public string Name { get; set; }
        public List<Doctor> DoctorList { get; set; }
        public List<Nurse> NurseList { get; set; }
        public List<Patient> PatientList { get; set; }

        public Department(string name)
        {
            Name = name;
            DoctorList = new List<Doctor>();
            NurseList = new List<Nurse>();
            PatientList = new List<Patient>();
        }

        public void AddDoctor(Doctor doctor)
        {
            DoctorList.Add(doctor);
        }

        public void AddNurse(Nurse nurse)
        {
            NurseList.Add(nurse);
        }

        public void AddPatient(Patient patient)
        {
            PatientList.Add(patient);
        }
    }

}



