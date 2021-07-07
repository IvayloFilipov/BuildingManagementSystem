using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BMS.Models.BuildingData
{
    public class CompanyOwner
    {
        public CompanyOwner()
        {
            this.CompanyProperties = new HashSet<Property>();
        }

        [Key]
        //[ForeignKey("Address")]//if CompanyOwner does't have address EF will throw exception(can not save CompanyOwner without address)
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string CompanyName { get; set; }

        [MaxLength(20)]
        public string UIC { get; set; }

        [Required]
        [MaxLength(150)]
        public string CompanyOwnerFullName { get; set; }

        [Required]
        [MaxLength(80)]
        public string Email { get; set; }

        [Required]
        [MaxLength(20)]
        public string Phone { get; set; }

        // default - false, if is removed and has new owner -> true
        public bool IsRemoved { get; set; }

        //one-to-one with Address - one/every CompanyOwner has only one permanent address
        public int AddressId { get; set; }
        public virtual Address Address { get; set; }


        //many-to-one with Property - one Company can have/owne many Properties
        public virtual ICollection<Property> CompanyProperties { get; set; }
    }
}
