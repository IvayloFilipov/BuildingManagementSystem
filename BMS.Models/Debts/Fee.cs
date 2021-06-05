using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BMS.Models.Debts
{
    public class Fee
    {
        public Fee()
        {
            this.PropertyDebts = new HashSet<PropertyDebt>();
        }

        [Key]
        public int Id { get; set; }

        public double Amount { get; set; } //10

        public DateTime CreatedOn { get; set; } // when the record (row) is creadet/updated

        [Required]
        [MaxLength(100)]
        public string Type { get; set; } //was enum //Now is Property fees - Намалена/reduced(10 lv), Нормална/regular(20 lv), Увеличена/increased(80 lv)

        [Required]
        [MaxLength(250)]
        public string Description { get; set; }


        // one-to-one with PropertyStatus - one type of Fee can be...
        //public int PropertyStatusId { get; set; }
        //public virtual PropertyStatus PropertyStatus { get; set; }


        //many-to-one with PropertyDebt
        public virtual ICollection<PropertyDebt> PropertyDebts { get; set; }
    }
}
