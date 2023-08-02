﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using hastaneRandevuSistemi.Models.hospital;

#nullable disable

namespace hastaneRandevuSistemi.Migrations.Hospital
{
    [DbContext(typeof(HospitalContext))]
    partial class HospitalContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("hastaneRandevuSistemi.Models.hospital.Hospital", b =>
                {
                    b.Property<int>("hospitalId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("hospitalId"));

                    b.Property<string>("hospitalName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("hospitalNumber")
                        .HasColumnType("int");

                    b.HasKey("hospitalId");

                    b.ToTable("Hastaneler");
                });
#pragma warning restore 612, 618
        }
    }
}
