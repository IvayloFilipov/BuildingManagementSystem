﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMS.Models.BuldingExpenses
{
    public class Transaction
    {
        [Key]
        public int Id { get; set; }

        public decimal Amount { get; set; }

        public DateTime DateOfPayment { get; set; }

        [Required]
        [MaxLength(250)]
        public string Description { get; set; }


        //one-to-many with PaymentType - 
        public int? PaymentTypeId { get; set; }
        public virtual PaymentType PaymentType { get; set; }


        //one-to-many with Account - 
        public int AccountId { get; set; }
        public virtual Account Account { get; set; }
    }
}