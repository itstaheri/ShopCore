﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SM.Infrastructure.EfCore;

namespace SM.Infrastructure.EfCore.Migrations
{
    [DbContext(typeof(ShopContext))]
    [Migration("20220118131841_OrderModelStatus")]
    partial class OrderModelStatus
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12");

            modelBuilder.Entity("SM.Domain.OrderAgg.OrderModel", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("DiscountAmount")
                        .HasColumnType("float");

                    b.Property<bool>("IsFinaly")
                        .HasColumnType("bit");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<double>("PayAmount")
                        .HasColumnType("float");

                    b.Property<int>("PaymentMethod")
                        .HasColumnType("int");

                    b.Property<long>("RefId")
                        .HasColumnType("bigint");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<double>("TotalPrice")
                        .HasColumnType("float");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.ToTable("orders");
                });

            modelBuilder.Entity("SM.Domain.Product.ProductModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<long>("CategoryId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Keywoard")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MetaDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NetworkSupport")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OperatingSystem")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Picture")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PictureAlt")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PictureTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("QuantityInStock")
                        .HasColumnType("bigint");

                    b.Property<int>("Ram")
                        .HasColumnType("int");

                    b.Property<int>("Resolution")
                        .HasColumnType("int");

                    b.Property<float>("ScreenSize")
                        .HasColumnType("real");

                    b.Property<string>("ShortDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Slug")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Storage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TouchId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("products");
                });

            modelBuilder.Entity("SM.Domain.ProductCategory.ProductCategoryModel", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Slug")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("productcategories");
                });

            modelBuilder.Entity("SM.Domain.ProductComment.ProductCommentModel", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("Text")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("productComments");
                });

            modelBuilder.Entity("SM.Domain.Sliders.ShopSliderModel", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<string>("ButtonText")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PictureAlt")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Url")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("shopSliders");
                });

            modelBuilder.Entity("SM.Domain.OrderAgg.OrderModel", b =>
                {
                    b.OwnsMany("SM.Domain.OrderAgg.OrderDetailModel", "orderDetails", b1 =>
                        {
                            b1.Property<long>("Id")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("bigint")
                                .UseIdentityColumn();

                            b1.Property<int>("Count")
                                .HasColumnType("int");

                            b1.Property<int>("DiscountRate")
                                .HasColumnType("int");

                            b1.Property<long>("OrderId")
                                .HasColumnType("bigint");

                            b1.Property<int>("ProductId")
                                .HasColumnType("int");

                            b1.Property<double>("TotalPrice")
                                .HasColumnType("float");

                            b1.Property<double>("UnitPrice")
                                .HasColumnType("float");

                            b1.HasKey("Id");

                            b1.HasIndex("OrderId");

                            b1.ToTable("OrderDetailModel");

                            b1.WithOwner("order")
                                .HasForeignKey("OrderId");

                            b1.Navigation("order");
                        });

                    b.Navigation("orderDetails");
                });

            modelBuilder.Entity("SM.Domain.Product.ProductModel", b =>
                {
                    b.HasOne("SM.Domain.ProductCategory.ProductCategoryModel", "productcategory")
                        .WithMany("products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("productcategory");
                });

            modelBuilder.Entity("SM.Domain.ProductComment.ProductCommentModel", b =>
                {
                    b.HasOne("SM.Domain.Product.ProductModel", "product")
                        .WithMany("Comments")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("product");
                });

            modelBuilder.Entity("SM.Domain.Product.ProductModel", b =>
                {
                    b.Navigation("Comments");
                });

            modelBuilder.Entity("SM.Domain.ProductCategory.ProductCategoryModel", b =>
                {
                    b.Navigation("products");
                });
#pragma warning restore 612, 618
        }
    }
}
