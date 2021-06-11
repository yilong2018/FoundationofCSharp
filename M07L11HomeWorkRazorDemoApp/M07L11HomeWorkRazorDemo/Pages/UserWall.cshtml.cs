using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace M07L11HomeWorkRazorDemo
{
    
    public class UserWallModel : PageModel
    {
        [BindProperty]
        public Person person { get; set; }

        [BindProperty]
        public List<Person> people { get; set; } = new List<Person>();

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            people.Add(person);
            return Page();
        }
    }
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName => $"{FirstName} {LastName}";
    }
}
