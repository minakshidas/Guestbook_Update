
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Guestbook.Controllers
{
    public class SignController : Controller
    {
        public ViewResult Random()
        {
            var Name = ' ';
            var sign = new SignController() { Name = "Very nice" };
            return View(sign);
        }
    }
}
