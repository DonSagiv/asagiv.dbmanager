using Microsoft.EntityFrameworkCore;

namespace asagiv.dbmanager.addresses
{
    public class AddressDbContext : DbContext
    {
        #region Properties
        public string ipAddress { get; }
        public string port { get;  }
        public string database { get; }
        public string username { get; }
        public string password { get; }
        #endregion

        #region DbSets
        public virtual DbSet<Family> Families { get; set; }
        public virtual DbSet<Address> Addresses { get; set; }
        public virtual DbSet<BabyGift> BabyGifts { get; set; }
        public virtual DbSet<FamilyBabyGift> FamilyBabyGifts { get; set; }
        #endregion

        #region Constructor
        public AddressDbContext(string ipAddress, string port, string database, string username, string password) 
        {
            this.ipAddress = ipAddress;
            this.port = port;
            this.database = database;
            this.username = username;
            this.password = password;
        }

        public AddressDbContext(string ipAddress, string port, string database, string username, string password, DbContextOptions<AddressDbContext> options) : base(options) 
        {
            this.ipAddress = ipAddress;
            this.port = port;
            this.database = database;
            this.username = username;
            this.password = password;
        }
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
