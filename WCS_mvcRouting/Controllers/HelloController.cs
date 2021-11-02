using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WCS_mvcRouting.Controllers
{
    public class HelloController : Controller
    {
        // GET: /<controller>/
        public String Index()
        {
            return "Index";
        }

        [Route("/Hello/Say")] // The endpoint here is reached by calling `/Say` route
        public String SayHello()
        {
            return "Hello !";
        }

        //[Route("/Hello/Yell")] // The endpoint here is reached by calling `/Yell` route
        public String YellHello()
        {
            return "HELLO !";
        }
    }
}
