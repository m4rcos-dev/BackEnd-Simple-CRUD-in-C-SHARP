using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BackEnd_Simple_CRUD_in_C_SHARP_MySQL.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "tb_users",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ocupation = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_users", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "tb_users",
                columns: new[] { "id", "name", "ocupation" },
                values: new object[,]
                {
                    { 1, "Gabrielle Pereira", "Terapeuta respiratório registrado" },
                    { 2, "Emily Gonçalves", "funcionária do correio" },
                    { 3, "Lavínia Pereira", "enfermeira do hospício" },
                    { 4, "Raissa Alves", "diretora de tecnologia" },
                    { 5, "Isabelle Cardoso", "Técnico de pré-impressão eletrônica" },
                    { 6, "Fernanda Castro", "Mecânica de veículos pesados e equipamentos móveis" },
                    { 7, "Matheus Goncalves", "terapeuta de radiação" },
                    { 8, "Kauan Correia", "Instalador de aquecimento, ar condicionado e refrigeração" },
                    { 9, "Otávio Carvalho", "Trabalhador de navio de cruzeiro" },
                    { 10, "Carlos Ferreira", "Assistente médico" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tb_users");
        }
    }
}
