using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using blockchain_peer.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace blockchain_peer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MineController : ControllerBase
    {
        // POST: api/Mine
        [HttpPost]
        [Produces("text/plain")]
        public void Post([FromBody] Address miner)
        {
            Program.ValueCoin.ProcessPendingTransaction(miner.walletAddress);
        }
    }
}
