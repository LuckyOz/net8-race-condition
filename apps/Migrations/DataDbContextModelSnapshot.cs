﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using apps.Models.Context;

#nullable disable

namespace apps.Migrations
{
    [DbContext(typeof(DataDbContext))]
    partial class DataDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("apps.Models.Entities.PromoMaster", b =>
                {
                    b.Property<string>("Code")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("code")
                        .HasColumnOrder(0);

                    b.Property<bool>("ActiveFlag")
                        .HasColumnType("boolean")
                        .HasColumnName("active_flag")
                        .HasColumnOrder(7);

                    b.Property<decimal?>("Balance")
                        .IsRequired()
                        .HasColumnType("numeric")
                        .HasColumnName("balance")
                        .HasColumnOrder(3);

                    b.Property<decimal?>("BalanceRemaining")
                        .IsRequired()
                        .HasColumnType("numeric")
                        .HasColumnName("balance_remaining")
                        .HasColumnOrder(4);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("created_date")
                        .HasColumnOrder(5);

                    b.Property<int?>("Qty")
                        .IsRequired()
                        .HasColumnType("integer")
                        .HasColumnName("qty")
                        .HasColumnOrder(1);

                    b.Property<int?>("QtyRemaining")
                        .IsRequired()
                        .HasColumnType("integer")
                        .HasColumnName("qty_remaining")
                        .HasColumnOrder(2);

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("updated_date")
                        .HasColumnOrder(6);

                    b.HasKey("Code");

                    b.ToTable("promo_master");
                });

            modelBuilder.Entity("apps.Models.Entities.PromoTransaction", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id")
                        .HasColumnOrder(0);

                    b.Property<bool>("ActiveFlag")
                        .HasColumnType("boolean")
                        .HasColumnName("active_flag")
                        .HasColumnOrder(6);

                    b.Property<bool>("Commited")
                        .HasColumnType("boolean")
                        .HasColumnName("commited")
                        .HasColumnOrder(3);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("created_date")
                        .HasColumnOrder(4);

                    b.Property<decimal>("TotalBalance")
                        .HasColumnType("numeric")
                        .HasColumnName("total_balance")
                        .HasColumnOrder(1);

                    b.Property<DateTime?>("TransDate")
                        .IsRequired()
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("trans_date")
                        .HasColumnOrder(2);

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("updated_date")
                        .HasColumnOrder(5);

                    b.HasKey("Id");

                    b.ToTable("promo_transaction");
                });

            modelBuilder.Entity("apps.Models.Entities.PromoTransactionDetail", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id")
                        .HasColumnOrder(0);

                    b.Property<bool>("ActiveFlag")
                        .HasColumnType("boolean")
                        .HasColumnName("active_flag")
                        .HasColumnOrder(7);

                    b.Property<decimal?>("Balance")
                        .IsRequired()
                        .HasColumnType("numeric")
                        .HasColumnName("balance")
                        .HasColumnOrder(4);

                    b.Property<string>("Code")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("code")
                        .HasColumnOrder(2);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("created_date")
                        .HasColumnOrder(5);

                    b.Property<Guid?>("PromoTransactionId")
                        .HasColumnType("uuid")
                        .HasColumnName("promo_transaction_id")
                        .HasColumnOrder(1);

                    b.Property<int?>("Qty")
                        .IsRequired()
                        .HasColumnType("integer")
                        .HasColumnName("qty")
                        .HasColumnOrder(3);

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("updated_date")
                        .HasColumnOrder(6);

                    b.HasKey("Id");

                    b.HasIndex("PromoTransactionId");

                    b.ToTable("promo_transaction_detail");
                });

            modelBuilder.Entity("apps.Models.Entities.PromoTransactionDetail", b =>
                {
                    b.HasOne("apps.Models.Entities.PromoTransaction", null)
                        .WithMany("PromoTransactionDetail")
                        .HasForeignKey("PromoTransactionId");
                });

            modelBuilder.Entity("apps.Models.Entities.PromoTransaction", b =>
                {
                    b.Navigation("PromoTransactionDetail");
                });
#pragma warning restore 612, 618
        }
    }
}
