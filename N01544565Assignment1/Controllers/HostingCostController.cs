using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;
using System.Web.Http;
using System.Web.UI.WebControls;

namespace N01544565Assignment1.Controllers
{
    public class HostingCostController : ApiController
    {//GET api/HostingCost/{id}
        [HttpGet]
        [Route("api/HostingCost/{id}")]
        public string Total(int id)
        {

            string Total = "";
            {
                if (0 <= id && id < 14)
                {

                    Total = "1 fortnights at $5.50 / FN = $5.50 CAD, HST 13% = $0.72 CAD,Total = $6.22 CAD";
                }
                else if (14 <= id && id < 28)
                {
                    Total = "2 fortnights at $5.50/FN = $11.00 CAD, HST 13% = $1.43 CAD,Total = $12.43 CAD";
                }
                else if (28 <= id && id < 42)
                {
                    Total = "3 fortnights at $5.50/FN = $16.50 CAD, HST 13% = $2.14 CAD, Total = $18.64 CAD";
                }
            }
            return Total;
        }
    }
}