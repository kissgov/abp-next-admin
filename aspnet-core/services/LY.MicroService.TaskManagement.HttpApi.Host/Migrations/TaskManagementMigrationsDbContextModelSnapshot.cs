﻿// <auto-generated />
using System;
using LY.MicroService.TaskManagement.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Volo.Abp.EntityFrameworkCore;

#nullable disable

namespace LY.MicroService.TaskManagement.Migrations
{
    [DbContext(typeof(TaskManagementMigrationsDbContext))]
    partial class TaskManagementMigrationsDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("_Abp_DatabaseProvider", EfCoreDatabaseProvider.MySql)
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("LINGYUN.Abp.TaskManagement.BackgroundJobInfo", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Args")
                        .HasColumnType("longtext")
                        .HasColumnName("Args");

                    b.Property<DateTime>("BeginTime")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasMaxLength(40)
                        .HasColumnType("varchar(40)")
                        .HasColumnName("ConcurrencyStamp");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("CreationTime");

                    b.Property<Guid?>("CreatorId")
                        .HasColumnType("char(36)")
                        .HasColumnName("CreatorId");

                    b.Property<string>("Cron")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("Cron");

                    b.Property<string>("Description")
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("Description");

                    b.Property<DateTime?>("EndTime")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("ExtraProperties")
                        .HasColumnType("longtext")
                        .HasColumnName("ExtraProperties");

                    b.Property<string>("Group")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("Group");

                    b.Property<int>("Interval")
                        .HasColumnType("int");

                    b.Property<bool>("IsAbandoned")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("IsEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("JobType")
                        .HasColumnType("int");

                    b.Property<DateTime?>("LastModificationTime")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("LastModificationTime");

                    b.Property<Guid?>("LastModifierId")
                        .HasColumnType("char(36)")
                        .HasColumnName("LastModifierId");

                    b.Property<DateTime?>("LastRunTime")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("LockTimeOut")
                        .HasColumnType("int");

                    b.Property<int>("MaxCount")
                        .HasColumnType("int");

                    b.Property<int>("MaxTryCount")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("Name");

                    b.Property<DateTime?>("NextRunTime")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("Priority")
                        .HasColumnType("int");

                    b.Property<string>("Result")
                        .HasMaxLength(1000)
                        .HasColumnType("varchar(1000)")
                        .HasColumnName("Result");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<int>("TriggerCount")
                        .HasColumnType("int");

                    b.Property<int>("TryCount")
                        .HasColumnType("int");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)")
                        .HasColumnName("Type");

                    b.HasKey("Id");

                    b.HasIndex("Name", "Group");

                    b.ToTable("TK_BackgroundJobs", (string)null);
                });

            modelBuilder.Entity("LINGYUN.Abp.TaskManagement.BackgroundJobLog", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<string>("Exception")
                        .HasMaxLength(2000)
                        .HasColumnType("varchar(2000)")
                        .HasColumnName("Exception");

                    b.Property<string>("JobGroup")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("JobGroup");

                    b.Property<Guid?>("JobId")
                        .HasColumnType("char(36)");

                    b.Property<string>("JobName")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("JobName");

                    b.Property<string>("JobType")
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)")
                        .HasColumnName("JobType");

                    b.Property<string>("Message")
                        .HasMaxLength(1000)
                        .HasColumnType("varchar(1000)")
                        .HasColumnName("Message");

                    b.Property<DateTime>("RunTime")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.HasIndex("JobGroup", "JobName");

                    b.ToTable("TK_BackgroundJobLogs", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
