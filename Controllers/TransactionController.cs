using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using blockchain_basic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace blockchain_peer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionController : ControllerBase
    {
        // POST: api/Transaction
        [HttpPost]
        [Produces("text/plain")]
        public void Post([FromBody] Transaction transaction)
        {
            Program.ValueCoin.CreateTransaction(transaction);
        }
    }
}
