﻿// <auto-generated />
using System;
using AM.Infrastracture.Efcore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AM.Infrastracture.Efcore.Migrations
{
    [DbContext(typeof(AccountContext))]
    partial class AccountContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12");

            modelBuilder.Entity("AM.Domain.AccountAgg.AccountModel", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsRemoved")
                        .HasColumnType("bit");

                    b.Property<string>("Number")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProfilePicture")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("RoleId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("SignupDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("accounts");
                });

            modelBuilder.Entity("AM.Domain.Role.RoleModel", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("roles");
                });

            modelBuilder.Entity("AM.Domain.AccountAgg.AccountModel", b =>
                {
                    b.HasOne("AM.Domain.Role.RoleModel", "role")
                        .WithMany("accounts")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("role");
                });

            modelBuilder.Entity("AM.Domain.Role.RoleModel", b =>
                {
                    b.OwnsMany("AM.Domain.Role.Permission", "Permissions", b1 =>
                        {
                            b1.Property<long>("Id")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("bigint")
                                .UseIdentityColumn();

                            b1.Property<int>("Code")
                                .HasColumnType("int");

                            b1.Property<long>("RoleId")
                                .HasColumnType("bigint");

                            b1.HasKey("Id");

                            b1.HasIndex("RoleId");

                            b1.ToTable("Permission");

                            b1.WithOwner("role")
                                .HasForeignKey("RoleId");

                            b1.Navigation("role");
                        });

                    b.Navigation("Permissions");
                });

            modelBuilder.Entity("AM.Domain.Role.RoleModel", b =>
                {
                    b.Navigation("accounts");
                });
#pragma warning restore 612, 618
        }
    }
}
