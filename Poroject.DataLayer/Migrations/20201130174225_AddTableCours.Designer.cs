﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Poroject.DataLayer.Context;

namespace Poroject.DataLayer.Migrations
{
    [DbContext(typeof(PorojectContext))]
    [Migration("20201130174225_AddTableCours")]
    partial class AddTableCours
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Poroject.DataLayer.Entities.Course.CourseGroup", b =>
                {
                    b.Property<int>("GroupId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("GroupTitle")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<int?>("ParentId")
                        .HasColumnType("int");

                    b.HasKey("GroupId");

                    b.HasIndex("ParentId");

                    b.ToTable("courseGroups");
                });

            modelBuilder.Entity("Poroject.DataLayer.Entities.Permissons.Permission", b =>
                {
                    b.Property<int>("PermissionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("ParentId")
                        .HasColumnType("int");

                    b.Property<string>("PermissionTitle")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("PermissionId");

                    b.HasIndex("ParentId");

                    b.ToTable("Permission");
                });

            modelBuilder.Entity("Poroject.DataLayer.Entities.Permissons.PermissonRoles", b =>
                {
                    b.Property<int>("PR_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("PermissionId")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("PR_ID");

                    b.HasIndex("PermissionId");

                    b.HasIndex("RoleId");

                    b.ToTable("PermissonRoles");
                });

            modelBuilder.Entity("Poroject.DataLayer.Entities.User.Role", b =>
                {
                    b.Property<int>("RoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<string>("RoleTitle")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("RoleId");

                    b.ToTable("roles");
                });

            modelBuilder.Entity("Poroject.DataLayer.Entities.User.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("ActiveCode")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<bool>("Isactive")
                        .HasColumnType("bit");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<DateTime>("RegisterDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserAvatar")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("UserId");

                    b.ToTable("users");
                });

            modelBuilder.Entity("Poroject.DataLayer.Entities.User.UserRole", b =>
                {
                    b.Property<int>("UR_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("UR_Id");

                    b.HasIndex("RoleId");

                    b.HasIndex("UserId");

                    b.ToTable("userRoles");
                });

            modelBuilder.Entity("Poroject.DataLayer.Entities.Wallet.Wallet", b =>
                {
                    b.Property<int>("WalletId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<bool>("IsPay")
                        .HasColumnType("bit");

                    b.Property<int>("TypeId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int?>("walletTypeTypeId")
                        .HasColumnType("int");

                    b.HasKey("WalletId");

                    b.HasIndex("UserId");

                    b.HasIndex("walletTypeTypeId");

                    b.ToTable("wallets");
                });

            modelBuilder.Entity("Poroject.DataLayer.Entities.Wallet.WalletType", b =>
                {
                    b.Property<int>("TypeId")
                        .HasColumnType("int");

                    b.Property<string>("TypeTitle")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("TypeId");

                    b.ToTable("walletTypes");
                });

            modelBuilder.Entity("Poroject.DataLayer.Entities.Course.CourseGroup", b =>
                {
                    b.HasOne("Poroject.DataLayer.Entities.Course.CourseGroup", null)
                        .WithMany("courseGroups")
                        .HasForeignKey("ParentId");
                });

            modelBuilder.Entity("Poroject.DataLayer.Entities.Permissons.Permission", b =>
                {
                    b.HasOne("Poroject.DataLayer.Entities.Permissons.Permission", null)
                        .WithMany("permission")
                        .HasForeignKey("ParentId");
                });

            modelBuilder.Entity("Poroject.DataLayer.Entities.Permissons.PermissonRoles", b =>
                {
                    b.HasOne("Poroject.DataLayer.Entities.Permissons.Permission", "Permission")
                        .WithMany("PermissonRole")
                        .HasForeignKey("PermissionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Poroject.DataLayer.Entities.User.Role", "Role")
                        .WithMany("PermissonRole")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Permission");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("Poroject.DataLayer.Entities.User.UserRole", b =>
                {
                    b.HasOne("Poroject.DataLayer.Entities.User.Role", "Role")
                        .WithMany("userRole")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Poroject.DataLayer.Entities.User.User", "User")
                        .WithMany("userRole")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Poroject.DataLayer.Entities.Wallet.Wallet", b =>
                {
                    b.HasOne("Poroject.DataLayer.Entities.User.User", "user")
                        .WithMany("wallet")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Poroject.DataLayer.Entities.Wallet.WalletType", "walletType")
                        .WithMany("wallet")
                        .HasForeignKey("walletTypeTypeId");

                    b.Navigation("user");

                    b.Navigation("walletType");
                });

            modelBuilder.Entity("Poroject.DataLayer.Entities.Course.CourseGroup", b =>
                {
                    b.Navigation("courseGroups");
                });

            modelBuilder.Entity("Poroject.DataLayer.Entities.Permissons.Permission", b =>
                {
                    b.Navigation("permission");

                    b.Navigation("PermissonRole");
                });

            modelBuilder.Entity("Poroject.DataLayer.Entities.User.Role", b =>
                {
                    b.Navigation("PermissonRole");

                    b.Navigation("userRole");
                });

            modelBuilder.Entity("Poroject.DataLayer.Entities.User.User", b =>
                {
                    b.Navigation("userRole");

                    b.Navigation("wallet");
                });

            modelBuilder.Entity("Poroject.DataLayer.Entities.Wallet.WalletType", b =>
                {
                    b.Navigation("wallet");
                });
#pragma warning restore 612, 618
        }
    }
}
