﻿// <auto-generated />
using System;
using DirectorPortalDatabase;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DirectorPortalDatabase.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20210202205008_InitialDatabase")]
    partial class InitialDatabase
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.11");

            modelBuilder.Entity("DirectorPortalDatabase.Models.Address", b =>
                {
                    b.Property<int>("GIntId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("INTEGER");

                    b.Property<int>("GIntZipCode")
                        .HasColumnName("zip")
                        .HasColumnType("INTEGER");

                    b.Property<string>("GStrAddress")
                        .HasColumnName("address")
                        .HasColumnType("TEXT");

                    b.Property<string>("GStrCity")
                        .HasColumnName("city")
                        .HasColumnType("TEXT");

                    b.Property<string>("GStrState")
                        .HasColumnName("state")
                        .HasColumnType("TEXT");

                    b.HasKey("GIntId");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("DirectorPortalDatabase.Models.Business", b =>
                {
                    b.Property<int>("GIntId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("INTEGER");

                    b.Property<int>("GEnumMembershipLevel")
                        .HasColumnName("level")
                        .HasColumnType("INTEGER");

                    b.Property<int>("GIntMailingAddressId")
                        .HasColumnName("mailingAddressId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("GIntPhysicalAddressId")
                        .HasColumnName("physicalAddressId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("GIntYearEstablished")
                        .HasColumnName("established")
                        .HasColumnType("INTEGER");

                    b.Property<int>("GIntZipCode")
                        .HasColumnName("zip")
                        .HasColumnType("INTEGER");

                    b.Property<string>("GStrBusinessName")
                        .HasColumnName("name")
                        .HasColumnType("TEXT");

                    b.Property<string>("GStrCity")
                        .HasColumnName("city")
                        .HasColumnType("TEXT");

                    b.Property<string>("GStrExtraFields")
                        .HasColumnName("extraFields")
                        .HasColumnType("TEXT");

                    b.Property<string>("GStrExtraNotes")
                        .HasColumnName("notes")
                        .HasColumnType("TEXT");

                    b.Property<string>("GStrState")
                        .HasColumnName("state")
                        .HasColumnType("TEXT");

                    b.Property<string>("GStrWebsite")
                        .HasColumnName("website")
                        .HasColumnType("TEXT");

                    b.HasKey("GIntId");

                    b.ToTable("Businesses");
                });

            modelBuilder.Entity("DirectorPortalDatabase.Models.BusinessRep", b =>
                {
                    b.Property<int>("GIntId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ContactPersonGIntId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("GIntBusinessId")
                        .HasColumnName("businessId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("GIntContactPersonId")
                        .HasColumnName("contactPersonId")
                        .HasColumnType("INTEGER");

                    b.HasKey("GIntId");

                    b.HasIndex("ContactPersonGIntId");

                    b.ToTable("BusinessReps");
                });

            modelBuilder.Entity("DirectorPortalDatabase.Models.ContactPerson", b =>
                {
                    b.Property<int>("GIntId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("INTEGER");

                    b.Property<string>("GStrName")
                        .HasColumnName("name")
                        .HasColumnType("TEXT");

                    b.HasKey("GIntId");

                    b.ToTable("ContactPeople");
                });

            modelBuilder.Entity("DirectorPortalDatabase.Models.Email", b =>
                {
                    b.Property<int>("GIntId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ContactPersonGIntId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("GIntContactPersonId")
                        .HasColumnName("contactPersonId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("GStrEmailAddress")
                        .HasColumnName("email")
                        .HasColumnType("TEXT");

                    b.HasKey("GIntId");

                    b.HasIndex("ContactPersonGIntId");

                    b.ToTable("Emails");
                });

            modelBuilder.Entity("DirectorPortalDatabase.Models.PhoneNumber", b =>
                {
                    b.Property<int>("GIntId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("INTEGER");

                    b.Property<int>("GEnumPhoneType")
                        .HasColumnName("type")
                        .HasColumnType("INTEGER");

                    b.Property<int>("GIntContactPersonId")
                        .HasColumnName("contactPersonId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("GStrNotes")
                        .HasColumnName("notes")
                        .HasColumnType("TEXT");

                    b.Property<string>("GStrPhoneNumber")
                        .HasColumnName("phoneNumber")
                        .HasColumnType("TEXT");

                    b.HasKey("GIntId");

                    b.ToTable("PhoneNumbers");
                });

            modelBuilder.Entity("DirectorPortalDatabase.Models.Todo", b =>
                {
                    b.Property<int>("GIntId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("GBlnMarkedAsDone")
                        .HasColumnName("complete")
                        .HasColumnType("INTEGER");

                    b.Property<string>("GStrDescription")
                        .HasColumnName("description")
                        .HasColumnType("TEXT");

                    b.Property<string>("GStrTitle")
                        .HasColumnName("title")
                        .HasColumnType("TEXT");

                    b.HasKey("GIntId");

                    b.ToTable("TodoListItems");
                });

            modelBuilder.Entity("DirectorPortalDatabase.Models.YearlyData", b =>
                {
                    b.Property<int>("GIntId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("BusinessGIntId")
                        .HasColumnType("INTEGER");

                    b.Property<double>("GDblCredit")
                        .HasColumnName("credit")
                        .HasColumnType("REAL");

                    b.Property<double>("GDblDuesPaid")
                        .HasColumnName("duesPaid")
                        .HasColumnType("REAL");

                    b.Property<double>("GDblTicketsReturned")
                        .HasColumnName("raffleTicketsReturned")
                        .HasColumnType("REAL");

                    b.Property<int>("GEnumTermLength")
                        .HasColumnName("terms")
                        .HasColumnType("INTEGER");

                    b.Property<int>("GIntBallotNumber")
                        .HasColumnName("ballotNum")
                        .HasColumnType("INTEGER");

                    b.Property<int>("GIntBusinessId")
                        .HasColumnName("businessId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("GIntYear")
                        .HasColumnName("year")
                        .HasColumnType("INTEGER");

                    b.Property<string>("GStrExtraFields")
                        .HasColumnName("extraFields")
                        .HasColumnType("TEXT");

                    b.HasKey("GIntId");

                    b.HasIndex("BusinessGIntId");

                    b.ToTable("BusinessYearlyData");
                });

            modelBuilder.Entity("DirectorPortalDatabase.Models.BusinessRep", b =>
                {
                    b.HasOne("DirectorPortalDatabase.Models.ContactPerson", null)
                        .WithMany("GRGRepresentations")
                        .HasForeignKey("ContactPersonGIntId");
                });

            modelBuilder.Entity("DirectorPortalDatabase.Models.Email", b =>
                {
                    b.HasOne("DirectorPortalDatabase.Models.ContactPerson", null)
                        .WithMany("GRGEmails")
                        .HasForeignKey("ContactPersonGIntId");
                });

            modelBuilder.Entity("DirectorPortalDatabase.Models.YearlyData", b =>
                {
                    b.HasOne("DirectorPortalDatabase.Models.Business", null)
                        .WithMany("GRGYearlyData")
                        .HasForeignKey("BusinessGIntId");
                });
#pragma warning restore 612, 618
        }
    }
}
