using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.Net.Http;
using System.Text.Json;

namespace ApiDBUI.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IHttpClientFactory _httpClientFactory;

        public IndexModel(ILogger<IndexModel> logger, IHttpClientFactory httpClientFactory)
        {
            _logger = logger;
            _httpClientFactory = httpClientFactory;
        }

        public void OnGet()
        {

        }

        private async Task GetAllContacts(){
            var _client = _httpClientFactory.CreateClient();
            var response = await _client.GetAsync("https://localhost:5001/weatherforecast");

            if ( response.IsSuccessStatusCode )
            {
                var option = new JsonSerializerOptions{
                    PropertyNameCaseInsensitive = true
                };
            }
        }
    }
}
