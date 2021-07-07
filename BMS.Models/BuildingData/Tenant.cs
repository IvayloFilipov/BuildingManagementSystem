using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BMS.Models.BuildingData
{
    public class Tenant
    {
        public Tenant()
        {
            this.TenantProperties = new HashSet<Property>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }

        [MaxLength(50)]
        public string MiddleName { get; set; }

        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }

        [Required]
        [MaxLength(80)]
        public string Email { get; set; }

        [Required]
        [MaxLength(50)]
        public string Phone { get; set; }

        // default - false, if is removed and has new tenant -> true
        public bool IsRemoved { get; set; }

        //many-to-one with Property - many Properties can be hired by one Tenant
        public virtual ICollection<Property> TenantProperties { get; set; }
    }
}
