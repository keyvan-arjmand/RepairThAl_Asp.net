using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class ChangeClass : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "City",
                table: "orders");

            migrationBuilder.DropColumn(
                name: "Order_End_Date",
                table: "orders");

            migrationBuilder.DropColumn(
                name: "Order_Start_Date",
                table: "orders");

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "users",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Order_Code",
                table: "orders",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Order_Repair_Date",
                table: "orders",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Order_Request_Date",
                table: "orders",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "contacts",
                columns: table => new
                {
                    Contact_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name_Family = table.Column<string>(nullable: true),
                    ContactNumber = table.Column<string>(nullable: true),
                    ContactSubject = table.Column<string>(nullable: true),
                    ContactBody = table.Column<string>(nullable: true),
                    Send_Date = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_contacts", x => x.Contact_ID);
                });

            migrationBuilder.CreateTable(
                name: "user_Orders",
                columns: table => new
                {
                    User_Order_ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Order_ID = table.Column<long>(nullable: false),
                    User_ID = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user_Orders", x => x.User_Order_ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "contacts");

            migrationBuilder.DropTable(
                name: "user_Orders");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "users");

            migrationBuilder.DropColumn(
                name: "Order_Code",
                table: "orders");

            migrationBuilder.DropColumn(
                name: "Order_Repair_Date",
                table: "orders");

            migrationBuilder.DropColumn(
                name: "Order_Request_Date",
                table: "orders");

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "orders",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Order_End_Date",
                table: "orders",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Order_Start_Date",
                table: "orders",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
