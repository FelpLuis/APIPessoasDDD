using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APIPessoasDDD.Infraestructure.Migrations
{
    /// <inheritdoc />
    public partial class alterarbanco : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Ativo",
                table: "Endereco",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ativo",
                table: "Endereco");
        }
    }
}
