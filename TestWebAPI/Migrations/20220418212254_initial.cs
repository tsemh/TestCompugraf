using Microsoft.EntityFrameworkCore.Migrations;

namespace TestWebAPI.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pessoa",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CPF = table.Column<string>(type: "TEXT", nullable: true),
                    Nome = table.Column<string>(type: "TEXT", nullable: true),
                    Sobrenome = table.Column<string>(type: "TEXT", nullable: true),
                    Nacionalidade = table.Column<string>(type: "TEXT", nullable: true),
                    CEP = table.Column<string>(type: "TEXT", nullable: true),
                    Estado = table.Column<string>(type: "TEXT", nullable: true),
                    Cidade = table.Column<string>(type: "TEXT", nullable: true),
                    Logradouro = table.Column<string>(type: "TEXT", nullable: true),
                    Email = table.Column<string>(type: "TEXT", nullable: true),
                    Telefone = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pessoa", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Pessoa",
                columns: new[] { "Id", "CEP", "CPF", "Cidade", "Email", "Estado", "Logradouro", "Nacionalidade", "Nome", "Sobrenome", "Telefone" },
                values: new object[] { 1, "18300-530", "106.723.510-80", "Capão Bonito", "Jonas@gmail.com", "São Paulo", "Avenida Santos Dumont.", "Brasileiro", "Jonas", "Montero", "3175-6848" });

            migrationBuilder.InsertData(
                table: "Pessoa",
                columns: new[] { "Id", "CEP", "CPF", "Cidade", "Email", "Estado", "Logradouro", "Nacionalidade", "Nome", "Sobrenome", "Telefone" },
                values: new object[] { 2, "88355-660", "198.454.220-63", "Brusque", "Kaique@protonmail.com", "Santa Catarina", "Rua Domingos Altair de Melo", "Português", "Kaique", "Fagundes", "3137-4428" });

            migrationBuilder.InsertData(
                table: "Pessoa",
                columns: new[] { "Id", "CEP", "CPF", "Cidade", "Email", "Estado", "Logradouro", "Nacionalidade", "Nome", "Sobrenome", "Telefone" },
                values: new object[] { 3, "68926-162", "922.696.940-07", "Santana", "Sylas@protonmail.com", "Amapá", "Rua D 14", "Inglês", "Sylas", "Lancaster", "2776-5574" });

            migrationBuilder.InsertData(
                table: "Pessoa",
                columns: new[] { "Id", "CEP", "CPF", "Cidade", "Email", "Estado", "Logradouro", "Nacionalidade", "Nome", "Sobrenome", "Telefone" },
                values: new object[] { 4, "69303-037", "268.320.060-98", "Boa Vista", "Isaya@hotmail.com", "Roraima", "Rua Amajari", "Inglês", "Isaya", "Otomano", "3836-3348" });

            migrationBuilder.InsertData(
                table: "Pessoa",
                columns: new[] { "Id", "CEP", "CPF", "Cidade", "Email", "Estado", "Logradouro", "Nacionalidade", "Nome", "Sobrenome", "Telefone" },
                values: new object[] { 5, "35302-405", "161.443.780-73", "Caratinga", "Marlon@hotmail.com", "Minas Gerais", "Rua Rubens Gomes", "Brasileiro", "Marlon", "Silva", "3071-0045" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pessoa");
        }
    }
}
