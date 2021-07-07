using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BMS.Models.BuldingExpenses
{
    public class ExpenseType
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Type { get; set; }

        //many-to-one - many Transactions can have one expense type 
        public virtual ICollection<Transaction> Transactions { get; set; }

        //Elevator 
        //Cleaning 
        //ManagementFee 
        //BankFee 
        //ElectricityElevator 
        //ElectricityStairs 
        //OtherExpenses - should be describe into field Description
    }
}
