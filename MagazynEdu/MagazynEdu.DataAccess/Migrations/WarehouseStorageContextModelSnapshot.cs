﻿// <auto-generated />
using MagazynEdu.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MagazynEdu.DataAccess.Migrations
{
    [DbContext(typeof(WarehouseStorageContext))]
    partial class WarehouseStorageContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0-preview.2.23128.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AuthorDevice", b =>
                {
                    b.Property<int>("AuthorsId")
                        .HasColumnType("int");

                    b.Property<int>("DevicesId")
                        .HasColumnType("int");

                    b.HasKey("AuthorsId", "DevicesId");

                    b.HasIndex("DevicesId");

                    b.ToTable("AuthorDevice", (string)null);
                });

            modelBuilder.Entity("MagazynEdu.DataAccess.Entities.Author", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Id");

                    b.ToTable("Authors", (string)null);
                });

            modelBuilder.Entity("MagazynEdu.DataAccess.Entities.Device", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DeviceCaseId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DeviceCaseId");

                    b.ToTable("Devices", (string)null);
                });

            modelBuilder.Entity("MagazynEdu.DataAccess.Entities.DeviceCase", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("DeviceCases", (string)null);
                });

            modelBuilder.Entity("AuthorDevice", b =>
                {
                    b.HasOne("MagazynEdu.DataAccess.Entities.Author", null)
                        .WithMany()
                        .HasForeignKey("AuthorsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MagazynEdu.DataAccess.Entities.Device", null)
                        .WithMany()
                        .HasForeignKey("DevicesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MagazynEdu.DataAccess.Entities.Device", b =>
                {
                    b.HasOne("MagazynEdu.DataAccess.Entities.DeviceCase", "DeviceCase")
                        .WithMany("Devices")
                        .HasForeignKey("DeviceCaseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DeviceCase");
                });

            modelBuilder.Entity("MagazynEdu.DataAccess.Entities.DeviceCase", b =>
                {
                    b.Navigation("Devices");
                });
#pragma warning restore 612, 618
        }
    }
}
