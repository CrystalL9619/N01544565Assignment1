using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace N01544565Assignment1.Controllers
{
    public class GreetingidController : ApiController
    {//GET api/Greetingid/{id}
        public IEnumerable<string> Get(int id)
        {
            return new string[] { "Greetings to" + " " + id + " " + "people!" };
        }
    }
}
;