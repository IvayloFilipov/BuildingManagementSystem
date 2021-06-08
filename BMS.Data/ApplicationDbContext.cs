﻿using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

using BMS.Models.Debts;
using BMS.Models.BuildingData;
using BMS.Models.BuildingFunds;
using BMS.Models.BuildingIncomes;
using BMS.Models.BuldingExpenses;

namespace BMS.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        //BuildingData
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Building> Building { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<CompanyOwner> CompanyOwners { get; set; }
        public DbSet<Owner> Owners { get; set; }
        public DbSet<Property> Properties { get; set; }
        public DbSet<PropertyFloor> PropertyFloors { get; set; }
        public DbSet<PropertyOwner> PropertiesOwners { get; set; }
        public DbSet<PropertyType> PropertyTypes { get; set; }
        public DbSet<Tenant> Tenants { get; set; }

        //BuildingIncomes
        public DbSet<Payment> IncomingPayments { get; set; }
        public DbSet<PaymentType> PaymentTypes { get; set; }

        //BuildingExpenses
        public DbSet<Transaction> OutgoingPayments { get; set; }

        //Debts
        public DbSet<Fee> Fees { get; set; }
        public DbSet<PropertyDebt> PropertyDebtsMonthly { get; set; }
        public DbSet<PropertyStatus> PropertyStatusMonthly { get; set; }

        //Funds
        public DbSet<Account> BuildingAccounts { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<PropertyOwner>()
                .HasKey(po => po.Id);

            builder.Entity<Property>()
                .HasMany(p => p.Owners)
                .WithOne(o => o.Property)
                .OnDelete(DeleteBehavior.NoAction);

            builder.Entity<Owner>()
                .HasMany(o => o.Properties)
                .WithOne(p => p.Owner)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
