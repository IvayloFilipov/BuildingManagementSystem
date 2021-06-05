using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BMS.Models.Debts
{
    public class PropertyStatus
    {
        public PropertyStatus()
        {
            this.CurrMonthPropertyStatus = new HashSet<PropertyDebt>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Status { get; set; } //Occupied/Обитаем, Unoccupied/Необитаем, Commertial/С търг. дейност


        //many-to-one with MonthlyDebt - many Properties can have one type of Status at a time 
        public virtual ICollection<PropertyDebt> CurrMonthPropertyStatus { get; set; }


        //one-to-one with Fee -
        //public virtual Fee Fee { get; set; }
    }
}
