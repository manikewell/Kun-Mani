using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GitTest.Controllers
{
    public class HelloWorldController : Controller
    {
        // 
        // GET: /HelloWorld/ 

        public string Index()
        {
            return "This is <b>HelloWorld</b>...";
        } 

    }
}
