using ECMS.Enums;

namespace ECMS.DTO
{
    public class EventRegistrationDto
    {
        public int EventId { get; set; }
        public int CustomerId { get; set; }
        public decimal TicketPrice { get; set; }
        public string SeatNumber { get; set; }
        public TicketType TicketType { get; set; }
    }
}