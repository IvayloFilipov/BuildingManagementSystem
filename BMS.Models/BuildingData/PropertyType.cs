using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BMS.Models.BuildingData
{
    public class PropertyType
    {
        public PropertyType()
        {
            this.Property = new HashSet<Property>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Type { get; set; } // магазин, апартамент, ателие

        //many-to-one with Property -> many Properties can be one particular Type (Shop/Магазин, Office/Офис, Apartment/Апартамент)
        public virtual ICollection<Property> Property { get; set; }
    }
}
