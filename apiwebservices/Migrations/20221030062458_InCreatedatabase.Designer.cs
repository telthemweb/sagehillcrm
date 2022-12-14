// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using apiwebservices.Databasemanager;

#nullable disable

namespace apiwebservices.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20221030062458_InCreatedatabase")]
    partial class InCreatedatabase
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("apiwebservices.Model.Administrator", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("MobilePhone")
                        .HasColumnType("longtext");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("longtext");

                    b.Property<string>("address")
                        .HasColumnType("longtext");

                    b.Property<string>("administrator_key")
                        .HasColumnType("longtext");

                    b.Property<string>("city")
                        .HasColumnType("longtext");

                    b.Property<string>("country")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("created_at")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("deleted_at")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("district")
                        .HasColumnType("longtext");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("province")
                        .HasColumnType("longtext");

                    b.Property<int>("roleId")
                        .HasColumnType("int");

                    b.Property<bool>("status")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("surname")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime?>("updated_at")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("user_number")
                        .HasColumnType("longtext");

                    b.HasKey("id");

                    b.HasIndex("roleId");

                    b.ToTable("administrator");
                });

            modelBuilder.Entity("apiwebservices.Model.AuditTrailt", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("action")
                        .HasColumnType("longtext");

                    b.Property<int>("administratorId")
                        .HasColumnType("int");

                    b.Property<DateTime>("created_at")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("deleted_at")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("entity")
                        .HasColumnType("longtext");

                    b.Property<string>("newvalue")
                        .HasColumnType("longtext");

                    b.Property<string>("oldvalue")
                        .HasColumnType("longtext");

                    b.Property<string>("status")
                        .HasColumnType("longtext");

                    b.Property<DateTime?>("updated_at")
                        .HasColumnType("datetime(6)");

                    b.HasKey("id");

                    b.HasIndex("administratorId");

                    b.ToTable("auditTrailt");
                });

            modelBuilder.Entity("apiwebservices.Model.Permision", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("created_at")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("name")
                        .HasColumnType("longtext");

                    b.Property<int>("submoduleId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("updated_at")
                        .HasColumnType("datetime(6)");

                    b.HasKey("id");

                    b.HasIndex("submoduleId");

                    b.ToTable("Permision");
                });

            modelBuilder.Entity("apiwebservices.Model.Role", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("created_at")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("deleted_at")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("level")
                        .HasColumnType("longtext");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("role_key")
                        .HasColumnType("longtext");

                    b.Property<string>("status")
                        .HasColumnType("longtext");

                    b.Property<DateTime?>("updated_at")
                        .HasColumnType("datetime(6)");

                    b.HasKey("id");

                    b.ToTable("role");
                });

            modelBuilder.Entity("apiwebservices.Model.Submodule", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("created_at")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("icon")
                        .HasColumnType("longtext");

                    b.Property<int>("systemmoduleId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("updated_at")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("url")
                        .HasColumnType("longtext");

                    b.HasKey("id");

                    b.HasIndex("systemmoduleId");

                    b.ToTable("submodule");
                });

            modelBuilder.Entity("apiwebservices.Model.SystemModule", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("created_at")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("deleted_at")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("description")
                        .HasColumnType("longtext");

                    b.Property<string>("icon")
                        .HasColumnType("longtext");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("status")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("updated_at")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("widget")
                        .HasColumnType("longtext");

                    b.HasKey("id");

                    b.ToTable("systemModule");
                });

            modelBuilder.Entity("PermisionRole", b =>
                {
                    b.Property<int>("permisionsid")
                        .HasColumnType("int");

                    b.Property<int>("rolesid")
                        .HasColumnType("int");

                    b.HasKey("permisionsid", "rolesid");

                    b.HasIndex("rolesid");

                    b.ToTable("permission_roles", (string)null);
                });

            modelBuilder.Entity("RoleSubmodule", b =>
                {
                    b.Property<int>("rolesid")
                        .HasColumnType("int");

                    b.Property<int>("submodulesid")
                        .HasColumnType("int");

                    b.HasKey("rolesid", "submodulesid");

                    b.HasIndex("submodulesid");

                    b.ToTable("submodules_roles", (string)null);
                });

            modelBuilder.Entity("RoleSystemModule", b =>
                {
                    b.Property<int>("roleid")
                        .HasColumnType("int");

                    b.Property<int>("systemModuleid")
                        .HasColumnType("int");

                    b.HasKey("roleid", "systemModuleid");

                    b.HasIndex("systemModuleid");

                    b.ToTable("systemmodules_roles", (string)null);
                });

            modelBuilder.Entity("apiwebservices.Model.Administrator", b =>
                {
                    b.HasOne("apiwebservices.Model.Role", "role")
                        .WithMany("administrators")
                        .HasForeignKey("roleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("role");
                });

            modelBuilder.Entity("apiwebservices.Model.AuditTrailt", b =>
                {
                    b.HasOne("apiwebservices.Model.Administrator", "administrator")
                        .WithMany("audits")
                        .HasForeignKey("administratorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("administrator");
                });

            modelBuilder.Entity("apiwebservices.Model.Permision", b =>
                {
                    b.HasOne("apiwebservices.Model.Submodule", "submodule")
                        .WithMany("permisions")
                        .HasForeignKey("submoduleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("submodule");
                });

            modelBuilder.Entity("apiwebservices.Model.Submodule", b =>
                {
                    b.HasOne("apiwebservices.Model.SystemModule", "systemmodule")
                        .WithMany("submodule")
                        .HasForeignKey("systemmoduleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("systemmodule");
                });

            modelBuilder.Entity("PermisionRole", b =>
                {
                    b.HasOne("apiwebservices.Model.Permision", null)
                        .WithMany()
                        .HasForeignKey("permisionsid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("apiwebservices.Model.Role", null)
                        .WithMany()
                        .HasForeignKey("rolesid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("RoleSubmodule", b =>
                {
                    b.HasOne("apiwebservices.Model.Role", null)
                        .WithMany()
                        .HasForeignKey("rolesid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("apiwebservices.Model.Submodule", null)
                        .WithMany()
                        .HasForeignKey("submodulesid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("RoleSystemModule", b =>
                {
                    b.HasOne("apiwebservices.Model.Role", null)
                        .WithMany()
                        .HasForeignKey("roleid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("apiwebservices.Model.SystemModule", null)
                        .WithMany()
                        .HasForeignKey("systemModuleid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("apiwebservices.Model.Administrator", b =>
                {
                    b.Navigation("audits");
                });

            modelBuilder.Entity("apiwebservices.Model.Role", b =>
                {
                    b.Navigation("administrators");
                });

            modelBuilder.Entity("apiwebservices.Model.Submodule", b =>
                {
                    b.Navigation("permisions");
                });

            modelBuilder.Entity("apiwebservices.Model.SystemModule", b =>
                {
                    b.Navigation("submodule");
                });
#pragma warning restore 612, 618
        }
    }
}
