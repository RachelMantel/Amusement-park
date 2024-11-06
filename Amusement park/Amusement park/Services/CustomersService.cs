using Microsoft.AspNetCore.Mvc;

namespace Amusement_park
{
    public class CustomersService
    {

        public List<Customer> Get()
        {
            return DataManager.dataContext.dataCustomers;
        }

        public Customer GetById(int id)
        {
            return DataManager.dataContext.dataCustomers.FirstOrDefault(x => x.Id == id);
        }
        public bool IsValidTz(string tz)
        {
            if (tz.Length != 9)
                return false;
            int sum = 0, i = 0, plus;
            while (i < tz.Length - 1)
            {
                if (tz[i] < '0' || tz[i] > '9')
                    return false;
                plus = tz[i] - '0';
                if (i % 2 == 1)
                    plus *= 2;
                if (plus > 9)
                    plus = plus / 10 + plus % 10;
                sum += plus;
                i++;
            }
            sum %= 10;
            if (10 - sum == tz[tz.Length - 1] - '0')
                return true;
            return false;
        }
        public bool Add(Customer customer)
        {
            if (IsValidTz(customer.Tz))
            {
                DataManager.dataContext.dataCustomers.Add(new Customer(customer));
                return true;
            }
            return false;
        }
        public bool Update(int id, Customer customer)
        {
            int index = DataManager.dataContext.dataCustomers.FindIndex(x => x.Id == id);
            if (index != -1 && IsValidTz(customer.Tz))
            {
                DataManager.dataContext.dataCustomers[index] = new Customer(id, customer);
                return true;
            }
            return false;
        }
        public bool Remove(int id)
        {
            return DataManager.dataContext.dataCustomers.Remove(DataManager.dataContext.dataCustomers.FirstOrDefault(x => x.Id == id));
        }

    }
}
