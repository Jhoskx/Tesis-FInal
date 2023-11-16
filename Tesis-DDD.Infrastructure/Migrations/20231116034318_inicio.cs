using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tesis_DDD.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class inicio : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Screens1",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameProject = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FinalUser = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DevelopmentMethodology = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ResponsiblePosition = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DevelopmentType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Screens1", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AlgorithmCases",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectId = table.Column<int>(type: "int", nullable: false),
                    Screen1Id = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AlgorithmCases", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AlgorithmCases_Screens1_Screen1Id",
                        column: x => x.Screen1Id,
                        principalTable: "Screens1",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EstimationAlgorithms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idproject = table.Column<int>(type: "int", nullable: false),
                    Screen1Id = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstimationAlgorithms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EstimationAlgorithms_Screens1_Screen1Id",
                        column: x => x.Screen1Id,
                        principalTable: "Screens1",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ExpertEstimates",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    projectId = table.Column<int>(type: "int", nullable: false),
                    Screen1Id = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExpertEstimates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ExpertEstimates_Screens1_Screen1Id",
                        column: x => x.Screen1Id,
                        principalTable: "Screens1",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Responsibles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    projectId = table.Column<int>(type: "int", nullable: false),
                    Screen1Id = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Responsibles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Responsibles_Screens1_Screen1Id",
                        column: x => x.Screen1Id,
                        principalTable: "Screens1",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "resultAlgoriths",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idEstimate = table.Column<int>(type: "int", nullable: false),
                    EstimationAlgorithmId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_resultAlgoriths", x => x.Id);
                    table.ForeignKey(
                        name: "FK_resultAlgoriths_EstimationAlgorithms_EstimationAlgorithmId",
                        column: x => x.EstimationAlgorithmId,
                        principalTable: "EstimationAlgorithms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UseCaseAlgoriths",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idEstimate = table.Column<int>(type: "int", nullable: false),
                    EstimationAlgorithmId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UseCaseAlgoriths", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UseCaseAlgoriths_EstimationAlgorithms_EstimationAlgorithmId",
                        column: x => x.EstimationAlgorithmId,
                        principalTable: "EstimationAlgorithms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ResourceLists",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idEstimate = table.Column<int>(type: "int", nullable: false),
                    ExpertEstimateId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResourceLists", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ResourceLists_ExpertEstimates_ExpertEstimateId",
                        column: x => x.ExpertEstimateId,
                        principalTable: "ExpertEstimates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Resultestimates",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idEstimate = table.Column<int>(type: "int", nullable: false),
                    ExpertEstimateId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Resultestimates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Resultestimates_ExpertEstimates_ExpertEstimateId",
                        column: x => x.ExpertEstimateId,
                        principalTable: "ExpertEstimates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UseCases",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idEstimate = table.Column<int>(type: "int", nullable: false),
                    ExpertEstimateId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UseCases", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UseCases_ExpertEstimates_ExpertEstimateId",
                        column: x => x.ExpertEstimateId,
                        principalTable: "ExpertEstimates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AlgorithmCases_Screen1Id",
                table: "AlgorithmCases",
                column: "Screen1Id");

            migrationBuilder.CreateIndex(
                name: "IX_EstimationAlgorithms_Screen1Id",
                table: "EstimationAlgorithms",
                column: "Screen1Id");

            migrationBuilder.CreateIndex(
                name: "IX_ExpertEstimates_Screen1Id",
                table: "ExpertEstimates",
                column: "Screen1Id");

            migrationBuilder.CreateIndex(
                name: "IX_ResourceLists_ExpertEstimateId",
                table: "ResourceLists",
                column: "ExpertEstimateId");

            migrationBuilder.CreateIndex(
                name: "IX_Responsibles_Screen1Id",
                table: "Responsibles",
                column: "Screen1Id");

            migrationBuilder.CreateIndex(
                name: "IX_resultAlgoriths_EstimationAlgorithmId",
                table: "resultAlgoriths",
                column: "EstimationAlgorithmId");

            migrationBuilder.CreateIndex(
                name: "IX_Resultestimates_ExpertEstimateId",
                table: "Resultestimates",
                column: "ExpertEstimateId");

            migrationBuilder.CreateIndex(
                name: "IX_UseCaseAlgoriths_EstimationAlgorithmId",
                table: "UseCaseAlgoriths",
                column: "EstimationAlgorithmId");

            migrationBuilder.CreateIndex(
                name: "IX_UseCases_ExpertEstimateId",
                table: "UseCases",
                column: "ExpertEstimateId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AlgorithmCases");

            migrationBuilder.DropTable(
                name: "ResourceLists");

            migrationBuilder.DropTable(
                name: "Responsibles");

            migrationBuilder.DropTable(
                name: "resultAlgoriths");

            migrationBuilder.DropTable(
                name: "Resultestimates");

            migrationBuilder.DropTable(
                name: "UseCaseAlgoriths");

            migrationBuilder.DropTable(
                name: "UseCases");

            migrationBuilder.DropTable(
                name: "EstimationAlgorithms");

            migrationBuilder.DropTable(
                name: "ExpertEstimates");

            migrationBuilder.DropTable(
                name: "Screens1");
        }
    }
}
