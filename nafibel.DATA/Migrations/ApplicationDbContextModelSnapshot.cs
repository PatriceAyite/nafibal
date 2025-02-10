﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using nafibel.DATA.Repositories;

#nullable disable

namespace nafibel.DATA.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Appointment", b =>
                {
                    b.Property<byte[]>("Id")
                        .HasColumnType("varbinary(16)");

                    b.Property<DateOnly>("AppointmentDate")
                        .HasColumnType("date");

                    b.Property<byte[]>("ClientId")
                        .HasColumnType("varbinary(16)");

                    b.Property<string>("ClientName")
                        .IsRequired()
                        .HasMaxLength(500)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("CountryCode")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<TimeOnly>("From")
                        .HasColumnType("time");

                    b.Property<byte[]>("HairStyleId")
                        .IsRequired()
                        .HasColumnType("varbinary(16)");

                    b.Property<byte[]>("HairdresserId")
                        .IsRequired()
                        .HasColumnType("varbinary(16)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<double?>("Latitude")
                        .HasColumnType("float");

                    b.Property<int>("LocationType")
                        .HasColumnType("int");

                    b.Property<double?>("Longitude")
                        .HasColumnType("float");

                    b.Property<string>("ModifiedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Region")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.Property<TimeOnly>("To")
                        .HasColumnType("time");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.HasIndex("HairStyleId");

                    b.HasIndex("HairdresserId");

                    b.ToTable("Appointments");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("nafibel.DATA.Models.Entities.Client", b =>
                {
                    b.Property<byte[]>("Id")
                        .HasColumnType("varbinary(16)");

                    b.Property<int>("AgeRange")
                        .HasColumnType("int");

                    b.Property<string>("CountryCode")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(255)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(255)");

                    b.Property<double?>("Latitude")
                        .HasColumnType("float");

                    b.Property<double?>("Longitude")
                        .HasColumnType("float");

                    b.Property<string>("MiddleName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("ModifiedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Region")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("nafibel.DATA.Models.Entities.HairStyle", b =>
                {
                    b.Property<byte[]>("Id")
                        .HasColumnType("varbinary(16)");

                    b.Property<int?>("AverageTime")
                        .HasColumnType("int");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(4000)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(4000)");

                    b.PrimitiveCollection<string>("HairType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<int>("Length")
                        .HasColumnType("int");

                    b.Property<int>("MaintenanceLevel")
                        .HasColumnType("int");

                    b.Property<string>("ModifiedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("Sex")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("HairStyles");
                });

            modelBuilder.Entity("nafibel.DATA.Models.Entities.HairStyleImage", b =>
                {
                    b.Property<byte[]>("Id")
                        .HasColumnType("varbinary(16)");

                    b.Property<string>("AltText")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<byte[]>("HairStyleId")
                        .IsRequired()
                        .HasColumnType("varbinary(16)");

                    b.Property<byte>("Order")
                        .HasColumnType("tinyint");

                    b.HasKey("Id");

                    b.HasIndex("HairStyleId");

                    b.ToTable("HairStyleImages");
                });

            modelBuilder.Entity("nafibel.DATA.Models.Entities.HairStyleNameLocale", b =>
                {
                    b.Property<byte[]>("Id")
                        .HasColumnType("varbinary(16)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(4000)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(4000)");

                    b.Property<byte[]>("HairstyleId")
                        .IsRequired()
                        .HasColumnType("varbinary(16)");

                    b.Property<string>("Locale")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("HairstyleId");

                    b.ToTable("HairStyleNameLocales");
                });

            modelBuilder.Entity("nafibel.DATA.Models.Entities.HairStylePopularity", b =>
                {
                    b.Property<byte[]>("HairStyleId")
                        .HasColumnType("varbinary(16)");

                    b.Property<short>("Popularity")
                        .HasColumnType("smallint");

                    b.HasKey("HairStyleId");

                    b.ToTable("HairStylePopularities");
                });

            modelBuilder.Entity("nafibel.DATA.Models.Entities.HairStylePrice", b =>
                {
                    b.Property<byte[]>("Id")
                        .HasColumnType("varbinary(16)");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<byte[]>("HairStyleId")
                        .IsRequired()
                        .HasColumnType("varbinary(16)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("HairStyleId");

                    b.ToTable("HairStylePrices");
                });

            modelBuilder.Entity("nafibel.DATA.Models.Entities.Haircut", b =>
                {
                    b.Property<byte[]>("Id")
                        .HasColumnType("varbinary(16)");

                    b.Property<byte[]>("AppointmentId")
                        .IsRequired()
                        .HasColumnType("varbinary(16)");

                    b.Property<DateTime?>("EndHaircutDatetime")
                        .HasColumnType("datetime2");

                    b.Property<byte[]>("HairStyleId")
                        .IsRequired()
                        .HasColumnType("varbinary(16)");

                    b.Property<DateTime?>("StartHaircutDatetime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("HairStyleId");

                    b.ToTable("Haircuts");
                });

            modelBuilder.Entity("nafibel.DATA.Models.Entities.Hairdresser", b =>
                {
                    b.Property<byte[]>("Id")
                        .HasColumnType("varbinary(16)");

                    b.Property<string>("CountryCode")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("Dob")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(255)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(255)");

                    b.Property<double?>("Latitude")
                        .HasColumnType("float");

                    b.Property<double?>("Longitude")
                        .HasColumnType("float");

                    b.Property<string>("MiddleName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("ModifiedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("ProfileImage")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)");

                    b.Property<string>("ProfileText")
                        .HasMaxLength(4000)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(4000)");

                    b.Property<string>("Region")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("Hairdressers");
                });

            modelBuilder.Entity("nafibel.DATA.Models.Entities.HairdresserHairStyle", b =>
                {
                    b.Property<byte[]>("HairdresserId")
                        .HasColumnType("varbinary(16)");

                    b.Property<byte[]>("HairStyleId")
                        .HasColumnType("varbinary(16)");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.HasKey("HairdresserId", "HairStyleId");

                    b.HasIndex("HairStyleId");

                    b.ToTable("HairdresserHairStyles");
                });

            modelBuilder.Entity("nafibel.DATA.Models.Entities.Payment", b =>
                {
                    b.Property<byte[]>("Id")
                        .HasColumnType("varbinary(16)");

                    b.Property<double>("Amount")
                        .HasColumnType("float");

                    b.Property<byte[]>("AppointmentId")
                        .HasColumnType("varbinary(16)");

                    b.Property<byte[]>("ClientId")
                        .HasColumnType("varbinary(16)");

                    b.Property<string>("ClientName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("ExternalId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ExternalPayload")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("HaircutId")
                        .IsRequired()
                        .HasColumnType("varbinary(16)");

                    b.Property<int>("PaymentType")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AppointmentId");

                    b.HasIndex("HaircutId");

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("nafibel.DATA.Models.Entities.Rating", b =>
                {
                    b.Property<byte[]>("Id")
                        .HasColumnType("varbinary(16)");

                    b.Property<byte[]>("AppointmentId")
                        .IsRequired()
                        .HasColumnType("varbinary(16)");

                    b.Property<string>("Comments")
                        .HasMaxLength(4000)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(4000)");

                    b.Property<byte[]>("HairStyleId")
                        .IsRequired()
                        .HasColumnType("varbinary(16)");

                    b.Property<byte[]>("HairdresserId")
                        .IsRequired()
                        .HasColumnType("varbinary(16)");

                    b.Property<short>("Rate")
                        .HasColumnType("smallint");

                    b.HasKey("Id");

                    b.ToTable("Ratings");
                });

            modelBuilder.Entity("nafibel.DATA.Models.Identity.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Appointment", b =>
                {
                    b.HasOne("nafibel.DATA.Models.Entities.Client", "Client")
                        .WithMany()
                        .HasForeignKey("ClientId");

                    b.HasOne("nafibel.DATA.Models.Entities.HairStyle", "HairStyle")
                        .WithMany()
                        .HasForeignKey("HairStyleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("nafibel.DATA.Models.Entities.Hairdresser", "Hairdresser")
                        .WithMany()
                        .HasForeignKey("HairdresserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");

                    b.Navigation("HairStyle");

                    b.Navigation("Hairdresser");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("nafibel.DATA.Models.Identity.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("nafibel.DATA.Models.Identity.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("nafibel.DATA.Models.Identity.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("nafibel.DATA.Models.Identity.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("nafibel.DATA.Models.Entities.HairStyleImage", b =>
                {
                    b.HasOne("nafibel.DATA.Models.Entities.HairStyle", "HairStyle")
                        .WithMany("Images")
                        .HasForeignKey("HairStyleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("HairStyle");
                });

            modelBuilder.Entity("nafibel.DATA.Models.Entities.HairStyleNameLocale", b =>
                {
                    b.HasOne("nafibel.DATA.Models.Entities.HairStyle", "HairStyle")
                        .WithMany("Locales")
                        .HasForeignKey("HairstyleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("HairStyle");
                });

            modelBuilder.Entity("nafibel.DATA.Models.Entities.HairStylePrice", b =>
                {
                    b.HasOne("nafibel.DATA.Models.Entities.HairStyle", "HairStyle")
                        .WithMany("HairStylePrices")
                        .HasForeignKey("HairStyleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("HairStyle");
                });

            modelBuilder.Entity("nafibel.DATA.Models.Entities.Haircut", b =>
                {
                    b.HasOne("nafibel.DATA.Models.Entities.HairStyle", "HairStyle")
                        .WithMany()
                        .HasForeignKey("HairStyleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("HairStyle");
                });

            modelBuilder.Entity("nafibel.DATA.Models.Entities.HairdresserHairStyle", b =>
                {
                    b.HasOne("nafibel.DATA.Models.Entities.HairStyle", "HairStyle")
                        .WithMany("Hairdressers")
                        .HasForeignKey("HairStyleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("nafibel.DATA.Models.Entities.Hairdresser", "Hairdresser")
                        .WithMany("HairStyles")
                        .HasForeignKey("HairdresserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("HairStyle");

                    b.Navigation("Hairdresser");
                });

            modelBuilder.Entity("nafibel.DATA.Models.Entities.Payment", b =>
                {
                    b.HasOne("Appointment", null)
                        .WithMany("Payments")
                        .HasForeignKey("AppointmentId");

                    b.HasOne("nafibel.DATA.Models.Entities.Haircut", "Haircut")
                        .WithMany()
                        .HasForeignKey("HaircutId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Haircut");
                });

            modelBuilder.Entity("nafibel.DATA.Models.Identity.ApplicationUser", b =>
                {
                    b.OwnsMany("nafibel.DATA.Models.Identity.RefreshToken", "RefreshTokens", b1 =>
                        {
                            b1.Property<string>("ApplicationUserId")
                                .HasColumnType("nvarchar(450)");

                            b1.Property<int>("Id")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("int");

                            SqlServerPropertyBuilderExtensions.UseIdentityColumn(b1.Property<int>("Id"));

                            b1.Property<DateTime>("CreatedOn")
                                .HasColumnType("datetime2");

                            b1.Property<DateTime>("ExpiresOn")
                                .HasColumnType("datetime2");

                            b1.Property<DateTime?>("RevokedOn")
                                .HasColumnType("datetime2");

                            b1.Property<string>("Token")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.HasKey("ApplicationUserId", "Id");

                            b1.ToTable("RefreshToken");

                            b1.WithOwner()
                                .HasForeignKey("ApplicationUserId");
                        });

                    b.Navigation("RefreshTokens");
                });

            modelBuilder.Entity("Appointment", b =>
                {
                    b.Navigation("Payments");
                });

            modelBuilder.Entity("nafibel.DATA.Models.Entities.HairStyle", b =>
                {
                    b.Navigation("HairStylePrices");

                    b.Navigation("Hairdressers");

                    b.Navigation("Images");

                    b.Navigation("Locales");
                });

            modelBuilder.Entity("nafibel.DATA.Models.Entities.Hairdresser", b =>
                {
                    b.Navigation("HairStyles");
                });
#pragma warning restore 612, 618
        }
    }
}
