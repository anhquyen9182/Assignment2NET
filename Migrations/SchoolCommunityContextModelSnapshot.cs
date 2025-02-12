﻿// <auto-generated />
using System;
using Assignment2NET.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Assignment2NET.Migrations
{
    [DbContext(typeof(SchoolCommunityContext))]
    partial class SchoolCommunityContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Assignment2NET.Models.Community", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<decimal>("Budget")
                        .HasColumnType("money");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ID");

                    b.ToTable("Communities");
                });

            modelBuilder.Entity("Assignment2NET.Models.CommunityMembership", b =>
                {
                    b.Property<int>("StudentID")
                        .HasColumnType("int");

                    b.Property<string>("CommunityID")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("StudentID", "CommunityID");

                    b.HasIndex("CommunityID");

                    b.ToTable("CommunityMemberships");
                });

            modelBuilder.Entity("Assignment2NET.Models.Student", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("EnrollmentDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ID");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("Assignment2NET.Models.CommunityMembership", b =>
                {
                    b.HasOne("Assignment2NET.Models.Community", "Community")
                        .WithMany("CommunityMemberships")
                        .HasForeignKey("CommunityID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Assignment2NET.Models.Student", "Student")
                        .WithMany("CommunityMemberships")
                        .HasForeignKey("StudentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Community");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("Assignment2NET.Models.Community", b =>
                {
                    b.Navigation("CommunityMemberships");
                });

            modelBuilder.Entity("Assignment2NET.Models.Student", b =>
                {
                    b.Navigation("CommunityMemberships");
                });
#pragma warning restore 612, 618
        }
    }
}
