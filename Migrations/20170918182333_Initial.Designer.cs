﻿// <auto-generated />
using LatinDictionaryNoAuth.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace LatinDictionaryNoAuth.Migrations
{
    [DbContext(typeof(LatinDictionaryWebContext))]
    [Migration("20170918182333_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452");

            modelBuilder.Entity("LatinDictionaryNoAuth.Models.EnglishWord", b =>
                {
                    b.Property<int>("EnglishWordId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateCreated")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasDefaultValueSql("strftime('%Y-%m-%d %H:%M:%S')");

                    b.Property<int>("StageId");

                    b.Property<string>("Word")
                        .IsRequired();

                    b.Property<int>("WordTypeId");

                    b.HasKey("EnglishWordId");

                    b.HasIndex("StageId");

                    b.HasIndex("WordTypeId");

                    b.ToTable("EnglishWord");
                });

            modelBuilder.Entity("LatinDictionaryNoAuth.Models.LatinWord", b =>
                {
                    b.Property<int>("LatinWordId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateCreated")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasDefaultValueSql("strftime('%Y-%m-%d %H:%M:%S')");

                    b.Property<int>("StageId");

                    b.Property<string>("Word")
                        .IsRequired();

                    b.Property<int>("WordTypeId");

                    b.HasKey("LatinWordId");

                    b.HasIndex("StageId");

                    b.HasIndex("WordTypeId");

                    b.ToTable("LatinWord");
                });

            modelBuilder.Entity("LatinDictionaryNoAuth.Models.Stage", b =>
                {
                    b.Property<int>("StageId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("StageName")
                        .IsRequired();

                    b.HasKey("StageId");

                    b.ToTable("Stage");
                });

            modelBuilder.Entity("LatinDictionaryNoAuth.Models.WordType", b =>
                {
                    b.Property<int>("WordTypeId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Type")
                        .IsRequired();

                    b.HasKey("WordTypeId");

                    b.ToTable("WordType");
                });

            modelBuilder.Entity("LatinDictionaryNoAuth.Models.EnglishWord", b =>
                {
                    b.HasOne("LatinDictionaryNoAuth.Models.Stage", "Stage")
                        .WithMany()
                        .HasForeignKey("StageId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("LatinDictionaryNoAuth.Models.WordType", "WordType")
                        .WithMany()
                        .HasForeignKey("WordTypeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("LatinDictionaryNoAuth.Models.LatinWord", b =>
                {
                    b.HasOne("LatinDictionaryNoAuth.Models.Stage", "Stage")
                        .WithMany()
                        .HasForeignKey("StageId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("LatinDictionaryNoAuth.Models.WordType", "WordType")
                        .WithMany()
                        .HasForeignKey("WordTypeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
