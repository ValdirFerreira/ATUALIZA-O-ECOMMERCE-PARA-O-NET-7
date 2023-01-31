using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class Inicial_base_nova : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    USR_CPF = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    USR_IDADE = table.Column<int>(type: "int", nullable: false),
                    USR_NOME = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    USR_CEP = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    USR_ENDERECO = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    USR_COMPLEMENTO_ENDERECO = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: true),
                    USR_CELULAR = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    USR_TELEFONE = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    USR_ESTADO = table.Column<bool>(type: "bit", nullable: false),
                    USR_TIPO = table.Column<int>(type: "int", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TB_COMPRA",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    COM_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    COM_ESTADO = table.Column<int>(type: "int", nullable: false),
                    COM_DATA_COMPRA = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_COMPRA", x => x.COM_ID);
                    table.ForeignKey(
                        name: "FK_TB_COMPRA_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "TB_LOGSISTEMA",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LOG_JSONINFORMACAO = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LOG_TIPOLOG = table.Column<int>(type: "int", nullable: false),
                    LOG_CONTROLLER = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LOG_ACTION = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_LOGSISTEMA", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TB_LOGSISTEMA_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "TB_PRODUTO",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    PRD_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PRD_NOME = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    PRD_DESCRICAO = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    PRD_OBSERVACAO = table.Column<string>(type: "nvarchar(max)", maxLength: 20000, nullable: true),
                    PRD_VALO = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PRD_QTD_ESTOQUE = table.Column<int>(type: "int", nullable: false),
                    PRD_ESTADO = table.Column<bool>(type: "bit", nullable: false),
                    PRD_DATA_CADASTRO = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PRD_DATA_ALTERACAO = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PRD_URL = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_PRODUTO", x => x.PRD_ID);
                    table.ForeignKey(
                        name: "FK_TB_PRODUTO_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "TB_COMPRA_USUARIO",
                columns: table => new
                {
                    IdProduto = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    IdCompra = table.Column<int>(type: "int", nullable: false),
                    CUS_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProdutoId = table.Column<int>(type: "int", nullable: true),
                    CUS_ESTADO = table.Column<int>(type: "int", nullable: false),
                    CSU_QTD = table.Column<int>(type: "int", nullable: false),
                    CompraId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_COMPRA_USUARIO", x => x.CUS_ID);
                    table.ForeignKey(
                        name: "FK_TB_COMPRA_USUARIO_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TB_COMPRA_USUARIO_TB_COMPRA_CompraId",
                        column: x => x.CompraId,
                        principalTable: "TB_COMPRA",
                        principalColumn: "COM_ID");
                    table.ForeignKey(
                        name: "FK_TB_COMPRA_USUARIO_TB_PRODUTO_ProdutoId",
                        column: x => x.ProdutoId,
                        principalTable: "TB_PRODUTO",
                        principalColumn: "PRD_ID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_TB_COMPRA_UserId",
                table: "TB_COMPRA",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_TB_COMPRA_USUARIO_CompraId",
                table: "TB_COMPRA_USUARIO",
                column: "CompraId");

            migrationBuilder.CreateIndex(
                name: "IX_TB_COMPRA_USUARIO_ProdutoId",
                table: "TB_COMPRA_USUARIO",
                column: "ProdutoId");

            migrationBuilder.CreateIndex(
                name: "IX_TB_COMPRA_USUARIO_UserId",
                table: "TB_COMPRA_USUARIO",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_TB_LOGSISTEMA_UserId",
                table: "TB_LOGSISTEMA",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_TB_PRODUTO_UserId",
                table: "TB_PRODUTO",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "TB_COMPRA_USUARIO");

            migrationBuilder.DropTable(
                name: "TB_LOGSISTEMA");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "TB_COMPRA");

            migrationBuilder.DropTable(
                name: "TB_PRODUTO");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
