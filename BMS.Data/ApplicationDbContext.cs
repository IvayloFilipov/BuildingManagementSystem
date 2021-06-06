using BMS.Models.BuildingData;
using BMS.Models.BuildingIncomes;
using BMS.Models.BuldingExpenses;
using BMS.Models.Debts;
using BMS.Models.Funds;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BMS.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

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

        public DbSet<Payment> IncomingPayments { get; set; }
        public DbSet<PaymentType> PaymentTypes { get; set; }

        public DbSet<Transaction> OutgoingPayments { get; set; }

        public DbSet<Fee> Fees { get; set; }
        public DbSet<PropertyDebt> PropertyDebtsMonthly { get; set; }
        public DbSet<PropertyStatus> PropertyStatusMonthly { get; set; }

        public DbSet<Account> BuildingAccounts { get; set; }

    }
}
