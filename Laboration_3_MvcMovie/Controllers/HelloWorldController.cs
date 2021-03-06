﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Microsoft.Extensions.WebEncoders;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Laboration_3_MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: /HelloWorld/
        public string Index()
        {
            return "This is my default action...";
        }

        //
        //GET: /HelloWorld/Welcome/
        public string Welcome(string name, int numTimes = 1)
        {
            return HtmlEncoder.Default.HtmlEncode("Hello " + name + ", NumTimes is: " + numTimes);
        }
    }
}
