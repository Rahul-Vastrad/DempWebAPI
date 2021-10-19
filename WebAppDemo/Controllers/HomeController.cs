using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAppDemo.Controllers
{
    public class HomeController : ApiController
    {
        [HttpGet]
        [Route("api/HomeController/GetDetails")]
        public string GetDetails()
        {
            return "Rahul Vastrad - Test for CI/CD Build.";
        }
    }
}
