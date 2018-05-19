using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace stockUpdate.Models
{
    public class Price
    {
        public string currency  { get; set; }
        public double amount { get; set; }  //1
    }

    public class Stock
    {
        public string name { get; set; }  //1
        public Price price { get; set; }
        public double percent_change { get; set; }
        public int volume { get; set; } //1
        public string symbol { get; set; }
    }

    public class RootObject
    {
        public List<Stock> stock { get; set; }
        public DateTime as_of { get; set; }
    }
}
