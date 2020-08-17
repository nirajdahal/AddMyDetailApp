using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;

namespace Library.Models
{
    public class Person
    {
        public string Name { get; set; }

        public string Age { get; set; }

        public List<Address> Address { get; set; }
    }
}
