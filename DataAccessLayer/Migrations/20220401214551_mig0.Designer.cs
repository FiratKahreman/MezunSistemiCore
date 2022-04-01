﻿// <auto-generated />
using System;
using DataAccessLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataAccessLayer.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20220401214551_mig0")]
    partial class mig0
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.15")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EntityLayer.Concrete.Card", b =>
                {
                    b.Property<int>("CardId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("ExpiryDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("RemainingDiscounts")
                        .HasColumnType("int");

                    b.Property<int>("UsedDiscounts")
                        .HasColumnType("int");

                    b.HasKey("CardId");

                    b.ToTable("Cards");
                });

            modelBuilder.Entity("EntityLayer.Concrete.CardMap", b =>
                {
                    b.Property<int>("CardMapId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Coordinates")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Kind")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CardMapId");

                    b.ToTable("CardMaps");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Comment", b =>
                {
                    b.Property<int>("CommentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CommentText")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProfileId")
                        .HasColumnType("int");

                    b.HasKey("CommentId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Discount", b =>
                {
                    b.Property<int>("DiscountsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("RemainingDiscounts")
                        .HasColumnType("int");

                    b.Property<int>("UsedDiscountsOnAll")
                        .HasColumnType("int");

                    b.Property<int>("UsedDiscountsOnMonth")
                        .HasColumnType("int");

                    b.HasKey("DiscountsId");

                    b.ToTable("Discounts");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Grad", b =>
                {
                    b.Property<int>("GradId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("GraduationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GradId");

                    b.ToTable("Grads");
                });

            modelBuilder.Entity("EntityLayer.Concrete.GradMap", b =>
                {
                    b.Property<int>("GradMapId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Coordinates")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Kind")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GradMapId");

                    b.ToTable("GradMaps");
                });

            modelBuilder.Entity("EntityLayer.Concrete.GradProfile", b =>
                {
                    b.Property<int>("GradProfileId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GradId")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PictureId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GradProfileId");

                    b.ToTable("GradProfiles");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Picture", b =>
                {
                    b.Property<int>("PictureId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PictureId");

                    b.ToTable("Pictures");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Post", b =>
                {
                    b.Property<int>("PostId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CommentsId")
                        .HasColumnType("int");

                    b.Property<int>("Likes")
                        .HasColumnType("int");

                    b.HasKey("PostId");

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Student", b =>
                {
                    b.Property<int>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Program")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StudentProfileId")
                        .HasColumnType("int");

                    b.HasKey("StudentId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("EntityLayer.Concrete.StudentProfile", b =>
                {
                    b.Property<int>("StudentProfileId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PictureId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.HasKey("StudentProfileId");

                    b.ToTable("StudentProfiles");
                });
#pragma warning restore 612, 618
        }
    }
}