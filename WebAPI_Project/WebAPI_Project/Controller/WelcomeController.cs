using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Http;

namespace WebAPI_Project.Controllers
{
    public class WelcomeController : ApiController // we use ApiController
    {
       public string Get()
        {
            string strWelcome = "Halo Infinite is going to be awesome!";
            return strWelcome;
        }
    }
}