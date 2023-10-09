﻿// <auto-generated />
using System;
using FinReportBuilder.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FinReportBuilder.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20231009051714_AddClients")]
    partial class AddClients
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.11");

            modelBuilder.Entity("FinReportBuilder.Models.Clients.Attachments.DocumentManagement", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ClientProfileId")
                        .HasColumnType("INTEGER");

                    b.Property<byte[]>("DocumentData")
                        .HasColumnType("BLOB");

                    b.Property<string>("DocumentName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("DocumentPath")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("DocumentType")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("EntityOwner")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ClientProfileId");

                    b.ToTable("DocumentManagement");
                });

            modelBuilder.Entity("FinReportBuilder.Models.Clients.BusinessParticulars.BusinessInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("BusinessName")
                        .HasColumnType("TEXT");

                    b.Property<string>("BusinessRegistrationDetails")
                        .HasColumnType("TEXT");

                    b.Property<string>("BusinessStructure")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("BusinessInfo");
                });

            modelBuilder.Entity("FinReportBuilder.Models.Clients.ClientPreferences", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("FridayAppointments")
                        .HasColumnType("TEXT");

                    b.Property<string>("MondayAppointments")
                        .HasColumnType("TEXT");

                    b.Property<string>("PreferredCommunicationMethod")
                        .HasColumnType("TEXT");

                    b.Property<string>("SaturdayAppointments")
                        .HasColumnType("TEXT");

                    b.Property<string>("SundayAppointments")
                        .HasColumnType("TEXT");

                    b.Property<string>("ThursdayAppointments")
                        .HasColumnType("TEXT");

                    b.Property<string>("TuesdayAppointments")
                        .HasColumnType("TEXT");

                    b.Property<string>("WednesdayAppointments")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("ClientPreferences");
                });

            modelBuilder.Entity("FinReportBuilder.Models.Clients.ClientProfile", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ABN")
                        .HasColumnType("TEXT");

                    b.Property<string>("ACN")
                        .HasColumnType("TEXT");

                    b.Property<int?>("BusinessInformationId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ContactInformationId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Created")
                        .HasColumnType("TEXT");

                    b.Property<string>("CustomerOf")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("EntityName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("LastUpdated")
                        .HasColumnType("TEXT");

                    b.Property<int?>("PreferencesId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("TaxFileNumber")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("BusinessInformationId");

                    b.HasIndex("ContactInformationId");

                    b.HasIndex("PreferencesId");

                    b.ToTable("ClientProfiles");
                });

            modelBuilder.Entity("FinReportBuilder.Models.Clients.ContactInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Address1")
                        .HasColumnType("TEXT");

                    b.Property<string>("Address2")
                        .HasColumnType("TEXT");

                    b.Property<string>("City")
                        .HasColumnType("TEXT");

                    b.Property<string>("Country")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("MailingAddress1")
                        .HasColumnType("TEXT");

                    b.Property<string>("MailingAddress2")
                        .HasColumnType("TEXT");

                    b.Property<string>("MailingCity")
                        .HasColumnType("TEXT");

                    b.Property<string>("MailingCountry")
                        .HasColumnType("TEXT");

                    b.Property<string>("MailingPostCode")
                        .HasColumnType("TEXT");

                    b.Property<string>("MailingState")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<string>("PostCode")
                        .HasColumnType("TEXT");

                    b.Property<string>("PreferredContactMethod")
                        .HasColumnType("TEXT");

                    b.Property<string>("State")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("ContactInfo");
                });

            modelBuilder.Entity("FinReportBuilder.Models.Reports.FinancialReportYearEnd", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ABN")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("BasisOfReport")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ClientName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("CustomerId")
                        .HasColumnType("TEXT");

                    b.Property<string>("DirectorsName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("FirmAddress")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("FirmName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("FirmPartnerName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("HasABN")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("HasPropertyPlantEquipment")
                        .HasColumnType("INTEGER");

                    b.Property<string>("PropertyPlantEquipment")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PropertyPlantEquipmentDepreciation")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ReportGeneratedDate")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("YearEndedStatement")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("FinancialReportYearEnds");
                });

            modelBuilder.Entity("FinReportBuilder.Models.Typography.ParagraphFormattingInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("BackColor")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("FirstLineIndentation")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Keep")
                        .HasColumnType("INTEGER");

                    b.Property<int>("LeftIndentation")
                        .HasColumnType("INTEGER");

                    b.Property<int>("RightIndentation")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("ParagraphFormattingInfos");
                });

            modelBuilder.Entity("FinReportBuilder.Models.Typography.TextFormattingInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Bold")
                        .HasColumnType("INTEGER");

                    b.Property<string>("FontName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<float>("FontSize")
                        .HasColumnType("REAL");

                    b.Property<bool>("Italic")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Underline")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("TextFormattingInfos");
                });

            modelBuilder.Entity("FinReportBuilder.Models.Clients.Attachments.DocumentManagement", b =>
                {
                    b.HasOne("FinReportBuilder.Models.Clients.ClientProfile", null)
                        .WithMany("Documents")
                        .HasForeignKey("ClientProfileId");
                });

            modelBuilder.Entity("FinReportBuilder.Models.Clients.ClientProfile", b =>
                {
                    b.HasOne("FinReportBuilder.Models.Clients.BusinessParticulars.BusinessInfo", "BusinessInformation")
                        .WithMany()
                        .HasForeignKey("BusinessInformationId");

                    b.HasOne("FinReportBuilder.Models.Clients.ContactInfo", "ContactInformation")
                        .WithMany()
                        .HasForeignKey("ContactInformationId");

                    b.HasOne("FinReportBuilder.Models.Clients.ClientPreferences", "Preferences")
                        .WithMany()
                        .HasForeignKey("PreferencesId");

                    b.Navigation("BusinessInformation");

                    b.Navigation("ContactInformation");

                    b.Navigation("Preferences");
                });

            modelBuilder.Entity("FinReportBuilder.Models.Clients.ClientProfile", b =>
                {
                    b.Navigation("Documents");
                });
#pragma warning restore 612, 618
        }
    }
}
