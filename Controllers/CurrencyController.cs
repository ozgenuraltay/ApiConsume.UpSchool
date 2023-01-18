using ApiConsume.UpSchool.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace ApiConsume.UpSchool.Controllers
{
    public class CurrencyController : Controller
    {
        public async Task<IActionResult> Index()        
        
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://booking-com.p.rapidapi.com/v1/metadata/exchange-rates?locale=en-gb&currency=TRY"),
                Headers =
    {
        { "X-RapidAPI-Key", "cff36bc163mshea8330ce63da292p1133b5jsn8b39d54ed286" },
        { "X-RapidAPI-Host", "booking-com.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                var currencies = JsonConvert.DeserializeObject<CurrencyListVM>(body);
                return View((currencies.exchange_rates).ToList());
            }
        }
    }
}
