using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace N01544565Assignment1.Controllers
{
    public class GreetingController : ApiController
    {//POST api/Greeting
        /// <summary>
        /// This method returns one string ["Hello Would!"] when receiving a post request
        /// </summary>
        /// <returns>["Hello Would!"]</returns>
        public IEnumerable<string> Post()
        { return new string[] { "Hello" + " " + "World!" };
        }   
    }
}