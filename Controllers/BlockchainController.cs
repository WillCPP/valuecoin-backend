using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace blockchain_peer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlockchainController : ControllerBase
    {
        // GET: api/Blockchain
        [HttpGet]
        //[Produces("application/json")]
        public string Get()
        {
            return JsonConvert.SerializeObject(Program.ValueCoin, Formatting.Indented);
        }
    }
}
