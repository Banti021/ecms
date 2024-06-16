using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ECMS.Migrations
{
    /// <inheritdoc />
    public partial class SeedDataChanges : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "addresses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BuildingNo", "City", "Street" },
                values: new object[] { "0506", "Kutchmouth", "Wyman Camp" });

            migrationBuilder.UpdateData(
                table: "addresses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BuildingNo", "City", "Street" },
                values: new object[] { "64951", "North Clementineborough", "Dickinson Summit" });

            migrationBuilder.UpdateData(
                table: "addresses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BuildingNo", "City", "Street" },
                values: new object[] { "49793", "Eraland", "Prosacco Common" });

            migrationBuilder.UpdateData(
                table: "addresses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BuildingNo", "City", "Street" },
                values: new object[] { "27379", "Lake Lula", "Payton Burg" });

            migrationBuilder.UpdateData(
                table: "addresses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "BuildingNo", "City", "Street" },
                values: new object[] { "2239", "North Edmondmouth", "Name Plain" });

            migrationBuilder.UpdateData(
                table: "addresses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "BuildingNo", "City", "Street" },
                values: new object[] { "568", "Malachishire", "Karli Road" });

            migrationBuilder.UpdateData(
                table: "addresses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "BuildingNo", "City", "Street" },
                values: new object[] { "4487", "Hildahaven", "Mary Divide" });

            migrationBuilder.UpdateData(
                table: "addresses",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "BuildingNo", "City", "Street" },
                values: new object[] { "22183", "Port Jaidenfort", "Jacobs Alley" });

            migrationBuilder.UpdateData(
                table: "addresses",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "BuildingNo", "City", "Street" },
                values: new object[] { "389", "Treutelburgh", "Jessika Court" });

            migrationBuilder.UpdateData(
                table: "addresses",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "BuildingNo", "City", "Street" },
                values: new object[] { "177", "New Gerardo", "Schiller Unions" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 125, "Rerum recusandae provident libero nemo optio quam labore labore.", "Open-source responsive website" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Capacity", "Description", "IsAvailable", "Name" },
                values: new object[] { 174, "Omnis architecto non autem voluptatem nulla.", true, "Mandatory demand-driven encoding" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 177, "Voluptatem impedit et perspiciatis distinctio ad voluptas voluptatem.", "Realigned fresh-thinking parallelism" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 78, "Sed quas occaecati in mollitia qui.", "Synergized bifurcated interface" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 59, "Molestiae laudantium est.", "Upgradable client-server structure" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 89, "Dolor maiores perferendis beatae quia dolorum qui.", "Cloned 5th generation concept" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Capacity", "Description", "IsAvailable", "Name" },
                values: new object[] { 176, "Rerum quaerat quibusdam ex suscipit in labore aspernatur quis.", true, "Re-contextualized fresh-thinking superstructure" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 153, "Quia voluptatem et ex facilis qui assumenda.", "Ameliorated object-oriented strategy" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Capacity", "Description", "IsAvailable", "Name" },
                values: new object[] { 120, "Beatae illum modi reiciendis voluptate accusantium optio.", false, "Synergized optimal open system" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 86, "Optio aperiam cupiditate quidem rerum quos.", "Multi-channelled well-modulated collaboration" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 52, "Maiores id fuga numquam unde aut blanditiis occaecati.", "Phased tangible knowledge base" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 160, "Beatae nostrum quis optio et suscipit.", "Innovative bifurcated archive" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 170, "Et voluptas aut.", "Exclusive 24 hour synergy" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Capacity", "Description", "IsAvailable", "Name" },
                values: new object[] { 187, "Quo quam nihil.", true, "Ameliorated zero tolerance hub" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Capacity", "Description", "IsAvailable", "Name" },
                values: new object[] { 114, "Id pariatur cupiditate voluptatem nihil quisquam ipsam.", false, "Fundamental system-worthy model" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 160, "Illum ipsa quibusdam at nesciunt enim et et.", "Exclusive logistical model" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Capacity", "Description", "IsAvailable", "Name" },
                values: new object[] { 77, "Vel veritatis odit reprehenderit et autem dolores.", false, "Triple-buffered disintermediate alliance" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 174, "Qui excepturi perferendis aut ut.", "Synchronised real-time infrastructure" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 99, "Autem aut velit quos reprehenderit.", "Ameliorated asymmetric conglomeration" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 87, "Voluptates deserunt dolor qui.", "Cloned local architecture" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Capacity", "Description", "IsAvailable", "Name" },
                values: new object[] { 155, "Quos tenetur aut minima et vel unde qui rem.", false, "Expanded methodical approach" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Capacity", "Description", "IsAvailable", "Name" },
                values: new object[] { 134, "Necessitatibus ut qui.", true, "Expanded bottom-line emulation" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 149, "Ratione dolores consectetur amet ut corporis in molestiae quo necessitatibus.", "Down-sized reciprocal methodology" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Capacity", "Description", "IsAvailable", "Name" },
                values: new object[] { 165, "Et accusamus ipsa culpa corporis non molestiae.", false, "Secured static encoding" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 196, "Nostrum id ea placeat eum eius.", "Upgradable dynamic leverage" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Capacity", "Description", "IsAvailable", "Name" },
                values: new object[] { 181, "Dicta consequuntur pariatur debitis sed.", false, "Expanded reciprocal migration" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Capacity", "Description", "IsAvailable", "Name" },
                values: new object[] { 61, "Aliquam fugiat et consequatur reprehenderit.", true, "Enterprise-wide maximized matrices" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Capacity", "Description", "IsAvailable", "Name" },
                values: new object[] { 156, "Voluptatum veritatis qui odit fuga.", false, "Enterprise-wide even-keeled budgetary management" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Capacity", "Description", "IsAvailable", "Name" },
                values: new object[] { 182, "Mollitia voluptatibus aut consequatur earum unde ab enim.", true, "Customer-focused logistical monitoring" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 178, "Ipsam numquam sapiente placeat ut consequatur voluptatem earum aut alias.", "Horizontal modular installation" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 189, "Temporibus libero ipsum ratione fugiat nisi.", "Secured national emulation" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Capacity", "Description", "IsAvailable", "Name" },
                values: new object[] { 168, "Earum qui qui et aut cupiditate.", true, "Progressive bottom-line implementation" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Capacity", "Description", "IsAvailable", "Name" },
                values: new object[] { 54, "Velit ea quia.", false, "Re-engineered logistical solution" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 139, "In molestiae vel debitis cupiditate est facere vero modi error.", "Organic systematic customer loyalty" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Magnam facilis consequuntur aut provident dolorum deleniti.", "Diverse zero defect hierarchy" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 62, "Quis praesentium sint.", "Reduced motivating complexity" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 139, "Adipisci quo labore.", "Adaptive impactful firmware" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 152, "Labore distinctio voluptatem non quo tempora ad.", "Switchable modular product" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 80, "Iure iusto quo aut.", "Inverse radical interface" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Capacity", "Description", "IsAvailable", "Name" },
                values: new object[] { 194, "Perspiciatis soluta dignissimos commodi est debitis.", false, "Secured client-server internet solution" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Capacity", "Description", "IsAvailable", "Name" },
                values: new object[] { 89, "Aut reiciendis numquam necessitatibus perferendis mollitia eos modi nostrum.", false, "Managed logistical firmware" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 155, "Dolor quidem voluptatem corrupti.", "Balanced context-sensitive data-warehouse" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 98, "Eum tempora modi voluptatem.", "Focused user-facing database" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 94, "Ad illum quam sit aut quas voluptatem dicta.", "Open-architected regional initiative" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 157, "Atque hic sint rerum cupiditate distinctio.", "Up-sized clear-thinking throughput" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 152, "Qui dignissimos dignissimos molestiae tempora sunt quo et.", "Decentralized radical local area network" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 175, "Adipisci error tenetur vel accusantium at itaque.", "User-centric disintermediate database" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 152, "Expedita rem nobis omnis provident est odit.", "User-friendly coherent Graphic Interface" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 86, "Repellat at dolor.", "Enhanced client-driven groupware" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Capacity", "Description", "IsAvailable", "Name" },
                values: new object[] { 79, "Suscipit ea sit qui esse perspiciatis.", false, "Function-based methodical time-frame" });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "EmployeeCount", "Name" },
                values: new object[] { "Quis exercitationem maxime quam magnam facere.", 15, "Home" });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "EmployeeCount", "Name" },
                values: new object[] { "Totam quis distinctio repellendus dignissimos officiis deleniti sed eos.", 28, "Sports & Beauty" });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "EmployeeCount", "Name" },
                values: new object[] { "Quis quod qui corporis.", 50, "Games" });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "EmployeeCount", "Name" },
                values: new object[] { "Laboriosam quod quisquam omnis tenetur beatae qui ipsa qui eos.", 36, "Games" });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "EmployeeCount", "Name" },
                values: new object[] { "Sed doloremque sit enim modi aut.", 37, "Beauty, Electronics & Garden" });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Description", "EmployeeCount", "Name" },
                values: new object[] { "Ut fugit mollitia rerum eligendi est optio repellendus natus distinctio.", 26, "Sports & Music" });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Description", "EmployeeCount", "Name" },
                values: new object[] { "Dolor sed velit quod aut at voluptas vitae minima.", 17, "Jewelery, Electronics & Kids" });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Description", "EmployeeCount", "Name" },
                values: new object[] { "Quod cum quibusdam vitae natus fugiat in eligendi.", 21, "Toys, Health & Jewelery" });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Description", "EmployeeCount", "Name" },
                values: new object[] { "Expedita qui dolorem omnis ut voluptas quia nobis vitae eos.", 22, "Automotive" });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Description", "EmployeeCount", "Name" },
                values: new object[] { "Dolor minima itaque cupiditate rerum distinctio deleniti doloribus.", 5, "Industrial & Kids" });

            migrationBuilder.UpdateData(
                table: "events",
                keyColumn: "Id",
                keyValue: -20,
                columns: new[] { "CurrentAttendees", "Description", "EndTime", "EventCategory", "MaxAttendees", "RegularPrice", "StartTime", "Title", "VipPrice" },
                values: new object[] { 1, "Sint occaecati ut. Doloribus nisi accusantium voluptas dicta qui mollitia id voluptas mollitia. Incidunt quae non ut. Dignissimos consequatur neque perspiciatis fugit quos facilis.", new DateTime(2025, 4, 1, 22, 9, 22, 916, DateTimeKind.Local).AddTicks(2103), 5, 92, 792.254500352883910m, new DateTime(2025, 4, 1, 20, 42, 17, 998, DateTimeKind.Local).AddTicks(3972), "Assumenda qui inventore ipsum sunt.", 1188.3817505293258650m });

            migrationBuilder.UpdateData(
                table: "events",
                keyColumn: "Id",
                keyValue: -19,
                columns: new[] { "CurrentAttendees", "Description", "EndTime", "EventCategory", "MaxAttendees", "RegularPrice", "StartTime", "Title", "VipPrice" },
                values: new object[] { 2, "Ut aliquid id sunt quasi quis qui repellat ea. Perspiciatis aut voluptatem quo nihil unde totam reprehenderit. Quaerat sunt et a. Iure nihil vel. Consequuntur temporibus et at natus deserunt ut.", new DateTime(2024, 8, 20, 18, 31, 8, 532, DateTimeKind.Local).AddTicks(9381), 1, 174, 583.040559032258680m, new DateTime(2024, 8, 20, 17, 9, 29, 801, DateTimeKind.Local).AddTicks(2713), "Ab consequatur hic in nihil.", 874.5608385483880200m });

            migrationBuilder.UpdateData(
                table: "events",
                keyColumn: "Id",
                keyValue: -18,
                columns: new[] { "CurrentAttendees", "Description", "EndTime", "EventCategory", "MaxAttendees", "RegularPrice", "StartTime", "Title", "VipPrice" },
                values: new object[] { 36, "Sint nam cupiditate eveniet quis magnam quia et magnam. Aliquid libero rerum. Voluptatem nam sint soluta est voluptas ea nobis iure eius. Recusandae cupiditate unde tempore temporibus fugit est alias omnis facere.", new DateTime(2024, 8, 27, 2, 57, 5, 284, DateTimeKind.Local).AddTicks(7455), 6, 127, 414.194411060764390m, new DateTime(2024, 8, 26, 23, 2, 40, 661, DateTimeKind.Local).AddTicks(3134), "Voluptatem sunt aliquid itaque eligendi sit.", 621.2916165911465850m });

            migrationBuilder.UpdateData(
                table: "events",
                keyColumn: "Id",
                keyValue: -17,
                columns: new[] { "CurrentAttendees", "Description", "EndTime", "EventCategory", "MaxAttendees", "RegularPrice", "StartTime", "Title", "VipPrice" },
                values: new object[] { 43, "Corporis earum in. Sit dolor quia atque est sunt accusamus. Cumque dolore qui laboriosam sit laboriosam cum quae odio dolores.", new DateTime(2025, 4, 24, 7, 46, 22, 167, DateTimeKind.Local).AddTicks(4794), 3, 180, 965.891917479254140m, new DateTime(2025, 4, 24, 4, 38, 56, 984, DateTimeKind.Local).AddTicks(1895), "Iure totam libero aliquam corporis.", 1448.8378762188812100m });

            migrationBuilder.UpdateData(
                table: "events",
                keyColumn: "Id",
                keyValue: -16,
                columns: new[] { "CurrentAttendees", "Description", "EndTime", "EventCategory", "MaxAttendees", "RegularPrice", "StartTime", "Title", "VipPrice" },
                values: new object[] { 50, "Aut iste voluptas autem labore. Adipisci aut inventore aut ipsam. Et nisi animi quibusdam maiores ipsa optio aut minima quaerat. Et vero culpa placeat voluptas veniam animi. Et fugit id consequatur odit perspiciatis. Alias et unde voluptas.", new DateTime(2024, 9, 17, 3, 48, 33, 143, DateTimeKind.Local).AddTicks(6308), 6, 62, 383.231190804112630m, new DateTime(2024, 9, 17, 2, 31, 34, 580, DateTimeKind.Local).AddTicks(4887), "Eius omnis voluptate minima consequatur aut accusantium qui.", 574.8467862061689450m });

            migrationBuilder.UpdateData(
                table: "events",
                keyColumn: "Id",
                keyValue: -15,
                columns: new[] { "CurrentAttendees", "Description", "EndTime", "EventCategory", "MaxAttendees", "RegularPrice", "StartTime", "Title", "VipPrice" },
                values: new object[] { 43, "Ratione ullam pariatur. Vero dolore numquam quod consectetur molestiae odio iure nemo repellendus. In omnis vero perspiciatis et placeat consequatur. Non rerum beatae eius aspernatur assumenda aliquam id reiciendis.", new DateTime(2024, 7, 8, 21, 46, 37, 330, DateTimeKind.Local).AddTicks(3616), 5, 165, 203.49309094283080m, new DateTime(2024, 7, 8, 18, 34, 50, 572, DateTimeKind.Local).AddTicks(4575), "Dolorem laborum numquam aut repellendus autem voluptatibus vel modi voluptates.", 305.239636414246200m });

            migrationBuilder.UpdateData(
                table: "events",
                keyColumn: "Id",
                keyValue: -14,
                columns: new[] { "CurrentAttendees", "Description", "EndTime", "MaxAttendees", "RegularPrice", "StartTime", "Title", "VipPrice" },
                values: new object[] { 17, "Asperiores non ratione culpa eos recusandae odit excepturi ea. Placeat occaecati et eius incidunt fugit est quaerat cupiditate et. Rerum consequatur sed soluta ea dicta ad repellendus et. Aut rerum sapiente.", new DateTime(2025, 6, 15, 23, 34, 43, 135, DateTimeKind.Local).AddTicks(9676), 72, 330.634516141367560m, new DateTime(2025, 6, 15, 19, 46, 39, 440, DateTimeKind.Local).AddTicks(9725), "Quo iste alias quis.", 495.9517742120513400m });

            migrationBuilder.UpdateData(
                table: "events",
                keyColumn: "Id",
                keyValue: -13,
                columns: new[] { "CurrentAttendees", "Description", "EndTime", "MaxAttendees", "RegularPrice", "StartTime", "Title", "VipPrice" },
                values: new object[] { 50, "Voluptatum voluptatum et harum. Qui magnam animi hic sunt qui est sunt aut. Error quo at omnis error nesciunt dolor.", new DateTime(2025, 1, 17, 18, 10, 29, 512, DateTimeKind.Local).AddTicks(5536), 116, 921.21436767241540m, new DateTime(2025, 1, 17, 16, 8, 38, 581, DateTimeKind.Local).AddTicks(1143), "Recusandae rerum dolore maiores nostrum animi occaecati dolores.", 1381.821551508623100m });

            migrationBuilder.UpdateData(
                table: "events",
                keyColumn: "Id",
                keyValue: -12,
                columns: new[] { "CurrentAttendees", "Description", "EndTime", "MaxAttendees", "RegularPrice", "StartTime", "Title", "VipPrice" },
                values: new object[] { 40, "Quis eveniet voluptate velit est. Rem autem rem dolore. Doloremque rem quos sed sint ipsum et ducimus est.", new DateTime(2025, 5, 6, 1, 33, 13, 552, DateTimeKind.Local).AddTicks(258), 167, 158.75082722481850m, new DateTime(2025, 5, 5, 22, 39, 7, 262, DateTimeKind.Local).AddTicks(4680), "Eligendi et aliquam quia.", 238.126240837227750m });

            migrationBuilder.UpdateData(
                table: "events",
                keyColumn: "Id",
                keyValue: -11,
                columns: new[] { "CurrentAttendees", "Description", "EndTime", "EventCategory", "MaxAttendees", "RegularPrice", "StartTime", "Title", "VipPrice" },
                values: new object[] { 43, "Incidunt quo voluptas veritatis beatae aut. Et adipisci id natus qui eum aperiam ut quia labore. Aut eveniet quasi quo nisi error omnis quos alias. Natus non praesentium est ut. Voluptas veniam incidunt cum perspiciatis et ut voluptatem alias corporis.", new DateTime(2025, 5, 30, 16, 56, 27, 990, DateTimeKind.Local).AddTicks(5025), 2, 142, 67.7194476192150850m, new DateTime(2025, 5, 30, 14, 11, 17, 370, DateTimeKind.Local).AddTicks(816), "Officiis blanditiis quo eos voluptatum facilis.", 101.57917142882262750m });

            migrationBuilder.UpdateData(
                table: "events",
                keyColumn: "Id",
                keyValue: -10,
                columns: new[] { "CurrentAttendees", "Description", "EndTime", "EventCategory", "MaxAttendees", "RegularPrice", "StartTime", "Title", "VipPrice" },
                values: new object[] { 36, "Aut mollitia aut culpa voluptas aut rerum voluptate. Omnis aliquid maxime. Qui in sed cupiditate ea. Dicta et rerum similique quo.", new DateTime(2025, 3, 30, 16, 36, 36, 104, DateTimeKind.Local).AddTicks(3255), 1, 117, 973.393709498769340m, new DateTime(2025, 3, 30, 15, 29, 25, 176, DateTimeKind.Local).AddTicks(9047), "Omnis ducimus nihil velit voluptas voluptates aut eos non officiis.", 1460.0905642481540100m });

            migrationBuilder.UpdateData(
                table: "events",
                keyColumn: "Id",
                keyValue: -9,
                columns: new[] { "CurrentAttendees", "Description", "EndTime", "EventCategory", "MaxAttendees", "RegularPrice", "StartTime", "Title", "VipPrice" },
                values: new object[] { 35, "Dolor aperiam id quis quidem distinctio possimus beatae libero unde. Ipsa sequi impedit illo quia fuga expedita. Soluta ut ullam perferendis accusantium modi. Reprehenderit enim accusamus. Ut qui consequuntur nemo accusamus. Iste distinctio molestiae offi", new DateTime(2024, 11, 10, 8, 28, 12, 412, DateTimeKind.Local).AddTicks(684), 5, 189, 310.486063855865140m, new DateTime(2024, 11, 10, 6, 35, 35, 908, DateTimeKind.Local).AddTicks(4400), "Natus et suscipit blanditiis qui placeat placeat molestiae dolor.", 465.7290957837977100m });

            migrationBuilder.UpdateData(
                table: "events",
                keyColumn: "Id",
                keyValue: -8,
                columns: new[] { "CurrentAttendees", "Description", "EndTime", "EventCategory", "MaxAttendees", "RegularPrice", "StartTime", "Title", "VipPrice" },
                values: new object[] { 30, "Exercitationem nesciunt itaque accusamus ratione magni minus id maiores. Enim officiis dolores quo fugit qui explicabo animi sint saepe. Corporis consequatur quis illum est quia sit qui harum.", new DateTime(2024, 12, 22, 4, 24, 13, 787, DateTimeKind.Local).AddTicks(7782), 1, 100, 954.92050483267360m, new DateTime(2024, 12, 22, 3, 14, 34, 49, DateTimeKind.Local).AddTicks(5224), "Dolor qui ipsa laborum est voluptatibus saepe et dolorum ipsa.", 1432.380757249010400m });

            migrationBuilder.UpdateData(
                table: "events",
                keyColumn: "Id",
                keyValue: -7,
                columns: new[] { "CurrentAttendees", "Description", "EndTime", "EventCategory", "MaxAttendees", "RegularPrice", "StartTime", "Title", "VipPrice" },
                values: new object[] { 4, "Asperiores voluptas et quae eum. Amet atque id quisquam iusto repellendus accusantium in. Porro voluptates dignissimos aliquid cupiditate saepe.", new DateTime(2025, 5, 11, 1, 55, 34, 213, DateTimeKind.Local).AddTicks(3835), 4, 143, 108.4971557818964980m, new DateTime(2025, 5, 10, 22, 16, 50, 398, DateTimeKind.Local).AddTicks(8239), "Fuga necessitatibus natus porro cum.", 162.74573367284474700m });

            migrationBuilder.UpdateData(
                table: "events",
                keyColumn: "Id",
                keyValue: -6,
                columns: new[] { "CurrentAttendees", "Description", "EndTime", "EventCategory", "MaxAttendees", "RegularPrice", "StartTime", "Title", "VipPrice" },
                values: new object[] { 30, "Corrupti velit maxime deserunt cupiditate rem illo. Exercitationem alias rem sit aut. Necessitatibus beatae sint doloremque.", new DateTime(2025, 6, 5, 3, 28, 48, 520, DateTimeKind.Local).AddTicks(8323), 5, 200, 175.049465619820870m, new DateTime(2025, 6, 5, 0, 4, 54, 742, DateTimeKind.Local).AddTicks(1415), "Dignissimos sit repellendus qui aspernatur aut pariatur quae.", 262.5741984297313050m });

            migrationBuilder.UpdateData(
                table: "events",
                keyColumn: "Id",
                keyValue: -5,
                columns: new[] { "CurrentAttendees", "Description", "EndTime", "EventCategory", "MaxAttendees", "RegularPrice", "StartTime", "Title", "VipPrice" },
                values: new object[] { 14, "Sit et reiciendis voluptatem reiciendis placeat voluptatem est. Delectus magni voluptas iusto maiores molestiae possimus et. Occaecati rerum odio voluptatem qui ad autem.", new DateTime(2025, 1, 20, 7, 3, 25, 747, DateTimeKind.Local).AddTicks(1718), 3, 188, 195.837598584716320m, new DateTime(2025, 1, 20, 5, 18, 26, 347, DateTimeKind.Local).AddTicks(5339), "Sunt blanditiis quam ullam id itaque autem et quaerat.", 293.7563978770744800m });

            migrationBuilder.UpdateData(
                table: "events",
                keyColumn: "Id",
                keyValue: -4,
                columns: new[] { "CurrentAttendees", "Description", "EndTime", "EventCategory", "MaxAttendees", "RegularPrice", "StartTime", "Title", "VipPrice" },
                values: new object[] { 4, "Et doloribus ea quia qui autem error autem accusamus doloremque. Ut minus quas reiciendis deleniti consequatur. Deleniti modi dolorum.", new DateTime(2024, 10, 21, 18, 33, 27, 459, DateTimeKind.Local).AddTicks(2992), 2, 136, 572.197759967821780m, new DateTime(2024, 10, 21, 16, 21, 22, 962, DateTimeKind.Local).AddTicks(4731), "Ullam aut ipsam voluptatem.", 858.2966399517326700m });

            migrationBuilder.UpdateData(
                table: "events",
                keyColumn: "Id",
                keyValue: -3,
                columns: new[] { "CurrentAttendees", "Description", "EndTime", "EventCategory", "MaxAttendees", "RegularPrice", "StartTime", "Title", "VipPrice" },
                values: new object[] { 43, "Iste ratione consequuntur tempore. Vel excepturi cumque ut. Aut omnis dolores omnis deleniti quae aut fuga mollitia.", new DateTime(2024, 6, 21, 8, 9, 50, 558, DateTimeKind.Local).AddTicks(4221), 2, 155, 583.378728727307140m, new DateTime(2024, 6, 21, 6, 32, 13, 423, DateTimeKind.Local).AddTicks(4671), "Dolores earum delectus.", 875.0680930909607100m });

            migrationBuilder.UpdateData(
                table: "events",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "CurrentAttendees", "Description", "EndTime", "EventCategory", "MaxAttendees", "RegularPrice", "StartTime", "Title", "VipPrice" },
                values: new object[] { 40, "Ipsa illo consequatur sed voluptatem aliquam vel recusandae impedit. Rem qui aut ullam sed repudiandae doloremque fugiat autem placeat. Repudiandae dolor dolor itaque sit occaecati neque. Ullam nam ut voluptatem quasi reprehenderit et quia ducimus quia.", new DateTime(2025, 2, 21, 2, 34, 58, 41, DateTimeKind.Local).AddTicks(1447), 5, 136, 545.643409367642950m, new DateTime(2025, 2, 21, 0, 35, 51, 17, DateTimeKind.Local).AddTicks(4835), "Mollitia cupiditate inventore.", 818.4651140514644250m });

            migrationBuilder.UpdateData(
                table: "events",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "Description", "EndTime", "EventCategory", "MaxAttendees", "RegularPrice", "StartTime", "Title", "VipPrice" },
                values: new object[] { "Illo autem sit rem provident sunt porro et sed expedita. Voluptatem facere modi quae modi ullam veniam est aut. Quidem vel eaque tempora voluptatem voluptatem. Ut ab voluptas et et dolorem aut quia asperiores.", new DateTime(2024, 7, 13, 16, 13, 57, 240, DateTimeKind.Local).AddTicks(4758), 1, 129, 142.581476255770630m, new DateTime(2024, 7, 13, 12, 44, 5, 443, DateTimeKind.Local).AddTicks(3099), "Consequuntur quis eum nihil quis.", 213.8722143836559450m });

            migrationBuilder.UpdateData(
                table: "facilities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 340, "Qui nostrum dolorem soluta voluptatibus sint commodi porro accusantium.", "Zulauf, Fritsch and Johnson" });

            migrationBuilder.UpdateData(
                table: "facilities",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 302, "Perferendis ea velit.", "Rath Group" });

            migrationBuilder.UpdateData(
                table: "facilities",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 360, "Et consequatur est consequuntur sint.", "Schuster, Koss and Renner" });

            migrationBuilder.UpdateData(
                table: "facilities",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 426, "Hic eum ut dolor est suscipit quas.", "Schoen, Medhurst and Bernier" });

            migrationBuilder.UpdateData(
                table: "facilities",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 211, "Corporis nulla vel.", "Kling Group" });

            migrationBuilder.UpdateData(
                table: "facilities",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 152, "Aut non et provident ab architecto.", "Toy Group" });

            migrationBuilder.UpdateData(
                table: "facilities",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 184, "Veniam mollitia veniam quis distinctio omnis iure distinctio.", "Kuvalis Group" });

            migrationBuilder.UpdateData(
                table: "facilities",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 308, "Eaque assumenda eveniet nemo natus tempora praesentium.", "Crist LLC" });

            migrationBuilder.UpdateData(
                table: "facilities",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 412, "Rerum fuga officia animi eius et nam optio.", "Mitchell LLC" });

            migrationBuilder.UpdateData(
                table: "facilities",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 188, "Eveniet placeat exercitationem tenetur neque omnis ut.", "Koelpin Inc" });

            migrationBuilder.UpdateData(
                table: "shifts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FromHour", "ToHour" },
                values: new object[] { new DateTime(2023, 12, 9, 2, 3, 54, 479, DateTimeKind.Local).AddTicks(4080), new DateTime(2025, 5, 3, 11, 29, 30, 278, DateTimeKind.Local).AddTicks(7605) });

            migrationBuilder.UpdateData(
                table: "shifts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "FromHour", "ShiftType", "ToHour" },
                values: new object[] { new DateTime(2024, 1, 29, 12, 31, 42, 520, DateTimeKind.Local).AddTicks(6838), 1, new DateTime(2024, 11, 16, 12, 7, 42, 519, DateTimeKind.Local).AddTicks(440) });

            migrationBuilder.UpdateData(
                table: "shifts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "FromHour", "ToHour" },
                values: new object[] { new DateTime(2024, 1, 16, 12, 6, 52, 485, DateTimeKind.Local).AddTicks(1448), new DateTime(2024, 8, 29, 23, 34, 23, 498, DateTimeKind.Local).AddTicks(9119) });

            migrationBuilder.UpdateData(
                table: "shifts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "FromHour", "ShiftType", "ToHour" },
                values: new object[] { new DateTime(2023, 9, 19, 0, 45, 35, 700, DateTimeKind.Local).AddTicks(9902), 1, new DateTime(2024, 12, 9, 7, 17, 44, 694, DateTimeKind.Local).AddTicks(7039) });

            migrationBuilder.UpdateData(
                table: "shifts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "FromHour", "ShiftType", "ToHour" },
                values: new object[] { new DateTime(2024, 5, 19, 3, 8, 59, 147, DateTimeKind.Local).AddTicks(8362), 2, new DateTime(2024, 7, 21, 4, 59, 43, 660, DateTimeKind.Local).AddTicks(8696) });

            migrationBuilder.UpdateData(
                table: "shifts",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "FromHour", "ToHour" },
                values: new object[] { new DateTime(2024, 5, 13, 8, 28, 58, 334, DateTimeKind.Local).AddTicks(9345), new DateTime(2025, 4, 6, 11, 7, 13, 49, DateTimeKind.Local).AddTicks(4428) });

            migrationBuilder.UpdateData(
                table: "shifts",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "FromHour", "ShiftType", "ToHour" },
                values: new object[] { new DateTime(2023, 10, 28, 7, 43, 19, 864, DateTimeKind.Local).AddTicks(8880), 3, new DateTime(2024, 9, 4, 10, 26, 47, 873, DateTimeKind.Local).AddTicks(9306) });

            migrationBuilder.UpdateData(
                table: "shifts",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "FromHour", "ShiftType", "ToHour" },
                values: new object[] { new DateTime(2024, 2, 3, 14, 4, 50, 270, DateTimeKind.Local).AddTicks(3910), 1, new DateTime(2025, 5, 18, 0, 47, 49, 769, DateTimeKind.Local).AddTicks(9511) });

            migrationBuilder.UpdateData(
                table: "shifts",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "FromHour", "ShiftType", "ToHour" },
                values: new object[] { new DateTime(2023, 7, 3, 23, 11, 37, 787, DateTimeKind.Local).AddTicks(2185), 1, new DateTime(2025, 6, 7, 21, 40, 35, 364, DateTimeKind.Local).AddTicks(3375) });

            migrationBuilder.UpdateData(
                table: "shifts",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "FromHour", "ShiftType", "ToHour" },
                values: new object[] { new DateTime(2024, 3, 26, 0, 18, 11, 416, DateTimeKind.Local).AddTicks(2018), 2, new DateTime(2025, 5, 3, 21, 13, 15, 739, DateTimeKind.Local).AddTicks(5156) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "addresses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BuildingNo", "City", "Street" },
                values: new object[] { "9571", "Bellatown", "Gracie Mountains" });

            migrationBuilder.UpdateData(
                table: "addresses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BuildingNo", "City", "Street" },
                values: new object[] { "51204", "West Evalynview", "Leonard Lakes" });

            migrationBuilder.UpdateData(
                table: "addresses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BuildingNo", "City", "Street" },
                values: new object[] { "375", "East Kristian", "Carter Mountain" });

            migrationBuilder.UpdateData(
                table: "addresses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BuildingNo", "City", "Street" },
                values: new object[] { "841", "Port Eliaschester", "Marks Radial" });

            migrationBuilder.UpdateData(
                table: "addresses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "BuildingNo", "City", "Street" },
                values: new object[] { "442", "Stiedemannside", "Grant Harbor" });

            migrationBuilder.UpdateData(
                table: "addresses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "BuildingNo", "City", "Street" },
                values: new object[] { "7797", "Armstrongmouth", "Hane Hills" });

            migrationBuilder.UpdateData(
                table: "addresses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "BuildingNo", "City", "Street" },
                values: new object[] { "6022", "Felicitabury", "Smitham Tunnel" });

            migrationBuilder.UpdateData(
                table: "addresses",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "BuildingNo", "City", "Street" },
                values: new object[] { "19605", "New Polly", "Torphy Bridge" });

            migrationBuilder.UpdateData(
                table: "addresses",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "BuildingNo", "City", "Street" },
                values: new object[] { "25523", "East Geovany", "Hills Garden" });

            migrationBuilder.UpdateData(
                table: "addresses",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "BuildingNo", "City", "Street" },
                values: new object[] { "19007", "Eldredhaven", "Natalie Via" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 106, "Rem cum quod velit.", "Multi-channelled transitional toolset" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Capacity", "Description", "IsAvailable", "Name" },
                values: new object[] { 121, "Velit fugit maxime ad atque minima numquam ducimus hic sunt.", false, "Public-key hybrid architecture" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 58, "Quo laudantium necessitatibus qui voluptatem dolores.", "User-centric national benchmark" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 92, "Labore accusamus et fugit.", "User-centric 24/7 complexity" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 178, "Voluptates temporibus maxime quidem adipisci minima repellendus odio pariatur excepturi.", "Self-enabling optimal ability" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 55, "Ea blanditiis est rem cum magni.", "Ameliorated cohesive neural-net" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Capacity", "Description", "IsAvailable", "Name" },
                values: new object[] { 91, "Tenetur nulla modi et et mollitia sit pariatur voluptatem.", false, "Grass-roots bifurcated alliance" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 63, "Beatae rerum est error et dolorum.", "Synchronised motivating internet solution" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Capacity", "Description", "IsAvailable", "Name" },
                values: new object[] { 165, "Nesciunt numquam sunt et quae voluptatem rerum est eius rerum.", true, "Devolved hybrid array" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 72, "Rem eum autem veniam excepturi sapiente porro et nobis.", "Streamlined local migration" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 66, "Reprehenderit asperiores quo sit voluptatem.", "Compatible system-worthy groupware" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 76, "Facilis qui totam possimus corporis nihil assumenda voluptas.", "Function-based maximized capability" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 152, "Nihil ducimus sed animi consequatur est repellendus sit.", "Visionary exuding analyzer" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Capacity", "Description", "IsAvailable", "Name" },
                values: new object[] { 194, "Est qui reprehenderit reiciendis officiis.", false, "Robust regional website" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Capacity", "Description", "IsAvailable", "Name" },
                values: new object[] { 162, "Vero voluptatem saepe incidunt deserunt quas molestiae totam tenetur voluptatem.", true, "User-centric bottom-line pricing structure" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 172, "Expedita voluptatem aut exercitationem expedita enim iusto.", "Assimilated maximized intranet" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Capacity", "Description", "IsAvailable", "Name" },
                values: new object[] { 92, "Quae dolorum quia.", true, "Operative value-added model" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 155, "Ab cum voluptas quo eveniet laudantium.", "Digitized bifurcated synergy" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 157, "Eveniet molestias quia provident ipsum.", "Realigned 24 hour model" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 165, "Molestiae eum ea quo illum placeat.", "Up-sized intangible infrastructure" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Capacity", "Description", "IsAvailable", "Name" },
                values: new object[] { 171, "Modi aliquid quo molestiae rem quasi ut consequatur exercitationem.", true, "Self-enabling transitional paradigm" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Capacity", "Description", "IsAvailable", "Name" },
                values: new object[] { 182, "Nihil optio iusto illum qui.", false, "Advanced didactic access" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 199, "Impedit quia exercitationem porro maiores.", "Business-focused zero administration collaboration" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Capacity", "Description", "IsAvailable", "Name" },
                values: new object[] { 102, "Id vel nam eum rerum id.", true, "Managed solution-oriented support" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 86, "Molestiae omnis voluptate veritatis nihil fuga commodi minus quis.", "Business-focused mission-critical secured line" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Capacity", "Description", "IsAvailable", "Name" },
                values: new object[] { 103, "Earum fugiat necessitatibus labore suscipit adipisci.", true, "Distributed demand-driven help-desk" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Capacity", "Description", "IsAvailable", "Name" },
                values: new object[] { 75, "Earum pariatur maiores magni accusamus impedit qui harum placeat.", false, "Reduced responsive open system" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Capacity", "Description", "IsAvailable", "Name" },
                values: new object[] { 67, "Expedita quam eum perferendis aut ipsa esse qui enim saepe.", true, "Visionary stable orchestration" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Capacity", "Description", "IsAvailable", "Name" },
                values: new object[] { 188, "Aut neque dolorem autem cum sit.", false, "Optional 24 hour interface" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 177, "Pariatur voluptas corporis repellat consequatur neque aliquid accusantium molestiae.", "Programmable executive matrices" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 198, "Accusantium optio tenetur vero rerum placeat fugit officiis.", "Decentralized high-level productivity" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Capacity", "Description", "IsAvailable", "Name" },
                values: new object[] { 109, "Ut ex est.", false, "User-centric interactive access" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Capacity", "Description", "IsAvailable", "Name" },
                values: new object[] { 194, "Enim vitae iusto tempore praesentium aut.", true, "Proactive asymmetric archive" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 182, "Quibusdam atque est iste ullam autem et architecto quis.", "Managed web-enabled customer loyalty" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Explicabo inventore eos officiis tempora repellendus ipsum eum.", "Team-oriented even-keeled matrices" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 195, "Ut voluptatem distinctio aliquam quas.", "Proactive didactic synergy" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 94, "Delectus quas asperiores qui eos sit ratione.", "Organized local forecast" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 86, "Dicta sint magnam molestiae.", "Multi-channelled systemic support" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 102, "Quod reiciendis qui et dolor nihil facere.", "Cross-platform holistic parallelism" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Capacity", "Description", "IsAvailable", "Name" },
                values: new object[] { 157, "Deserunt impedit ipsa.", true, "Compatible intermediate definition" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Capacity", "Description", "IsAvailable", "Name" },
                values: new object[] { 88, "Perspiciatis neque quo aut aliquam.", true, "Multi-tiered disintermediate parallelism" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 81, "Nemo sed doloremque voluptas magnam temporibus tempore nobis ducimus corporis.", "Cross-platform executive benchmark" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 178, "Voluptatem expedita est quos possimus magnam at repellendus ut molestias.", "Monitored heuristic database" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 176, "Possimus cumque odit repellat non.", "De-engineered asynchronous leverage" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 51, "Ab dolorum sit aut.", "Monitored even-keeled capacity" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 151, "Dignissimos officiis sit alias et earum voluptates voluptas quibusdam quis.", "Triple-buffered directional data-warehouse" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 196, "Sunt dolor ut fugit aut magnam itaque quibusdam sequi non.", "Digitized optimal moderator" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 81, "Aspernatur vero eos autem quasi deserunt in eveniet mollitia.", "Mandatory asynchronous parallelism" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 172, "Aut libero nostrum ut delectus ipsa quia architecto quis.", "Triple-buffered zero administration implementation" });

            migrationBuilder.UpdateData(
                table: "areas",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Capacity", "Description", "IsAvailable", "Name" },
                values: new object[] { 182, "Illum molestiae non quia maxime et et quia.", true, "Future-proofed leading edge infrastructure" });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "EmployeeCount", "Name" },
                values: new object[] { "Error cumque in dolores dicta.", 16, "Baby & Clothing" });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "EmployeeCount", "Name" },
                values: new object[] { "Vel iusto illo ipsa ut.", 40, "Sports" });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "EmployeeCount", "Name" },
                values: new object[] { "Quo tempore nam sit mollitia facere ipsum sed.", 38, "Books & Sports" });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "EmployeeCount", "Name" },
                values: new object[] { "Deserunt dolor similique culpa fuga eos sit laboriosam quo.", 38, "Clothing, Health & Outdoors" });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "EmployeeCount", "Name" },
                values: new object[] { "Tenetur rerum incidunt et vel labore fugit.", 18, "Tools, Health & Shoes" });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Description", "EmployeeCount", "Name" },
                values: new object[] { "Sapiente dolorum iure molestiae quaerat.", 48, "Garden & Kids" });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Description", "EmployeeCount", "Name" },
                values: new object[] { "Tempore facilis quia perferendis facere dolor qui sequi.", 29, "Beauty & Health" });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Description", "EmployeeCount", "Name" },
                values: new object[] { "Nisi quasi eaque quae beatae.", 23, "Outdoors & Home" });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Description", "EmployeeCount", "Name" },
                values: new object[] { "Quos laboriosam ipsum molestias accusantium qui cum vero sapiente.", 27, "Music" });

            migrationBuilder.UpdateData(
                table: "departments",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Description", "EmployeeCount", "Name" },
                values: new object[] { "Earum quia delectus magni quo reprehenderit esse ullam.", 33, "Toys" });

            migrationBuilder.UpdateData(
                table: "events",
                keyColumn: "Id",
                keyValue: -20,
                columns: new[] { "CurrentAttendees", "Description", "EndTime", "EventCategory", "MaxAttendees", "RegularPrice", "StartTime", "Title", "VipPrice" },
                values: new object[] { 50, "Voluptatem quisquam quidem atque et ex eaque temporibus. Occaecati blanditiis quod illum enim rem aliquid amet sed. Ut eius impedit quos nihil repellendus quia suscipit. Explicabo et esse non a nihil. Doloribus qui velit enim amet libero. Deserunt quos sed modi.", new DateTime(2025, 2, 14, 1, 1, 25, 665, DateTimeKind.Local).AddTicks(4175), 3, 87, 116.275147556421250m, new DateTime(2025, 2, 13, 21, 29, 25, 0, DateTimeKind.Local).AddTicks(2143), "Non dicta fugit molestias.", 174.4127213346318750m });

            migrationBuilder.UpdateData(
                table: "events",
                keyColumn: "Id",
                keyValue: -19,
                columns: new[] { "CurrentAttendees", "Description", "EndTime", "EventCategory", "MaxAttendees", "RegularPrice", "StartTime", "Title", "VipPrice" },
                values: new object[] { 44, "Consequatur minima maxime voluptas eum praesentium fugiat qui. Voluptate eligendi ipsum ut et. Autem eveniet eveniet quo maiores. Dolores consequatur molestias maiores et fugiat aut ex ad. Aliquam laboriosam praesentium odio natus deleniti tenetur repudiandae.", new DateTime(2024, 9, 15, 15, 40, 0, 180, DateTimeKind.Local).AddTicks(7928), 5, 163, 645.759515777106160m, new DateTime(2024, 9, 15, 13, 5, 12, 751, DateTimeKind.Local).AddTicks(2857), "Qui aut explicabo tempora.", 968.6392736656592400m });

            migrationBuilder.UpdateData(
                table: "events",
                keyColumn: "Id",
                keyValue: -18,
                columns: new[] { "CurrentAttendees", "Description", "EndTime", "EventCategory", "MaxAttendees", "RegularPrice", "StartTime", "Title", "VipPrice" },
                values: new object[] { 0, "Quasi pariatur itaque est. Ut quisquam recusandae quia quia non nemo. Nostrum culpa cupiditate saepe ut perferendis aut. Ut ut enim sint illum.", new DateTime(2025, 2, 5, 2, 10, 18, 402, DateTimeKind.Local).AddTicks(1099), 3, 123, 412.796695379967460m, new DateTime(2025, 2, 5, 1, 3, 37, 779, DateTimeKind.Local).AddTicks(2889), "Et odit officia sunt atque tempora sint eos rerum vel.", 619.1950430699511900m });

            migrationBuilder.UpdateData(
                table: "events",
                keyColumn: "Id",
                keyValue: -17,
                columns: new[] { "CurrentAttendees", "Description", "EndTime", "EventCategory", "MaxAttendees", "RegularPrice", "StartTime", "Title", "VipPrice" },
                values: new object[] { 40, "Qui sint reiciendis non minus ratione deserunt rerum. Sit eos blanditiis. Hic maiores quos iste facilis fugit cupiditate sapiente.", new DateTime(2024, 7, 17, 22, 29, 48, 740, DateTimeKind.Local).AddTicks(8190), 1, 107, 891.304920255897280m, new DateTime(2024, 7, 17, 18, 49, 35, 702, DateTimeKind.Local).AddTicks(9653), "Possimus ut ad aut accusamus aperiam odit praesentium asperiores.", 1336.9573803838459200m });

            migrationBuilder.UpdateData(
                table: "events",
                keyColumn: "Id",
                keyValue: -16,
                columns: new[] { "CurrentAttendees", "Description", "EndTime", "EventCategory", "MaxAttendees", "RegularPrice", "StartTime", "Title", "VipPrice" },
                values: new object[] { 2, "Adipisci sed ea ullam esse molestiae maiores. Qui ex rerum. Modi minus repellat ratione. Ab ullam et non nisi voluptatem. Cupiditate provident rem omnis sapiente recusandae. Iusto numquam natus deleniti.", new DateTime(2025, 5, 2, 18, 5, 49, 937, DateTimeKind.Local).AddTicks(6946), 1, 184, 849.137103054871390m, new DateTime(2025, 5, 2, 15, 55, 25, 675, DateTimeKind.Local).AddTicks(3506), "Iure asperiores expedita.", 1273.7056545823070850m });

            migrationBuilder.UpdateData(
                table: "events",
                keyColumn: "Id",
                keyValue: -15,
                columns: new[] { "CurrentAttendees", "Description", "EndTime", "EventCategory", "MaxAttendees", "RegularPrice", "StartTime", "Title", "VipPrice" },
                values: new object[] { 27, "Dicta ut expedita id et. Omnis eum est. Sed atque quia. Tempora ab et consequatur dolorem quaerat sit. Dolorem nemo nihil.", new DateTime(2025, 1, 20, 13, 52, 14, 865, DateTimeKind.Local).AddTicks(7183), 3, 173, 722.93970513017890m, new DateTime(2025, 1, 20, 11, 33, 50, 264, DateTimeKind.Local).AddTicks(5878), "Aut repellendus corrupti ut debitis placeat voluptatem sunt.", 1084.409557695268350m });

            migrationBuilder.UpdateData(
                table: "events",
                keyColumn: "Id",
                keyValue: -14,
                columns: new[] { "CurrentAttendees", "Description", "EndTime", "MaxAttendees", "RegularPrice", "StartTime", "Title", "VipPrice" },
                values: new object[] { 49, "Ut delectus at ut officia. Voluptatum magnam distinctio id est dolor. Aspernatur esse modi quas. Et itaque neque cumque facilis facilis. Sit vitae quis aliquam debitis sit debitis odit minus itaque.", new DateTime(2024, 6, 16, 16, 7, 43, 751, DateTimeKind.Local).AddTicks(4509), 97, 955.686150508870540m, new DateTime(2024, 6, 16, 14, 41, 53, 261, DateTimeKind.Local).AddTicks(4153), "Fugiat et id.", 1433.5292257633058100m });

            migrationBuilder.UpdateData(
                table: "events",
                keyColumn: "Id",
                keyValue: -13,
                columns: new[] { "CurrentAttendees", "Description", "EndTime", "MaxAttendees", "RegularPrice", "StartTime", "Title", "VipPrice" },
                values: new object[] { 39, "Repellat expedita maiores est. Non unde ipsum non. Possimus ratione qui rerum. Aut officiis laudantium.", new DateTime(2025, 6, 11, 10, 18, 49, 602, DateTimeKind.Local).AddTicks(9247), 143, 434.804716810328140m, new DateTime(2025, 6, 11, 6, 36, 49, 356, DateTimeKind.Local).AddTicks(4441), "Qui vitae doloremque.", 652.2070752154922100m });

            migrationBuilder.UpdateData(
                table: "events",
                keyColumn: "Id",
                keyValue: -12,
                columns: new[] { "CurrentAttendees", "Description", "EndTime", "MaxAttendees", "RegularPrice", "StartTime", "Title", "VipPrice" },
                values: new object[] { 38, "Illum incidunt vero error sed amet. Magnam dolores ut. Tempore et expedita sed eligendi aut. Commodi qui provident quae est repudiandae cumque accusantium. Voluptas ut dolorem est corporis quo in aut quia. Quis minus architecto et quia sapiente.", new DateTime(2024, 8, 14, 12, 5, 1, 431, DateTimeKind.Local).AddTicks(6608), 106, 768.010026213139150m, new DateTime(2024, 8, 14, 9, 30, 6, 372, DateTimeKind.Local).AddTicks(3770), "Quae temporibus rerum et dolor aut quia quos dolores temporibus.", 1152.0150393197087250m });

            migrationBuilder.UpdateData(
                table: "events",
                keyColumn: "Id",
                keyValue: -11,
                columns: new[] { "CurrentAttendees", "Description", "EndTime", "EventCategory", "MaxAttendees", "RegularPrice", "StartTime", "Title", "VipPrice" },
                values: new object[] { 31, "Ut excepturi in dolores. Aut eveniet et reiciendis consequatur itaque ratione quam beatae velit. Inventore voluptatem ut aut. Aut sed unde sit architecto reprehenderit illo consequuntur eaque. Molestias nostrum eum qui et facilis aut maxime aut.", new DateTime(2024, 9, 5, 22, 38, 39, 112, DateTimeKind.Local).AddTicks(8642), 4, 132, 712.766422008433090m, new DateTime(2024, 9, 5, 21, 24, 32, 445, DateTimeKind.Local).AddTicks(9782), "Et iste modi.", 1069.1496330126496350m });

            migrationBuilder.UpdateData(
                table: "events",
                keyColumn: "Id",
                keyValue: -10,
                columns: new[] { "CurrentAttendees", "Description", "EndTime", "EventCategory", "MaxAttendees", "RegularPrice", "StartTime", "Title", "VipPrice" },
                values: new object[] { 17, "Cupiditate dignissimos velit corrupti incidunt accusantium quis molestiae sequi. Ex quia enim exercitationem animi recusandae consequuntur aut. Ab nisi voluptatem ex iste. Explicabo et cum impedit deserunt deleniti et. Veniam et soluta quo assumenda.", new DateTime(2024, 12, 12, 4, 12, 27, 197, DateTimeKind.Local).AddTicks(5558), 5, 163, 477.163037354445190m, new DateTime(2024, 12, 12, 0, 21, 46, 148, DateTimeKind.Local).AddTicks(1525), "Ipsam accusantium ratione quos ex quaerat eaque id tempore.", 715.7445560316677850m });

            migrationBuilder.UpdateData(
                table: "events",
                keyColumn: "Id",
                keyValue: -9,
                columns: new[] { "CurrentAttendees", "Description", "EndTime", "EventCategory", "MaxAttendees", "RegularPrice", "StartTime", "Title", "VipPrice" },
                values: new object[] { 33, "Animi illum dolorem voluptates at ullam accusamus esse voluptatibus. Officiis magni repellendus voluptate sed aut impedit reprehenderit aut. Eius non itaque corporis assumenda dicta est odit voluptate quo. Adipisci iste at aut est iusto.", new DateTime(2025, 3, 2, 11, 35, 44, 58, DateTimeKind.Local).AddTicks(2938), 2, 90, 68.3844979518962920m, new DateTime(2025, 3, 2, 8, 38, 48, 866, DateTimeKind.Local).AddTicks(166), "Reprehenderit a enim quos dolores atque ut ea qui.", 102.57674692784443800m });

            migrationBuilder.UpdateData(
                table: "events",
                keyColumn: "Id",
                keyValue: -8,
                columns: new[] { "CurrentAttendees", "Description", "EndTime", "EventCategory", "MaxAttendees", "RegularPrice", "StartTime", "Title", "VipPrice" },
                values: new object[] { 40, "Sed qui atque. Laudantium rerum consequatur quisquam aliquam eaque. Veniam commodi molestias. Et quasi voluptates neque et. Deserunt consectetur aut dicta porro aperiam voluptates consequatur veritatis sint.", new DateTime(2025, 4, 2, 19, 10, 11, 191, DateTimeKind.Local).AddTicks(4880), 2, 145, 409.819857525116380m, new DateTime(2025, 4, 2, 16, 3, 54, 831, DateTimeKind.Local).AddTicks(3168), "Similique quo occaecati rerum reprehenderit impedit quo optio.", 614.7297862876745700m });

            migrationBuilder.UpdateData(
                table: "events",
                keyColumn: "Id",
                keyValue: -7,
                columns: new[] { "CurrentAttendees", "Description", "EndTime", "EventCategory", "MaxAttendees", "RegularPrice", "StartTime", "Title", "VipPrice" },
                values: new object[] { 5, "Qui reiciendis possimus aliquam qui ducimus placeat amet ut. Eum veniam voluptas consequuntur dolorum. Laborum delectus enim.", new DateTime(2024, 9, 5, 8, 37, 56, 60, DateTimeKind.Local).AddTicks(4145), 6, 109, 866.628205275079270m, new DateTime(2024, 9, 5, 6, 13, 39, 463, DateTimeKind.Local).AddTicks(3155), "Aspernatur et commodi quaerat.", 1299.9423079126189050m });

            migrationBuilder.UpdateData(
                table: "events",
                keyColumn: "Id",
                keyValue: -6,
                columns: new[] { "CurrentAttendees", "Description", "EndTime", "EventCategory", "MaxAttendees", "RegularPrice", "StartTime", "Title", "VipPrice" },
                values: new object[] { 40, "Ex corrupti eum sed consequuntur temporibus sit dicta non eos. Pariatur aspernatur praesentium pariatur. Sit sequi mollitia earum. Accusamus aspernatur nihil et cum.", new DateTime(2024, 8, 19, 17, 48, 2, 35, DateTimeKind.Local).AddTicks(8401), 3, 141, 326.842968777305410m, new DateTime(2024, 8, 19, 15, 24, 31, 259, DateTimeKind.Local).AddTicks(8411), "Qui repellat neque numquam pariatur nemo eveniet.", 490.2644531659581150m });

            migrationBuilder.UpdateData(
                table: "events",
                keyColumn: "Id",
                keyValue: -5,
                columns: new[] { "CurrentAttendees", "Description", "EndTime", "EventCategory", "MaxAttendees", "RegularPrice", "StartTime", "Title", "VipPrice" },
                values: new object[] { 19, "Excepturi eum eum neque nihil a aut id amet. Soluta et rerum reprehenderit voluptas et omnis ut non. Qui aperiam nostrum in quis quia ut. Odio assumenda nesciunt enim pariatur rerum. Animi tempora expedita tempore in sunt nulla repellat.", new DateTime(2025, 2, 4, 13, 3, 37, 208, DateTimeKind.Local).AddTicks(195), 4, 136, 276.174576479928160m, new DateTime(2025, 2, 4, 9, 17, 4, 602, DateTimeKind.Local).AddTicks(4066), "Quo quos consequatur perspiciatis sunt sapiente quia.", 414.2618647198922400m });

            migrationBuilder.UpdateData(
                table: "events",
                keyColumn: "Id",
                keyValue: -4,
                columns: new[] { "CurrentAttendees", "Description", "EndTime", "EventCategory", "MaxAttendees", "RegularPrice", "StartTime", "Title", "VipPrice" },
                values: new object[] { 26, "Magni error omnis eius autem est voluptas quia consequatur doloribus. Eligendi rem animi ducimus adipisci. Laboriosam recusandae minima voluptatem.", new DateTime(2024, 12, 26, 2, 54, 45, 374, DateTimeKind.Local).AddTicks(253), 5, 99, 16.88341951711239760m, new DateTime(2024, 12, 26, 0, 23, 53, 768, DateTimeKind.Local).AddTicks(3767), "Dolorum odio et.", 25.325129275668596400m });

            migrationBuilder.UpdateData(
                table: "events",
                keyColumn: "Id",
                keyValue: -3,
                columns: new[] { "CurrentAttendees", "Description", "EndTime", "EventCategory", "MaxAttendees", "RegularPrice", "StartTime", "Title", "VipPrice" },
                values: new object[] { 38, "Aspernatur minima harum sit consequuntur consequatur eum. Non qui iusto. Unde consequatur dignissimos nesciunt explicabo. Veniam qui ad. Iusto quo dolorum quaerat quia necessitatibus doloribus placeat inventore est. Commodi maiores quaerat aut.", new DateTime(2024, 6, 19, 14, 3, 19, 309, DateTimeKind.Local).AddTicks(3006), 4, 149, 844.916474388589120m, new DateTime(2024, 6, 19, 11, 56, 30, 130, DateTimeKind.Local).AddTicks(7973), "Fuga culpa voluptate.", 1267.3747115828836800m });

            migrationBuilder.UpdateData(
                table: "events",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "CurrentAttendees", "Description", "EndTime", "EventCategory", "MaxAttendees", "RegularPrice", "StartTime", "Title", "VipPrice" },
                values: new object[] { 26, "Aut laudantium architecto. Asperiores quis aliquid sit optio. Doloribus nisi rerum non nulla illum aut illo. Enim consequuntur voluptas est aut quam ratione facilis. Sit eos sint. Velit expedita exercitationem architecto et est autem est.", new DateTime(2025, 2, 9, 5, 31, 1, 622, DateTimeKind.Local).AddTicks(3461), 6, 169, 496.833866185150990m, new DateTime(2025, 2, 9, 2, 47, 12, 945, DateTimeKind.Local).AddTicks(6641), "Hic voluptas excepturi id sed inventore consequatur dolor placeat iste.", 745.2507992777264850m });

            migrationBuilder.UpdateData(
                table: "events",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "Description", "EndTime", "EventCategory", "MaxAttendees", "RegularPrice", "StartTime", "Title", "VipPrice" },
                values: new object[] { "Eius rem nihil nostrum praesentium quasi. Voluptatem laudantium vero libero ex. Repellendus commodi et autem. Autem accusamus consectetur voluptas omnis facilis dolorem. Assumenda error dignissimos nostrum earum consequuntur.", new DateTime(2024, 10, 9, 17, 5, 51, 190, DateTimeKind.Local).AddTicks(7700), 6, 65, 128.175274083497950m, new DateTime(2024, 10, 9, 13, 47, 10, 966, DateTimeKind.Local).AddTicks(2384), "Labore fugiat nihil blanditiis molestias labore.", 192.2629111252469250m });

            migrationBuilder.UpdateData(
                table: "facilities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 343, "Labore consectetur aliquid illo atque voluptatem.", "Corkery LLC" });

            migrationBuilder.UpdateData(
                table: "facilities",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 316, "Expedita doloremque culpa facilis eum quia.", "Langworth Group" });

            migrationBuilder.UpdateData(
                table: "facilities",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 484, "Doloremque autem et nisi.", "Gaylord LLC" });

            migrationBuilder.UpdateData(
                table: "facilities",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 412, "Ipsum ullam distinctio possimus molestiae repudiandae nihil maxime autem.", "Wilderman, Casper and Yost" });

            migrationBuilder.UpdateData(
                table: "facilities",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 304, "Quisquam dolore maiores.", "Zboncak Inc" });

            migrationBuilder.UpdateData(
                table: "facilities",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 115, "Quia ut est qui cumque.", "Williamson Group" });

            migrationBuilder.UpdateData(
                table: "facilities",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 437, "Quod ipsa autem in voluptatem quas asperiores atque vel facere.", "Heidenreich - Mills" });

            migrationBuilder.UpdateData(
                table: "facilities",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 270, "Doloribus expedita ratione voluptatum quos dolorum facere assumenda.", "Larkin, Schroeder and Welch" });

            migrationBuilder.UpdateData(
                table: "facilities",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 402, "Voluptatem velit aut quos non consectetur et.", "Streich and Sons" });

            migrationBuilder.UpdateData(
                table: "facilities",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Capacity", "Description", "Name" },
                values: new object[] { 452, "Debitis asperiores animi est eveniet alias soluta ratione.", "Collins, Koch and Hartmann" });

            migrationBuilder.UpdateData(
                table: "shifts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FromHour", "ToHour" },
                values: new object[] { new DateTime(2023, 12, 14, 0, 19, 52, 348, DateTimeKind.Local).AddTicks(1121), new DateTime(2024, 7, 26, 11, 0, 59, 331, DateTimeKind.Local).AddTicks(2398) });

            migrationBuilder.UpdateData(
                table: "shifts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "FromHour", "ShiftType", "ToHour" },
                values: new object[] { new DateTime(2023, 6, 20, 18, 58, 28, 823, DateTimeKind.Local).AddTicks(1282), 3, new DateTime(2025, 1, 24, 20, 35, 21, 917, DateTimeKind.Local).AddTicks(6080) });

            migrationBuilder.UpdateData(
                table: "shifts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "FromHour", "ToHour" },
                values: new object[] { new DateTime(2024, 4, 5, 19, 42, 24, 750, DateTimeKind.Local).AddTicks(9919), new DateTime(2024, 8, 7, 14, 54, 37, 867, DateTimeKind.Local).AddTicks(8638) });

            migrationBuilder.UpdateData(
                table: "shifts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "FromHour", "ShiftType", "ToHour" },
                values: new object[] { new DateTime(2024, 1, 2, 11, 7, 25, 660, DateTimeKind.Local).AddTicks(490), 2, new DateTime(2024, 11, 25, 16, 42, 52, 878, DateTimeKind.Local).AddTicks(9324) });

            migrationBuilder.UpdateData(
                table: "shifts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "FromHour", "ShiftType", "ToHour" },
                values: new object[] { new DateTime(2024, 1, 9, 6, 53, 48, 128, DateTimeKind.Local).AddTicks(8786), 3, new DateTime(2024, 11, 11, 22, 56, 45, 720, DateTimeKind.Local).AddTicks(9385) });

            migrationBuilder.UpdateData(
                table: "shifts",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "FromHour", "ToHour" },
                values: new object[] { new DateTime(2023, 9, 6, 0, 27, 9, 914, DateTimeKind.Local).AddTicks(6268), new DateTime(2024, 10, 14, 0, 18, 18, 740, DateTimeKind.Local).AddTicks(6956) });

            migrationBuilder.UpdateData(
                table: "shifts",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "FromHour", "ShiftType", "ToHour" },
                values: new object[] { new DateTime(2024, 4, 1, 15, 12, 28, 643, DateTimeKind.Local).AddTicks(8396), 2, new DateTime(2024, 9, 18, 21, 11, 55, 164, DateTimeKind.Local).AddTicks(9318) });

            migrationBuilder.UpdateData(
                table: "shifts",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "FromHour", "ShiftType", "ToHour" },
                values: new object[] { new DateTime(2024, 2, 12, 10, 39, 58, 670, DateTimeKind.Local).AddTicks(9427), 3, new DateTime(2025, 5, 21, 9, 50, 26, 89, DateTimeKind.Local).AddTicks(4267) });

            migrationBuilder.UpdateData(
                table: "shifts",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "FromHour", "ShiftType", "ToHour" },
                values: new object[] { new DateTime(2024, 4, 24, 22, 18, 30, 527, DateTimeKind.Local).AddTicks(7692), 3, new DateTime(2025, 5, 17, 15, 54, 53, 118, DateTimeKind.Local).AddTicks(6529) });

            migrationBuilder.UpdateData(
                table: "shifts",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "FromHour", "ShiftType", "ToHour" },
                values: new object[] { new DateTime(2024, 5, 13, 6, 34, 40, 83, DateTimeKind.Local).AddTicks(9204), 3, new DateTime(2024, 8, 18, 16, 40, 14, 228, DateTimeKind.Local).AddTicks(6817) });
        }
    }
}
