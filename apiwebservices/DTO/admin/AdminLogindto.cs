using Microsoft.AspNetCore.Identity;

namespace apiwebservices.DTO.admin
{
    public class AdminLogindto: IdentityUser
    {
        public string user_number { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string email { get; set; }

         public int roleId { get; set; }

        public string Token { get; set; }
    }
}
