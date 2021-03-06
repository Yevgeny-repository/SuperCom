﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using UserManagement.Data;

namespace UserManagement.Data.Migrations
{
    [DbContext(typeof(UsersContext))]
    [Migration("20210205110656_new2")]
    partial class new2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("UserManagement.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("About")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("ImageData")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneSkype")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TimeZone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WebSite")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = new Guid("3fdc65ee-a96f-458f-bfc4-9cb4be0d8e78"),
                            About = "Hi",
                            FirstName = "Test",
                            LastName = "User",
                            PhoneSkype = "None",
                            TimeZone = "Europe/Warsaw",
                            UserName = "First",
                            WebSite = "http://microsoft.net"
                        },
                        new
                        {
                            Id = new Guid("e6552edd-9a1f-428f-b4a3-fdee7f55df0f"),
                            About = "Hi Second",
                            FirstName = "Test",
                            LastName = "Second User",
                            PhoneSkype = "None",
                            TimeZone = "Europe/Israel",
                            UserName = "Second",
                            WebSite = "http://microsoft.net"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
