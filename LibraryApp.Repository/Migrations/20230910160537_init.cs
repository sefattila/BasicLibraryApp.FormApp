using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibraryApp.Repository.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Statu = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Statu = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Statu = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Fiyat = table.Column<double>(type: "float", nullable: false),
                    ReleaseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AuthorId = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    Stock = table.Column<int>(type: "int", nullable: false),
                    Discount = table.Column<double>(type: "float", nullable: false),
                    StockState = table.Column<bool>(type: "bit", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Statu = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Books_Authors_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Authors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Books_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "CreateDate", "DeleteDate", "Name", "Surname", "Statu", "UpdateDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 9, 10, 19, 5, 36, 700, DateTimeKind.Local).AddTicks(5494), null, "Sefa", "Attila", 0, null },
                    { 2, new DateTime(2023, 9, 10, 19, 5, 36, 700, DateTimeKind.Local).AddTicks(5495), null, "Peyami", "Safa", 0, null }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryName", "CreateDate", "DeleteDate", "Statu", "UpdateDate" },
                values: new object[,]
                {
                    { 1, "Roman", new DateTime(2023, 9, 10, 19, 5, 36, 700, DateTimeKind.Local).AddTicks(5199), null, 0, null },
                    { 2, "Karikatür", new DateTime(2023, 9, 10, 19, 5, 36, 700, DateTimeKind.Local).AddTicks(5212), null, 0, null },
                    { 3, "Tarih", new DateTime(2023, 9, 10, 19, 5, 36, 700, DateTimeKind.Local).AddTicks(5212), null, 0, null },
                    { 4, "Biyografi", new DateTime(2023, 9, 10, 19, 5, 36, 700, DateTimeKind.Local).AddTicks(5213), null, 0, null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreateDate", "DeleteDate", "Email", "FirstName", "LastName", "Password", "Statu", "UpdateDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 9, 10, 19, 5, 36, 700, DateTimeKind.Local).AddTicks(5437), null, "attila@gmail.com", "Sefa", "Attila", "123456", 0, null },
                    { 2, new DateTime(2023, 9, 10, 19, 5, 36, 700, DateTimeKind.Local).AddTicks(5439), null, "ali@gmail.com", "Ali", "Yaşar", "54546546", 0, null },
                    { 3, new DateTime(2023, 9, 10, 19, 5, 36, 700, DateTimeKind.Local).AddTicks(5441), null, "mehmet@gmail.com", "Mehmet", "Gündüz", "873687", 0, null },
                    { 4, new DateTime(2023, 9, 10, 19, 5, 36, 700, DateTimeKind.Local).AddTicks(5441), null, "mahmut@gmail.com", "Mahmut", "Gece", "981376", 0, null }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "BookName", "CategoryId", "CreateDate", "DeleteDate", "Discount", "Fiyat", "ReleaseDate", "Statu", "Stock", "StockState", "UpdateDate" },
                values: new object[,]
                {
                    { 1, 1, "Attila", 3, new DateTime(2023, 9, 10, 19, 5, 36, 700, DateTimeKind.Local).AddTicks(5364), null, 15.0, 120.0, new DateTime(1998, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 10, true, null },
                    { 2, 2, "Deneme", 1, new DateTime(2023, 9, 10, 19, 5, 36, 700, DateTimeKind.Local).AddTicks(5370), null, 20.0, 69.0, new DateTime(2000, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 5, true, null },
                    { 3, 1, "Deneme1", 2, new DateTime(2023, 9, 10, 19, 5, 36, 700, DateTimeKind.Local).AddTicks(5372), null, 25.0, 136.0, new DateTime(2010, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 11, true, null },
                    { 4, 2, "Deneme2", 1, new DateTime(2023, 9, 10, 19, 5, 36, 700, DateTimeKind.Local).AddTicks(5373), null, 0.0, 75.0, new DateTime(2009, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 7, false, null },
                    { 5, 1, "Deneme3", 3, new DateTime(2023, 9, 10, 19, 5, 36, 700, DateTimeKind.Local).AddTicks(5374), null, 40.0, 225.0, new DateTime(1071, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 4, true, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Books_AuthorId",
                table: "Books",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_Books_CategoryId",
                table: "Books",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Categories_CategoryName",
                table: "Categories",
                column: "CategoryName",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Authors");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
