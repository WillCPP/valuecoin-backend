using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace blockchain_basic
{
    public class Transaction
    {
        [JsonProperty(PropertyName = "fromAddress")]
        public string FromAddress { get; set;  }
        [JsonProperty(PropertyName = "toAddress")]
        public string ToAddress { get; set; }
        [JsonProperty(PropertyName = "amount")]
        public int Amount { get; set; }

        public Transaction()
        {

        }

        public Transaction(string fromAddress, string toAddress, int amount)
        {
            FromAddress = fromAddress;
            ToAddress = toAddress;
            Amount = amount;
        }
    }
}
