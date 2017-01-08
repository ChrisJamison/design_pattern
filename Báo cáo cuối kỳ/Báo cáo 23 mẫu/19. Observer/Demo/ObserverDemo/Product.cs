using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDemo
{
    class Product : Observer
    {
        private string name;

        List<Customer> customers = new List<Customer>();        

        public Product(string name)
        {
            this.name = name;
        }

        public override void ObserverInfo()
        {
            foreach (Customer item in customers)
            {
                if (item != null)
                {
                    item.ObserverInfo();
                }
            }
        }

        public void AddCustomer(Customer cus) {
            if (cus != null)
            {
                this.customers.Add(cus);
            }
        }

        public void RemoveCustomer(Customer cus)
        {
            if (cus != null)
            {
                this.customers.Remove(cus);
            }
        }
    }
}
