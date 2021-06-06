﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

using BMS.Models.Debts;
using BMS.Models.BuildingIncomes;

namespace BMS.Models.BuildingData
{
    public class  Property
    {
        public Property()
        {
            this.Owners = new HashSet<PropertyOwner>();
            this.PropertyMonthlyDebt = new HashSet<PropertyDebt>();
            this.PropertyPayments = new HashSet<Payment>();
        }

        [Key]
        public int Id { get; set; }

        //one-to-many with Building -
        public int BuildingId { get; set; }
        public virtual Building Building { get; set; }


        //one-to-many with PropertyType - 
        public int PropertyTypeId { get; set; }
        public virtual PropertyType PropertyType { get; set; }


        //one-to-many with PropertyFloor - 
        public int PropertyFloorId { get; set; }
        public virtual PropertyFloor PropertyFloor { get; set; }

        public int AppartNumber { get; set; }

        public double PropertyPart { get; set; }

        public int? DogCount { get; set; }


        //one-to-many with Tenant - one Tenant can hire many Properties
        public int TenantId { get; set; }
        public virtual Tenant Tenant { get; set; }


        //many-to-many with Owner - make class PropertyOwner 
        public virtual ICollection<PropertyOwner> Owners { get; set; }


        //many-to-one with PropertyDebt (in Debts folder) - one Property can have many monthly debts (if not pay on time)
        public virtual ICollection<PropertyDebt> PropertyMonthlyDebt { get; set; }


        //many-to-one with Payment - 
        public virtual ICollection<Payment> PropertyPayments { get; set; }
    }
}
