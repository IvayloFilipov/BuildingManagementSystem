using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BMS.Models.BuildingData
{
    public class Owner
    {
        public Owner()
        {
            this.Properties = new HashSet<PropertyOwner>();
        }

        [Key]
        //[ForeignKey("Address")] //if Owner does't have address EF will throw exception(can not save Owner without address)
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }

        [MaxLength(80)]
        public string Email { get; set; }

        [Required]
        [MaxLength(50)]
        public string Phone { get; set; }


        //many-to-many with Property - make class PropertyOwner
        public virtual ICollection<PropertyOwner> Properties { get; set; }


        //one-to-one with Address - every Owner has only one permanent address
        public int AddressId { get; set; }
        public virtual Address Address { get; set; }
    }
}
