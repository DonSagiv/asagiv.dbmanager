using Microsoft.EntityFrameworkCore;
using System;

namespace asagiv.dbmanager.addresses
{
    public class AddressDbContext : DbContext
    {
        #region Properties
        public string ipAddress => "192.168.1.4";
        public string port => "5432";
        public string database => "addresses";
        public string username => "asagiv";
        public string password => "kingkong";
        #endregion

        #region DbSets
        public virtual DbSet<Family> Families { get; set; }
        public virtual DbSet<Address> Addresses { get; set; }
        public virtual DbSet<BabyGift> BabyGifts { get; set; }
        public virtual DbSet<FamilyBabyGift> FamilyBabyGifts { get; set; }
        #endregion

        #region Constructor
        public AddressDbContext() { }
        public AddressDbContext(DbContextOptions<AddressDbContext> options) : base(options) { }
        #endregion

        #region Methods
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql($"Host={ipAddress};" +
                    $"Port={port};" +
                    $"Database={database};" +
                    $"Username={username};" +
                    $"Password={password}");
            }
        }
        #endregion
    }
}
