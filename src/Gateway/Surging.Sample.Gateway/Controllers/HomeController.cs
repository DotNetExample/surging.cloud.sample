using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Surging.Sample.Gateway.Controllers
{
    public class HomeController : Controller
    {
        public async Task<object> Index() {
            return new  { Value = "1" };
        }
    }
}
