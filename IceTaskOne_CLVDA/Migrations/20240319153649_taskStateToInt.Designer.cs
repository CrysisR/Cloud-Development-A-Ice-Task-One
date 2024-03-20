﻿// <auto-generated />
using System;
using IceTaskOne_CLVDA.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace IceTaskOne_CLVDA.Migrations
{
    [DbContext(typeof(IceTaskOne_CLVDAContext))]
    [Migration("20240319153649_taskStateToInt")]
    partial class taskStateToInt
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("IceTaskOne_CLVDA.Models.LoginM.Login", b =>
                {
                    b.Property<int>("userID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("userID"));

                    b.Property<string>("password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("userID");

                    b.ToTable("LoginTable");
                });

            modelBuilder.Entity("IceTaskOne_CLVDA.Models.Tasks.Tasks", b =>
                {
                    b.Property<int>("taskId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("taskId"));

                    b.Property<DateTime>("TaskDueDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("taskGiver")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("taskName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("taskState")
                        .HasColumnType("int");

                    b.HasKey("taskId");

                    b.ToTable("Tasks");
                });
#pragma warning restore 612, 618
        }
    }
}
