﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Tesis_DDD.Infrastructure.Persistence;

#nullable disable

namespace Tesis_DDD.Infrastructure.Migrations
{
    [DbContext(typeof(TesisDbContext))]
    [Migration("20231117033219_inicio")]
    partial class inicio
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Api_DDD.Domain.ResultAlgorith", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EstimationAlgorithmId")
                        .HasColumnType("int");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<int>("idEstimate")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EstimationAlgorithmId");

                    b.ToTable("resultAlgoriths");
                });

            modelBuilder.Entity("Api_DDD.Domain.Resultestimate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ExpertEstimateId")
                        .HasColumnType("int");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<int>("idEstimate")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ExpertEstimateId");

                    b.ToTable("Resultestimates");
                });

            modelBuilder.Entity("Api_DDD.Domain.Screen1", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DevelopmentMethodology")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DevelopmentType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FinalUser")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("NameProject")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ResponsiblePosition")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Screens1");
                });

            modelBuilder.Entity("Api_DDD.Domain.UseCaseAlgorith", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EstimationAlgorithmId")
                        .HasColumnType("int");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<int>("idEstimate")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EstimationAlgorithmId");

                    b.ToTable("UseCaseAlgoriths");
                });

            modelBuilder.Entity("Api_DDD.Domain.algorithmCase", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Screen1Id")
                        .HasColumnType("int");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<int>("proyectid")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Screen1Id");

                    b.ToTable("AlgorithmCases");
                });

            modelBuilder.Entity("Api_DDD.Domain.estimationAlgorithm", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Screen1Id")
                        .HasColumnType("int");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<int>("idproject")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Screen1Id");

                    b.ToTable("EstimationAlgorithms");
                });

            modelBuilder.Entity("Api_DDD.Domain.expertEstimate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Screen1Id")
                        .HasColumnType("int");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<int>("projectId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Screen1Id");

                    b.ToTable("ExpertEstimates");
                });

            modelBuilder.Entity("Api_DDD.Domain.resourceList", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ExpertEstimateId")
                        .HasColumnType("int");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<int>("idEstimate")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ExpertEstimateId");

                    b.ToTable("ResourceLists");
                });

            modelBuilder.Entity("Api_DDD.Domain.useCase", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ExpertEstimateId")
                        .HasColumnType("int");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<int>("idEstimate")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ExpertEstimateId");

                    b.ToTable("UseCases");
                });

            modelBuilder.Entity("Api_DDD.Domain.ResultAlgorith", b =>
                {
                    b.HasOne("Api_DDD.Domain.estimationAlgorithm", "EstimationAlgorithm")
                        .WithMany()
                        .HasForeignKey("EstimationAlgorithmId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EstimationAlgorithm");
                });

            modelBuilder.Entity("Api_DDD.Domain.Resultestimate", b =>
                {
                    b.HasOne("Api_DDD.Domain.expertEstimate", "ExpertEstimate")
                        .WithMany()
                        .HasForeignKey("ExpertEstimateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ExpertEstimate");
                });

            modelBuilder.Entity("Api_DDD.Domain.UseCaseAlgorith", b =>
                {
                    b.HasOne("Api_DDD.Domain.estimationAlgorithm", "EstimationAlgorithm")
                        .WithMany()
                        .HasForeignKey("EstimationAlgorithmId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EstimationAlgorithm");
                });

            modelBuilder.Entity("Api_DDD.Domain.algorithmCase", b =>
                {
                    b.HasOne("Api_DDD.Domain.Screen1", "Screen1")
                        .WithMany()
                        .HasForeignKey("Screen1Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Screen1");
                });

            modelBuilder.Entity("Api_DDD.Domain.estimationAlgorithm", b =>
                {
                    b.HasOne("Api_DDD.Domain.Screen1", "Screen1")
                        .WithMany()
                        .HasForeignKey("Screen1Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Screen1");
                });

            modelBuilder.Entity("Api_DDD.Domain.expertEstimate", b =>
                {
                    b.HasOne("Api_DDD.Domain.Screen1", "Screen1")
                        .WithMany()
                        .HasForeignKey("Screen1Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Screen1");
                });

            modelBuilder.Entity("Api_DDD.Domain.resourceList", b =>
                {
                    b.HasOne("Api_DDD.Domain.expertEstimate", "ExpertEstimate")
                        .WithMany()
                        .HasForeignKey("ExpertEstimateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ExpertEstimate");
                });

            modelBuilder.Entity("Api_DDD.Domain.useCase", b =>
                {
                    b.HasOne("Api_DDD.Domain.expertEstimate", "ExpertEstimate")
                        .WithMany()
                        .HasForeignKey("ExpertEstimateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ExpertEstimate");
                });
#pragma warning restore 612, 618
        }
    }
}
