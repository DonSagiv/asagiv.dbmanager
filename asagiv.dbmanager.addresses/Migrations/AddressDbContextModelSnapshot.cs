﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using asagiv.dbmanager.addresses;

namespace asagiv.dbmanager.addresses.Migrations
{
    [DbContext(typeof(AddressDbContext))]
    partial class AddressDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("asagiv.dbmanager.addresses.Address", b =>
                {
                    b.Property<long>("addressId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("City")
                        .HasColumnType("text");

                    b.Property<string>("Country")
                        .HasColumnType("text");

                    b.Property<string>("State")
                        .HasColumnType("character varying(2)")
                        .HasMaxLength(2);

                    b.Property<string>("Street")
                        .HasColumnType("text");

                    b.Property<string>("Zip")
                        .HasColumnType("text");

                    b.Property<long>("familyId")
                        .HasColumnType("bigint");

                    b.HasKey("addressId");

                    b.HasIndex("familyId");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("asagiv.dbmanager.addresses.BabyGift", b =>
                {
                    b.Property<long>("giftId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("giftDescription")
                        .HasColumnType("text");

                    b.HasKey("giftId");

                    b.ToTable("BabyGifts");
                });

            modelBuilder.Entity("asagiv.dbmanager.addresses.Family", b =>
                {
                    b.Property<long>("familyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("addressHeader")
                        .HasColumnType("text");

                    b.Property<string>("familyName")
                        .HasColumnType("text");

                    b.HasKey("familyId");

                    b.ToTable("Families");
                });

            modelBuilder.Entity("asagiv.dbmanager.addresses.FamilyBabyGift", b =>
                {
                    b.Property<long>("familyBabyGiftId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<long>("babyGiftId")
                        .HasColumnType("bigint");

                    b.Property<long>("familyId")
                        .HasColumnType("bigint");

                    b.Property<bool>("thankYouNoteWritten")
                        .HasColumnType("boolean");

                    b.HasKey("familyBabyGiftId");

                    b.HasIndex("babyGiftId");

                    b.HasIndex("familyId");

                    b.ToTable("FamilyBabyGifts");
                });

            modelBuilder.Entity("asagiv.dbmanager.addresses.Person", b =>
                {
                    b.Property<long>("personId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("dateOfBirth")
                        .HasColumnType("timestamp without time zone");

                    b.Property<long>("familyId")
                        .HasColumnType("bigint");

                    b.Property<string>("personName")
                        .HasColumnType("text");

                    b.HasKey("personId");

                    b.HasIndex("familyId");

                    b.ToTable("Person");
                });

            modelBuilder.Entity("asagiv.dbmanager.addresses.Address", b =>
                {
                    b.HasOne("asagiv.dbmanager.addresses.Family", "family")
                        .WithMany("addresses")
                        .HasForeignKey("familyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("asagiv.dbmanager.addresses.FamilyBabyGift", b =>
                {
                    b.HasOne("asagiv.dbmanager.addresses.BabyGift", "babyGift")
                        .WithMany()
                        .HasForeignKey("babyGiftId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("asagiv.dbmanager.addresses.Family", "family")
                        .WithMany()
                        .HasForeignKey("familyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("asagiv.dbmanager.addresses.Person", b =>
                {
                    b.HasOne("asagiv.dbmanager.addresses.Family", "family")
                        .WithMany("familyMembers")
                        .HasForeignKey("familyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}