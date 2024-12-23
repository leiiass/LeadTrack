﻿// <auto-generated />
using System;
using LeadTrack.Infrastructure.dataBase;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LeadTrack.Infrastructure.Migrations
{
    [DbContext(typeof(LeadTrackContext))]
    partial class LeadTrackContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("LeadTrack.Domain.models.Lead", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("Id"));

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactFirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactFullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactPhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("Suburb")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Lead");

                    b.HasData(
                        new
                        {
                            Id = 5577421,
                            Category = "Painters",
                            ContactFirstName = "Bill",
                            DateCreated = new DateTime(2023, 1, 4, 2, 37, 0, 0, DateTimeKind.Unspecified),
                            Description = "Need to paint 2 aluminum windows and a sliding glass door",
                            Price = 62.00m,
                            Status = 0,
                            Suburb = "Yanderra 2574"
                        },
                        new
                        {
                            Id = 5588872,
                            Category = "Interior Painters",
                            ContactFirstName = "Craig",
                            DateCreated = new DateTime(2023, 1, 4, 1, 15, 0, 0, DateTimeKind.Unspecified),
                            Description = "Internal walls 3 colours",
                            Price = 49.00m,
                            Status = 0,
                            Suburb = "Woolooware 2230"
                        },
                        new
                        {
                            Id = 5141895,
                            Category = "Interior Painters",
                            ContactEmail = "fake@mailinator.com",
                            ContactFirstName = "Pete",
                            ContactPhoneNumber = "041235678",
                            DateCreated = new DateTime(2018, 9, 5, 10, 36, 0, 0, DateTimeKind.Unspecified),
                            Description = "Plaster exposed brick walls (see photos), square off 2 archways (see photos), and expand pantry (see photos).",
                            Price = 49.00m,
                            Status = 1,
                            Suburb = "Woolooware 2230"
                        },
                        new
                        {
                            Id = 5121931,
                            Category = "Home Renovations",
                            ContactEmail = "another.fake@hipmail.com",
                            ContactFirstName = "Cris",
                            ContactFullName = "Sanderson",
                            ContactPhoneNumber = "04987654321",
                            DateCreated = new DateTime(2018, 8, 30, 11, 14, 0, 0, DateTimeKind.Unspecified),
                            Description = "There is a two story building at the front of the main house that's about 10x5 that would like to convert into self contained living area.",
                            Price = 32.00m,
                            Status = 1,
                            Suburb = "Quinns Rocks 6030"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
