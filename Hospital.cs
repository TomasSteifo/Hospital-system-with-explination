

namespace Hospital_system
{
    //The hospital has diffrent departments 

    public class Hospital
    {
        public string Name { get; set; }
        public List<Department> Departments { get; set; }

        public Hospital(string name)
        {
            Name = name;
            Departments = new List<Department>();
        }

        public void AddDepartment(Department department)
        {
            Departments.Add(department);
        }
    }
}


