﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SettingManagement;

namespace SettingManagement.Migrations
{
    [DbContext(typeof(SettingContext))]
    partial class SettingContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12");

            modelBuilder.Entity("SettingManagement.SettingModel", b =>
                {
                    b.Property<string>("BannerOne")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BannerTwo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContectEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContectNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContectUs")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContectUsAdd")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HeaderLeft")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HeaderRight")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("Id")
                        .HasColumnType("bigint");

                    b.Property<string>("Logo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SmtpEmail")
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("setting");
                });
#pragma warning restore 612, 618
        }
    }
}
