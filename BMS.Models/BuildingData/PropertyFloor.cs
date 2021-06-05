using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BMS.Models.BuildingData
{
    public class PropertyFloor
    {
        public PropertyFloor()
        {
            this.Property = new HashSet<Property>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public byte Floor { get; set; } //(Подземни гаражи, Партер, 1, 2 ...)


        //many-to-one with Property -> many Properties can lay on a Floor 
        public virtual ICollection<Property> Property { get; set; }
    }
}
