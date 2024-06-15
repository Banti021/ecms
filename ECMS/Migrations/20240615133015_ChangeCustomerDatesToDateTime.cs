using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ECMS.Migrations
{
    /// <inheritdoc />
    public partial class ChangeCustomerDatesToDateTime : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "LastVisit",
                table: "customers",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateOnly),
                oldType: "date");

            migrationBuilder.AlterColumn<DateTime>(
                name: "JoinDate",
                table: "customers",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateOnly),
                oldType: "date");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfBirth",
                table: "customers",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateOnly),
                oldType: "date");

            migrationBuilder.UpdateData(
                table: "addresses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BuildingNo", "City", "Street" },
                values: new object[] { "4504", "Isacmouth", "Deborah Keys" });

            migrationBuilder.UpdateData(
                table: "addresses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BuildingNo", "City", "Street" },
                values: new object[] { "6828", "Lornahaven", "Glover Mission" });

            migrationBuilder.UpdateData(
                table: "addresses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BuildingNo", "City", "Street" },
                values: new object[] { "165", "South Arnold", "Cameron Shore" });

            migrationBuilder.UpdateData(
                table: "addresses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BuildingNo", "City", "Street" },
                values: new object[] { "565", "Flatleyhaven", "Cierra Mountain" });

            migrationBuilder.UpdateData(
                table: "addresses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "BuildingNo", "City", "Street" },
                values: new object[] { "240", "Lauraview", "Sabina Overpass" });

            migrationBuilder.UpdateData(
                table: "addresses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "BuildingNo", "City", "Street" },
                values: new object[] { "6247", "West Jacquelyn", "Shanny Row" });

            migrationBuilder.UpdateData(
                table: "addresses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "BuildingNo", "City", "Street" },
                values: new object[] { "046", "Port Samir", "Bonita Mill" });

            migrationBuilder.UpdateData(
                table: "addresses",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "BuildingNo", "City", "Street" },
                values: new object[] { "31084", "Luettgenview", "Yost Throughway" });

            migrationBuilder.UpdateData(
                table: "addresses",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "BuildingNo", "City", "Street" },
                values: new object[] { "17969", "East Tyson", "Marcia Rapids" });

            migrationBuilder.UpdateData(
                table: "addresses",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "BuildingNo", "City", "Street" },
                values: new object[] { "03049", "West Oliver", "Kulas Summit" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 93, "Omnis et libero commodi.", "Centralized grid-enabled infrastructure" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 81, "Vero mollitia qui.", "De-engineered disintermediate application" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Capacity", "Description", "IsAvailable", "Name" },
                values: new object[] { 131, "Ullam tempora illo architecto quos autem natus.", false, "Synchronised zero defect conglomeration" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Capacity", "Description", "IsAvailable", "Name" },
                values: new object[] { 90, "Assumenda qui totam dolorum voluptatibus voluptatem.", false, "Progressive multi-tasking architecture" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 157, "Eius odit et voluptatem velit quam ducimus voluptatem quaerat maxime.", "Monitored bi-directional moratorium" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 190, "Et rerum sit sit.", "Right-sized systematic info-mediaries" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 103, "Dolores dolores fuga est.", "Organized dynamic throughput" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Capacity", "Description", "IsAvailable", "Name" },
                values: new object[] { 59, "Ducimus esse amet quam dolorem.", true, "Up-sized system-worthy workforce" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 128, "Optio aperiam eveniet voluptatem eos rerum.", "Streamlined eco-centric concept" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 162, "Est possimus earum quia et veniam aut quos unde officia.", "Customer-focused asynchronous extranet" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 51, "Et minima blanditiis voluptatibus vel earum temporibus doloribus.", "Robust optimal implementation" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 53, "Earum qui illo nobis.", "Innovative homogeneous complexity" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 75, "Et odio qui.", "Persistent attitude-oriented productivity" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Capacity", "Description", "IsAvailable", "Name" },
                values: new object[] { 117, "Soluta molestiae sit et ullam odit dicta nisi.", true, "Self-enabling 3rd generation firmware" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Capacity", "Description", "IsAvailable", "Name" },
                values: new object[] { 88, "Nam doloribus quod eos impedit est deserunt.", true, "Customer-focused value-added toolset" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Capacity", "Description", "IsAvailable", "Name" },
                values: new object[] { 69, "Quos consequatur consequatur.", true, "Ergonomic local matrices" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 96, "Deserunt tempora eos adipisci qui quod voluptates reiciendis.", "Public-key asynchronous budgetary management" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Capacity", "Description", "IsAvailable", "Name" },
                values: new object[] { 163, "Eveniet corporis voluptate cumque quidem consequatur voluptas at non quidem.", false, "Centralized actuating attitude" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Capacity", "Description", "IsAvailable", "Name" },
                values: new object[] { 82, "Dolorum ad voluptatum sed.", true, "Devolved executive workforce" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Capacity", "Description", "IsAvailable", "Name" },
                values: new object[] { 73, "Quia sunt id.", true, "Implemented 24/7 software" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Capacity", "Description", "IsAvailable", "Name" },
                values: new object[] { 84, "Cupiditate veniam delectus hic amet nostrum quae qui.", true, "Profound bi-directional moratorium" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 89, "Fugit tempora in exercitationem rerum ad eum consectetur consequatur.", "Persistent heuristic intranet" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Capacity", "Description", "IsAvailable", "Name" },
                values: new object[] { 159, "Voluptatem in molestias recusandae sit mollitia voluptates hic.", true, "User-centric bi-directional middleware" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Capacity", "Description", "IsAvailable", "Name" },
                values: new object[] { 83, "Deleniti praesentium repellat repudiandae dolor nesciunt dolores.", true, "Polarised global secured line" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Capacity", "Description", "IsAvailable", "Name" },
                values: new object[] { 112, "Ut architecto explicabo doloremque maiores doloremque ea ad facilis.", false, "Cloned interactive budgetary management" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Capacity", "Description", "IsAvailable", "Name" },
                values: new object[] { 121, "Error ipsam non.", true, "Polarised transitional Graphic Interface" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Capacity", "Description", "IsAvailable", "Name" },
                values: new object[] { 120, "Et id corporis optio voluptatem impedit aut.", true, "Ameliorated non-volatile frame" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 90, "Unde quo ratione repellendus.", "Distributed disintermediate matrix" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 182, "Incidunt placeat est voluptatem suscipit doloribus.", "Focused client-driven hub" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 125, "Animi doloremque sint tenetur alias.", "Open-architected explicit core" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 165, "Saepe magni beatae et numquam.", "Progressive client-server application" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 189, "Ut dignissimos mollitia consequatur.", "Customizable disintermediate parallelism" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Capacity", "Description", "IsAvailable", "Name" },
                values: new object[] { 61, "Ab sint occaecati.", false, "Monitored regional internet solution" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Capacity", "Description", "IsAvailable", "Name" },
                values: new object[] { 178, "Corporis quibusdam labore soluta omnis natus ipsa repudiandae.", false, "Intuitive real-time middleware" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 61, "Quidem veritatis optio officia commodi.", "Vision-oriented background framework" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Capacity", "Description", "IsAvailable", "Name" },
                values: new object[] { 123, "Sit est sit dolores dolore.", false, "Fundamental empowering hub" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Description", "IsAvailable", "Name" },
                values: new object[] { "Aliquid dolor omnis vel quidem dolorem.", true, "Expanded full-range circuit" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Capacity", "Description", "IsAvailable", "Name" },
                values: new object[] { 173, "Adipisci temporibus est esse neque rerum.", true, "Enterprise-wide bi-directional challenge" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Capacity", "Description", "IsAvailable", "Name" },
                values: new object[] { 91, "Consequatur porro sed.", false, "User-centric object-oriented knowledge base" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 95, "Id facere corrupti iusto qui nulla.", "Profound intermediate installation" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Capacity", "Description", "IsAvailable", "Name" },
                values: new object[] { 166, "Laborum explicabo deleniti assumenda.", true, "User-friendly intangible throughput" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 180, "Iure nostrum voluptatum nesciunt nostrum nam doloribus.", "Operative multi-state instruction set" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Capacity", "Description", "IsAvailable", "Name" },
                values: new object[] { 71, "Distinctio voluptatum temporibus consectetur consequatur.", true, "Operative leading edge installation" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 106, "Labore quibusdam voluptatem rem aut recusandae.", "Progressive radical implementation" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 60, "Ut ipsam amet sint tenetur possimus maxime natus commodi placeat.", "Cross-group contextually-based definition" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 153, "Ab quae cupiditate vel et at reiciendis.", "Organic systemic intranet" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Capacity", "Description", "IsAvailable", "Name" },
                values: new object[] { 187, "Blanditiis suscipit rerum qui.", true, "Pre-emptive value-added collaboration" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 179, "Qui explicabo vero.", "Expanded radical protocol" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 122, "Non sequi officiis dolorem quaerat nihil.", "Grass-roots eco-centric leverage" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 82, "Quo distinctio voluptas et itaque labore minus cupiditate.", "Self-enabling impactful concept" });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "EmployeeCount", "Name" },
                values: new object[] { "Eum aut earum deleniti occaecati.", 14, "Sports & Outdoors" });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "EmployeeCount", "Name" },
                values: new object[] { "Et explicabo occaecati dolor vitae laboriosam.", 15, "Beauty, Garden & Movies" });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "EmployeeCount", "Name" },
                values: new object[] { "Repudiandae sit qui velit dolores veniam nobis eius est provident.", 11, "Music" });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "EmployeeCount", "Name" },
                values: new object[] { "Quo temporibus ut laboriosam dolorem magnam et aut.", 45, "Music" });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "EmployeeCount", "Name" },
                values: new object[] { "Dolorem recusandae quasi odio vel est.", 10, "Tools" });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Description", "EmployeeCount", "Name" },
                values: new object[] { "Perspiciatis autem quis et id.", 13, "Clothing" });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Description", "EmployeeCount", "Name" },
                values: new object[] { "Nihil et omnis ea dolorem dicta vel rerum.", 47, "Clothing & Shoes" });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Description", "EmployeeCount", "Name" },
                values: new object[] { "In delectus architecto.", 26, "Sports" });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Description", "EmployeeCount", "Name" },
                values: new object[] { "Fuga perferendis illum ipsam beatae eum tempore sed illum non.", 35, "Electronics, Baby & Tools" });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Description", "EmployeeCount", "Name" },
                values: new object[] { "Praesentium totam et.", 43, "Games" });

            migrationBuilder.UpdateData(
                table: "facilities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 236, "Aut distinctio pariatur est repellendus praesentium vel voluptatem eum.", "Kassulke, Haley and Volkman" });

            migrationBuilder.UpdateData(
                table: "facilities",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 496, "In voluptatem corporis.", "DuBuque, Bartoletti and Smith" });

            migrationBuilder.UpdateData(
                table: "facilities",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 337, "Facere provident neque sed voluptatibus exercitationem voluptatem debitis.", "Haley Group" });

            migrationBuilder.UpdateData(
                table: "facilities",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 166, "Nostrum placeat veritatis est illo quia ea harum.", "Bednar - Cronin" });

            migrationBuilder.UpdateData(
                table: "facilities",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 207, "Voluptatem totam sed hic est qui qui sunt.", "Lang - Terry" });

            migrationBuilder.UpdateData(
                table: "facilities",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 268, "Facere aut quia magnam est voluptas minus.", "Littel and Sons" });

            migrationBuilder.UpdateData(
                table: "facilities",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 203, "Tempora accusamus vel rerum iusto ad consequatur sed dolores ducimus.", "Runte, Batz and Olson" });

            migrationBuilder.UpdateData(
                table: "facilities",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 104, "Animi officia maxime.", "Moore - Hintz" });

            migrationBuilder.UpdateData(
                table: "facilities",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 233, "Aut at maxime ut est unde repudiandae maiores est.", "Goldner Inc" });

            migrationBuilder.UpdateData(
                table: "facilities",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 129, "Ea ut eos eum sint fugiat.", "Walter, Thompson and Volkman" });

            migrationBuilder.UpdateData(
                table: "shifts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FromHour", "ShiftType", "ToHour" },
                values: new object[] { new DateTime(2024, 4, 10, 16, 55, 52, 228, DateTimeKind.Local).AddTicks(7661), 1, new DateTime(2024, 9, 30, 11, 3, 22, 344, DateTimeKind.Local).AddTicks(642) });

            migrationBuilder.UpdateData(
                table: "shifts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "FromHour", "ShiftType", "ToHour" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 5, 5, 624, DateTimeKind.Local).AddTicks(4986), 2, new DateTime(2025, 1, 11, 11, 22, 4, 697, DateTimeKind.Local).AddTicks(967) });

            migrationBuilder.UpdateData(
                table: "shifts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "FromHour", "ToHour" },
                values: new object[] { new DateTime(2023, 12, 2, 5, 54, 8, 513, DateTimeKind.Local).AddTicks(4157), new DateTime(2024, 12, 25, 9, 2, 6, 405, DateTimeKind.Local).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "shifts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "FromHour", "ShiftType", "ToHour" },
                values: new object[] { new DateTime(2023, 12, 19, 17, 9, 49, 821, DateTimeKind.Local).AddTicks(7674), 2, new DateTime(2024, 12, 1, 17, 50, 36, 526, DateTimeKind.Local).AddTicks(8149) });

            migrationBuilder.UpdateData(
                table: "shifts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "FromHour", "ShiftType", "ToHour" },
                values: new object[] { new DateTime(2023, 9, 9, 9, 31, 38, 679, DateTimeKind.Local).AddTicks(5907), 1, new DateTime(2025, 4, 6, 3, 36, 38, 621, DateTimeKind.Local).AddTicks(7955) });

            migrationBuilder.UpdateData(
                table: "shifts",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "FromHour", "ShiftType", "ToHour" },
                values: new object[] { new DateTime(2023, 9, 1, 4, 11, 4, 14, DateTimeKind.Local).AddTicks(5291), 2, new DateTime(2024, 10, 21, 7, 3, 54, 736, DateTimeKind.Local).AddTicks(7556) });

            migrationBuilder.UpdateData(
                table: "shifts",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "FromHour", "ShiftType", "ToHour" },
                values: new object[] { new DateTime(2023, 10, 5, 20, 5, 20, 256, DateTimeKind.Local).AddTicks(569), 2, new DateTime(2024, 9, 23, 7, 35, 53, 570, DateTimeKind.Local).AddTicks(90) });

            migrationBuilder.UpdateData(
                table: "shifts",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "FromHour", "ShiftType", "ToHour" },
                values: new object[] { new DateTime(2023, 10, 11, 11, 0, 51, 639, DateTimeKind.Local).AddTicks(6231), 2, new DateTime(2024, 11, 27, 2, 18, 43, 847, DateTimeKind.Local).AddTicks(8245) });

            migrationBuilder.UpdateData(
                table: "shifts",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "FromHour", "ShiftType", "ToHour" },
                values: new object[] { new DateTime(2023, 8, 8, 22, 12, 5, 586, DateTimeKind.Local).AddTicks(8637), 1, new DateTime(2025, 2, 10, 3, 2, 50, 933, DateTimeKind.Local).AddTicks(7278) });

            migrationBuilder.UpdateData(
                table: "shifts",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "FromHour", "ShiftType", "ToHour" },
                values: new object[] { new DateTime(2023, 8, 25, 1, 2, 5, 409, DateTimeKind.Local).AddTicks(6015), 3, new DateTime(2024, 10, 4, 3, 54, 6, 860, DateTimeKind.Local).AddTicks(581) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateOnly>(
                name: "LastVisit",
                table: "customers",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateOnly>(
                name: "JoinDate",
                table: "customers",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateOnly>(
                name: "DateOfBirth",
                table: "customers",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.UpdateData(
                table: "addresses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BuildingNo", "City", "Street" },
                values: new object[] { "2097", "Liamshire", "Klein Orchard" });

            migrationBuilder.UpdateData(
                table: "addresses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BuildingNo", "City", "Street" },
                values: new object[] { "455", "Port Gayle", "Homenick Pass" });

            migrationBuilder.UpdateData(
                table: "addresses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BuildingNo", "City", "Street" },
                values: new object[] { "429", "Pfeffermouth", "Xzavier Dale" });

            migrationBuilder.UpdateData(
                table: "addresses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BuildingNo", "City", "Street" },
                values: new object[] { "07498", "Torpton", "Cale Pines" });

            migrationBuilder.UpdateData(
                table: "addresses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "BuildingNo", "City", "Street" },
                values: new object[] { "8289", "Thereseview", "Jones Vista" });

            migrationBuilder.UpdateData(
                table: "addresses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "BuildingNo", "City", "Street" },
                values: new object[] { "1905", "Janiceville", "Moore Meadows" });

            migrationBuilder.UpdateData(
                table: "addresses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "BuildingNo", "City", "Street" },
                values: new object[] { "076", "Lake Hattiechester", "Vernice Shore" });

            migrationBuilder.UpdateData(
                table: "addresses",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "BuildingNo", "City", "Street" },
                values: new object[] { "00703", "Rohanmouth", "Wilfredo Lakes" });

            migrationBuilder.UpdateData(
                table: "addresses",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "BuildingNo", "City", "Street" },
                values: new object[] { "5824", "South Kaycee", "Jules Skyway" });

            migrationBuilder.UpdateData(
                table: "addresses",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "BuildingNo", "City", "Street" },
                values: new object[] { "1513", "Ethelynstad", "Fay Lights" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 171, "Vel nisi quia nisi dolorum rerum reprehenderit impedit et doloremque.", "De-engineered modular data-warehouse" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 190, "Dignissimos ex totam atque ullam molestiae.", "Implemented clear-thinking definition" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Capacity", "Description", "IsAvailable", "Name" },
                values: new object[] { 197, "Non assumenda quia voluptates facere.", true, "Cross-platform responsive data-warehouse" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Capacity", "Description", "IsAvailable", "Name" },
                values: new object[] { 61, "Amet ut sed enim optio magni aut impedit.", true, "Re-engineered demand-driven function" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 174, "Perferendis aut nihil dolorum in voluptatem iure similique labore exercitationem.", "Horizontal bottom-line standardization" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 99, "Repellendus incidunt quasi inventore sunt nostrum incidunt dignissimos aliquid libero.", "Re-contextualized asymmetric initiative" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 76, "A culpa officia ipsam eaque repudiandae ipsa consequatur vel vel.", "Future-proofed context-sensitive firmware" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Capacity", "Description", "IsAvailable", "Name" },
                values: new object[] { 82, "Non dolore officia.", false, "Open-source multi-state architecture" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 66, "Error laudantium eos.", "Cloned 3rd generation workforce" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 102, "Atque cum maxime explicabo enim fuga nesciunt et saepe temporibus.", "Organic global info-mediaries" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 99, "Error in error praesentium.", "Monitored human-resource adapter" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 104, "Molestias libero natus cupiditate est at suscipit veritatis.", "Synergistic client-server archive" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 178, "Eos eum tenetur optio.", "Customizable system-worthy benchmark" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Capacity", "Description", "IsAvailable", "Name" },
                values: new object[] { 113, "Accusantium nobis deserunt odit consequatur.", false, "Focused optimizing alliance" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Capacity", "Description", "IsAvailable", "Name" },
                values: new object[] { 134, "Possimus quo impedit tempora natus sint in repudiandae.", false, "Assimilated cohesive policy" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Capacity", "Description", "IsAvailable", "Name" },
                values: new object[] { 149, "Voluptates optio velit in veritatis tempore cupiditate occaecati qui voluptas.", false, "Optimized client-server extranet" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 125, "Praesentium incidunt autem id.", "Mandatory tertiary data-warehouse" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Capacity", "Description", "IsAvailable", "Name" },
                values: new object[] { 180, "Tenetur in inventore veniam eligendi alias corporis.", true, "Multi-layered scalable algorithm" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Capacity", "Description", "IsAvailable", "Name" },
                values: new object[] { 59, "Sed iste est perspiciatis est sapiente.", false, "Polarised executive time-frame" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Capacity", "Description", "IsAvailable", "Name" },
                values: new object[] { 179, "Optio possimus beatae iusto corrupti quis minus sed in.", false, "Multi-lateral scalable Graphic Interface" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Capacity", "Description", "IsAvailable", "Name" },
                values: new object[] { 115, "Architecto beatae doloremque sint totam recusandae libero eligendi voluptas quas.", false, "Digitized 5th generation challenge" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 120, "Corrupti ea minima quis totam.", "Front-line tangible core" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Capacity", "Description", "IsAvailable", "Name" },
                values: new object[] { 188, "Iste aut quibusdam sint cupiditate sequi architecto.", false, "Enterprise-wide multimedia methodology" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Capacity", "Description", "IsAvailable", "Name" },
                values: new object[] { 65, "Sit nemo mollitia voluptatem accusamus aut dicta nesciunt qui optio.", false, "Optimized systemic internet solution" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Capacity", "Description", "IsAvailable", "Name" },
                values: new object[] { 54, "Illum non facilis est nam voluptas.", true, "De-engineered encompassing model" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Capacity", "Description", "IsAvailable", "Name" },
                values: new object[] { 99, "Officia quam omnis nihil velit optio dolores.", false, "Re-contextualized systematic monitoring" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Capacity", "Description", "IsAvailable", "Name" },
                values: new object[] { 194, "Et qui id.", false, "Future-proofed 4th generation paradigm" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 127, "Laudantium quaerat veniam corrupti.", "Optimized global local area network" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 80, "Voluptate minima minima.", "Open-source asynchronous synergy" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 111, "Alias vero ipsam asperiores sint.", "Self-enabling zero tolerance secured line" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 78, "Necessitatibus officiis omnis iusto quidem incidunt ut.", "Persistent context-sensitive success" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 97, "Tenetur ratione aut quo molestias quam ut mollitia incidunt.", "Digitized attitude-oriented hub" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Capacity", "Description", "IsAvailable", "Name" },
                values: new object[] { 195, "Eligendi aut voluptas.", true, "Proactive local intranet" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Capacity", "Description", "IsAvailable", "Name" },
                values: new object[] { 134, "Reiciendis adipisci hic.", true, "Synergistic systematic function" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 67, "Cumque dolore ducimus ab eos architecto porro.", "Exclusive needs-based Graphic Interface" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Capacity", "Description", "IsAvailable", "Name" },
                values: new object[] { 191, "Omnis asperiores sit nesciunt culpa non et illum ipsum.", true, "Vision-oriented context-sensitive monitoring" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Description", "IsAvailable", "Name" },
                values: new object[] { "Aut ut repellat rerum amet perferendis magni incidunt qui sunt.", false, "Triple-buffered fresh-thinking open system" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Capacity", "Description", "IsAvailable", "Name" },
                values: new object[] { 86, "Labore eos officiis corrupti aut in.", false, "Open-source intangible matrices" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Capacity", "Description", "IsAvailable", "Name" },
                values: new object[] { 95, "Sunt voluptatem qui similique.", true, "Reverse-engineered object-oriented protocol" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 132, "Mollitia debitis similique omnis eveniet et nulla.", "Inverse interactive standardization" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Capacity", "Description", "IsAvailable", "Name" },
                values: new object[] { 172, "Modi adipisci consequatur et delectus est.", false, "Right-sized 24/7 moderator" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 107, "Molestiae fugit facere.", "Grass-roots systematic forecast" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Capacity", "Description", "IsAvailable", "Name" },
                values: new object[] { 141, "Voluptas cum id esse est in autem.", false, "Fundamental reciprocal strategy" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 123, "Nulla vero quasi harum.", "Inverse directional neural-net" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 141, "Ratione perspiciatis sed ea autem natus aut.", "Triple-buffered impactful knowledge base" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 109, "Dolores sed recusandae reprehenderit facere eaque sit.", "Visionary hybrid parallelism" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Capacity", "Description", "IsAvailable", "Name" },
                values: new object[] { 189, "Perspiciatis animi sunt voluptates molestias minima doloribus sed molestiae.", false, "Triple-buffered 3rd generation workforce" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 120, "Quae iure similique quo dolores aut eum iste.", "Sharable tangible orchestration" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 136, "Et ipsa dolorum facilis hic et consequatur dignissimos illo.", "Proactive composite concept" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 92, "Animi voluptas veniam excepturi.", "Realigned dedicated infrastructure" });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "EmployeeCount", "Name" },
                values: new object[] { "Eos voluptate ut sint et eum et sunt.", 29, "Automotive" });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "EmployeeCount", "Name" },
                values: new object[] { "Eaque expedita facilis placeat at reiciendis et aut ab vero.", 19, "Industrial & Beauty" });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "EmployeeCount", "Name" },
                values: new object[] { "Delectus molestiae nihil animi sint nulla delectus.", 37, "Sports & Automotive" });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "EmployeeCount", "Name" },
                values: new object[] { "Voluptatibus quod qui quo consequatur molestiae facilis voluptatem nisi.", 14, "Jewelery, Kids & Computers" });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "EmployeeCount", "Name" },
                values: new object[] { "Quam omnis qui ducimus optio.", 20, "Clothing" });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Description", "EmployeeCount", "Name" },
                values: new object[] { "Est fugit architecto maiores inventore dicta eum aut rerum itaque.", 15, "Kids, Games & Computers" });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Description", "EmployeeCount", "Name" },
                values: new object[] { "Illum sint vero vel.", 48, "Movies, Garden & Beauty" });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Description", "EmployeeCount", "Name" },
                values: new object[] { "Dolore nemo facilis in qui voluptates natus atque.", 19, "Music, Automotive & Outdoors" });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Description", "EmployeeCount", "Name" },
                values: new object[] { "Laborum optio placeat.", 22, "Kids, Baby & Sports" });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Description", "EmployeeCount", "Name" },
                values: new object[] { "Aut vel blanditiis sit id culpa dolorem voluptatem ut et.", 35, "Industrial" });

            migrationBuilder.UpdateData(
                table: "facilities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 322, "Repellendus autem cum qui dolores et esse.", "Doyle - O'Reilly" });

            migrationBuilder.UpdateData(
                table: "facilities",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 455, "Eum eos ut repellendus modi nam dolorem est.", "Crist, Glover and Lakin" });

            migrationBuilder.UpdateData(
                table: "facilities",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 149, "Odio ducimus ducimus impedit asperiores voluptatum nihil.", "Haag - Thompson" });

            migrationBuilder.UpdateData(
                table: "facilities",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 390, "Eum id aut distinctio ratione inventore est perspiciatis nulla voluptate.", "Schowalter Group" });

            migrationBuilder.UpdateData(
                table: "facilities",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 479, "Cumque ea est explicabo.", "Lynch - Koch" });

            migrationBuilder.UpdateData(
                table: "facilities",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 161, "Ut reprehenderit ea ratione repellendus reiciendis aperiam.", "Feil, Hane and Emard" });

            migrationBuilder.UpdateData(
                table: "facilities",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 143, "Nihil sint consequatur dolor eum.", "O'Reilly, Wolf and Smith" });

            migrationBuilder.UpdateData(
                table: "facilities",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 175, "Ut dolorum ad quia modi omnis.", "Rippin - Haley" });

            migrationBuilder.UpdateData(
                table: "facilities",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 434, "Qui voluptas quas placeat omnis voluptatem adipisci aliquam quibusdam mollitia.", "Bruen, Schneider and Davis" });

            migrationBuilder.UpdateData(
                table: "facilities",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 219, "Enim similique placeat et quia vel.", "Satterfield - Metz" });

            migrationBuilder.UpdateData(
                table: "shifts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FromHour", "ShiftType", "ToHour" },
                values: new object[] { new DateTime(2024, 1, 10, 18, 29, 44, 839, DateTimeKind.Local).AddTicks(5959), 2, new DateTime(2024, 8, 18, 19, 43, 42, 794, DateTimeKind.Local).AddTicks(989) });

            migrationBuilder.UpdateData(
                table: "shifts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "FromHour", "ShiftType", "ToHour" },
                values: new object[] { new DateTime(2024, 4, 25, 23, 23, 4, 261, DateTimeKind.Local).AddTicks(1895), 3, new DateTime(2024, 7, 6, 10, 56, 50, 88, DateTimeKind.Local).AddTicks(8409) });

            migrationBuilder.UpdateData(
                table: "shifts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "FromHour", "ToHour" },
                values: new object[] { new DateTime(2024, 1, 28, 16, 17, 57, 740, DateTimeKind.Local).AddTicks(5578), new DateTime(2025, 1, 16, 0, 27, 41, 986, DateTimeKind.Local).AddTicks(3098) });

            migrationBuilder.UpdateData(
                table: "shifts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "FromHour", "ShiftType", "ToHour" },
                values: new object[] { new DateTime(2024, 4, 2, 10, 10, 56, 871, DateTimeKind.Local).AddTicks(5237), 1, new DateTime(2025, 5, 13, 19, 44, 31, 104, DateTimeKind.Local).AddTicks(7812) });

            migrationBuilder.UpdateData(
                table: "shifts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "FromHour", "ShiftType", "ToHour" },
                values: new object[] { new DateTime(2023, 7, 12, 7, 22, 47, 222, DateTimeKind.Local).AddTicks(9282), 3, new DateTime(2025, 5, 26, 13, 36, 39, 785, DateTimeKind.Local).AddTicks(1853) });

            migrationBuilder.UpdateData(
                table: "shifts",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "FromHour", "ShiftType", "ToHour" },
                values: new object[] { new DateTime(2023, 8, 28, 19, 48, 47, 13, DateTimeKind.Local).AddTicks(1254), 1, new DateTime(2025, 4, 12, 13, 1, 49, 215, DateTimeKind.Local).AddTicks(9857) });

            migrationBuilder.UpdateData(
                table: "shifts",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "FromHour", "ShiftType", "ToHour" },
                values: new object[] { new DateTime(2024, 4, 3, 18, 34, 50, 538, DateTimeKind.Local).AddTicks(399), 1, new DateTime(2024, 12, 1, 18, 13, 53, 223, DateTimeKind.Local).AddTicks(6128) });

            migrationBuilder.UpdateData(
                table: "shifts",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "FromHour", "ShiftType", "ToHour" },
                values: new object[] { new DateTime(2024, 3, 4, 11, 4, 20, 505, DateTimeKind.Local).AddTicks(1771), 1, new DateTime(2024, 12, 20, 2, 34, 7, 480, DateTimeKind.Local).AddTicks(2132) });

            migrationBuilder.UpdateData(
                table: "shifts",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "FromHour", "ShiftType", "ToHour" },
                values: new object[] { new DateTime(2023, 8, 27, 10, 6, 9, 918, DateTimeKind.Local).AddTicks(6500), 2, new DateTime(2024, 12, 29, 10, 57, 11, 91, DateTimeKind.Local).AddTicks(7515) });

            migrationBuilder.UpdateData(
                table: "shifts",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "FromHour", "ShiftType", "ToHour" },
                values: new object[] { new DateTime(2024, 5, 2, 8, 39, 20, 851, DateTimeKind.Local).AddTicks(1579), 1, new DateTime(2025, 4, 1, 8, 46, 11, 312, DateTimeKind.Local).AddTicks(7788) });
        }
    }
}
