using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

using BMS.Models.BuildingData;
using BMS.Models.BuildingIncomes;
using BMS.Models.BuldingExpenses;


namespace BMS.Models.Funds
{
    public class Account
    {
        public Account()
        {
            this.IncomingPayments = new HashSet<Payment>();
            this.OutgoingPayments = new HashSet<Transaction>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(20)]
        public string AccountType { get; set; } //cash account or bank account

        public decimal TotalAmount { get; set; } //total curr amount in cash or total curr amount in bank 


        //one-to-many with Building - 
        public int BuildingId { get; set; }
        public virtual Building Buildings { get; set; }


        // one-to-one with PaymentType
        public int PaymentTypeId { get; set; }
        public virtual PaymentType PaymentType { get; set; }


        [Required]
        [MaxLength(250)]
        public string Description { get; set; }


        //many-to-one with Payment -
        public virtual ICollection<Payment> IncomingPayments { get; set; }


        //many-to-one with Transaction - 
        public virtual ICollection<Transaction> OutgoingPayments { get; set; }
    }
}
