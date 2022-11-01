using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace apiwebservices.Model
{
    
    public class permision
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public int systemmoduleId { get; set; }

        public string? icon { get; set; }
        public string? url { get; set; }
        public DateTime created_at { get; set; } = DateTime.Now;

        public DateTime? updated_at { get; set; }

        public virtual ICollection<Role> roles { get; set; }
        public virtual ICollection<Permision> permisions { get; set; }
        public virtual SystemModule systemmodule { get; set; }

    }
}
