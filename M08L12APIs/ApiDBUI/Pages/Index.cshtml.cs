using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.Net.Http;
using System.Text.Json;
using ApiDBUI.Models;

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

        public async Task OnGet()
        {
            await GetAllContacts();
        }

        private async Task GetAllContacts(){
            var _client = _httpClientFactory.CreateClient();
            var response = await _client.GetAsync("https://localhost:5002/api/contacts");

            List<ContactModel> contacts;

            if ( response.IsSuccessStatusCode )
            {
                var options = new JsonSerializerOptions{
                    PropertyNameCaseInsensitive = true
                };
                string responseText = await response.Content.ReadAsStringAsync();
                contacts = JsonSerializer.Deserialize<List<ContactModel>>(responseText, options);
            }else{
                throw new Exception(response.ReasonPhrase);
            }
        }
    }
}
