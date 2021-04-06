﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Swagger_API.Context;

namespace Swagger_API.Migrations
{
    [DbContext(typeof(CRUDContext))]
    [Migration("20210401102222_SecondMigration")]
    partial class SecondMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Swagger_API.Models.BatchAclReadGroupsTable", b =>
                {
                    b.Property<int>("SrNo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AciID")
                        .HasColumnType("int");

                    b.Property<string>("Groupdetail")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SrNo");

                    b.ToTable("BatchAclReadGroupsTables");
                });

            modelBuilder.Entity("Swagger_API.Models.BatchAclReadUsersTable", b =>
                {
                    b.Property<int>("SrNo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AciID")
                        .HasColumnType("int");

                    b.Property<string>("Usersdetail")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SrNo");

                    b.ToTable("BatchAclReadUsersTables");
                });

            modelBuilder.Entity("Swagger_API.Models.BatchAclTable", b =>
                {
                    b.Property<int>("SrNo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AciID")
                        .HasColumnType("int");

                    b.Property<string>("BatchID")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SrNo");

                    b.ToTable("BatchAclTables");
                });

            modelBuilder.Entity("Swagger_API.Models.BatchAttributeTable", b =>
                {
                    b.Property<int>("SrNo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BatchID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Keydetail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Valuedetail")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SrNo");

                    b.ToTable("BatchAttributeTables");
                });

            modelBuilder.Entity("Swagger_API.Models.BatchTable", b =>
                {
                    b.Property<int>("SrNo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BatchID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BusinessUnit")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("EmpiryDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("Publishdate")
                        .HasColumnType("datetime2");

                    b.HasKey("SrNo");

                    b.ToTable("BatchTables");
                });

            modelBuilder.Entity("Swagger_API.Models.Entity_Model.BatchBusinessUnitTable", b =>
                {
                    b.Property<int>("SrNo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BusinessUnitName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SrNo");

                    b.ToTable("BatchBusinessUnitTables");
                });
#pragma warning restore 612, 618
        }
    }
}
