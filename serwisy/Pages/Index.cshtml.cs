using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using serwisy.Models;
using serwisy.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace serwisy.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public JsonFileProduktSerwis ProduktSerwis;
        public IEnumerable<Produkt> Produkty { get; private set; }

        public IndexModel(
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
