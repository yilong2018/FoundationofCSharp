using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace M7L14HomeworkWebAPI.Models
{
    public class PersonModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName => $"{FirstName} {LastName}";
    }
}
