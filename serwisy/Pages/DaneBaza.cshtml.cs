using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using serwisy.Data;
using serwisy.Models;

namespace serwisy.Pages
{
    public class DaneBazaModel : PageModel
    {
        private readonly ILogger<DaneBazaModel> _logger;
        private readonly ProduktContext _context;
        public IList<Produkt> Produkty { get; set; }
        public DaneBazaModel(ILogger<DaneBazaModel> logger, ProduktContext context)
        {
            _logger = logger;
            _context = context;
        }
        public void OnGet()
        {
            Produkty = _context.Produkt.ToList();
        }
    }
}
