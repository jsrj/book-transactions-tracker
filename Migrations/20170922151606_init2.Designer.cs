﻿// <auto-generated />
using books_transaction_tracker.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace books_transaction_tracker.Migrations
{
    [DbContext(typeof(TrackerContext))]
    [Migration("20170922151606_init2")]
    partial class init2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("books_transaction_tracker.Models.Book", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Author");

                    b.Property<string>("BookCategory");

                    b.Property<string>("ISBN");

                    b.Property<int>("Issued");

                    b.Property<string>("PublishDate");

                    b.Property<int>("Quantity");

                    b.Property<string>("Title");

                    b.HasKey("ID");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("books_transaction_tracker.Models.Transaction", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Book");

                    b.Property<int>("Closed");

                    b.Property<string>("TransactionDate");

                    b.Property<string>("TransactionType");

                    b.Property<string>("UpdateDate");

                    b.HasKey("ID");

                    b.ToTable("Transactions");
                });
#pragma warning restore 612, 618
        }
    }
}