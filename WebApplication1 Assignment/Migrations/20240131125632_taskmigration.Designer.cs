﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication1_Assignment.DataContext;

#nullable disable

namespace WebApplication1_Assignment.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20240131125632_taskmigration")]
    partial class taskmigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("WebApplication1_Assignment.Model.TaskList", b =>
                {
                    b.Property<int>("taskid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("taskid"));

                    b.Property<string>("taskdescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("taskname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("taskstatus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("taskid");

                    b.ToTable("taskLists");
                });
#pragma warning restore 612, 618
        }
    }
}
