// <auto-generated />
using System;
using DataAccess.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataAccess.Migrations
{
    [DbContext(typeof(ApartmentContext))]
    [Migration("20220813212538_mig1")]
    partial class mig1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Entity.ApartmentInformation", b =>
                {
                    b.Property<int>("ApartmentInformationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ApartmentNo")
                        .HasColumnType("int");

                    b.Property<string>("ApartmentType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("AppUserId")
                        .HasColumnType("int");

                    b.Property<string>("BlockNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Floor")
                        .HasColumnType("int");

                    b.HasKey("ApartmentInformationId");

                    b.HasIndex("AppUserId")
                        .IsUnique()
                        .HasFilter("[AppUserId] IS NOT NULL");

                    b.ToTable("ApartmentInformations");

                    b.HasData(
                        new
                        {
                            ApartmentInformationId = 1,
                            ApartmentNo = 1,
                            ApartmentType = "3+1",
                            BlockNo = "A",
                            Floor = 1
                        },
                        new
                        {
                            ApartmentInformationId = 2,
                            ApartmentNo = 2,
                            ApartmentType = "3+1",
                            BlockNo = "A",
                            Floor = 1
                        },
                        new
                        {
                            ApartmentInformationId = 3,
                            ApartmentNo = 3,
                            ApartmentType = "3+1",
                            BlockNo = "A",
                            Floor = 2
                        },
                        new
                        {
                            ApartmentInformationId = 4,
                            ApartmentNo = 4,
                            ApartmentType = "3+1",
                            BlockNo = "A",
                            Floor = 2
                        },
                        new
                        {
                            ApartmentInformationId = 5,
                            ApartmentNo = 5,
                            ApartmentType = "3+1",
                            BlockNo = "A",
                            Floor = 3
                        },
                        new
                        {
                            ApartmentInformationId = 6,
                            ApartmentNo = 6,
                            ApartmentType = "3+1",
                            BlockNo = "A",
                            Floor = 3
                        },
                        new
                        {
                            ApartmentInformationId = 7,
                            ApartmentNo = 7,
                            ApartmentType = "3+1",
                            BlockNo = "A",
                            Floor = 4
                        },
                        new
                        {
                            ApartmentInformationId = 8,
                            ApartmentNo = 8,
                            ApartmentType = "3+1",
                            BlockNo = "A",
                            Floor = 4
                        },
                        new
                        {
                            ApartmentInformationId = 9,
                            ApartmentNo = 9,
                            ApartmentType = "3+1",
                            BlockNo = "A",
                            Floor = 5
                        },
                        new
                        {
                            ApartmentInformationId = 10,
                            ApartmentNo = 10,
                            ApartmentType = "3+1",
                            BlockNo = "A",
                            Floor = 5
                        },
                        new
                        {
                            ApartmentInformationId = 11,
                            ApartmentNo = 1,
                            ApartmentType = "4+1",
                            BlockNo = "B",
                            Floor = 1
                        },
                        new
                        {
                            ApartmentInformationId = 12,
                            ApartmentNo = 2,
                            ApartmentType = "4+1",
                            BlockNo = "B",
                            Floor = 1
                        },
                        new
                        {
                            ApartmentInformationId = 13,
                            ApartmentNo = 3,
                            ApartmentType = "4+1",
                            BlockNo = "B",
                            Floor = 2
                        },
                        new
                        {
                            ApartmentInformationId = 14,
                            ApartmentNo = 4,
                            ApartmentType = "4+1",
                            BlockNo = "B",
                            Floor = 2
                        },
                        new
                        {
                            ApartmentInformationId = 15,
                            ApartmentNo = 5,
                            ApartmentType = "4+1",
                            BlockNo = "B",
                            Floor = 3
                        },
                        new
                        {
                            ApartmentInformationId = 16,
                            ApartmentNo = 6,
                            ApartmentType = "4+1",
                            BlockNo = "B",
                            Floor = 3
                        },
                        new
                        {
                            ApartmentInformationId = 17,
                            ApartmentNo = 7,
                            ApartmentType = "4+1",
                            BlockNo = "B",
                            Floor = 4
                        },
                        new
                        {
                            ApartmentInformationId = 18,
                            ApartmentNo = 8,
                            ApartmentType = "4+1",
                            BlockNo = "B",
                            Floor = 4
                        },
                        new
                        {
                            ApartmentInformationId = 19,
                            ApartmentNo = 9,
                            ApartmentType = "4+1",
                            BlockNo = "B",
                            Floor = 5
                        },
                        new
                        {
                            ApartmentInformationId = 20,
                            ApartmentNo = 10,
                            ApartmentType = "4+1",
                            BlockNo = "B",
                            Floor = 5
                        });
                });

            modelBuilder.Entity("Entity.AppRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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

                    b.ToTable("AspNetRoles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ConcurrencyStamp = "914ebd0b-3055-47c5-ab2b-f3143d17d389",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        });
                });

            modelBuilder.Entity("Entity.AppUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

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

                    b.Property<string>("PlateNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TcNo")
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

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Entity.BillOrder", b =>
                {
                    b.Property<int>("BillOrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ApartmentInformationId")
                        .HasColumnType("int");

                    b.Property<DateTime>("LastPaymentDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("PaymentDate")
                        .HasColumnType("datetime2");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.HasKey("BillOrderId");

                    b.HasIndex("ApartmentInformationId");

                    b.ToTable("BillOrders");

                    b.HasData(
                        new
                        {
                            BillOrderId = 1,
                            ApartmentInformationId = 1,
                            LastPaymentDate = new DateTime(2022, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Aidat",
                            Price = 100.0
                        },
                        new
                        {
                            BillOrderId = 2,
                            ApartmentInformationId = 2,
                            LastPaymentDate = new DateTime(2022, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Aidat",
                            Price = 100.0
                        },
                        new
                        {
                            BillOrderId = 3,
                            ApartmentInformationId = 3,
                            LastPaymentDate = new DateTime(2022, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Aidat",
                            Price = 100.0
                        },
                        new
                        {
                            BillOrderId = 4,
                            ApartmentInformationId = 4,
                            LastPaymentDate = new DateTime(2022, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Aidat",
                            Price = 100.0
                        },
                        new
                        {
                            BillOrderId = 5,
                            ApartmentInformationId = 5,
                            LastPaymentDate = new DateTime(2022, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Aidat",
                            Price = 100.0
                        },
                        new
                        {
                            BillOrderId = 6,
                            ApartmentInformationId = 6,
                            LastPaymentDate = new DateTime(2022, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Aidat",
                            Price = 100.0
                        },
                        new
                        {
                            BillOrderId = 7,
                            ApartmentInformationId = 7,
                            LastPaymentDate = new DateTime(2022, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Aidat",
                            Price = 100.0
                        },
                        new
                        {
                            BillOrderId = 8,
                            ApartmentInformationId = 8,
                            LastPaymentDate = new DateTime(2022, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Aidat",
                            Price = 100.0
                        },
                        new
                        {
                            BillOrderId = 9,
                            ApartmentInformationId = 9,
                            LastPaymentDate = new DateTime(2022, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Aidat",
                            Price = 100.0
                        },
                        new
                        {
                            BillOrderId = 10,
                            ApartmentInformationId = 10,
                            LastPaymentDate = new DateTime(2022, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Aidat",
                            Price = 100.0
                        },
                        new
                        {
                            BillOrderId = 11,
                            ApartmentInformationId = 11,
                            LastPaymentDate = new DateTime(2022, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Aidat",
                            Price = 100.0
                        },
                        new
                        {
                            BillOrderId = 12,
                            ApartmentInformationId = 12,
                            LastPaymentDate = new DateTime(2022, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Aidat",
                            Price = 100.0
                        },
                        new
                        {
                            BillOrderId = 13,
                            ApartmentInformationId = 13,
                            LastPaymentDate = new DateTime(2022, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Aidat",
                            Price = 100.0
                        },
                        new
                        {
                            BillOrderId = 14,
                            ApartmentInformationId = 14,
                            LastPaymentDate = new DateTime(2022, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Aidat",
                            Price = 100.0
                        },
                        new
                        {
                            BillOrderId = 15,
                            ApartmentInformationId = 15,
                            LastPaymentDate = new DateTime(2022, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Aidat",
                            Price = 100.0
                        },
                        new
                        {
                            BillOrderId = 16,
                            ApartmentInformationId = 16,
                            LastPaymentDate = new DateTime(2022, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Aidat",
                            Price = 100.0
                        },
                        new
                        {
                            BillOrderId = 17,
                            ApartmentInformationId = 17,
                            LastPaymentDate = new DateTime(2022, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Aidat",
                            Price = 100.0
                        },
                        new
                        {
                            BillOrderId = 18,
                            ApartmentInformationId = 18,
                            LastPaymentDate = new DateTime(2022, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Aidat",
                            Price = 100.0
                        },
                        new
                        {
                            BillOrderId = 19,
                            ApartmentInformationId = 19,
                            LastPaymentDate = new DateTime(2022, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Aidat",
                            Price = 100.0
                        },
                        new
                        {
                            BillOrderId = 20,
                            ApartmentInformationId = 20,
                            LastPaymentDate = new DateTime(2022, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Aidat",
                            Price = 100.0
                        },
                        new
                        {
                            BillOrderId = 21,
                            ApartmentInformationId = 1,
                            LastPaymentDate = new DateTime(2022, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Su",
                            Price = 25.0
                        },
                        new
                        {
                            BillOrderId = 22,
                            ApartmentInformationId = 2,
                            LastPaymentDate = new DateTime(2022, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Su",
                            Price = 25.0
                        },
                        new
                        {
                            BillOrderId = 23,
                            ApartmentInformationId = 3,
                            LastPaymentDate = new DateTime(2022, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Su",
                            Price = 25.0
                        },
                        new
                        {
                            BillOrderId = 24,
                            ApartmentInformationId = 4,
                            LastPaymentDate = new DateTime(2022, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Su",
                            Price = 25.0
                        },
                        new
                        {
                            BillOrderId = 25,
                            ApartmentInformationId = 5,
                            LastPaymentDate = new DateTime(2022, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Su",
                            Price = 25.0
                        },
                        new
                        {
                            BillOrderId = 26,
                            ApartmentInformationId = 6,
                            LastPaymentDate = new DateTime(2022, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Su",
                            Price = 25.0
                        },
                        new
                        {
                            BillOrderId = 27,
                            ApartmentInformationId = 7,
                            LastPaymentDate = new DateTime(2022, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Su",
                            Price = 25.0
                        },
                        new
                        {
                            BillOrderId = 28,
                            ApartmentInformationId = 8,
                            LastPaymentDate = new DateTime(2022, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Su",
                            Price = 25.0
                        },
                        new
                        {
                            BillOrderId = 29,
                            ApartmentInformationId = 9,
                            LastPaymentDate = new DateTime(2022, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Su",
                            Price = 25.0
                        },
                        new
                        {
                            BillOrderId = 30,
                            ApartmentInformationId = 10,
                            LastPaymentDate = new DateTime(2022, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Su",
                            Price = 25.0
                        },
                        new
                        {
                            BillOrderId = 31,
                            ApartmentInformationId = 11,
                            LastPaymentDate = new DateTime(2022, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Su",
                            Price = 25.0
                        },
                        new
                        {
                            BillOrderId = 32,
                            ApartmentInformationId = 12,
                            LastPaymentDate = new DateTime(2022, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Su",
                            Price = 25.0
                        },
                        new
                        {
                            BillOrderId = 33,
                            ApartmentInformationId = 13,
                            LastPaymentDate = new DateTime(2022, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Su",
                            Price = 25.0
                        },
                        new
                        {
                            BillOrderId = 34,
                            ApartmentInformationId = 14,
                            LastPaymentDate = new DateTime(2022, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Su",
                            Price = 25.0
                        },
                        new
                        {
                            BillOrderId = 35,
                            ApartmentInformationId = 15,
                            LastPaymentDate = new DateTime(2022, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Su",
                            Price = 25.0
                        },
                        new
                        {
                            BillOrderId = 36,
                            ApartmentInformationId = 16,
                            LastPaymentDate = new DateTime(2022, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Su",
                            Price = 25.0
                        },
                        new
                        {
                            BillOrderId = 37,
                            ApartmentInformationId = 17,
                            LastPaymentDate = new DateTime(2022, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Su",
                            Price = 25.0
                        },
                        new
                        {
                            BillOrderId = 38,
                            ApartmentInformationId = 18,
                            LastPaymentDate = new DateTime(2022, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Su",
                            Price = 25.0
                        },
                        new
                        {
                            BillOrderId = 39,
                            ApartmentInformationId = 19,
                            LastPaymentDate = new DateTime(2022, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Su",
                            Price = 25.0
                        },
                        new
                        {
                            BillOrderId = 40,
                            ApartmentInformationId = 20,
                            LastPaymentDate = new DateTime(2022, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Su",
                            Price = 25.0
                        });
                });

            modelBuilder.Entity("Entity.Message", b =>
                {
                    b.Property<int>("MessageID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AppUserId")
                        .HasColumnType("int");

                    b.Property<DateTime>("MessageDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("MessageDetails")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("MessageStatus")
                        .HasColumnType("bit");

                    b.Property<string>("Subject")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MessageID");

                    b.HasIndex("AppUserId");

                    b.ToTable("Messages");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Entity.ApartmentInformation", b =>
                {
                    b.HasOne("Entity.AppUser", "User")
                        .WithOne("ApartmentInformation")
                        .HasForeignKey("Entity.ApartmentInformation", "AppUserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Entity.BillOrder", b =>
                {
                    b.HasOne("Entity.ApartmentInformation", "ApartmentInformation")
                        .WithMany("BillOrders")
                        .HasForeignKey("ApartmentInformationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ApartmentInformation");
                });

            modelBuilder.Entity("Entity.Message", b =>
                {
                    b.HasOne("Entity.AppUser", "AppUser")
                        .WithMany()
                        .HasForeignKey("AppUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AppUser");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.HasOne("Entity.AppRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.HasOne("Entity.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.HasOne("Entity.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.HasOne("Entity.AppRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entity.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.HasOne("Entity.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Entity.ApartmentInformation", b =>
                {
                    b.Navigation("BillOrders");
                });

            modelBuilder.Entity("Entity.AppUser", b =>
                {
                    b.Navigation("ApartmentInformation");
                });
#pragma warning restore 612, 618
        }
    }
}
