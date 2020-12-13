using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ContactManager.Controllers
{
    public class ContactController : Controller
    {
        public string[] Get()
        {
            return new string[]
            {
        "Hello",
        "World"
            };
        }
    }
}