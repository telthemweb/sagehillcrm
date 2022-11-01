using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace apiwebservices.Model
{
    [Table("role")]
    public class Role
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [Required]
        [MaxLength(50)]
        public string name { get; set; }
        public string? level { get; set; }
        public string? role_key { get; set; }
        [DefaultValue("ACTIVE")]
        public string? status { get; set; }
        public DateTime created_at { get; set; } = DateTime.Now;
        public DateTime? updated_at { get; set; }
        public DateTime? deleted_at { get; set; }

        public virtual ICollection<Administrator> administrators { get; set; }
        public virtual ICollection<Permision> permisions { get; set; }

        public virtual ICollection<SystemModule> systemModule { get; set; }

        public virtual ICollection<Submodule> submodules { get; set; }
    }
}
