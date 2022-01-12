﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ToDoListClassLibrary.Models;

namespace ToDoListClassLibrary.Migrations
{
    [DbContext(typeof(ToDoListDBContext))]
    [Migration("20220112102257_changes03")]
    partial class changes03
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:Collation", "Danish_Norwegian_CI_AS")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ToDoListClassLibrary.Models.ShoppingListItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Checked")
                        .HasColumnType("bit")
                        .HasColumnName("checked")
                        .IsFixedLength(true);

                    b.Property<int>("ShoppinglistId")
                        .HasColumnType("int")
                        .HasColumnName("shoppinglistId");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("title");

                    b.HasKey("Id");

                    b.HasIndex("ShoppinglistId");

                    b.ToTable("ShoppingListItems");
                });

            modelBuilder.Entity("ToDoListClassLibrary.Models.Shoppinglist", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date")
                        .HasColumnType("date")
                        .HasColumnName("date");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("title");

                    b.HasKey("Id");

                    b.ToTable("Shoppinglist");
                });

            modelBuilder.Entity("ToDoListClassLibrary.Models.ShoppingListItem", b =>
                {
                    b.HasOne("ToDoListClassLibrary.Models.Shoppinglist", "Shoppinglist")
                        .WithMany("ShoppingListItems")
                        .HasForeignKey("ShoppinglistId")
                        .HasConstraintName("FK_ShoppingListItems_Shoppinglist")
                        .IsRequired();

                    b.Navigation("Shoppinglist");
                });

            modelBuilder.Entity("ToDoListClassLibrary.Models.Shoppinglist", b =>
                {
                    b.Navigation("ShoppingListItems");
                });
#pragma warning restore 612, 618
        }
    }
}
