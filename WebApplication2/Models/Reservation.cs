namespace WebApplication2.Models
{
    public class Reservation
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int RoomId { get; set; }
        public DateTime ReservationDateTime { get; set; }
        public string Description { get; set; }
        public User User { get; set; }
        public Room Room { get; set; }
    }
}
