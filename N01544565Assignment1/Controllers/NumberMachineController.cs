using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace N01544565Assignment1.Controllers
{
    public class NumberMachineController : ApiController
    {//GET api/NumberMachine
        public IEnumerable<int> Get(int id)
        {
            return new int[] { id/5, id+5,(id*2)-10};
        }
    }
}
