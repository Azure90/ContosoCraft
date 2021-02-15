using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace ContosoCrafts.Users.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public  string Username { get; set; }
        public Address address { get; set; }
        public string Phone { get; set; }      
        public string Website { get; set; }
        public Company company { get; set; }
        public override string ToString() => JsonSerializer.Serialize<User>(this);
    }
    public  class Address
    {
        public string Street { get; set; }
        public string Suite { get; set; }
        public string City { get; set; }
        public string Zipcode { get; set; }
        public Geo geo { get; set; }
    }
    public class Geo
    {
        public string Lat { get; set; }
        public string Lng { get; set; }
    }
    public  class Company
    {
        public string Name { get; set; }
        public string CatchPhrase { get; set; }
        public string Bs { get; set; }
    }
}
