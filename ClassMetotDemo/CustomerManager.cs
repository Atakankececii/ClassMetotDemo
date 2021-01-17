using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        
       
    
        public void Add(Customer customer)
        {
            Console.WriteLine("Eklenen müşterinin adı :" + customer.Name +"\n"+"Eklenen müşterinin soyadı :"+customer.Surname);
           
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine("Silinen müşterinin adı :" + customer.Name + "\n" + "Silinen müşterinin soyadı :" + customer.Surname);

        }

        public void Show(Customer customer)
        {
            Console.WriteLine("Müşterinin Id numarası :"+customer.Id+"\n"+"Müşterinin adı:"+customer.Name+"\n"+"Müşterinin soyadı:"+customer.Surname);
        }

       
        public void ShowasList(Customer[] customers)
        {
            
            foreach (var customer in customers)
            {
                Console.WriteLine("Müşterinin adı : "+customer.Name+"\n"+"Müşterinin soyadı:"+customer.Surname+"\n"+"----------------");

            }
        }
    }
}
