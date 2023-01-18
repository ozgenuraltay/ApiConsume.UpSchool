using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiConsume.UpSchool.Models
{
    public class CurrencyListVM
    {
        public string base_currency { get; set; }

        public string base_currency_date { get; set; }

        public Exchange_Rates[] exchange_rates { get; set; }

        public class Exchange_Rates
        {
            public string currency { get; set; }

            public string exchange_rate_buy { get; set; }
        }
    }
}
