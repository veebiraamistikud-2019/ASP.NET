using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASP.NET_kodune.Models;
using ASP.NET_kodune.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace ASP.NET_kodune.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public jsonFileItemsService ItemsService;
        public IEnumerable<Items> Items { get; private set; }

        public IndexModel(ILogger<IndexModel> logger, jsonFileItemsService itemsService)
        {
            _logger = logger;
            ItemsService = itemsService;
        }

        public void OnGet()
        {
            Items = ItemsService.GetProducts();
        }
    }
}
