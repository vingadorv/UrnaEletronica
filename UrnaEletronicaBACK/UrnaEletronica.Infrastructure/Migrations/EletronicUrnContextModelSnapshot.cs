﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using UrnaEletronica.Infrastructure.Context;

#nullable disable

namespace UrnaEletronica.Infrastructure.Migrations
{
    [DbContext(typeof(EletronicUrnContext))]
    partial class EletronicUrnContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("UrnaEletronica.Domain.Model.Address", b =>
                {
                    b.Property<int>("AddressId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AddressId"), 1L, 1);

                    b.Property<int>("CityId")
                        .HasColumnType("int");

                    b.Property<string>("Complement")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<short>("Number")
                        .HasPrecision(5)
                        .HasColumnType("smallint");

                    b.Property<string>("Reference")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("StreetAddress")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("Zipcode")
                        .HasMaxLength(9)
                        .HasColumnType("char(9)");

                    b.HasKey("AddressId");

                    b.HasIndex("CityId");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("UrnaEletronica.Domain.Model.Candidate", b =>
                {
                    b.Property<int>("CandidateId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CandidateId"), 1L, 1);

                    b.Property<int?>("ElectionCycleId")
                        .HasColumnType("int");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<int>("PartyId")
                        .HasColumnType("int");

                    b.Property<byte>("PoliticalRole")
                        .HasColumnType("tinyint");

                    b.HasKey("CandidateId");

                    b.HasIndex("ElectionCycleId");

                    b.HasIndex("PartyId");

                    b.ToTable("Candidates");
                });

