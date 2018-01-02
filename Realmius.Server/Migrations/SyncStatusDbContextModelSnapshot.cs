﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using Realmius.Server.Models;
using System;

namespace Realmius.Server.Migrations
{
    [DbContext(typeof(SyncStatusDbContext))]
    partial class SyncStatusDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Realmius.Server.Models.LogEntryBase", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AfterJson");

                    b.Property<string>("BeforeJson");

                    b.Property<string>("ChangesJson");

                    b.Property<string>("EntityType");

                    b.Property<int>("RecordIdInt");

                    b.Property<string>("RecordIdString")
                        .HasMaxLength(40);

                    b.Property<DateTimeOffset>("Time");

                    b.HasKey("Id");

                    b.HasIndex("RecordIdInt");

                    b.HasIndex("RecordIdString");

                    b.HasIndex("Time");

                    b.ToTable("LogEntryBase");
                });

            modelBuilder.Entity("Realmius.Server.Models.SyncStatusServerObject", b =>
                {
                    b.Property<string>("MobilePrimaryKey")
                        .HasMaxLength(40);

                    b.Property<string>("Type")
                        .HasMaxLength(40);

                    b.Property<string>("ColumnChangeDatesSerialized");

                    b.Property<string>("FullObjectAsJson");

                    b.Property<bool>("IsDeleted");

                    b.Property<DateTimeOffset>("LastChange");

                    b.Property<string>("Tag0")
                        .HasMaxLength(40);

                    b.Property<string>("Tag1")
                        .HasMaxLength(40);

                    b.Property<string>("Tag2")
                        .HasMaxLength(40);

                    b.Property<string>("Tag3")
                        .HasMaxLength(40);

                    b.HasKey("MobilePrimaryKey", "Type");

                    b.HasIndex("LastChange");

                    b.HasIndex("Tag0");

                    b.ToTable("_RealmSyncStatus");
                });
#pragma warning restore 612, 618
        }
    }
}
