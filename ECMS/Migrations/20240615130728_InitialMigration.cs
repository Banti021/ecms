using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ECMS.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "addresses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    City = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Street = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    BuildingNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_addresses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "departments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmployeeCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_departments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "events",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    EventCategory = table.Column<int>(type: "int", nullable: false),
                    RegularPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    VipPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    StartTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    MaxAttendees = table.Column<int>(type: "int", nullable: false),
                    CurrentAttendees = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_events", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "persons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_persons", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Category = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    Stock = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_products", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "shifts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShiftType = table.Column<int>(type: "int", nullable: false),
                    FromHour = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ToHour = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_shifts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tickets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IsSeated = table.Column<bool>(type: "bit", nullable: false),
                    SeatNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TicketType = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tickets", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "facilities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    AddressId = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Capacity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_facilities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_facilities_addresses_AddressId",
                        column: x => x.AddressId,
                        principalTable: "addresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "suppliers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    AddressId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_suppliers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_suppliers_addresses_AddressId",
                        column: x => x.AddressId,
                        principalTable: "addresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "customers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonId = table.Column<int>(type: "int", nullable: false),
                    DateOfBirth = table.Column<DateOnly>(type: "date", nullable: false),
                    JoinDate = table.Column<DateOnly>(type: "date", nullable: false),
                    LastVisit = table.Column<DateOnly>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_customers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_customers_persons_PersonId",
                        column: x => x.PersonId,
                        principalTable: "persons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "areas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Capacity = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    IsAvailable = table.Column<bool>(type: "bit", nullable: false),
                    FacilityId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_areas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_areas_facilities_FacilityId",
                        column: x => x.FacilityId,
                        principalTable: "facilities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "facility_suppliers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FacilityId = table.Column<int>(type: "int", nullable: false),
                    SupplierId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_facility_suppliers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_facility_suppliers_facilities_FacilityId",
                        column: x => x.FacilityId,
                        principalTable: "facilities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_facility_suppliers_suppliers_SupplierId",
                        column: x => x.SupplierId,
                        principalTable: "suppliers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "supplier_products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SupplierId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_supplier_products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_supplier_products_products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_supplier_products_suppliers_SupplierId",
                        column: x => x.SupplierId,
                        principalTable: "suppliers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "event_customers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EventId = table.Column<int>(type: "int", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    TicketId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_event_customers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_event_customers_customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_event_customers_events_EventId",
                        column: x => x.EventId,
                        principalTable: "events",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_event_customers_tickets_TicketId",
                        column: x => x.TicketId,
                        principalTable: "tickets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderNumber = table.Column<int>(type: "int", nullable: false),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    TotalAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CustomerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "reservations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReservationFrom = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ReservationTo = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Category = table.Column<int>(type: "int", nullable: false),
                    NumberOfGuests = table.Column<int>(type: "int", nullable: false),
                    ConfirmedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AdditionalInfo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_reservations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_reservations_customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "customers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "area_events",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AreaId = table.Column<int>(type: "int", nullable: false),
                    EventId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_area_events", x => x.Id);
                    table.ForeignKey(
                        name: "FK_area_events_areas_AreaId",
                        column: x => x.AreaId,
                        principalTable: "areas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_area_events_events_EventId",
                        column: x => x.EventId,
                        principalTable: "events",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonId = table.Column<int>(type: "int", nullable: false),
                    Position = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Salary = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    HireDate = table.Column<DateOnly>(type: "date", nullable: false),
                    SupervisorId = table.Column<int>(type: "int", nullable: true),
                    DepartmentId = table.Column<int>(type: "int", nullable: true),
                    ShiftId = table.Column<int>(type: "int", nullable: false),
                    AreaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_employees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_employees_areas_AreaId",
                        column: x => x.AreaId,
                        principalTable: "areas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_employees_departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "departments",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_employees_employees_SupervisorId",
                        column: x => x.SupervisorId,
                        principalTable: "employees",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_employees_persons_PersonId",
                        column: x => x.PersonId,
                        principalTable: "persons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_employees_shifts_ShiftId",
                        column: x => x.ShiftId,
                        principalTable: "shifts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "order_products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_order_products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_order_products_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_order_products_products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "reservation_areas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReservationId = table.Column<int>(type: "int", nullable: false),
                    AreaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_reservation_areas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_reservation_areas_areas_AreaId",
                        column: x => x.AreaId,
                        principalTable: "areas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_reservation_areas_reservations_ReservationId",
                        column: x => x.ReservationId,
                        principalTable: "reservations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "addresses",
                columns: new[] { "Id", "BuildingNo", "City", "Street" },
                values: new object[,]
                {
                    { 1, "2097", "Liamshire", "Klein Orchard" },
                    { 2, "455", "Port Gayle", "Homenick Pass" },
                    { 3, "429", "Pfeffermouth", "Xzavier Dale" },
                    { 4, "07498", "Torpton", "Cale Pines" },
                    { 5, "8289", "Thereseview", "Jones Vista" },
                    { 6, "1905", "Janiceville", "Moore Meadows" },
                    { 7, "076", "Lake Hattiechester", "Vernice Shore" },
                    { 8, "00703", "Rohanmouth", "Wilfredo Lakes" },
                    { 9, "5824", "South Kaycee", "Jules Skyway" },
                    { 10, "1513", "Ethelynstad", "Fay Lights" }
                });

            migrationBuilder.InsertData(
                table: "departments",
                columns: new[] { "Id", "Description", "EmployeeCount", "Name" },
                values: new object[,]
                {
                    { 1, "Eos voluptate ut sint et eum et sunt.", 29, "Automotive" },
                    { 2, "Eaque expedita facilis placeat at reiciendis et aut ab vero.", 19, "Industrial & Beauty" },
                    { 3, "Delectus molestiae nihil animi sint nulla delectus.", 37, "Sports & Automotive" },
                    { 4, "Voluptatibus quod qui quo consequatur molestiae facilis voluptatem nisi.", 14, "Jewelery, Kids & Computers" },
                    { 5, "Quam omnis qui ducimus optio.", 20, "Clothing" },
                    { 6, "Est fugit architecto maiores inventore dicta eum aut rerum itaque.", 15, "Kids, Games & Computers" },
                    { 7, "Illum sint vero vel.", 48, "Movies, Garden & Beauty" },
                    { 8, "Dolore nemo facilis in qui voluptates natus atque.", 19, "Music, Automotive & Outdoors" },
                    { 9, "Laborum optio placeat.", 22, "Kids, Baby & Sports" },
                    { 10, "Aut vel blanditiis sit id culpa dolorem voluptatem ut et.", 35, "Industrial" }
                });

            migrationBuilder.InsertData(
                table: "shifts",
                columns: new[] { "Id", "FromHour", "ShiftType", "ToHour" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 1, 10, 18, 29, 44, 839, DateTimeKind.Local).AddTicks(5959), 2, new DateTime(2024, 8, 18, 19, 43, 42, 794, DateTimeKind.Local).AddTicks(989) },
                    { 2, new DateTime(2024, 4, 25, 23, 23, 4, 261, DateTimeKind.Local).AddTicks(1895), 3, new DateTime(2024, 7, 6, 10, 56, 50, 88, DateTimeKind.Local).AddTicks(8409) },
                    { 3, new DateTime(2024, 1, 28, 16, 17, 57, 740, DateTimeKind.Local).AddTicks(5578), 3, new DateTime(2025, 1, 16, 0, 27, 41, 986, DateTimeKind.Local).AddTicks(3098) },
                    { 4, new DateTime(2024, 4, 2, 10, 10, 56, 871, DateTimeKind.Local).AddTicks(5237), 1, new DateTime(2025, 5, 13, 19, 44, 31, 104, DateTimeKind.Local).AddTicks(7812) },
                    { 5, new DateTime(2023, 7, 12, 7, 22, 47, 222, DateTimeKind.Local).AddTicks(9282), 3, new DateTime(2025, 5, 26, 13, 36, 39, 785, DateTimeKind.Local).AddTicks(1853) },
                    { 6, new DateTime(2023, 8, 28, 19, 48, 47, 13, DateTimeKind.Local).AddTicks(1254), 1, new DateTime(2025, 4, 12, 13, 1, 49, 215, DateTimeKind.Local).AddTicks(9857) },
                    { 7, new DateTime(2024, 4, 3, 18, 34, 50, 538, DateTimeKind.Local).AddTicks(399), 1, new DateTime(2024, 12, 1, 18, 13, 53, 223, DateTimeKind.Local).AddTicks(6128) },
                    { 8, new DateTime(2024, 3, 4, 11, 4, 20, 505, DateTimeKind.Local).AddTicks(1771), 1, new DateTime(2024, 12, 20, 2, 34, 7, 480, DateTimeKind.Local).AddTicks(2132) },
                    { 9, new DateTime(2023, 8, 27, 10, 6, 9, 918, DateTimeKind.Local).AddTicks(6500), 2, new DateTime(2024, 12, 29, 10, 57, 11, 91, DateTimeKind.Local).AddTicks(7515) },
                    { 10, new DateTime(2024, 5, 2, 8, 39, 20, 851, DateTimeKind.Local).AddTicks(1579), 1, new DateTime(2025, 4, 1, 8, 46, 11, 312, DateTimeKind.Local).AddTicks(7788) }
                });

            migrationBuilder.InsertData(
                table: "facilities",
                columns: new[] { "Id", "AddressId", "Capacity", "Description", "Name" },
                values: new object[,]
                {
                    { 1, 1, 322, "Repellendus autem cum qui dolores et esse.", "Doyle - O'Reilly" },
                    { 2, 2, 455, "Eum eos ut repellendus modi nam dolorem est.", "Crist, Glover and Lakin" },
                    { 3, 3, 149, "Odio ducimus ducimus impedit asperiores voluptatum nihil.", "Haag - Thompson" },
                    { 4, 4, 390, "Eum id aut distinctio ratione inventore est perspiciatis nulla voluptate.", "Schowalter Group" },
                    { 5, 5, 479, "Cumque ea est explicabo.", "Lynch - Koch" },
                    { 6, 6, 161, "Ut reprehenderit ea ratione repellendus reiciendis aperiam.", "Feil, Hane and Emard" },
                    { 7, 7, 143, "Nihil sint consequatur dolor eum.", "O'Reilly, Wolf and Smith" },
                    { 8, 8, 175, "Ut dolorum ad quia modi omnis.", "Rippin - Haley" },
                    { 9, 9, 434, "Qui voluptas quas placeat omnis voluptatem adipisci aliquam quibusdam mollitia.", "Bruen, Schneider and Davis" },
                    { 10, 10, 219, "Enim similique placeat et quia vel.", "Satterfield - Metz" }
                });

            migrationBuilder.InsertData(
                table: "areas",
                columns: new[] { "Id", "Capacity", "Description", "FacilityId", "IsAvailable", "Name" },
                values: new object[,]
                {
                    { 1, 171, "Vel nisi quia nisi dolorum rerum reprehenderit impedit et doloremque.", 1, true, "De-engineered modular data-warehouse" },
                    { 2, 190, "Dignissimos ex totam atque ullam molestiae.", 1, true, "Implemented clear-thinking definition" },
                    { 3, 197, "Non assumenda quia voluptates facere.", 1, true, "Cross-platform responsive data-warehouse" },
                    { 4, 61, "Amet ut sed enim optio magni aut impedit.", 1, true, "Re-engineered demand-driven function" },
                    { 5, 174, "Perferendis aut nihil dolorum in voluptatem iure similique labore exercitationem.", 1, false, "Horizontal bottom-line standardization" },
                    { 6, 99, "Repellendus incidunt quasi inventore sunt nostrum incidunt dignissimos aliquid libero.", 2, false, "Re-contextualized asymmetric initiative" },
                    { 7, 76, "A culpa officia ipsam eaque repudiandae ipsa consequatur vel vel.", 2, true, "Future-proofed context-sensitive firmware" },
                    { 8, 82, "Non dolore officia.", 2, false, "Open-source multi-state architecture" },
                    { 9, 66, "Error laudantium eos.", 2, false, "Cloned 3rd generation workforce" },
                    { 10, 102, "Atque cum maxime explicabo enim fuga nesciunt et saepe temporibus.", 2, true, "Organic global info-mediaries" },
                    { 11, 99, "Error in error praesentium.", 3, false, "Monitored human-resource adapter" },
                    { 12, 104, "Molestias libero natus cupiditate est at suscipit veritatis.", 3, false, "Synergistic client-server archive" },
                    { 13, 178, "Eos eum tenetur optio.", 3, true, "Customizable system-worthy benchmark" },
                    { 14, 113, "Accusantium nobis deserunt odit consequatur.", 3, false, "Focused optimizing alliance" },
                    { 15, 134, "Possimus quo impedit tempora natus sint in repudiandae.", 3, false, "Assimilated cohesive policy" },
                    { 16, 149, "Voluptates optio velit in veritatis tempore cupiditate occaecati qui voluptas.", 4, false, "Optimized client-server extranet" },
                    { 17, 125, "Praesentium incidunt autem id.", 4, true, "Mandatory tertiary data-warehouse" },
                    { 18, 180, "Tenetur in inventore veniam eligendi alias corporis.", 4, true, "Multi-layered scalable algorithm" },
                    { 19, 59, "Sed iste est perspiciatis est sapiente.", 4, false, "Polarised executive time-frame" },
                    { 20, 179, "Optio possimus beatae iusto corrupti quis minus sed in.", 4, false, "Multi-lateral scalable Graphic Interface" },
                    { 21, 115, "Architecto beatae doloremque sint totam recusandae libero eligendi voluptas quas.", 5, false, "Digitized 5th generation challenge" },
                    { 22, 120, "Corrupti ea minima quis totam.", 5, false, "Front-line tangible core" },
                    { 23, 188, "Iste aut quibusdam sint cupiditate sequi architecto.", 5, false, "Enterprise-wide multimedia methodology" },
                    { 24, 65, "Sit nemo mollitia voluptatem accusamus aut dicta nesciunt qui optio.", 5, false, "Optimized systemic internet solution" },
                    { 25, 54, "Illum non facilis est nam voluptas.", 5, true, "De-engineered encompassing model" },
                    { 26, 99, "Officia quam omnis nihil velit optio dolores.", 6, false, "Re-contextualized systematic monitoring" },
                    { 27, 194, "Et qui id.", 6, false, "Future-proofed 4th generation paradigm" },
                    { 28, 127, "Laudantium quaerat veniam corrupti.", 6, true, "Optimized global local area network" },
                    { 29, 80, "Voluptate minima minima.", 6, true, "Open-source asynchronous synergy" },
                    { 30, 111, "Alias vero ipsam asperiores sint.", 6, true, "Self-enabling zero tolerance secured line" },
                    { 31, 78, "Necessitatibus officiis omnis iusto quidem incidunt ut.", 7, true, "Persistent context-sensitive success" },
                    { 32, 97, "Tenetur ratione aut quo molestias quam ut mollitia incidunt.", 7, true, "Digitized attitude-oriented hub" },
                    { 33, 195, "Eligendi aut voluptas.", 7, true, "Proactive local intranet" },
                    { 34, 134, "Reiciendis adipisci hic.", 7, true, "Synergistic systematic function" },
                    { 35, 67, "Cumque dolore ducimus ab eos architecto porro.", 7, false, "Exclusive needs-based Graphic Interface" },
                    { 36, 191, "Omnis asperiores sit nesciunt culpa non et illum ipsum.", 8, true, "Vision-oriented context-sensitive monitoring" },
                    { 37, 124, "Aut ut repellat rerum amet perferendis magni incidunt qui sunt.", 8, false, "Triple-buffered fresh-thinking open system" },
                    { 38, 86, "Labore eos officiis corrupti aut in.", 8, false, "Open-source intangible matrices" },
                    { 39, 95, "Sunt voluptatem qui similique.", 8, true, "Reverse-engineered object-oriented protocol" },
                    { 40, 132, "Mollitia debitis similique omnis eveniet et nulla.", 8, true, "Inverse interactive standardization" },
                    { 41, 172, "Modi adipisci consequatur et delectus est.", 9, false, "Right-sized 24/7 moderator" },
                    { 42, 107, "Molestiae fugit facere.", 9, false, "Grass-roots systematic forecast" },
                    { 43, 141, "Voluptas cum id esse est in autem.", 9, false, "Fundamental reciprocal strategy" },
                    { 44, 123, "Nulla vero quasi harum.", 9, true, "Inverse directional neural-net" },
                    { 45, 141, "Ratione perspiciatis sed ea autem natus aut.", 9, true, "Triple-buffered impactful knowledge base" },
                    { 46, 109, "Dolores sed recusandae reprehenderit facere eaque sit.", 10, true, "Visionary hybrid parallelism" },
                    { 47, 189, "Perspiciatis animi sunt voluptates molestias minima doloribus sed molestiae.", 10, false, "Triple-buffered 3rd generation workforce" },
                    { 48, 120, "Quae iure similique quo dolores aut eum iste.", 10, true, "Sharable tangible orchestration" },
                    { 49, 136, "Et ipsa dolorum facilis hic et consequatur dignissimos illo.", 10, false, "Proactive composite concept" },
                    { 50, 92, "Animi voluptas veniam excepturi.", 10, false, "Realigned dedicated infrastructure" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_area_events_AreaId",
                table: "area_events",
                column: "AreaId");

            migrationBuilder.CreateIndex(
                name: "IX_area_events_EventId",
                table: "area_events",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_areas_FacilityId",
                table: "areas",
                column: "FacilityId");

            migrationBuilder.CreateIndex(
                name: "IX_customers_PersonId",
                table: "customers",
                column: "PersonId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_employees_AreaId",
                table: "employees",
                column: "AreaId");

            migrationBuilder.CreateIndex(
                name: "IX_employees_DepartmentId",
                table: "employees",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_employees_PersonId",
                table: "employees",
                column: "PersonId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_employees_ShiftId",
                table: "employees",
                column: "ShiftId");

            migrationBuilder.CreateIndex(
                name: "IX_employees_SupervisorId",
                table: "employees",
                column: "SupervisorId");

            migrationBuilder.CreateIndex(
                name: "IX_event_customers_CustomerId",
                table: "event_customers",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_event_customers_EventId",
                table: "event_customers",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_event_customers_TicketId",
                table: "event_customers",
                column: "TicketId");

            migrationBuilder.CreateIndex(
                name: "IX_facilities_AddressId",
                table: "facilities",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_facility_suppliers_FacilityId",
                table: "facility_suppliers",
                column: "FacilityId");

            migrationBuilder.CreateIndex(
                name: "IX_facility_suppliers_SupplierId",
                table: "facility_suppliers",
                column: "SupplierId");

            migrationBuilder.CreateIndex(
                name: "IX_order_products_OrderId",
                table: "order_products",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_order_products_ProductId",
                table: "order_products",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CustomerId",
                table: "Orders",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_reservation_areas_AreaId",
                table: "reservation_areas",
                column: "AreaId");

            migrationBuilder.CreateIndex(
                name: "IX_reservation_areas_ReservationId",
                table: "reservation_areas",
                column: "ReservationId");

            migrationBuilder.CreateIndex(
                name: "IX_reservations_CustomerId",
                table: "reservations",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_supplier_products_ProductId",
                table: "supplier_products",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_supplier_products_SupplierId",
                table: "supplier_products",
                column: "SupplierId");

            migrationBuilder.CreateIndex(
                name: "IX_suppliers_AddressId",
                table: "suppliers",
                column: "AddressId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "area_events");

            migrationBuilder.DropTable(
                name: "employees");

            migrationBuilder.DropTable(
                name: "event_customers");

            migrationBuilder.DropTable(
                name: "facility_suppliers");

            migrationBuilder.DropTable(
                name: "order_products");

            migrationBuilder.DropTable(
                name: "reservation_areas");

            migrationBuilder.DropTable(
                name: "supplier_products");

            migrationBuilder.DropTable(
                name: "departments");

            migrationBuilder.DropTable(
                name: "shifts");

            migrationBuilder.DropTable(
                name: "events");

            migrationBuilder.DropTable(
                name: "tickets");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "areas");

            migrationBuilder.DropTable(
                name: "reservations");

            migrationBuilder.DropTable(
                name: "products");

            migrationBuilder.DropTable(
                name: "suppliers");

            migrationBuilder.DropTable(
                name: "facilities");

            migrationBuilder.DropTable(
                name: "customers");

            migrationBuilder.DropTable(
                name: "addresses");

            migrationBuilder.DropTable(
                name: "persons");
        }
    }
}
