﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using kudapoyti.DataAccess.DbConstexts;

#nullable disable

namespace kudapoyti.DataAccess.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230109153531_Personalization")]
    partial class Personalization
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("kudapoyti.Domain.Entities.Admins.Admin1", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Role")
                        .HasColumnType("integer");

                    b.Property<string>("Salt")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("TelegramLink")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Admins");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Description = " ",
                            Email = "Kudapayti@gmail.com",
                            FullName = "Kudapayti",
                            PasswordHash = "$2a$11$pUC4LQVORynSuk0xn/Wl9ujn3e8NVGIa9rs8WUliW4USW5FY/BhOG",
                            PhoneNumber = "+998999909090",
                            Role = 0,
                            Salt = "f1fd3ecc-32c8-430d-ae6d-288eb2753c43",
                            TelegramLink = "https://t.me/Shoxrux_Husenov"
                        });
                });

            modelBuilder.Entity("kudapoyti.Domain.Entities.Comment.Comment", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<string>("Comments")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<long>("PlaceId")
                        .HasColumnType("bigint");

                    b.Property<string>("UserEmail")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("PlaceId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("kudapoyti.Domain.Entities.Photos.Photo", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<string>("Photo_path")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<long>("PlaceId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("PlaceId");

                    b.ToTable("Photos");
                });

            modelBuilder.Entity("kudapoyti.Domain.Entities.Places.Place", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Location_link")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PlaceSiteUrl")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<long>("Ranked_point")
                        .HasColumnType("bigint");

                    b.Property<string>("Region")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<double>("rank")
                        .HasColumnType("double precision");

                    b.Property<long>("rankedUsersCount")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.ToTable("Places");
                });

            modelBuilder.Entity("kudapoyti.Domain.Entities.Comment.Comment", b =>
                {
                    b.HasOne("kudapoyti.Domain.Entities.Places.Place", "Place")
                        .WithMany()
                        .HasForeignKey("PlaceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Place");
                });

            modelBuilder.Entity("kudapoyti.Domain.Entities.Photos.Photo", b =>
                {
                    b.HasOne("kudapoyti.Domain.Entities.Places.Place", "Place")
                        .WithMany()
                        .HasForeignKey("PlaceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Place");
                });
#pragma warning restore 612, 618
        }
    }
}