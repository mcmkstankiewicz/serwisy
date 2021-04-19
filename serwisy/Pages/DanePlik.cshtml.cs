using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using serwisy.Models;
using serwisy.Services;

namespace serwisy.Pages
{
    public class DanePlikModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public JsonFileProduktSerwis ProduktSerwis;
        public IEnumerable<Produkt> Produkty { get; private set; }
        public DanePlikModel(
            ILogger<IndexModel> logger,
            JsonFileProduktSerwis produktSerwis)
        {
            _logger = logger;
            ProduktSerwis = produktSerwis;
        }


        public void OnGet()
        {
            Produkty = ProduktSerwis.GetProdukts();
        }
    }
}
