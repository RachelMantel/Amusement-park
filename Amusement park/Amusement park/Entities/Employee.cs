namespace Amusement_park
{
    public class Employee
    {
        static int id=0;

        public string Tz { get; set; }
        public int Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public string Role { get; set; }

        public int Seniority { get; set; }

        public double Salary { get; set; }

        public int WorkingHours { get; set; }

        public bool Status { get; set; }

        public Employee(Employee e)
        {
            this.Id = id;
            id++;
            Tz = e.Tz;
            Name = e.Name;
            Email = e.Email;
            Phone = e.Phone;
            Role = e.Role;
            Seniority = e.Seniority;
            Salary = e.Salary;
            WorkingHours = e.WorkingHours;
            Status = e.Status;
        }

        public Employee(int idFromBody,Employee e)
        {
            id=idFromBody;
            Tz = e.Tz;
            Name = e.Name;
            Email = e.Email;
            Phone = e.Phone;
            Role = e.Role;
            Seniority = e.Seniority;
            Salary = e.Salary;
            WorkingHours = e.WorkingHours;
            Status = e.Status;
        }

        public Employee()
        {
            
        }

    }
}
