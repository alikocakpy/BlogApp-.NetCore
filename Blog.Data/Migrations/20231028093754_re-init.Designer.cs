﻿// <auto-generated />
using System;
using Blog.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Blog.Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20231028093754_re-init")]
    partial class reinit
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Blog.Entity.Entities.AppRole", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

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

                    b.HasData(
                        new
                        {
                            Id = new Guid("3fda26aa-7900-470c-bd41-d885ed911b5f"),
                            ConcurrencyStamp = "d2e66578-3ccb-4981-9f0b-fffd74001a0e",
                            Name = "SuperAdmin",
                            NormalizedName = "SUPERADMIN"
                        },
                        new
                        {
                            Id = new Guid("9824e1c0-c194-4ad3-a70f-e11efcc6a8fd"),
                            ConcurrencyStamp = "4839fba1-223e-4a76-bce8-fe0808358d2a",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = new Guid("bae9f1d8-4b38-4bfe-b331-68f041168aff"),
                            ConcurrencyStamp = "0640bf55-c511-414e-8c29-a25cc5ac1dbe",
                            Name = "User",
                            NormalizedName = "USER"
                        });
                });

            modelBuilder.Entity("Blog.Entity.Entities.AppRoleClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Blog.Entity.Entities.AppUser", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("ImageId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LastName")
                        .IsRequired()
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

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("ImageId");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("443b2355-ab33-4aa0-b45c-7ff53a21d738"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "89b59bfe-c299-4b3f-a387-1f1599ede726",
                            Email = "alikocak@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Ali",
                            ImageId = new Guid("38ab58f5-e29c-4b07-8e56-84ea9b042360"),
                            LastName = "Koçak",
                            LockoutEnabled = false,
                            NormalizedEmail = "ALIKOCAK@GMAIL.COM",
                            NormalizedUserName = "ALIKOCAK@GMAIL.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEGJIJNNFCnrA847KjaNlBTgVgQHHSLe1UfK55Rbuxe5tyaHAuTdHDRXyox9Af/GnCg==",
                            PhoneNumber = "1234567890",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "4cbc0523-0846-4d68-aa7e-33b40ddd2b93",
                            TwoFactorEnabled = false,
                            UserName = "alikocak@gmail.com"
                        },
                        new
                        {
                            Id = new Guid("7b455a65-ad54-40c0-86c9-70aeca8ecb80"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "577effd7-51d5-461e-8636-a95574485e53",
                            Email = "admin@gmail.com",
                            EmailConfirmed = false,
                            FirstName = "Admin",
                            ImageId = new Guid("a8ed4358-ae31-460a-a510-cc916ed7e235"),
                            LastName = "yetkikli",
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@GMAIL.COM",
                            NormalizedUserName = "ADMIN@GMAIL.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEJJeROhQMvJroOPYA4l51hNWXnP8j9/NXHXitVqOfF7OrWrAIx4tlOSlqzJ7Rdd9Tw==",
                            PhoneNumber = "1234567890",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "dadd5b67-7000-4962-8e9d-f59c1e3fd2f2",
                            TwoFactorEnabled = false,
                            UserName = "admin@gmail.com"
                        });
                });

            modelBuilder.Entity("Blog.Entity.Entities.AppUserClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Blog.Entity.Entities.AppUserLogin", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Blog.Entity.Entities.AppUserRole", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = new Guid("443b2355-ab33-4aa0-b45c-7ff53a21d738"),
                            RoleId = new Guid("3fda26aa-7900-470c-bd41-d885ed911b5f")
                        },
                        new
                        {
                            UserId = new Guid("7b455a65-ad54-40c0-86c9-70aeca8ecb80"),
                            RoleId = new Guid("9824e1c0-c194-4ad3-a70f-e11efcc6a8fd")
                        });
                });

            modelBuilder.Entity("Blog.Entity.Entities.AppUserToken", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Blog.Entity.Entities.Article", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeletedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("ImageId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("ViewCount")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("ImageId");

                    b.HasIndex("UserId");

                    b.ToTable("Articles");

                    b.HasData(
                        new
                        {
                            Id = new Guid("21cc3a55-0f32-4d40-a4d1-95c1e8898326"),
                            CategoryId = new Guid("ee0433d7-ca05-4923-9351-3a6dee2fde0f"),
                            Content = "First Title Content",
                            CreatedBy = "Admin",
                            CreatedDate = new DateTime(2023, 10, 28, 12, 37, 54, 115, DateTimeKind.Local).AddTicks(2404),
                            ImageId = new Guid("38ab58f5-e29c-4b07-8e56-84ea9b042360"),
                            IsDeleted = false,
                            Title = "Title 1",
                            UserId = new Guid("443b2355-ab33-4aa0-b45c-7ff53a21d738"),
                            ViewCount = 15
                        },
                        new
                        {
                            Id = new Guid("b27e3052-d461-41e0-8469-0b53db86ef66"),
                            CategoryId = new Guid("0cd944d0-911c-4269-b527-4df9afbcb3e7"),
                            Content = "Second Title Content",
                            CreatedBy = "Admin",
                            CreatedDate = new DateTime(2023, 10, 28, 12, 37, 54, 115, DateTimeKind.Local).AddTicks(2411),
                            ImageId = new Guid("a8ed4358-ae31-460a-a510-cc916ed7e235"),
                            IsDeleted = false,
                            Title = "Title 2",
                            UserId = new Guid("7b455a65-ad54-40c0-86c9-70aeca8ecb80"),
                            ViewCount = 25
                        });
                });

            modelBuilder.Entity("Blog.Entity.Entities.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeletedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = new Guid("ee0433d7-ca05-4923-9351-3a6dee2fde0f"),
                            CreatedBy = "Admin",
                            CreatedDate = new DateTime(2023, 10, 28, 12, 37, 54, 115, DateTimeKind.Local).AddTicks(3875),
                            IsDeleted = false,
                            Name = "Category 1"
                        },
                        new
                        {
                            Id = new Guid("0cd944d0-911c-4269-b527-4df9afbcb3e7"),
                            CreatedBy = "Admin",
                            CreatedDate = new DateTime(2023, 10, 28, 12, 37, 54, 115, DateTimeKind.Local).AddTicks(3880),
                            IsDeleted = false,
                            Name = "Category 2"
                        });
                });

            modelBuilder.Entity("Blog.Entity.Entities.Image", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeletedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FileName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FileType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Images");

                    b.HasData(
                        new
                        {
                            Id = new Guid("38ab58f5-e29c-4b07-8e56-84ea9b042360"),
                            CreatedBy = "Admin",
                            CreatedDate = new DateTime(2023, 10, 28, 12, 37, 54, 115, DateTimeKind.Local).AddTicks(5237),
                            FileName = "images/image1",
                            FileType = "jpg",
                            IsDeleted = false
                        },
                        new
                        {
                            Id = new Guid("a8ed4358-ae31-460a-a510-cc916ed7e235"),
                            CreatedBy = "Admin",
                            CreatedDate = new DateTime(2023, 10, 28, 12, 37, 54, 115, DateTimeKind.Local).AddTicks(5241),
                            FileName = "images/image2",
                            FileType = "jpg",
                            IsDeleted = false
                        });
                });

            modelBuilder.Entity("Blog.Entity.Entities.AppRoleClaim", b =>
                {
                    b.HasOne("Blog.Entity.Entities.AppRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Blog.Entity.Entities.AppUser", b =>
                {
                    b.HasOne("Blog.Entity.Entities.Image", "Image")
                        .WithMany("Users")
                        .HasForeignKey("ImageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Image");
                });

            modelBuilder.Entity("Blog.Entity.Entities.AppUserClaim", b =>
                {
                    b.HasOne("Blog.Entity.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Blog.Entity.Entities.AppUserLogin", b =>
                {
                    b.HasOne("Blog.Entity.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Blog.Entity.Entities.AppUserRole", b =>
                {
                    b.HasOne("Blog.Entity.Entities.AppRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Blog.Entity.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Blog.Entity.Entities.AppUserToken", b =>
                {
                    b.HasOne("Blog.Entity.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Blog.Entity.Entities.Article", b =>
                {
                    b.HasOne("Blog.Entity.Entities.Category", "Category")
                        .WithMany("Articles")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Blog.Entity.Entities.Image", "Image")
                        .WithMany("Articles")
                        .HasForeignKey("ImageId");

                    b.HasOne("Blog.Entity.Entities.AppUser", "User")
                        .WithMany("Articles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Image");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Blog.Entity.Entities.AppUser", b =>
                {
                    b.Navigation("Articles");
                });

            modelBuilder.Entity("Blog.Entity.Entities.Category", b =>
                {
                    b.Navigation("Articles");
                });

            modelBuilder.Entity("Blog.Entity.Entities.Image", b =>
                {
                    b.Navigation("Articles");

                    b.Navigation("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
