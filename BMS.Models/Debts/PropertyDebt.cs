using System;
using System.ComponentModel.DataAnnotations;

using BMS.Models.BuildingData;

namespace BMS.Models.Debts
{
    public class PropertyDebt
    {
        [Key]
        public int Id { get; set; }

        public DateTime OccurrenceDate { get; set; }

        //one-to-many with Property - one property can have many monthly debts
        public int PropertyId { get; set; }
        public virtual Property Property { get; set; }


        //one-to-many - one Property each month can have different status
        public int? PropertyStatusId { get; set; }
        public virtual PropertyStatus PropertyStatus { get; set; }


        // one-to-many with Fee - one fee ammount can be used by many Properties (PropertyDebts)
        public int FeeId { get; set; }
        public virtual Fee Fee { get; set; }


        // default - false, if debt is paid -> true
        public bool IsPaid { get; set; }


        [MaxLength(250)]
        public string Descrtiption { get; set; }
    }
}
