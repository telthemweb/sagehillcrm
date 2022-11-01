using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace apiwebservices.Model
{
    public class Customer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public string regnumber { get; set; }

        [DataMember(IsRequired = true)]
        public string name { get; set; }
        public string surname { get; set; }
        public string email { get; set; }

        [ForeignKey(nameof(role))]
        public int roleId { get; set; }
        public string Gender { get; set; }
        public string MobilePhone { get; set; }
        public string PhoneNumber { get; set; }
        public string administrator_key { get; set; }
        public string password { get; set; }
        public string country { get; set; }
        public string province { get; set; }
        public string district { get; set; }
        public string city { get; set; }
        public string address { get; set; }

        [DefaultValue(true)]
        public bool status { get; set; }

        public DateTime created_at { get; set; } = DateTime.Now;
        public DateTime updated_at { get; set; }
        public DateTime deleted_at { get; set; }

     
        public virtual Role role { get; set; }
    }
}
