using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace apiwebservices.Model
{
    
    public class AuditTrailt
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public string? entity { get; set; }
        public string? oldvalue { get; set; }
        public string? newvalue { get; set; }
        public string? action { get; set; }

        [ForeignKey(nameof(administrator))]
        public int administratorId { get; set; }
        [DefaultValue("ACTIVE")]
        public string? status { get; set; }
        public DateTime created_at { get; set; } = DateTime.Now;
        public DateTime? updated_at { get; set; }
        public DateTime? deleted_at { get; set; }

        public virtual Administrator administrator { get; set; }
    }
}
