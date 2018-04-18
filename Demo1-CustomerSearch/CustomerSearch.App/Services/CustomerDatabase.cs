using CustomerSearch.Core.Models;
using CustomerSearch.Core.Services;
using System.Collections.Generic;

namespace CustomerSearch.App.Services
{
    public class CustomerDatabase : ICustomerDatabase
    {
        public IEnumerable<Customer> GetAll()
        {
            return new[]
            {
                Customer.Create("William","Abrahamsson","william@hotmail.com"),
                Customer.Create("Oscar","Backlund","oscar@gmail.com"),
                Customer.Create("Liam","Cederholm","liam@outlook.com"),
                Customer.Create("Lucas","Danielsson","lucas@icloud.com"),
                Customer.Create("Oliver","Edberg","oliver@hotmail.com"),
                Customer.Create("Alexander","Einarsson","alexander@gmail.com"),
                Customer.Create("Elias","Einarsson","elias@outlook.com"),
                Customer.Create("Hugo","Flodin","hugo@icloud.com"),
                Customer.Create("Noah","Gradin","noah@hotmail.com"),
                Customer.Create("Adam","Hallqvist","adam@gmail.com"),
                Customer.Create("Alice","Ahlin","alice@outlook.com"),
                Customer.Create("Alicia","Berggren","alicia@icloud.com"),
                Customer.Create("Olivia","Classon","olivia@gmail.com"),
                Customer.Create("Ella","Degerman","ella@hotmail.com"),
                Customer.Create("Ebba","Ferm","ebba@gmail.com"),
                Customer.Create("Lilly","Gabrielsson","lilly@outlook.com"),
                Customer.Create("Astrid","Hagelin","astrid@icloud.com"),
                Customer.Create("Saga","Isberg","saga@hotmail.com"),
                Customer.Create("Freja","Abrahamsson","freja@gmail.com"),
                Customer.Create("Wilma","Ahlin","wilma@outlook.com"),
                Customer.Create("Eric","Eriksson","eric@gmail.com"),
                Customer.Create("Eric","Ericsson","eric@gmail.com")
            };
        }
    }
}