namespace PsychoAPI.Models;

public class Reservation
{
    public int ReservationId { get; set; }
    public int RoomId { get; set; }
    public string PsychoName { get; set; }
    public string PhoneNumber { get; set; }
    public DateTime DateFrom { get; set; }
    public DateTime DateTo { get; set; }
}