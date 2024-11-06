namespace Amusement_park
{
    public class Customer
    {
        static int id=0;
        public int Id { get; set; }

        public string Tz{ get; set; }

        public string Name{get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public string Password { get; set; }

        public DateTime DateRegistration { get; set; }

        public int Points { get; set; }

        public string CustomerType { get; set; }

        public Customer(Customer c)
        {
            Id = id;
            id++;
            Tz = c.Tz;
            Name = c.Name;
            Email = c.Email;
            Phone = c.Phone;
            Password = c.Password;
            DateRegistration = c.DateRegistration;
            Points = c.Points;
            CustomerType = c.CustomerType;
        }
        public Customer()
        {
            
        }

        public Customer(int idFromBody,Customer c)
        {
            Id = idFromBody;
            Tz = c.Tz;
            Name = c.Name;
            Email = c.Email;
            Phone = c.Phone;
            Password =c.Password;
            DateRegistration =c.DateRegistration;
            Points = c.Points;
            CustomerType = c.CustomerType;
        }

        public Customer(string tz, string name, string email, string phone, string password, DateTime dateRegistration, int points, string customerType)
        {
            Id = id;
            id++;  
            Tz = tz;
            Name = name;
            Email = email;
            Phone = phone;
            Password = password;
            DateRegistration = dateRegistration;
            Points = points;
            CustomerType = customerType;
        }
    }
}

