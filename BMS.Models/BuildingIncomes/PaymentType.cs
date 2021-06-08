using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

using BMS.Models.BuildingFunds;
using BMS.Models.BuldingExpenses;

namespace BMS.Models.BuildingIncomes
{
    public class PaymentType
    {
        public PaymentType()
        {
            this.TypeOfPayment = new HashSet<Payment>();
            this.TypeOfTransaction = new HashSet<Transaction>();
        }

        [Key]
        public int Id { get; set; }


        [Required]
        [MaxLength(20)]
        public string Type { get; set; } //cash, bank

        // one-to-one with Account
        public virtual Account Account { get; set; }


        //many-to-one - many incoming payments can have one type payment
        public virtual ICollection<Payment> TypeOfPayment { get; set; }


        //many-to-one - many outgoing payments can have one type payment
        public virtual ICollection<Transaction> TypeOfTransaction { get; set; }
    }
}
