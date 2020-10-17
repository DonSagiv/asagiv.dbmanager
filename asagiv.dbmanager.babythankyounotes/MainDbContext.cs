using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace asagiv.dbmanager.babythankyounotes
{
    public class MainDbContext : DbContext
    {
        #region Fields
        private string _ipAddress;
        private string _port;
        private string _database;
        private string _username;
        private string _password;
        #endregion

        public MainDbContext(string ipAddress, string port, string database, string username, string password) 
        {
            _ipAddress = ipAddress;
            _port = port;
            _database = database;
            _username = username;
            _password = password;
        }

        public MainDbContext(string ipAddress, string port, string database, string username, string password, DbContextOptions<MainDbContext> options) : base(options) 
        {
            _ipAddress = ipAddress;
            _port = port;
            _database = database;
            _username = username;
            _password = password;
        }

        public virtual DbSet<BabyGiftList> BabyGiftList { get; set; }
        public virtual DbSet<BabyGifts> BabyGifts { get; set; }
        public virtual DbSet<People> People { get; set; }
        public virtual DbSet<PeopleBabyGifts> PeopleBabyGifts { get; set; }
        public virtual DbSet<RobertBabyAnnouncements> RobertBabyAnnouncements { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql($"Host={_ipAddress};" +
                    $"Port={_port};" +
                    $"Database={_database};" +
                    $"Username={_username};" +
                    $"Password={_password}");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasPostgresExtension("pg_stat_statements")
                .HasPostgresExtension("pgaudit");

            modelBuilder.Entity<BabyGiftList>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("baby_gift_list", "asagiv");

                entity.Property(e => e.City)
                    .HasColumnName("city")
                    .HasColumnType("character varying");

                entity.Property(e => e.Country)
                    .HasColumnName("country")
                    .HasColumnType("character varying");

                entity.Property(e => e.Gift)
                    .HasColumnName("gift")
                    .HasColumnType("character varying");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasColumnType("character varying");

                entity.Property(e => e.State)
                    .HasColumnName("state")
                    .HasMaxLength(2);

                entity.Property(e => e.Street)
                    .HasColumnName("street")
                    .HasColumnType("character varying");

                entity.Property(e => e.TyNoteWritten).HasColumnName("ty_note_written");

                entity.Property(e => e.Zip)
                    .HasColumnName("zip")
                    .HasColumnType("character varying");
            });

            modelBuilder.Entity<BabyGifts>(entity =>
            {
                entity.HasKey(e => e.BabyGiftId)
                    .HasName("baby_gifts_pkey");

                entity.ToTable("baby_gifts", "asagiv");

                entity.HasIndex(e => e.BabyGiftId)
                    .HasName("baby_gift_id_desc")
                    .IsUnique()
                    .HasNullSortOrder(new[] { NullSortOrder.NullsLast })
                    .HasSortOrder(new[] { SortOrder.Descending });

                entity.Property(e => e.BabyGiftId)
                    .HasColumnName("baby_gift_id")
                    .HasDefaultValueSql("nextval('baby_gifts_baby_gift_id_seq'::regclass)");

                entity.Property(e => e.Gift)
                    .HasColumnName("gift")
                    .HasColumnType("character varying");

                entity.Property(e => e.TyNoteWritten).HasColumnName("ty_note_written");
            });

            modelBuilder.Entity<People>(entity =>
            {
                entity.ToTable("people", "asagiv");

                entity.HasIndex(e => e.PeopleId)
                    .HasName("people_id_descending")
                    .IsUnique()
                    .HasNullSortOrder(new[] { NullSortOrder.NullsLast })
                    .HasSortOrder(new[] { SortOrder.Descending });

                entity.Property(e => e.PeopleId)
                    .HasColumnName("people_id")
                    .HasDefaultValueSql("nextval('people_people_id_seq'::regclass)");

                entity.Property(e => e.City)
                    .HasColumnName("city")
                    .HasColumnType("character varying");

                entity.Property(e => e.Country)
                    .HasColumnName("country")
                    .HasColumnType("character varying")
                    .HasDefaultValueSql("'USA'::character varying");

                entity.Property(e => e.FamilyName)
                    .HasColumnName("family_name")
                    .HasColumnType("character varying");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("character varying");

                entity.Property(e => e.State)
                    .HasColumnName("state")
                    .HasMaxLength(2);

                entity.Property(e => e.Street)
                    .HasColumnName("street")
                    .HasColumnType("character varying");

                entity.Property(e => e.Zip)
                    .HasColumnName("zip")
                    .HasColumnType("character varying");
            });

            modelBuilder.Entity<PeopleBabyGifts>(entity =>
            {
                entity.HasKey(e => e.PeopleBabyGiftId)
                    .HasName("people_baby_gifts_pkey");

                entity.ToTable("people_baby_gifts", "asagiv");

                entity.Property(e => e.PeopleBabyGiftId)
                    .HasColumnName("people_baby_gift_id")
                    .HasDefaultValueSql("nextval('people_baby_gifts_people_baby_gift_id_seq'::regclass)");

                entity.Property(e => e.BabyGiftId).HasColumnName("baby_gift_id");

                entity.Property(e => e.PeopleId).HasColumnName("people_id");

                entity.HasOne(d => d.BabyGift)
                    .WithMany(p => p.PeopleBabyGifts)
                    .HasForeignKey(d => d.BabyGiftId)
                    .HasConstraintName("people_baby_gifts_baby_gift_id_fkey");

                entity.HasOne(d => d.People)
                    .WithMany(p => p.PeopleBabyGifts)
                    .HasForeignKey(d => d.PeopleId)
                    .HasConstraintName("people_baby_gifts_people_id_fkey");
            });

            modelBuilder.Entity<RobertBabyAnnouncements>(entity =>
            {
                entity.HasKey(e => e.AnnouncementId)
                    .HasName("robert_baby_announcements_pkey");

                entity.ToTable("robert_baby_announcements", "asagiv");

                entity.Property(e => e.AnnouncementId)
                    .HasColumnName("announcement_id")
                    .HasDefaultValueSql("nextval('robert_baby_announcements_announcement_id_seq'::regclass)");

                entity.Property(e => e.PeopleId).HasColumnName("people_id");

                entity.Property(e => e.CustomName).HasColumnName("custom_name");

                entity.HasOne(d => d.People)
                    .WithMany(p => p.RobertBabyAnnouncements)
                    .HasForeignKey(d => d.PeopleId)
                    .HasConstraintName("robert_baby_announcements_people_id_fkey");
            });
        }
    }
}
