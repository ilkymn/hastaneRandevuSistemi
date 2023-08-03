﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using hastaneRandevuSistemi.Models.city;

#nullable disable

namespace hastaneRandevuSistemi.Migrations.city
{
    [DbContext(typeof(cityContext))]
    partial class cityContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("hastaneRandevuSistemi.Models.city.patCity", b =>
                {
                    b.Property<int>("cityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("cityId"));

                    b.Property<string>("city")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("county")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("cityId");

                    b.ToTable("Şehirler");
                });
#pragma warning restore 612, 618
        }
    }
}