using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blockchain_peer.Models
{
    public class Address
    {
        [JsonProperty(PropertyName = "walletAddress")]
        public string walletAddress { get; set; }
    }
}
