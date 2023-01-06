using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ASPProject.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Location",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Region = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Street = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumberStore = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Location", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Preferences = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Role = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ComicStore",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ComicStoreName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ComicStoreID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LocationID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComicStore", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ComicStore_Location_LocationID",
                        column: x => x.LocationID,
                        principalTable: "Location",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Buys",
                columns: table => new
                {
                    MagazineID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PersonID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    BuyDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumberOfUnitsSold = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Buys", x => new { x.MagazineID, x.PersonID });
                    table.ForeignKey(
                        name: "FK_Buys_Users_PersonID",
                        column: x => x.PersonID,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Comics",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ComicsName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ComicsDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ComicsPrice = table.Column<int>(type: "int", nullable: false),
                    ComicsType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ComicID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ComicStoreID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BuyMagazineID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BuyPersonID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comics", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comics_Buys_BuyMagazineID_BuyPersonID",
                        columns: x => new { x.BuyMagazineID, x.BuyPersonID },
                        principalTable: "Buys",
                        principalColumns: new[] { "MagazineID", "PersonID" });
                    table.ForeignKey(
                        name: "FK_Comics_ComicStore_ComicStoreID",
                        column: x => x.ComicStoreID,
                        principalTable: "ComicStore",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Rent",
                columns: table => new
                {
                    MagazineID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PersonID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateStart = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateEnd = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PricePerDay = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rent", x => new { x.MagazineID, x.PersonID });
                    table.ForeignKey(
                        name: "FK_Rent_Comics_MagazineID",
                        column: x => x.MagazineID,
                        principalTable: "Comics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Rent_Users_PersonID",
                        column: x => x.PersonID,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Buys_PersonID",
                table: "Buys",
                column: "PersonID");

            migrationBuilder.CreateIndex(
                name: "IX_Comics_BuyMagazineID_BuyPersonID",
                table: "Comics",
                columns: new[] { "BuyMagazineID", "BuyPersonID" });

            migrationBuilder.CreateIndex(
                name: "IX_Comics_ComicStoreID",
                table: "Comics",
                column: "ComicStoreID");

            migrationBuilder.CreateIndex(
                name: "IX_ComicStore_LocationID",
                table: "ComicStore",
                column: "LocationID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Rent_PersonID",
                table: "Rent",
                column: "PersonID");

            migrationBuilder.AddForeignKey(
                name: "FK_Buys_Comics_MagazineID",
                table: "Buys",
                column: "MagazineID",
                principalTable: "Comics",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Buys_Comics_MagazineID",
                table: "Buys");

            migrationBuilder.DropTable(
                name: "Rent");

            migrationBuilder.DropTable(
                name: "Comics");

            migrationBuilder.DropTable(
                name: "Buys");

            migrationBuilder.DropTable(
                name: "ComicStore");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Location");
        }
    }
}
