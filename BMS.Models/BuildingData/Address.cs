﻿using System.ComponentModel.DataAnnotations;

namespace BMS.Models.BuildingData
{
    public class Address
    {
        [Key]
        //[ForeignKey("Building")]
        public int Id { get; set; }

        //one-to-many with City -> one unique address can be/have in only one City
        public int CityId { get; set; }
        public virtual City City { get; set; }

        [MaxLength(50)]
        public string District { get; set; }

        public byte ZipCode { get; set; }

        [MaxLength(100)]
        public string Street { get; set; }

        [MaxLength(6)]
        public string StreetNumber { get; set; }

        [MaxLength(6)]
        public string BlockNumber { get; set; }

        [MaxLength(6)]
        public string EntranceNumber { get; set; }

        public int? Floor { get; set; }

        public int? AppartmentNumber { get; set; }


        //one-to-one with Building
        public int BuildingId { get; set; } //<- or to put [ForeignKey("Building")] above public int Id { get; set; }
        public virtual Building Building { get; set; }


        //one-to-one with Owner - an Owner has only one permanent address
        public virtual Owner Owner { get; set; }


        //one-to-one with CompanyOwner - a CompanyOwner has only one permanent address
        public virtual CompanyOwner CompanyOwner { get; set; }
    }
}
