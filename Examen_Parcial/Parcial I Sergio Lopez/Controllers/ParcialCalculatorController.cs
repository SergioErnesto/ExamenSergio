using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Parcial_I_Sergio_Lopez.Controllers
{
    public class ParcialCalculatorController : ApiController
    {
        [HttpPost]
        [Route("Add")]
        public int Add([FromHeader] int numa, [FromHeader] int numb)
        {
            return numa + numb;
        }
    }
}
