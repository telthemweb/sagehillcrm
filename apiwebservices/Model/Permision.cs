using System.Xml.Linq;

namespace apiwebservices.Model
{
    public class Permision
    {
        public int id { get; set; }
        public int submoduleId { get; set; }
        public string? name { get; set; }
        public DateTime created_at { get; set; } = DateTime.Now;
        public DateTime? updated_at { get; set; }
        public virtual ICollection<Role> roles { get; set; }
        public virtual Submodule submodule { get; set; }

       
    }
}
