using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace blockchain_peer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValidateController : ControllerBase
    {
        // GET: api/Validate
        [HttpGet]
        [Produces("application/json")]
        public Dictionary<string, string> Get()
        {
            return new Dictionary<string, string> { { "blockchainIsValid", (Program.ValueCoin.IsValid()?"true":"false") } };
        }
    }
}
