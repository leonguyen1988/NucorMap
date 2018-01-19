using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace myfirstWebApp.Controllers
{
    public class HomeController : Controller
    {

        // GET: Home

        [OutputCache(Duration = 15)]
        public string Index()
        {
            return "Hello world";
        }

        [HttpPost]
        public ActionResult PostAction()
        {
            return View("Index");
        }

        // This selector will let the developer change the name of the route to different name like
        // this case, this chaged from "GetCurrentTime" to "CurrentTime"
        [ActionName("CurrentTime")]

        // This filter will automaticly update the output every 1 second
        // This filter just only do on the variable, not a website, we have to manually refresh to see the change
        [OutputCache(Duration = 1)]
        public string GetCurrentTime()
        {
            return TimeString();
        }

        // This selector is basically a public method but wont show up on website unless we call it from another action
        // Like this case, the TimeString method isn't direcly show on web app, it was called via a GetCurrentTime method.
        // It works like function file and main file in C++
        [NonAction]
        public string TimeString()
        {
            return "Time is " + DateTime.Now.ToString("T");
        }

        

    }
}