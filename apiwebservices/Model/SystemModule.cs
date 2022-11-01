using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using Microsoft.AspNetCore.Identity;

namespace apiwebservices.Model
{
    public class SystemModule
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public string name { get; set; }
        public string? icon { get; set; }
        public string? widget { get; set; }
        public string? description { get; set; }

        [DefaultValue("PENDING")]
        public string? status { get; set; }
        public DateTime created_at { get; set; } = DateTime.Now;
        public DateTime updated_at { get; set; }
        public DateTime deleted_at { get; set; }

        
        public virtual ICollection<Role> role { get; set; }
        public virtual ICollection<Submodule> submodule { get; set; }
    }
}
