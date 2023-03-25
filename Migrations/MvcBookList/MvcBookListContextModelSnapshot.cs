﻿// <auto-generated />
using AdvancedProgramming_Lesson1.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AdvancedProgramming_Lesson1.Migrations.MvcBookList
{
    [DbContext(typeof(MvcBookListContext))]
    partial class MvcBookListContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.32")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AdvancedProgramming_Lesson1.Models.BookList", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Circulation")
                        .HasColumnType("int");

                    b.Property<int>("Pages")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Rate")
                        .HasColumnType("int");

                    b.Property<int>("Release")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("BookList");
                });
#pragma warning restore 612, 618
        }
    }
}