using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.Name = "Atakan";
            customer1.Surname = "Keçeci";


            Customer customer2 = new Customer();
            customer2.Id = 2;
            customer2.Name = "Mehmet";
            customer2.Surname = "Keçeci";

            Customer customer3 = new Customer();
            customer3.Id = 3;
            customer3.Name = "Sevilay";
            customer3.Surname = "Keçeci";


            
            Customer[] customers = new Customer[] { customer1,customer2,customer3};


            CustomerManager customermanager = new CustomerManager();
            //customermanager.Add(customer3);
            //customermanager.Delete(customer3);
            //customermanager.Show(customer1);
            customermanager.ShowasList(customers);
        }
    }
}
