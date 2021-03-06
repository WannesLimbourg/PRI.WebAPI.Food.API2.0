// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PRI.WebAPI.Food.API2._0.Data;

namespace PRI.WebAPI.Food.API2._0.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220302150011_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.14")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PRI.WebAPI.Food.API2._0.Entities.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("LastEditedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000001"),
                            CreatedOn = new DateTime(2022, 3, 2, 15, 0, 10, 799, DateTimeKind.Utc).AddTicks(7481),
                            LastEditedOn = new DateTime(2022, 3, 2, 15, 0, 10, 799, DateTimeKind.Utc).AddTicks(7752),
                            Name = "Pizza"
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000002"),
                            CreatedOn = new DateTime(2022, 3, 2, 15, 0, 10, 799, DateTimeKind.Utc).AddTicks(7994),
                            LastEditedOn = new DateTime(2022, 3, 2, 15, 0, 10, 799, DateTimeKind.Utc).AddTicks(7996),
                            Name = "Pasta"
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000003"),
                            CreatedOn = new DateTime(2022, 3, 2, 15, 0, 10, 799, DateTimeKind.Utc).AddTicks(7999),
                            LastEditedOn = new DateTime(2022, 3, 2, 15, 0, 10, 799, DateTimeKind.Utc).AddTicks(7999),
                            Name = "Groenten"
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000004"),
                            CreatedOn = new DateTime(2022, 3, 2, 15, 0, 10, 799, DateTimeKind.Utc).AddTicks(8002),
                            LastEditedOn = new DateTime(2022, 3, 2, 15, 0, 10, 799, DateTimeKind.Utc).AddTicks(8003),
                            Name = "Fruit"
                        });
                });

            modelBuilder.Entity("PRI.WebAPI.Food.API2._0.Entities.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("LastEditedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000001"),
                            CategoryId = new Guid("00000000-0000-0000-0000-000000000001"),
                            CreatedOn = new DateTime(2022, 3, 2, 15, 0, 10, 800, DateTimeKind.Utc).AddTicks(7378),
                            LastEditedOn = new DateTime(2022, 3, 2, 15, 0, 10, 800, DateTimeKind.Utc).AddTicks(7383),
                            Name = "Peperoni"
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000002"),
                            CategoryId = new Guid("00000000-0000-0000-0000-000000000001"),
                            CreatedOn = new DateTime(2022, 3, 2, 15, 0, 10, 800, DateTimeKind.Utc).AddTicks(7391),
                            LastEditedOn = new DateTime(2022, 3, 2, 15, 0, 10, 800, DateTimeKind.Utc).AddTicks(7392),
                            Name = "Hawai"
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000003"),
                            CategoryId = new Guid("00000000-0000-0000-0000-000000000002"),
                            CreatedOn = new DateTime(2022, 3, 2, 15, 0, 10, 800, DateTimeKind.Utc).AddTicks(7395),
                            LastEditedOn = new DateTime(2022, 3, 2, 15, 0, 10, 800, DateTimeKind.Utc).AddTicks(7396),
                            Name = "Macaroni"
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000004"),
                            CategoryId = new Guid("00000000-0000-0000-0000-000000000002"),
                            CreatedOn = new DateTime(2022, 3, 2, 15, 0, 10, 800, DateTimeKind.Utc).AddTicks(7400),
                            LastEditedOn = new DateTime(2022, 3, 2, 15, 0, 10, 800, DateTimeKind.Utc).AddTicks(7400),
                            Name = "Spaghetti"
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000005"),
                            CategoryId = new Guid("00000000-0000-0000-0000-000000000003"),
                            CreatedOn = new DateTime(2022, 3, 2, 15, 0, 10, 800, DateTimeKind.Utc).AddTicks(7403),
                            LastEditedOn = new DateTime(2022, 3, 2, 15, 0, 10, 800, DateTimeKind.Utc).AddTicks(7404),
                            Name = "Komkommer"
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000006"),
                            CategoryId = new Guid("00000000-0000-0000-0000-000000000003"),
                            CreatedOn = new DateTime(2022, 3, 2, 15, 0, 10, 800, DateTimeKind.Utc).AddTicks(7406),
                            LastEditedOn = new DateTime(2022, 3, 2, 15, 0, 10, 800, DateTimeKind.Utc).AddTicks(7407),
                            Name = "Tomaat"
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000007"),
                            CategoryId = new Guid("00000000-0000-0000-0000-000000000004"),
                            CreatedOn = new DateTime(2022, 3, 2, 15, 0, 10, 800, DateTimeKind.Utc).AddTicks(7410),
                            LastEditedOn = new DateTime(2022, 3, 2, 15, 0, 10, 800, DateTimeKind.Utc).AddTicks(7411),
                            Name = "Appel"
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000008"),
                            CategoryId = new Guid("00000000-0000-0000-0000-000000000004"),
                            CreatedOn = new DateTime(2022, 3, 2, 15, 0, 10, 800, DateTimeKind.Utc).AddTicks(7414),
                            LastEditedOn = new DateTime(2022, 3, 2, 15, 0, 10, 800, DateTimeKind.Utc).AddTicks(7414),
                            Name = "Peer"
                        });
                });

            modelBuilder.Entity("PRI.WebAPI.Food.API2._0.Entities.Product", b =>
                {
                    b.HasOne("PRI.WebAPI.Food.API2._0.Entities.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });
#pragma warning restore 612, 618
        }
    }
}
