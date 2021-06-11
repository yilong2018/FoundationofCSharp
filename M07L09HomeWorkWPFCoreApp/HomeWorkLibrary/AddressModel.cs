using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkLibrary
{
    public class AddressModel
    {
        public string Street { get; set; }
        public string City { get; set; }

        public string FullAddress => $"{Street} {City}";

    }
}