            modelBuilder.Entity("UrnaEletronica.Domain.Model.Citizen", b =>
                {
                    b.Property<int>("CitizenId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CitizenId"), 1L, 1);

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("char(11)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("CitizenId");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Citizens");
                });

            modelBuilder.Entity("UrnaEletronica.Domain.Model.City", b =>
                {
                    b.Property<int>("CityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CityId"), 1L, 1);

                    b.Property<string>("CityName")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.Property<int>("StateId")
                        .HasColumnType("int");

                    b.HasKey("CityId");

                    b.HasIndex("CityName")
                        .IsUnique();

                    b.HasIndex("StateId");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("UrnaEletronica.Domain.Model.Country", b =>
                {
                    b.Property<int>("CountryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CountryId"), 1L, 1);

                    b.Property<string>("CountryName")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.HasKey("CountryId");

                    b.HasIndex("CountryName")
                        .IsUnique();

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("UrnaEletronica.Domain.Model.Election", b =>
                {
                    b.Property<int>("ElectionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ElectionId"), 1L, 1);

                    b.Property<int>("ElectionYear")
                        .HasColumnType("int");

                    b.HasKey("ElectionId");

                    b.ToTable("Elections");
                });

            modelBuilder.Entity("UrnaEletronica.Domain.Model.ElectionCycle", b =>
                {
                    b.Property<int>("ElectionCycleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ElectionCycleId"), 1L, 1);

                    b.Property<int>("ElectionId")
                        .HasColumnType("int");

                    b.Property<int>("PoliticalRole")
                        .HasColumnType("int");

                    b.HasKey("ElectionCycleId");

                    b.HasIndex("ElectionId");

                    b.ToTable("ElectionCycles");
                });

            modelBuilder.Entity("UrnaEletronica.Domain.Model.Party", b =>
                {
                    b.Property<int>("PartyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PartyId"), 1L, 1);

                    b.Property<string>("Acronym")
                        .IsRequired()
                        .HasMaxLength(16)
                        .HasColumnType("varchar(16)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.HasKey("PartyId");

                    b.ToTable("Parties");
                });

            modelBuilder.Entity("UrnaEletronica.Domain.Model.State", b =>
                {
                    b.Property<int>("StateId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StateId"), 1L, 1);

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<string>("StateName")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.HasKey("StateId");

                    b.HasIndex("CountryId");

                    b.HasIndex("StateName")
                        .IsUnique();

                    b.ToTable("States");
                });

            modelBuilder.Entity("UrnaEletronica.Domain.Model.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"), 1L, 1);

                    b.Property<string>("ConfirmPassword")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.Property<byte>("LoginAttemps")
                        .HasColumnType("tinyint");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.Property<byte[]>("PasswordSalt")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("binary(64)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("varchar(32)");

                    b.HasKey("UserId");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("UserName")
                        .IsUnique();

                    b.ToTable("Users");
                });

            modelBuilder.Entity("UrnaEletronica.Domain.Model.Vote", b =>
                {
                    b.Property<int>("VoteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("VoteId"), 1L, 1);

                    b.Property<int>("CandidateId")
                        .HasColumnType("int");

                    b.Property<int?>("CitizenId")
                        .HasColumnType("int");

                    b.Property<int>("ElectionCycleId")
                        .HasColumnType("int");

                    b.Property<DateTime>("VoteTime")
                        .HasColumnType("datetime2");

                    b.HasKey("VoteId");

                    b.HasIndex("CandidateId");

                    b.HasIndex("CitizenId");

                    b.HasIndex("ElectionCycleId");

                    b.ToTable("Votes");
                });

            modelBuilder.Entity("UrnaEletronica.Domain.Model.Address", b =>
                {
                    b.HasOne("UrnaEletronica.Domain.Model.City", "City")
                        .WithMany("Addresses")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("UrnaEletronica.Domain.Model.User", "User")
                        .WithOne("Address")
                        .HasForeignKey("UrnaEletronica.Domain.Model.Address", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("City");

                    b.Navigation("User");
                });

            modelBuilder.Entity("UrnaEletronica.Domain.Model.Candidate", b =>
                {
                    b.HasOne("UrnaEletronica.Domain.Model.ElectionCycle", "ElectionCycle")
                        .WithMany("Candidates")
                        .HasForeignKey("ElectionCycleId");

                    b.HasOne("UrnaEletronica.Domain.Model.Party", "Party")
                        .WithMany("Candidates")
                        .HasForeignKey("PartyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ElectionCycle");

                    b.Navigation("Party");
                });

            modelBuilder.Entity("UrnaEletronica.Domain.Model.Citizen", b =>
                {
                    b.HasOne("UrnaEletronica.Domain.Model.User", "User")
                        .WithOne("Citizen")
                        .HasForeignKey("UrnaEletronica.Domain.Model.Citizen", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("UrnaEletronica.Domain.Model.City", b =>
                {
                    b.HasOne("UrnaEletronica.Domain.Model.State", "State")
                        .WithMany("Cities")
                        .HasForeignKey("StateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("State");
                });

            modelBuilder.Entity("UrnaEletronica.Domain.Model.ElectionCycle", b =>
                {
                    b.HasOne("UrnaEletronica.Domain.Model.Election", "Election")
                        .WithMany("ElectionCycles")
                        .HasForeignKey("ElectionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Election");
                });

            modelBuilder.Entity("UrnaEletronica.Domain.Model.State", b =>
                {
                    b.HasOne("UrnaEletronica.Domain.Model.Country", "Country")
                        .WithMany("States")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");
                });

            modelBuilder.Entity("UrnaEletronica.Domain.Model.Vote", b =>
                {
                    b.HasOne("UrnaEletronica.Domain.Model.Candidate", "Candidate")
                        .WithMany()
                        .HasForeignKey("CandidateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("UrnaEletronica.Domain.Model.Citizen", "Citizen")
                        .WithMany()
                        .HasForeignKey("CitizenId");

                    b.HasOne("UrnaEletronica.Domain.Model.ElectionCycle", "Election")
                        .WithMany("Votes")
                        .HasForeignKey("ElectionCycleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Candidate");

                    b.Navigation("Citizen");

                    b.Navigation("Election");
                });

            modelBuilder.Entity("UrnaEletronica.Domain.Model.City", b =>
                {
                    b.Navigation("Addresses");
                });

            modelBuilder.Entity("UrnaEletronica.Domain.Model.Country", b =>
                {
                    b.Navigation("States");
                });

            modelBuilder.Entity("UrnaEletronica.Domain.Model.Election", b =>
                {
                    b.Navigation("ElectionCycles");
                });

            modelBuilder.Entity("UrnaEletronica.Domain.Model.ElectionCycle", b =>
                {
                    b.Navigation("Candidates");

                    b.Navigation("Votes");
                });

            modelBuilder.Entity("UrnaEletronica.Domain.Model.Party", b =>
                {
                    b.Navigation("Candidates");
                });

            modelBuilder.Entity("UrnaEletronica.Domain.Model.State", b =>
                {
                    b.Navigation("Cities");
                });

            modelBuilder.Entity("UrnaEletronica.Domain.Model.User", b =>
                {
                    b.Navigation("Address");

                    b.Navigation("Citizen");
                });
#pragma warning restore 612, 618
        }
    }
}
