using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class CustomerBAL
    {
        public Customer GetCustomer()
        {
            Customer C = new Customer();
            C.CustomerName = "Raju";
            C.Address = "Bangalore";
            C.Age = 50;
            return C;
        }

    }
}