﻿// <auto-generated />
using ExpenseApplication.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace ExpenseApplication.Migrations
{
    [DbContext(typeof(ExpenseApplicationContext))]
    partial class ExpenseApplicationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ExpenseApplication.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Employee");
                });

            modelBuilder.Entity("ExpenseApplication.Models.Expense", b =>
                {
                    b.Property<int>("ExpenseId")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("Amount");

                    b.Property<int?>("ExpenseFormId");

                    b.Property<string>("ItemDescription");

                    b.Property<DateTime>("ReceiptDate");

                    b.Property<int>("ReceiptNumber");

                    b.Property<decimal>("ReimbursementAmount");

                    b.HasKey("ExpenseId");

                    b.HasIndex("ExpenseFormId");

                    b.ToTable("Expense");
                });

            modelBuilder.Entity("ExpenseApplication.Models.ExpenseForm", b =>
                {
                    b.Property<int>("ExpenseFormId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("RejectReason");

                    b.Property<int>("State");

                    b.Property<decimal>("Total");

                    b.HasKey("ExpenseFormId");

                    b.ToTable("ExpenseForm");
                });

            modelBuilder.Entity("ExpenseApplication.Models.Expense", b =>
                {
                    b.HasOne("ExpenseApplication.Models.ExpenseForm")
                        .WithMany("Expenses")
                        .HasForeignKey("ExpenseFormId");
                });
#pragma warning restore 612, 618
        }
    }
}
