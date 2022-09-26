﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SEMSonWeb.Server.Data;

#nullable disable

namespace SEMSonWeb.Server.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20220918052806_Photobyte")]
    partial class Photobyte
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("SEMSonWeb.Shared.Entities.SPClientClass", b =>
                {
                    b.Property<string>("PHClassCode")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("PHClassName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PHClassCode");

                    b.ToTable("SPClientClassdb");
                });

            modelBuilder.Entity("SEMSonWeb.Shared.Entities.SPClientDep", b =>
                {
                    b.Property<string>("PHDepCode")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("PHDepName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PHDepCode");

                    b.ToTable("SPClientDepdb");
                });

            modelBuilder.Entity("SEMSonWeb.Shared.Entities.SPClientPos", b =>
                {
                    b.Property<string>("PHPosCode")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("PHPosName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PHPosCode");

                    b.ToTable("SPClientPosdb");
                });

            modelBuilder.Entity("SEMSonWeb.Shared.Entities.SPClientPre", b =>
                {
                    b.Property<string>("PHPreCode")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("PHPreName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PHPreCode");

                    b.ToTable("SPClientPredb");
                });

            modelBuilder.Entity("SEMSonWeb.Shared.Entities.SPClientProfile", b =>
                {
                    b.Property<string>("PHProfileCode")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LSPClientClassPHClassCode")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LSPClientDepPHDepCode")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LSPClientPosPHPosCode")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LSPClientPrePHPreCode")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("PHClassCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PHDepCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PHPosCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PHPreCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PHProfileClassroom")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PHProfileEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PHProfileIDcard")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PHProfileIDstudent")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("PHProfileImg")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("PHProfilePhone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PHProfilefName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PHProfilelName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PHWhoCreate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PHWhoEdit")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("PHwhenCreate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("PHwhenEdit")
                        .HasColumnType("datetime2");

                    b.HasKey("PHProfileCode");

                    b.HasIndex("LSPClientClassPHClassCode");

                    b.HasIndex("LSPClientDepPHDepCode");

                    b.HasIndex("LSPClientPosPHPosCode");

                    b.HasIndex("LSPClientPrePHPreCode");

                    b.ToTable("SPClientProfiledb");
                });

            modelBuilder.Entity("SEMSonWeb.Shared.Entities.SPClientUser", b =>
                {
                    b.Property<string>("PHUserCode")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("PHProfileCode")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("PHUserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PHUserPassword")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PHUserState")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("PHUserStatus")
                        .HasColumnType("bit");

                    b.Property<string>("PHUserWhoCreate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PHUserWhoEdit")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("PHUserwhenCreate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("PHUserwhenEdit")
                        .HasColumnType("datetime2");

                    b.HasKey("PHUserCode");

                    b.HasIndex("PHProfileCode")
                        .IsUnique()
                        .HasFilter("[PHProfileCode] IS NOT NULL");

                    b.ToTable("SPClientUserdb");
                });

            modelBuilder.Entity("SEMSonWeb.Shared.Entities.SPHisAction", b =>
                {
                    b.Property<string>("PHHisActionCode")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("PHHisStautus")
                        .HasColumnType("bit");

                    b.Property<string>("PHIDequip")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PHIDuser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("PHborrow")
                        .HasColumnType("datetime2");

                    b.Property<int>("PHequipBorrow")
                        .HasColumnType("int");

                    b.Property<int>("PHequipReturn")
                        .HasColumnType("int");

                    b.Property<DateTime?>("PHreturn")
                        .HasColumnType("datetime2");

                    b.HasKey("PHHisActionCode");

                    b.ToTable("SPHisActiondb");
                });

            modelBuilder.Entity("SEMSonWeb.Shared.Entities.SPModelEquip", b =>
                {
                    b.Property<string>("PHEquipCode")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LSPModelSportPHSportCode")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("PHEquipAmount")
                        .HasColumnType("int");

                    b.Property<int>("PHEquipBorroww")
                        .HasColumnType("int");

                    b.Property<string>("PHEquipImg")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PHEquipName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PHEquipStatus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PHEquipTotal")
                        .HasColumnType("int");

                    b.Property<string>("PHEquipUnit")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PHEquipWhoCreate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PHEquipWhoEdit")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("PHEquipwhenCreate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("PHEquipwhenEdit")
                        .HasColumnType("datetime2");

                    b.Property<string>("PHSportCode")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PHEquipCode");

                    b.HasIndex("LSPModelSportPHSportCode");

                    b.ToTable("SPModelEquipdb");
                });

            modelBuilder.Entity("SEMSonWeb.Shared.Entities.SPModelSport", b =>
                {
                    b.Property<string>("PHSportCode")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("PHSportName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PHSportCode");

                    b.ToTable("SPModelSportdb");
                });

            modelBuilder.Entity("SEMSonWeb.Shared.Entities.SPClientProfile", b =>
                {
                    b.HasOne("SEMSonWeb.Shared.Entities.SPClientClass", "LSPClientClass")
                        .WithMany()
                        .HasForeignKey("LSPClientClassPHClassCode");

                    b.HasOne("SEMSonWeb.Shared.Entities.SPClientDep", "LSPClientDep")
                        .WithMany()
                        .HasForeignKey("LSPClientDepPHDepCode");

                    b.HasOne("SEMSonWeb.Shared.Entities.SPClientPos", "LSPClientPos")
                        .WithMany()
                        .HasForeignKey("LSPClientPosPHPosCode");

                    b.HasOne("SEMSonWeb.Shared.Entities.SPClientPre", "LSPClientPre")
                        .WithMany()
                        .HasForeignKey("LSPClientPrePHPreCode");

                    b.Navigation("LSPClientClass");

                    b.Navigation("LSPClientDep");

                    b.Navigation("LSPClientPos");

                    b.Navigation("LSPClientPre");
                });

            modelBuilder.Entity("SEMSonWeb.Shared.Entities.SPClientUser", b =>
                {
                    b.HasOne("SEMSonWeb.Shared.Entities.SPClientProfile", "LSPClientProfile")
                        .WithOne("LSPClientUser")
                        .HasForeignKey("SEMSonWeb.Shared.Entities.SPClientUser", "PHProfileCode");

                    b.Navigation("LSPClientProfile");
                });

            modelBuilder.Entity("SEMSonWeb.Shared.Entities.SPModelEquip", b =>
                {
                    b.HasOne("SEMSonWeb.Shared.Entities.SPModelSport", "LSPModelSport")
                        .WithMany()
                        .HasForeignKey("LSPModelSportPHSportCode");

                    b.Navigation("LSPModelSport");
                });

            modelBuilder.Entity("SEMSonWeb.Shared.Entities.SPClientProfile", b =>
                {
                    b.Navigation("LSPClientUser");
                });
#pragma warning restore 612, 618
        }
    }
}
