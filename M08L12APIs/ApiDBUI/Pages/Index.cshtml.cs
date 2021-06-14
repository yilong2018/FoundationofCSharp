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
using System.Text;

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
            await CreateContact();
            await GetAllContacts();
        }
        
        private async Task CreateContact()
        {
            ContactModel contact = new ContactModel
            {
                FirstName = "Yi",
                LastName = "Long"
            };

            contact.EmailAddresses.Add(new EmailAddressModel { EmailAddress = "yi@long.com" });
            contact.EmailAddresses.Add(new EmailAddressModel { EmailAddress = "yilong@gmail.com" });
            contact.PhoneNumbers.Add(new PhoneNumberModel { PhoneNumber = "111111" });
            contact.PhoneNumbers.Add(new PhoneNumberModel { PhoneNumber = "222222" });
            var _client = _httpClientFactory.CreateClient();
            var response = await _client.PostAsync(
                "http://localhost:45641/api/contacts", 
                new StringContent(JsonSerializer.Serialize(contact), Encoding.UTF8,"application/json"));
        }
        private async Task GetAllContacts(){
            var _client = _httpClientFactory.CreateClient();
            var response = await _client.GetAsync("http://localhost:45641/api/contacts");

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
