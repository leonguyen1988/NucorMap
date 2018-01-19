using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace myfirstWebApp.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public string GetAllCustomers()
        {
            return @"<ul>
                    <li>Ali Raza</li>
                    <li>Leo Nguyen</li>
                    <li>Tho Nguyen</li>
                        </ul>";
        }
    }
}