using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustomerProject.Models;


namespace CustomerProject.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            IList<Customer> customer = new List<Customer>();
            {
                customer.Add(new Customer() { CustomerID =1234, CustomerName="Srihari", CustomerAddress="Hyd"});
                customer.Add(new Customer() { CustomerID = 567, CustomerName = "Srikanth", CustomerAddress = "KMM" });
                customer.Add(new Customer() { CustomerID = 852, CustomerName = "Venkatesh", CustomerAddress = "SRPT" });

                ViewData["customer"] = customer;

            }
            return View();
        }
    }
}
