using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using blockchain_peer.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace blockchain_peer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BalanceController : ControllerBase
    {
        // POST: api/Balance
        [HttpPost]
        [Produces("application/json")]
        public Dictionary<string, string> Get([FromBody] Address address)
        {
            return new Dictionary<string, string> { { "balance", Program.ValueCoin.GetBalance(address.walletAddress).ToString() } };
        }
    }
}
