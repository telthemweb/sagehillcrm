using apiwebservices.Model;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace apiwebservices.DTO.admin
{
    public class Admindto: IdentityUser
    {
        public string user_number { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string email { get; set; }

        public int roleId { get; set; }
        public string Gender { get; set; }
        public string? MobilePhone { get; set; }
        public string? PhoneNumber { get; set; }
        public string? administrator_key { get; set; }
        public string password { get; set; }
        public string? country { get; set; }
        public string? province { get; set; }
        public string? district { get; set; }
        public string? city { get; set; }
        public string? address { get; set; }
    }
}
