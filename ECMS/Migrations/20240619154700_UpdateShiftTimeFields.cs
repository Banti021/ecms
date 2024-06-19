using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ECMS.Migrations
{
    /// <inheritdoc />
    public partial class UpdateShiftTimeFields : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // Drop existing columns
            migrationBuilder.DropColumn(
                name: "FromHour",
                table: "shifts");

            migrationBuilder.DropColumn(
                name: "ToHour",
                table: "shifts");

            // Add new columns
            migrationBuilder.AddColumn<TimeSpan>(
                name: "FromHour",
                table: "shifts",
                type: "time",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0));

            migrationBuilder.AddColumn<TimeSpan>(
                name: "ToHour",
                table: "shifts",
                type: "time",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0));
            
            migrationBuilder.UpdateData(
                table: "addresses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BuildingNo", "City", "Street" },
                values: new object[] { "45092", "Lenoraberg", "Dakota Isle" });

            migrationBuilder.UpdateData(
                table: "addresses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BuildingNo", "City", "Street" },
                values: new object[] { "45690", "South Mariam", "Demetris Ridge" });

            migrationBuilder.UpdateData(
                table: "addresses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BuildingNo", "City", "Street" },
                values: new object[] { "8263", "Anashire", "Trent Expressway" });

            migrationBuilder.UpdateData(
                table: "addresses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BuildingNo", "City", "Street" },
                values: new object[] { "8027", "New Sadiefort", "Sauer Trail" });

            migrationBuilder.UpdateData(
                table: "addresses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "BuildingNo", "City", "Street" },
                values: new object[] { "45434", "Kiehnbury", "Littel Throughway" });

            migrationBuilder.UpdateData(
                table: "addresses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "BuildingNo", "City", "Street" },
                values: new object[] { "764", "New Darrinburgh", "Queenie Fort" });

            migrationBuilder.UpdateData(
                table: "addresses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "BuildingNo", "City", "Street" },
                values: new object[] { "497", "Stonetown", "Alexa Plains" });

            migrationBuilder.UpdateData(
                table: "addresses",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "BuildingNo", "City", "Street" },
                values: new object[] { "4073", "Farrellton", "Upton Groves" });

            migrationBuilder.UpdateData(
                table: "addresses",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "BuildingNo", "City", "Street" },
                values: new object[] { "67125", "Graycechester", "Paucek Station" });

            migrationBuilder.UpdateData(
                table: "addresses",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "BuildingNo", "City", "Street" },
                values: new object[] { "701", "East Leslyville", "West Walk" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Capacity", "Description", "IsAvailable", "Name" },
                values: new object[] { 111, "Quae eaque qui sit ea dicta enim tempore consectetur.", true, "Distributed responsive customer loyalty" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Capacity", "Description", "IsAvailable", "Name" },
                values: new object[] { 83, "Quidem quia consequuntur voluptas accusantium eos et saepe beatae.", false, "Synergized background benchmark" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 89, "Et non minima et nam.", "Face to face exuding encryption" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 97, "Nihil voluptatum laboriosam amet.", "Compatible non-volatile website" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 59, "Dignissimos beatae dolorem corporis aliquam at autem doloribus placeat.", "Integrated modular migration" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Capacity", "Description", "IsAvailable", "Name" },
                values: new object[] { 182, "Inventore nesciunt non provident fugit ea illo ullam reprehenderit.", false, "Switchable logistical interface" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 73, "Recusandae doloremque enim sunt.", "Re-contextualized motivating intranet" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Capacity", "Description", "IsAvailable", "Name" },
                values: new object[] { 59, "Quos non quaerat eligendi labore non magnam magni commodi.", true, "Extended stable support" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Capacity", "Description", "IsAvailable", "Name" },
                values: new object[] { 51, "Dolor molestiae qui.", false, "Open-source systematic intranet" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 142, "Impedit voluptatem nulla pariatur error fugiat.", "Customizable contextually-based policy" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Capacity", "Description", "IsAvailable", "Name" },
                values: new object[] { 184, "Aliquam laudantium optio.", false, "Front-line leading edge installation" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 117, "Et eligendi non qui similique quasi est labore soluta.", "Multi-channelled high-level database" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Capacity", "Description", "IsAvailable", "Name" },
                values: new object[] { 185, "Corrupti repudiandae quam sit iusto itaque velit ut consequatur.", false, "Implemented executive ability" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 171, "Maxime ducimus rerum impedit aut modi error numquam qui.", "Right-sized foreground local area network" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 89, "Voluptatem id non autem consequatur et sed ut.", "Adaptive tangible open architecture" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Capacity", "Description", "IsAvailable", "Name" },
                values: new object[] { 156, "Tenetur voluptatibus alias libero.", true, "Reduced multimedia collaboration" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 50, "Ab delectus et ea assumenda.", "Compatible object-oriented capacity" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Capacity", "Description", "IsAvailable", "Name" },
                values: new object[] { 130, "Qui nobis debitis animi et veritatis voluptatem voluptatem.", false, "Up-sized zero administration task-force" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Capacity", "Description", "IsAvailable", "Name" },
                values: new object[] { 63, "Neque et et aperiam debitis ut.", false, "Vision-oriented system-worthy policy" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 107, "Hic harum atque sint alias qui fugit.", "Proactive heuristic superstructure" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Capacity", "Description", "IsAvailable", "Name" },
                values: new object[] { 107, "Rerum aut et.", true, "Front-line composite database" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Capacity", "Description", "IsAvailable", "Name" },
                values: new object[] { 109, "Aut qui non quos nostrum accusantium.", true, "Right-sized user-facing intranet" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Capacity", "Description", "IsAvailable", "Name" },
                values: new object[] { 164, "Eaque perferendis omnis enim reiciendis nemo quod est ea.", true, "Organized stable budgetary management" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Capacity", "Description", "IsAvailable", "Name" },
                values: new object[] { 167, "Soluta maxime sit eius quos nostrum ratione.", true, "Reverse-engineered attitude-oriented framework" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 58, "Repellendus officiis veniam cumque quasi voluptates nam voluptate.", "Proactive fresh-thinking monitoring" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Capacity", "Description", "IsAvailable", "Name" },
                values: new object[] { 53, "Maxime dolor enim ad non consequatur perspiciatis deserunt quibusdam sed.", true, "Virtual analyzing leverage" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 177, "Et quia sunt quam sed quia omnis laboriosam.", "Advanced mission-critical initiative" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Capacity", "Description", "IsAvailable", "Name" },
                values: new object[] { 86, "Id aliquam qui porro deserunt corrupti.", false, "Public-key contextually-based structure" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 53, "Repellendus quo labore facilis rerum qui nihil velit ea.", "Devolved explicit adapter" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 168, "Ipsum id beatae consequatur molestias doloribus dolor illo voluptatem.", "Expanded grid-enabled pricing structure" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 58, "Illo quia culpa provident odio voluptatem optio a dolorum.", "Operative encompassing local area network" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 141, "Rerum alias aut et odio magni voluptate.", "Upgradable systematic productivity" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 90, "Dolores at autem id ea.", "Visionary background groupware" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Capacity", "Description", "IsAvailable", "Name" },
                values: new object[] { 143, "Sunt omnis optio exercitationem possimus optio nostrum possimus eaque.", true, "Right-sized encompassing installation" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Capacity", "Description", "IsAvailable", "Name" },
                values: new object[] { 132, "Quis quia cupiditate illo quod.", false, "Pre-emptive stable benchmark" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 147, "Minus qui facere sint eum officia dolorum sapiente ipsam velit.", "Pre-emptive radical project" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Autem nam praesentium quaerat ut quia molestiae corrupti ut ut.", "Self-enabling regional functionalities" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 151, "Non soluta provident.", "Customizable multi-state adapter" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 134, "Dolore debitis recusandae ipsum veniam earum.", "Decentralized executive standardization" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 175, "Rerum delectus maxime.", "Exclusive composite frame" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Incidunt consectetur voluptatem velit ea molestias qui quasi quas nihil.", "Cross-platform global alliance" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 194, "Cupiditate cumque rerum quod ea.", "Centralized dynamic process improvement" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 156, "Exercitationem doloribus assumenda.", "Centralized tertiary capability" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Est temporibus necessitatibus qui dolor iure eius consequatur.", "Compatible executive productivity" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Capacity", "Description", "IsAvailable", "Name" },
                values: new object[] { 168, "Porro eos quod eum.", true, "Horizontal composite task-force" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 160, "Officia beatae molestiae reprehenderit.", "Networked dynamic toolset" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 103, "Eum magnam ullam quia nihil beatae sit.", "Decentralized heuristic solution" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Capacity", "Description", "IsAvailable", "Name" },
                values: new object[] { 171, "Provident laudantium a debitis id fugiat omnis laudantium.", true, "Managed multi-tasking analyzer" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Capacity", "Description", "IsAvailable", "Name" },
                values: new object[] { 136, "Harum corporis ut voluptas.", true, "Progressive clear-thinking secured line" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Capacity", "Description", "IsAvailable", "Name" },
                values: new object[] { 141, "Quam ipsa unde esse nesciunt.", false, "Cross-group composite ability" });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "EmployeeCount", "Name" },
                values: new object[] { "Sapiente rerum non consequuntur blanditiis consequatur sint voluptatem.", 37, "Music & Kids" });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "EmployeeCount", "Name" },
                values: new object[] { "Ut voluptates distinctio aliquam in.", 38, "Health" });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "EmployeeCount", "Name" },
                values: new object[] { "Nihil est exercitationem.", 41, "Baby, Jewelery & Industrial" });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "EmployeeCount", "Name" },
                values: new object[] { "Maiores aliquam et.", 19, "Industrial, Baby & Garden" });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "EmployeeCount", "Name" },
                values: new object[] { "Doloremque modi doloribus aut similique aspernatur.", 30, "Games & Grocery" });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Description", "EmployeeCount", "Name" },
                values: new object[] { "Dolorem ducimus qui.", 28, "Electronics, Garden & Sports" });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Description", "EmployeeCount", "Name" },
                values: new object[] { "Corrupti eum consequatur.", 7, "Home & Clothing" });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Description", "EmployeeCount", "Name" },
                values: new object[] { "Dolorem hic mollitia dolorum sint non omnis architecto velit consequatur.", 31, "Jewelery" });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Description", "EmployeeCount" },
                values: new object[] { "Quo quo at dolore officia nulla error eaque repellendus.", 32 });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Description", "EmployeeCount", "Name" },
                values: new object[] { "Cupiditate fugit voluptatibus id est tenetur laborum.", 43, "Kids" });

            migrationBuilder.UpdateData(
                table: "events",
                keyColumn: "Id",
                keyValue: -20,
                columns: new[] { "CurrentAttendees", "Description", "EndTime", "EventCategory", "MaxAttendees", "RegularPrice", "StartTime", "Title", "VipPrice" },
                values: new object[] { 28, "Voluptatem aspernatur dicta necessitatibus quas ullam debitis. Dolor ab dolor aut hic earum eaque mollitia nihil optio. Perferendis aliquam totam. Nostrum sapiente hic hic perferendis itaque est dolorem illo. Natus rerum at eos non omnis.", new DateTime(2025, 5, 4, 19, 0, 39, 892, DateTimeKind.Local).AddTicks(5613), 5, 144, 595.747584379924120m, new DateTime(2025, 5, 4, 17, 26, 28, 228, DateTimeKind.Local).AddTicks(1184), "Porro maiores nisi aut.", 893.6213765698861800m });

            migrationBuilder.UpdateData(
                table: "events",
                keyColumn: "Id",
                keyValue: -19,
                columns: new[] { "CurrentAttendees", "Description", "EndTime", "MaxAttendees", "RegularPrice", "StartTime", "Title", "VipPrice" },
                values: new object[] { 40, "Modi et facilis at nemo officia et. Aperiam ea et voluptas dignissimos corrupti illum. Velit laudantium voluptatem iure omnis placeat ab architecto. Maxime atque reiciendis aut delectus voluptas expedita.", new DateTime(2024, 8, 9, 14, 36, 48, 249, DateTimeKind.Local).AddTicks(118), 135, 433.489707847178830m, new DateTime(2024, 8, 9, 12, 3, 13, 606, DateTimeKind.Local).AddTicks(2267), "Sequi soluta aut dicta eos quia.", 650.2345617707682450m });

            migrationBuilder.UpdateData(
                table: "events",
                keyColumn: "Id",
                keyValue: -18,
                columns: new[] { "CurrentAttendees", "Description", "EndTime", "EventCategory", "MaxAttendees", "RegularPrice", "StartTime", "Title", "VipPrice" },
                values: new object[] { 17, "Aliquid porro officiis nisi eligendi pariatur. Aut totam numquam et dignissimos tempore esse sint occaecati. Minus cumque perferendis quasi voluptatum. Officiis placeat et.", new DateTime(2024, 11, 22, 8, 16, 12, 762, DateTimeKind.Local).AddTicks(3126), 3, 113, 96.9033493553629690m, new DateTime(2024, 11, 22, 5, 57, 18, 697, DateTimeKind.Local).AddTicks(5119), "Ipsam laboriosam minus sunt sed libero sint vitae.", 145.35502403304445350m });

            migrationBuilder.UpdateData(
                table: "events",
                keyColumn: "Id",
                keyValue: -17,
                columns: new[] { "CurrentAttendees", "Description", "EndTime", "MaxAttendees", "RegularPrice", "StartTime", "Title", "VipPrice" },
                values: new object[] { 9, "Error explicabo reiciendis necessitatibus. Laborum natus placeat enim cum nihil nobis aspernatur. Quasi rerum molestiae in architecto ut sint. Non voluptatem rerum perferendis adipisci porro.", new DateTime(2024, 11, 24, 16, 52, 58, 554, DateTimeKind.Local).AddTicks(8828), 113, 190.524176760540250m, new DateTime(2024, 11, 24, 13, 21, 42, 468, DateTimeKind.Local).AddTicks(995), "Itaque amet ea quidem et dignissimos.", 285.7862651408103750m });

            migrationBuilder.UpdateData(
                table: "events",
                keyColumn: "Id",
                keyValue: -16,
                columns: new[] { "CurrentAttendees", "Description", "EndTime", "EventCategory", "MaxAttendees", "RegularPrice", "StartTime", "Title", "VipPrice" },
                values: new object[] { 27, "Quia doloribus unde id. Ipsum nostrum et praesentium nesciunt unde sunt aliquid. Voluptate quidem voluptatem odio eius alias ut similique dolore. Ratione qui autem ea totam maxime impedit culpa. Tempora aliquam non.", new DateTime(2024, 8, 3, 9, 41, 51, 10, DateTimeKind.Local).AddTicks(8684), 1, 63, 384.658341665953510m, new DateTime(2024, 8, 3, 8, 6, 52, 229, DateTimeKind.Local).AddTicks(4728), "Blanditiis sed perferendis.", 576.9875124989302650m });

            migrationBuilder.UpdateData(
                table: "events",
                keyColumn: "Id",
                keyValue: -15,
                columns: new[] { "CurrentAttendees", "Description", "EndTime", "EventCategory", "MaxAttendees", "RegularPrice", "StartTime", "Title", "VipPrice" },
                values: new object[] { 18, "Eaque quas eum laboriosam qui atque. Rerum qui expedita perferendis et aut impedit iste. Id non fugit. Provident numquam voluptatum laboriosam qui. Consequuntur iusto molestiae ab delectus. Vero quia illum sed tenetur laudantium mollitia.", new DateTime(2024, 7, 4, 10, 58, 21, 923, DateTimeKind.Local).AddTicks(1173), 5, 146, 22.6437920664805090m, new DateTime(2024, 7, 4, 9, 30, 11, 59, DateTimeKind.Local).AddTicks(528), "Deleniti qui consequatur sequi laborum laborum omnis nemo.", 33.96568809972076350m });

            migrationBuilder.UpdateData(
                table: "events",
                keyColumn: "Id",
                keyValue: -14,
                columns: new[] { "CurrentAttendees", "Description", "EndTime", "EventCategory", "MaxAttendees", "RegularPrice", "StartTime", "Title", "VipPrice" },
                values: new object[] { 25, "Sunt et et temporibus nihil facilis. Illum et fugiat amet aut porro sed. Voluptatem voluptatem reiciendis nam sapiente minus temporibus dolore.", new DateTime(2024, 10, 1, 14, 55, 27, 200, DateTimeKind.Local).AddTicks(4708), 1, 133, 303.441741704010790m, new DateTime(2024, 10, 1, 12, 14, 24, 73, DateTimeKind.Local).AddTicks(3869), "Itaque officiis est quisquam nulla ea occaecati nihil.", 455.1626125560161850m });

            migrationBuilder.UpdateData(
                table: "events",
                keyColumn: "Id",
                keyValue: -13,
                columns: new[] { "CurrentAttendees", "Description", "EndTime", "EventCategory", "MaxAttendees", "RegularPrice", "StartTime", "Title", "VipPrice" },
                values: new object[] { 8, "Explicabo expedita dolores aperiam voluptatem. Eius et qui. Tempore quisquam corrupti unde non et eius. Ab quaerat incidunt occaecati et est adipisci molestias sapiente sequi. Distinctio minima asperiores totam ratione voluptas est blanditiis.", new DateTime(2024, 8, 4, 12, 15, 11, 355, DateTimeKind.Local).AddTicks(7873), 1, 174, 83.3528420515005940m, new DateTime(2024, 8, 4, 8, 34, 10, 454, DateTimeKind.Local).AddTicks(1296), "Dolorum fuga beatae dolores itaque voluptas eum minus.", 125.02926307725089100m });

            migrationBuilder.UpdateData(
                table: "events",
                keyColumn: "Id",
                keyValue: -12,
                columns: new[] { "CurrentAttendees", "Description", "EndTime", "MaxAttendees", "RegularPrice", "StartTime", "Title", "VipPrice" },
                values: new object[] { 42, "Nesciunt pariatur voluptatibus quaerat illum qui. Ut qui ut vitae quod vero ex. Voluptate neque sed voluptatem.", new DateTime(2025, 3, 7, 3, 6, 29, 381, DateTimeKind.Local).AddTicks(5413), 195, 210.782812219752070m, new DateTime(2025, 3, 6, 23, 27, 4, 384, DateTimeKind.Local).AddTicks(3770), "Hic tempora fugit id explicabo magnam nihil.", 316.1742183296281050m });

            migrationBuilder.UpdateData(
                table: "events",
                keyColumn: "Id",
                keyValue: -11,
                columns: new[] { "CurrentAttendees", "Description", "EndTime", "EventCategory", "MaxAttendees", "RegularPrice", "StartTime", "Title", "VipPrice" },
                values: new object[] { 37, "Odio molestiae libero cumque eaque recusandae voluptas voluptates rem voluptatem. Quo velit laboriosam natus cum sed impedit aut aspernatur. Nam dolorem officiis itaque inventore sunt repellat. Veniam eligendi sint distinctio quasi repudiandae dicta.", new DateTime(2025, 3, 12, 3, 15, 51, 27, DateTimeKind.Local).AddTicks(4145), 2, 89, 226.70489927177740m, new DateTime(2025, 3, 11, 23, 55, 54, 28, DateTimeKind.Local).AddTicks(9057), "Est provident perferendis distinctio quisquam.", 340.057348907666100m });

            migrationBuilder.UpdateData(
                table: "events",
                keyColumn: "Id",
                keyValue: -10,
                columns: new[] { "CurrentAttendees", "Description", "EndTime", "EventCategory", "MaxAttendees", "RegularPrice", "StartTime", "Title", "VipPrice" },
                values: new object[] { 43, "Dicta sed voluptatem ipsa porro qui. Optio labore repudiandae sunt minima et quia deserunt voluptatem enim. Harum distinctio velit voluptas libero sit expedita ut.", new DateTime(2024, 11, 26, 21, 5, 27, 785, DateTimeKind.Local).AddTicks(7855), 4, 168, 349.77565639001710m, new DateTime(2024, 11, 26, 17, 50, 23, 962, DateTimeKind.Local).AddTicks(7796), "Sunt fugit nisi doloribus.", 524.663484585025650m });

            migrationBuilder.UpdateData(
                table: "events",
                keyColumn: "Id",
                keyValue: -9,
                columns: new[] { "CurrentAttendees", "Description", "EndTime", "EventCategory", "MaxAttendees", "RegularPrice", "StartTime", "Title", "VipPrice" },
                values: new object[] { 25, "Voluptatem corrupti ab magni aperiam delectus eum mollitia dolorem. Ipsum impedit ducimus et nobis porro nihil est. Qui aut vero quod voluptatum impedit et. Sint similique illum cupiditate. Sit quod quia illum voluptas harum neque ratione quo aliquid. Id ", new DateTime(2025, 4, 13, 19, 31, 34, 816, DateTimeKind.Local).AddTicks(3531), 1, 101, 313.820723203434910m, new DateTime(2025, 4, 13, 17, 47, 9, 217, DateTimeKind.Local).AddTicks(485), "Alias et non ducimus numquam dolorem expedita veniam quia impedit.", 470.7310848051523650m });

            migrationBuilder.UpdateData(
                table: "events",
                keyColumn: "Id",
                keyValue: -8,
                columns: new[] { "CurrentAttendees", "Description", "EndTime", "EventCategory", "MaxAttendees", "RegularPrice", "StartTime", "Title", "VipPrice" },
                values: new object[] { 43, "Magni molestias sed sed ipsam. Repudiandae et nihil sapiente distinctio omnis molestiae dolores. Quia minus quo sapiente. Eos ipsam autem vero. Sapiente quis sit excepturi nesciunt.", new DateTime(2024, 10, 17, 8, 14, 39, 945, DateTimeKind.Local).AddTicks(4960), 4, 65, 489.116767845314170m, new DateTime(2024, 10, 17, 6, 11, 56, 67, DateTimeKind.Local).AddTicks(5812), "Qui quia sed nesciunt possimus nisi eos est possimus.", 733.6751517679712550m });

            migrationBuilder.UpdateData(
                table: "events",
                keyColumn: "Id",
                keyValue: -7,
                columns: new[] { "CurrentAttendees", "Description", "EndTime", "EventCategory", "MaxAttendees", "RegularPrice", "StartTime", "Title", "VipPrice" },
                values: new object[] { 9, "Alias deserunt tenetur eligendi voluptatum ut magnam aut laborum recusandae. Sed molestiae necessitatibus ipsum repudiandae molestiae minima ad maxime. Quia unde harum. Dolores perferendis vitae accusamus voluptate veniam est exercitationem omnis. Deserun", new DateTime(2025, 6, 5, 9, 37, 14, 821, DateTimeKind.Local).AddTicks(3856), 6, 162, 739.55760162807610m, new DateTime(2025, 6, 5, 6, 18, 59, 450, DateTimeKind.Local).AddTicks(9087), "Dolor ut voluptas ratione eligendi exercitationem quidem necessitatibus quia qui.", 1109.336402442114150m });

            migrationBuilder.UpdateData(
                table: "events",
                keyColumn: "Id",
                keyValue: -6,
                columns: new[] { "CurrentAttendees", "Description", "EndTime", "EventCategory", "MaxAttendees", "RegularPrice", "StartTime", "Title", "VipPrice" },
                values: new object[] { 33, "Aliquid rerum nulla qui sed quos vel. Quia magnam a nulla. Fuga minus nostrum illum eius et eos omnis earum labore. Quo voluptatem ut magni qui in.", new DateTime(2024, 9, 23, 15, 12, 31, 994, DateTimeKind.Local).AddTicks(5915), 6, 175, 114.745938197385430m, new DateTime(2024, 9, 23, 11, 41, 58, 684, DateTimeKind.Local).AddTicks(7623), "Vitae fuga eligendi et cupiditate sed dolorum delectus nisi.", 172.1189072960781450m });

            migrationBuilder.UpdateData(
                table: "events",
                keyColumn: "Id",
                keyValue: -5,
                columns: new[] { "CurrentAttendees", "Description", "EndTime", "EventCategory", "MaxAttendees", "RegularPrice", "StartTime", "Title", "VipPrice" },
                values: new object[] { 29, "Laboriosam qui enim et est sapiente iste ea eius. Et facere nobis. Consequatur consequatur et. Dolor pariatur illo ut. Dolorum aut dolores cupiditate repudiandae voluptatem qui perspiciatis qui error.", new DateTime(2024, 12, 26, 5, 27, 36, 133, DateTimeKind.Local).AddTicks(348), 2, 122, 43.0239279683492740m, new DateTime(2024, 12, 26, 3, 32, 7, 211, DateTimeKind.Local).AddTicks(2793), "Incidunt et blanditiis.", 64.53589195252391100m });

            migrationBuilder.UpdateData(
                table: "events",
                keyColumn: "Id",
                keyValue: -4,
                columns: new[] { "CurrentAttendees", "Description", "EndTime", "MaxAttendees", "RegularPrice", "StartTime", "Title", "VipPrice" },
                values: new object[] { 36, "Et sed porro. Culpa nobis amet laborum deserunt voluptates. Vero et provident et repudiandae enim cupiditate odit dignissimos.", new DateTime(2024, 9, 14, 17, 37, 19, 43, DateTimeKind.Local).AddTicks(3576), 162, 810.240644317912930m, new DateTime(2024, 9, 14, 14, 44, 54, 916, DateTimeKind.Local).AddTicks(4547), "Eaque quo fugiat qui exercitationem harum.", 1215.3609664768693950m });

            migrationBuilder.UpdateData(
                table: "events",
                keyColumn: "Id",
                keyValue: -3,
                columns: new[] { "CurrentAttendees", "Description", "EndTime", "EventCategory", "MaxAttendees", "RegularPrice", "StartTime", "Title", "VipPrice" },
                values: new object[] { 7, "Ut sequi illum provident cupiditate iste neque. Autem autem cupiditate. Maiores consequatur sed accusamus.", new DateTime(2024, 12, 9, 19, 41, 28, 165, DateTimeKind.Local).AddTicks(3148), 4, 193, 888.022802337830380m, new DateTime(2024, 12, 9, 18, 7, 47, 271, DateTimeKind.Local).AddTicks(9689), "Id itaque quas aut odio vel itaque autem nulla.", 1332.0342035067455700m });

            migrationBuilder.UpdateData(
                table: "events",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "CurrentAttendees", "Description", "EndTime", "EventCategory", "MaxAttendees", "RegularPrice", "StartTime", "Title", "VipPrice" },
                values: new object[] { 15, "Distinctio ipsum repellendus commodi sed pariatur iusto cupiditate veritatis sapiente. Quas eos eum maiores reiciendis quia non. Molestiae ad dolorum expedita atque qui quia quidem id. Officiis id non consequuntur fugiat.", new DateTime(2024, 6, 19, 23, 59, 50, 567, DateTimeKind.Local).AddTicks(5303), 5, 99, 630.838496502401320m, new DateTime(2024, 6, 19, 20, 49, 49, 540, DateTimeKind.Local).AddTicks(393), "Molestiae quia et qui illo deserunt.", 946.2577447536019800m });

            migrationBuilder.UpdateData(
                table: "events",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CurrentAttendees", "Description", "EndTime", "EventCategory", "MaxAttendees", "RegularPrice", "StartTime", "Title", "VipPrice" },
                values: new object[] { 30, "Voluptatem molestiae cum voluptates eius amet. Fuga est ex culpa dolor culpa sint dolorem. Cum assumenda vero laudantium earum ut iste consectetur nemo. Nobis consequatur repellat aliquam temporibus inventore et occaecati facilis est. Autem natus quis est", new DateTime(2024, 10, 22, 8, 27, 28, 856, DateTimeKind.Local).AddTicks(9960), 5, 113, 137.488946920422670m, new DateTime(2024, 10, 22, 7, 12, 8, 884, DateTimeKind.Local).AddTicks(2187), "Libero ex animi iure aut eaque id a et sed.", 206.2334203806340050m });

            migrationBuilder.UpdateData(
                table: "facilities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 176, "Voluptatem voluptatem ratione earum sed sequi facilis accusantium sequi.", "Bayer, Bahringer and Waelchi" });

            migrationBuilder.UpdateData(
                table: "facilities",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 303, "Est assumenda ducimus non veritatis.", "Murazik - Russel" });

            migrationBuilder.UpdateData(
                table: "facilities",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 421, "Rerum assumenda nihil quia ea velit aliquam.", "Boehm Group" });

            migrationBuilder.UpdateData(
                table: "facilities",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 322, "Officia et tenetur architecto excepturi ut quasi iste commodi esse.", "Hudson - Padberg" });

            migrationBuilder.UpdateData(
                table: "facilities",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 464, "Suscipit labore nihil eligendi consectetur rem officiis delectus praesentium recusandae.", "Thompson Inc" });

            migrationBuilder.UpdateData(
                table: "facilities",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 150, "Quis possimus neque eos debitis maiores.", "Greenfelder - Mann" });

            migrationBuilder.UpdateData(
                table: "facilities",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 473, "Possimus non exercitationem quia in repellat qui autem quia.", "Legros - MacGyver" });

            migrationBuilder.UpdateData(
                table: "facilities",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 146, "Praesentium incidunt qui.", "Witting and Sons" });

            migrationBuilder.UpdateData(
                table: "facilities",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 389, "In consequatur alias minima voluptatibus et velit.", "Haag LLC" });

            migrationBuilder.UpdateData(
                table: "facilities",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 178, "Aut repudiandae aperiam et unde asperiores hic numquam sit.", "Hyatt, Cronin and Mitchell" });

            migrationBuilder.UpdateData(
                table: "shifts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FromHour", "ToHour" },
                values: new object[] { new TimeSpan(0, 6, 52, 0, 0), new TimeSpan(0, 15, 24, 0, 0) });

            migrationBuilder.UpdateData(
                table: "shifts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "FromHour", "ShiftType", "ToHour" },
                values: new object[] { new TimeSpan(0, 16, 24, 0, 0), 1, new TimeSpan(0, 17, 19, 0, 0) });

            migrationBuilder.UpdateData(
                table: "shifts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "FromHour", "ToHour" },
                values: new object[] { new TimeSpan(0, 4, 41, 0, 0), new TimeSpan(0, 20, 57, 0, 0) });

            migrationBuilder.UpdateData(
                table: "shifts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "FromHour", "ShiftType", "ToHour" },
                values: new object[] { new TimeSpan(0, 0, 53, 0, 0), 2, new TimeSpan(0, 7, 54, 0, 0) });

            migrationBuilder.UpdateData(
                table: "shifts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "FromHour", "ShiftType", "ToHour" },
                values: new object[] { new TimeSpan(0, 6, 6, 0, 0), 3, new TimeSpan(0, 22, 27, 0, 0) });

            migrationBuilder.UpdateData(
                table: "shifts",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "FromHour", "ShiftType", "ToHour" },
                values: new object[] { new TimeSpan(0, 19, 6, 0, 0), 1, new TimeSpan(0, 17, 26, 0, 0) });

            migrationBuilder.UpdateData(
                table: "shifts",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "FromHour", "ShiftType", "ToHour" },
                values: new object[] { new TimeSpan(0, 3, 29, 0, 0), 1, new TimeSpan(0, 0, 34, 0, 0) });

            migrationBuilder.UpdateData(
                table: "shifts",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "FromHour", "ShiftType", "ToHour" },
                values: new object[] { new TimeSpan(0, 10, 10, 0, 0), 2, new TimeSpan(0, 11, 35, 0, 0) });

            migrationBuilder.UpdateData(
                table: "shifts",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "FromHour", "ToHour" },
                values: new object[] { new TimeSpan(0, 10, 49, 0, 0), new TimeSpan(0, 16, 14, 0, 0) });

            migrationBuilder.UpdateData(
                table: "shifts",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "FromHour", "ShiftType", "ToHour" },
                values: new object[] { new TimeSpan(0, 18, 14, 0, 0), 2, new TimeSpan(0, 8, 27, 0, 0) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "addresses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BuildingNo", "City", "Street" },
                values: new object[] { "5694", "Ashamouth", "Brooklyn Fork" });

            migrationBuilder.UpdateData(
                table: "addresses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BuildingNo", "City", "Street" },
                values: new object[] { "330", "Connerborough", "Kyleigh Corners" });

            migrationBuilder.UpdateData(
                table: "addresses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BuildingNo", "City", "Street" },
                values: new object[] { "63272", "Port Oralside", "Sydney Hollow" });

            migrationBuilder.UpdateData(
                table: "addresses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BuildingNo", "City", "Street" },
                values: new object[] { "33334", "New Cecile", "Buckridge Island" });

            migrationBuilder.UpdateData(
                table: "addresses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "BuildingNo", "City", "Street" },
                values: new object[] { "7414", "East Wanda", "Providenci Ports" });

            migrationBuilder.UpdateData(
                table: "addresses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "BuildingNo", "City", "Street" },
                values: new object[] { "079", "East Billyland", "Vince Flat" });

            migrationBuilder.UpdateData(
                table: "addresses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "BuildingNo", "City", "Street" },
                values: new object[] { "86312", "Schoentown", "Tromp Highway" });

            migrationBuilder.UpdateData(
                table: "addresses",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "BuildingNo", "City", "Street" },
                values: new object[] { "74322", "Dorothyshire", "Idella Roads" });

            migrationBuilder.UpdateData(
                table: "addresses",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "BuildingNo", "City", "Street" },
                values: new object[] { "258", "New Geovannytown", "Hahn Inlet" });

            migrationBuilder.UpdateData(
                table: "addresses",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "BuildingNo", "City", "Street" },
                values: new object[] { "4598", "Hilpertside", "Johnston Hills" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Capacity", "Description", "IsAvailable", "Name" },
                values: new object[] { 110, "Adipisci dolores odit sint.", false, "Polarised transitional alliance" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Capacity", "Description", "IsAvailable", "Name" },
                values: new object[] { 115, "Aperiam nostrum quo unde.", true, "Organized full-range structure" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 74, "Quidem asperiores consequatur dolores qui molestiae atque.", "Devolved coherent orchestration" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 107, "Perspiciatis iure earum ratione.", "Profound responsive synergy" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 54, "Quia itaque corrupti ipsum voluptatem aut soluta quos quia provident.", "Versatile eco-centric complexity" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Capacity", "Description", "IsAvailable", "Name" },
                values: new object[] { 185, "Similique recusandae voluptatum sed totam magni dolorem excepturi ullam.", true, "Exclusive dynamic conglomeration" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 60, "Eos fuga eaque.", "Upgradable hybrid paradigm" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Capacity", "Description", "IsAvailable", "Name" },
                values: new object[] { 107, "Molestiae nihil et corrupti et iste.", false, "Enhanced didactic conglomeration" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Capacity", "Description", "IsAvailable", "Name" },
                values: new object[] { 115, "Et eum deleniti cum earum.", true, "Polarised 4th generation leverage" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 116, "Totam voluptates incidunt recusandae magni enim.", "Universal directional conglomeration" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Capacity", "Description", "IsAvailable", "Name" },
                values: new object[] { 176, "Ipsum fugit error sit neque omnis nemo.", true, "Managed even-keeled encoding" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 140, "Qui sint expedita totam quia et.", "Reactive demand-driven migration" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Capacity", "Description", "IsAvailable", "Name" },
                values: new object[] { 158, "Non itaque excepturi quia nihil velit.", true, "Reactive local service-desk" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 197, "Dolor laboriosam dignissimos veritatis.", "Focused static paradigm" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 180, "At tempora totam quo est expedita quod beatae.", "Monitored coherent definition" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Capacity", "Description", "IsAvailable", "Name" },
                values: new object[] { 125, "Ut et quis sequi voluptatem.", false, "Managed optimizing alliance" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 66, "Natus eaque iste ea rem mollitia velit et ipsum velit.", "Face to face multimedia concept" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Capacity", "Description", "IsAvailable", "Name" },
                values: new object[] { 55, "Eius fugiat aliquid quia animi et est ut rerum eum.", true, "Assimilated methodical hub" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Capacity", "Description", "IsAvailable", "Name" },
                values: new object[] { 120, "Officiis est at nemo itaque assumenda laborum velit.", true, "Extended dedicated methodology" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 169, "Corrupti pariatur assumenda amet aliquam non veniam nulla.", "Vision-oriented national software" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Capacity", "Description", "IsAvailable", "Name" },
                values: new object[] { 170, "Veritatis voluptatem reiciendis molestiae.", false, "Team-oriented needs-based conglomeration" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Capacity", "Description", "IsAvailable", "Name" },
                values: new object[] { 115, "Voluptatem aut tenetur voluptatem quia quia veniam sit officia.", false, "Horizontal optimal website" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Capacity", "Description", "IsAvailable", "Name" },
                values: new object[] { 97, "Deleniti repudiandae sit enim fugit repellendus eum iusto commodi.", false, "Open-source user-facing capability" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Capacity", "Description", "IsAvailable", "Name" },
                values: new object[] { 177, "Dolorum architecto enim totam.", false, "Profit-focused systemic intranet" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 155, "Autem cumque sint voluptates quos officia nesciunt fugiat.", "Horizontal multi-state open architecture" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Capacity", "Description", "IsAvailable", "Name" },
                values: new object[] { 168, "Magni accusantium qui placeat laborum quia ex eum sequi.", false, "Optimized holistic customer loyalty" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 107, "Nulla ratione non totam perferendis voluptate.", "Vision-oriented responsive circuit" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Capacity", "Description", "IsAvailable", "Name" },
                values: new object[] { 145, "Iste eveniet molestiae ad odit dolor voluptatem sit earum.", true, "Cross-group asynchronous functionalities" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 165, "Fuga accusantium autem dicta autem voluptates molestiae praesentium.", "Distributed 3rd generation hardware" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 196, "Est et atque minima non eveniet quisquam modi et hic.", "Optimized object-oriented synergy" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 87, "Sunt nihil reiciendis natus dolorem natus neque.", "Visionary regional open architecture" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 190, "Quo voluptate dolore tempore.", "Pre-emptive grid-enabled access" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 86, "Fugiat qui aut sit explicabo neque.", "Diverse analyzing pricing structure" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Capacity", "Description", "IsAvailable", "Name" },
                values: new object[] { 105, "Cupiditate sapiente qui odit et.", false, "Diverse human-resource groupware" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Capacity", "Description", "IsAvailable", "Name" },
                values: new object[] { 186, "Voluptas consequatur optio sed molestias aut id dolor.", true, "Networked background definition" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 78, "Doloribus nobis adipisci dolor eaque.", "Extended leading edge encryption" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Aut vel praesentium libero perspiciatis et.", "Reduced exuding task-force" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 181, "Omnis ut ut fugiat quasi eos omnis tenetur quos dolor.", "Managed attitude-oriented open architecture" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 59, "Rerum distinctio aliquid dicta rerum quas assumenda.", "Ergonomic impactful artificial intelligence" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 149, "Dicta cupiditate nam beatae exercitationem.", "Compatible full-range pricing structure" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Voluptas qui aperiam.", "Customizable bifurcated Graphic Interface" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 171, "Aut neque ab odio deleniti.", "Face to face next generation knowledge user" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 189, "Animi quaerat atque placeat enim quam consequuntur dolorum.", "Secured fault-tolerant open architecture" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Qui deserunt odit sed ut tenetur eius.", "Programmable eco-centric info-mediaries" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Capacity", "Description", "IsAvailable", "Name" },
                values: new object[] { 64, "Impedit ut totam eos culpa.", false, "Decentralized contextually-based synergy" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 62, "Fugit velit aliquam ut et facere.", "Virtual logistical knowledge user" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 182, "In sapiente ipsa ratione nulla alias et voluptatem ex.", "Open-source multimedia portal" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Capacity", "Description", "IsAvailable", "Name" },
                values: new object[] { 96, "Qui incidunt velit sed.", false, "Object-based stable encoding" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Capacity", "Description", "IsAvailable", "Name" },
                values: new object[] { 93, "Et hic ratione nemo repudiandae maxime asperiores omnis.", false, "Integrated zero defect concept" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Capacity", "Description", "IsAvailable", "Name" },
                values: new object[] { 168, "Molestias consequatur architecto cupiditate et in harum qui voluptatem.", true, "Realigned demand-driven analyzer" });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "EmployeeCount", "Name" },
                values: new object[] { "Nihil sint distinctio nihil magni enim magni vitae animi.", 42, "Outdoors, Health & Grocery" });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "EmployeeCount", "Name" },
                values: new object[] { "Aut numquam dolor ut rem.", 25, "Toys & Computers" });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "EmployeeCount", "Name" },
                values: new object[] { "Omnis voluptatem quos aspernatur ipsum vero.", 44, "Outdoors, Industrial & Jewelery" });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "EmployeeCount", "Name" },
                values: new object[] { "Laborum officia dignissimos fuga.", 38, "Home & Games" });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "EmployeeCount", "Name" },
                values: new object[] { "Ea tempora autem reprehenderit culpa adipisci officia incidunt.", 44, "Baby" });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Description", "EmployeeCount", "Name" },
                values: new object[] { "Aperiam qui neque vel consequatur.", 12, "Jewelery, Garden & Health" });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Description", "EmployeeCount", "Name" },
                values: new object[] { "Voluptatem nam aut vel expedita in unde fugit ullam eaque.", 23, "Music & Electronics" });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Description", "EmployeeCount", "Name" },
                values: new object[] { "Maxime dolorem laborum error non porro cum adipisci molestias.", 48, "Health" });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Description", "EmployeeCount" },
                values: new object[] { "Aut qui animi quo veniam sint quia.", 33 });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Description", "EmployeeCount", "Name" },
                values: new object[] { "Earum tempora distinctio et molestiae.", 34, "Industrial & Electronics" });

            migrationBuilder.UpdateData(
                table: "events",
                keyColumn: "Id",
                keyValue: -20,
                columns: new[] { "CurrentAttendees", "Description", "EndTime", "EventCategory", "MaxAttendees", "RegularPrice", "StartTime", "Title", "VipPrice" },
                values: new object[] { 21, "Atque dolorum ratione minus odit temporibus. Id ex enim non aut molestiae. Autem sed nihil aut. Sed consequatur consequuntur minima fuga eum perspiciatis reprehenderit enim. Dolores sit placeat qui quas aut.", new DateTime(2025, 5, 22, 7, 2, 50, 83, DateTimeKind.Local).AddTicks(7387), 2, 111, 508.932230331245590m, new DateTime(2025, 5, 22, 4, 57, 23, 196, DateTimeKind.Local).AddTicks(6633), "Sapiente consequatur odit qui magni et est.", 763.3983454968683850m });

            migrationBuilder.UpdateData(
                table: "events",
                keyColumn: "Id",
                keyValue: -19,
                columns: new[] { "CurrentAttendees", "Description", "EndTime", "MaxAttendees", "RegularPrice", "StartTime", "Title", "VipPrice" },
                values: new object[] { 13, "Ea et saepe labore unde. At ab sed. Aut deserunt est velit rerum dolores aliquam libero est. Distinctio facilis qui hic natus placeat asperiores optio minus voluptates.", new DateTime(2024, 11, 16, 5, 32, 17, 620, DateTimeKind.Local).AddTicks(4841), 87, 888.532665426300610m, new DateTime(2024, 11, 16, 2, 38, 48, 410, DateTimeKind.Local).AddTicks(3338), "Facilis earum error corrupti eum omnis voluptatem praesentium numquam laudantium.", 1332.7989981394509150m });

            migrationBuilder.UpdateData(
                table: "events",
                keyColumn: "Id",
                keyValue: -18,
                columns: new[] { "CurrentAttendees", "Description", "EndTime", "EventCategory", "MaxAttendees", "RegularPrice", "StartTime", "Title", "VipPrice" },
                values: new object[] { 30, "Eum quia doloremque sed nisi praesentium amet veniam accusamus. Voluptatem harum iusto ipsa in repudiandae. Itaque odio autem. Quidem quis repellat. Consequatur odio alias et iste in.", new DateTime(2025, 2, 22, 23, 31, 7, 824, DateTimeKind.Local).AddTicks(1088), 6, 155, 461.388723945408370m, new DateTime(2025, 2, 22, 19, 48, 53, 591, DateTimeKind.Local).AddTicks(5306), "Quae dicta pariatur temporibus odio quisquam aspernatur.", 692.0830859181125550m });

            migrationBuilder.UpdateData(
                table: "events",
                keyColumn: "Id",
                keyValue: -17,
                columns: new[] { "CurrentAttendees", "Description", "EndTime", "MaxAttendees", "RegularPrice", "StartTime", "Title", "VipPrice" },
                values: new object[] { 40, "Maiores non dignissimos rerum quisquam ducimus. Inventore saepe unde. Beatae occaecati dolorem doloribus porro sequi quae nostrum et. Officiis fuga blanditiis exercitationem occaecati eaque qui cupiditate. Quia molestiae ut optio.", new DateTime(2025, 6, 6, 2, 56, 18, 740, DateTimeKind.Local).AddTicks(6345), 129, 130.521389496455530m, new DateTime(2025, 6, 5, 23, 35, 29, 79, DateTimeKind.Local).AddTicks(25), "Aut rerum quasi.", 195.7820842446832950m });

            migrationBuilder.UpdateData(
                table: "events",
                keyColumn: "Id",
                keyValue: -16,
                columns: new[] { "CurrentAttendees", "Description", "EndTime", "EventCategory", "MaxAttendees", "RegularPrice", "StartTime", "Title", "VipPrice" },
                values: new object[] { 28, "In ex delectus laudantium ipsam minus recusandae accusamus. Voluptas animi itaque est magnam sequi. Sed qui facilis enim odio doloribus dolores consequatur voluptatem distinctio.", new DateTime(2024, 12, 1, 4, 48, 28, 504, DateTimeKind.Local).AddTicks(2336), 5, 177, 51.0299631220746520m, new DateTime(2024, 12, 1, 2, 18, 2, 194, DateTimeKind.Local).AddTicks(3895), "Ut fugit placeat tempore fugiat.", 76.54494468311197800m });

            migrationBuilder.UpdateData(
                table: "events",
                keyColumn: "Id",
                keyValue: -15,
                columns: new[] { "CurrentAttendees", "Description", "EndTime", "EventCategory", "MaxAttendees", "RegularPrice", "StartTime", "Title", "VipPrice" },
                values: new object[] { 20, "Cum placeat commodi. Sunt perspiciatis quod deserunt ea corrupti quia reprehenderit. Quis distinctio aperiam consequatur sunt nisi iure. Necessitatibus laboriosam voluptatem corrupti. Omnis aut necessitatibus rem corrupti excepturi est suscipit.", new DateTime(2024, 9, 11, 2, 38, 56, 323, DateTimeKind.Local).AddTicks(2040), 6, 174, 170.642625766221610m, new DateTime(2024, 9, 10, 23, 11, 58, 405, DateTimeKind.Local).AddTicks(9023), "Facere a nulla.", 255.9639386493324150m });

            migrationBuilder.UpdateData(
                table: "events",
                keyColumn: "Id",
                keyValue: -14,
                columns: new[] { "CurrentAttendees", "Description", "EndTime", "EventCategory", "MaxAttendees", "RegularPrice", "StartTime", "Title", "VipPrice" },
                values: new object[] { 8, "Consequatur dolorem beatae veritatis dolores odio eum. Hic velit earum error et vel quas. Dicta eius perspiciatis dolores dolores tempore. Nostrum id numquam.", new DateTime(2024, 7, 20, 8, 21, 11, 771, DateTimeKind.Local).AddTicks(2483), 3, 178, 494.36254024961770m, new DateTime(2024, 7, 20, 6, 15, 26, 241, DateTimeKind.Local).AddTicks(5030), "Tenetur molestias est.", 741.543810374426550m });

            migrationBuilder.UpdateData(
                table: "events",
                keyColumn: "Id",
                keyValue: -13,
                columns: new[] { "CurrentAttendees", "Description", "EndTime", "EventCategory", "MaxAttendees", "RegularPrice", "StartTime", "Title", "VipPrice" },
                values: new object[] { 2, "Saepe nostrum blanditiis et ut assumenda. Sed sed aut quia autem. Est nihil facere et non distinctio qui at. Modi qui repellat quae. Non sed tenetur corrupti ratione. Rem quia quae a nulla amet quasi.", new DateTime(2025, 5, 31, 8, 13, 8, 397, DateTimeKind.Local).AddTicks(635), 5, 195, 289.434343836106360m, new DateTime(2025, 5, 31, 4, 13, 41, 471, DateTimeKind.Local).AddTicks(8204), "Quo ducimus aspernatur eum quibusdam qui omnis velit.", 434.1515157541595400m });

            migrationBuilder.UpdateData(
                table: "events",
                keyColumn: "Id",
                keyValue: -12,
                columns: new[] { "CurrentAttendees", "Description", "EndTime", "MaxAttendees", "RegularPrice", "StartTime", "Title", "VipPrice" },
                values: new object[] { 46, "Dolores distinctio deleniti est optio tempore blanditiis consequatur quam. Vel voluptatem omnis hic qui ut explicabo dolore dolor. Et enim error fuga ratione nesciunt similique est. Sunt explicabo laboriosam.", new DateTime(2024, 12, 26, 7, 28, 23, 820, DateTimeKind.Local).AddTicks(4321), 158, 76.1700993714965710m, new DateTime(2024, 12, 26, 3, 30, 19, 22, DateTimeKind.Local).AddTicks(7004), "Temporibus molestias perferendis neque sed veniam.", 114.25514905724485650m });

            migrationBuilder.UpdateData(
                table: "events",
                keyColumn: "Id",
                keyValue: -11,
                columns: new[] { "CurrentAttendees", "Description", "EndTime", "EventCategory", "MaxAttendees", "RegularPrice", "StartTime", "Title", "VipPrice" },
                values: new object[] { 10, "Reprehenderit ex neque quos aut quia eum. Voluptatem at ullam sapiente nobis sint quidem voluptatem aperiam. Nisi maiores quia quo ut.", new DateTime(2025, 2, 23, 23, 8, 40, 981, DateTimeKind.Local).AddTicks(714), 5, 59, 796.080019815478630m, new DateTime(2025, 2, 23, 20, 15, 28, 88, DateTimeKind.Local).AddTicks(7664), "Saepe quia et dolor vitae unde enim.", 1194.1200297232179450m });

            migrationBuilder.UpdateData(
                table: "events",
                keyColumn: "Id",
                keyValue: -10,
                columns: new[] { "CurrentAttendees", "Description", "EndTime", "EventCategory", "MaxAttendees", "RegularPrice", "StartTime", "Title", "VipPrice" },
                values: new object[] { 42, "Quaerat mollitia aut. Consequatur voluptatem tempora quis unde soluta et. Nulla id non velit. Aliquid fugiat dolor eaque. Assumenda aut reiciendis commodi autem temporibus assumenda id nihil tempora. Et delectus voluptatem quis sit et et officiis.", new DateTime(2024, 11, 5, 6, 42, 6, 112, DateTimeKind.Local).AddTicks(1083), 1, 188, 649.268833014244180m, new DateTime(2024, 11, 5, 2, 53, 29, 423, DateTimeKind.Local).AddTicks(848), "Aspernatur ut et.", 973.9032495213662700m });

            migrationBuilder.UpdateData(
                table: "events",
                keyColumn: "Id",
                keyValue: -9,
                columns: new[] { "CurrentAttendees", "Description", "EndTime", "EventCategory", "MaxAttendees", "RegularPrice", "StartTime", "Title", "VipPrice" },
                values: new object[] { 37, "Aut aperiam non quia nisi soluta sunt. Sit molestiae vel molestiae quasi voluptate sint sed perspiciatis nobis. Autem non ut ea labore quia impedit rerum vel dolores. Est ipsam quibusdam tempore enim id error. Nam dolor eius corrupti.", new DateTime(2024, 9, 1, 15, 18, 38, 988, DateTimeKind.Local).AddTicks(899), 6, 122, 98.0688783661504840m, new DateTime(2024, 9, 1, 13, 10, 42, 80, DateTimeKind.Local).AddTicks(2543), "Rerum omnis earum debitis quisquam labore.", 147.10331754922572600m });

            migrationBuilder.UpdateData(
                table: "events",
                keyColumn: "Id",
                keyValue: -8,
                columns: new[] { "CurrentAttendees", "Description", "EndTime", "EventCategory", "MaxAttendees", "RegularPrice", "StartTime", "Title", "VipPrice" },
                values: new object[] { 39, "Accusantium quo quasi corporis voluptatem eius corrupti perferendis sint. Voluptatibus quod blanditiis laudantium recusandae non. Aut in magni unde impedit necessitatibus.", new DateTime(2024, 10, 4, 6, 38, 15, 666, DateTimeKind.Local).AddTicks(2560), 1, 123, 67.9692753934061680m, new DateTime(2024, 10, 4, 3, 30, 12, 137, DateTimeKind.Local).AddTicks(3802), "Sapiente ullam provident magnam ut voluptatem illum neque aliquid.", 101.95391309010925200m });

            migrationBuilder.UpdateData(
                table: "events",
                keyColumn: "Id",
                keyValue: -7,
                columns: new[] { "CurrentAttendees", "Description", "EndTime", "EventCategory", "MaxAttendees", "RegularPrice", "StartTime", "Title", "VipPrice" },
                values: new object[] { 49, "Similique doloribus ratione assumenda doloribus minus quis animi. Ipsa quos molestiae aut dolore possimus voluptatum non est. Enim occaecati magnam dolor dolores ullam esse totam. Dolores id voluptas perferendis repellendus fuga exercitationem.", new DateTime(2025, 4, 29, 22, 51, 34, 981, DateTimeKind.Local).AddTicks(553), 2, 58, 658.650052976730310m, new DateTime(2025, 4, 29, 20, 28, 51, 760, DateTimeKind.Local).AddTicks(5955), "Facilis quo omnis.", 987.9750794650954650m });

            migrationBuilder.UpdateData(
                table: "events",
                keyColumn: "Id",
                keyValue: -6,
                columns: new[] { "CurrentAttendees", "Description", "EndTime", "EventCategory", "MaxAttendees", "RegularPrice", "StartTime", "Title", "VipPrice" },
                values: new object[] { 0, "Cumque ut non architecto quidem. Qui et omnis laborum quae nulla exercitationem. Delectus et porro ea quisquam placeat et et eos.", new DateTime(2025, 5, 22, 14, 57, 40, 222, DateTimeKind.Local).AddTicks(3603), 3, 64, 567.669042020461690m, new DateTime(2025, 5, 22, 13, 32, 9, 31, DateTimeKind.Local).AddTicks(243), "Molestiae voluptatem impedit labore libero placeat.", 851.5035630306925350m });

            migrationBuilder.UpdateData(
                table: "events",
                keyColumn: "Id",
                keyValue: -5,
                columns: new[] { "CurrentAttendees", "Description", "EndTime", "EventCategory", "MaxAttendees", "RegularPrice", "StartTime", "Title", "VipPrice" },
                values: new object[] { 38, "Molestias natus ipsam sit cupiditate. Debitis suscipit quo enim provident. Autem est qui voluptatem consequatur atque nulla iure saepe. Amet cum porro ab.", new DateTime(2025, 1, 13, 6, 48, 53, 346, DateTimeKind.Local).AddTicks(5375), 3, 85, 718.425094584578140m, new DateTime(2025, 1, 13, 5, 38, 34, 370, DateTimeKind.Local).AddTicks(3128), "Unde et voluptates corrupti nam odio suscipit.", 1077.6376418768672100m });

            migrationBuilder.UpdateData(
                table: "events",
                keyColumn: "Id",
                keyValue: -4,
                columns: new[] { "CurrentAttendees", "Description", "EndTime", "MaxAttendees", "RegularPrice", "StartTime", "Title", "VipPrice" },
                values: new object[] { 11, "Culpa asperiores enim aut eum. Quos qui expedita temporibus unde vel. Magnam dolore qui iste. Repudiandae suscipit hic totam eligendi et optio qui. Praesentium soluta consequuntur.", new DateTime(2025, 3, 30, 18, 27, 8, 511, DateTimeKind.Local).AddTicks(1455), 58, 733.326269840978320m, new DateTime(2025, 3, 30, 15, 10, 33, 667, DateTimeKind.Local).AddTicks(566), "Magni qui est aut veniam.", 1099.9894047614674800m });

            migrationBuilder.UpdateData(
                table: "events",
                keyColumn: "Id",
                keyValue: -3,
                columns: new[] { "CurrentAttendees", "Description", "EndTime", "EventCategory", "MaxAttendees", "RegularPrice", "StartTime", "Title", "VipPrice" },
                values: new object[] { 10, "Rem reiciendis provident facere sint sint. Ducimus ut aliquid est aut possimus minima. Commodi possimus quidem consectetur unde cupiditate optio quisquam.", new DateTime(2024, 7, 10, 21, 5, 38, 187, DateTimeKind.Local).AddTicks(6474), 2, 83, 542.814735246434740m, new DateTime(2024, 7, 10, 19, 21, 53, 315, DateTimeKind.Local).AddTicks(3251), "Quisquam minus illo a incidunt dignissimos.", 814.2221028696521100m });

            migrationBuilder.UpdateData(
                table: "events",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "CurrentAttendees", "Description", "EndTime", "EventCategory", "MaxAttendees", "RegularPrice", "StartTime", "Title", "VipPrice" },
                values: new object[] { 44, "Quam ullam nostrum magni voluptatem atque non pariatur sunt. Quis distinctio ut qui illo quis enim ipsa magnam assumenda. Aut eaque vitae voluptatum est veritatis ipsum.", new DateTime(2024, 11, 5, 17, 47, 10, 31, DateTimeKind.Local).AddTicks(6309), 2, 75, 451.950249360120490m, new DateTime(2024, 11, 5, 14, 56, 2, 888, DateTimeKind.Local).AddTicks(6477), "Asperiores voluptatibus impedit qui impedit dicta qui non itaque.", 677.9253740401807350m });

            migrationBuilder.UpdateData(
                table: "events",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CurrentAttendees", "Description", "EndTime", "EventCategory", "MaxAttendees", "RegularPrice", "StartTime", "Title", "VipPrice" },
                values: new object[] { 6, "Praesentium illum ut dolore. Non rem earum voluptatem itaque est temporibus. Harum eligendi laboriosam qui pariatur. Eum eum dicta esse exercitationem.", new DateTime(2024, 12, 4, 20, 2, 51, 670, DateTimeKind.Local).AddTicks(2878), 4, 178, 549.094518907314040m, new DateTime(2024, 12, 4, 16, 28, 56, 861, DateTimeKind.Local).AddTicks(2773), "Et amet officiis qui qui iure ratione voluptatem.", 823.6417783609710600m });

            migrationBuilder.UpdateData(
                table: "facilities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 434, "Et quis natus et nostrum et.", "Hessel - Balistreri" });

            migrationBuilder.UpdateData(
                table: "facilities",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 256, "Et expedita eum dolor laborum a sint qui earum.", "Spinka - Weimann" });

            migrationBuilder.UpdateData(
                table: "facilities",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 254, "Ea culpa quibusdam.", "Jacobs, Osinski and Maggio" });

            migrationBuilder.UpdateData(
                table: "facilities",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 403, "Soluta aliquid consequuntur dolor.", "Mann - Weber" });

            migrationBuilder.UpdateData(
                table: "facilities",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 176, "Odit consequatur et nihil id aut.", "Walker Group" });

            migrationBuilder.UpdateData(
                table: "facilities",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 205, "Sint modi esse non necessitatibus exercitationem ut.", "Jacobi, Fahey and Lang" });

            migrationBuilder.UpdateData(
                table: "facilities",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 126, "Ea et aut laboriosam repellendus pariatur ipsa.", "Hamill and Sons" });

            migrationBuilder.UpdateData(
                table: "facilities",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 422, "Qui voluptatem voluptates aperiam optio nobis.", "Bauch - Wisozk" });

            migrationBuilder.UpdateData(
                table: "facilities",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 119, "Iusto numquam consequuntur modi deserunt praesentium.", "Frami - Bartoletti" });

            migrationBuilder.UpdateData(
                table: "facilities",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 376, "Modi nihil mollitia ullam consequuntur vitae minima explicabo.", "Abernathy - Batz" });

            migrationBuilder.UpdateData(
                table: "shifts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FromHour", "ToHour" },
                values: new object[] { new TimeSpan(0, 15, 18, 0, 0), new TimeSpan(0, 16, 57, 0, 0) });

            migrationBuilder.UpdateData(
                table: "shifts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "FromHour", "ShiftType", "ToHour" },
                values: new object[] { new TimeSpan(0, 5, 34, 0, 0), 2, new TimeSpan(0, 8, 9, 0, 0) });

            migrationBuilder.UpdateData(
                table: "shifts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "FromHour", "ToHour" },
                values: new object[] { new TimeSpan(0, 1, 10, 0, 0), new TimeSpan(0, 0, 58, 0, 0) });

            migrationBuilder.UpdateData(
                table: "shifts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "FromHour", "ShiftType", "ToHour" },
                values: new object[] { new TimeSpan(0, 0, 45, 0, 0), 1, new TimeSpan(0, 23, 12, 0, 0) });

            migrationBuilder.UpdateData(
                table: "shifts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "FromHour", "ShiftType", "ToHour" },
                values: new object[] { new TimeSpan(0, 8, 43, 0, 0), 1, new TimeSpan(0, 18, 9, 0, 0) });

            migrationBuilder.UpdateData(
                table: "shifts",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "FromHour", "ShiftType", "ToHour" },
                values: new object[] { new TimeSpan(0, 23, 58, 0, 0), 3, new TimeSpan(0, 1, 30, 0, 0) });

            migrationBuilder.UpdateData(
                table: "shifts",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "FromHour", "ShiftType", "ToHour" },
                values: new object[] { new TimeSpan(0, 3, 59, 0, 0), 2, new TimeSpan(0, 9, 46, 0, 0) });

            migrationBuilder.UpdateData(
                table: "shifts",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "FromHour", "ShiftType", "ToHour" },
                values: new object[] { new TimeSpan(0, 17, 44, 0, 0), 1, new TimeSpan(0, 16, 14, 0, 0) });

            migrationBuilder.UpdateData(
                table: "shifts",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "FromHour", "ToHour" },
                values: new object[] { new TimeSpan(0, 2, 19, 0, 0), new TimeSpan(0, 16, 11, 0, 0) });

            migrationBuilder.UpdateData(
                table: "shifts",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "FromHour", "ShiftType", "ToHour" },
                values: new object[] { new TimeSpan(0, 14, 51, 0, 0), 3, new TimeSpan(0, 12, 24, 0, 0) });
        }
    }
}
