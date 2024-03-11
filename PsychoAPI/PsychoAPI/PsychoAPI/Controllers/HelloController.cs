using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Routing;
using PsychoAPI.Models;

namespace PsychoAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class HelloController : ControllerBase
{
    private static readonly List<CounselingCenter> cabinetsData = new()
    {
        new CounselingCenter() { RoomId = 1, RoomName = "Hej"},
        new CounselingCenter() { RoomId = 2, RoomName = "Mala"},
        new CounselingCenter() { RoomId = 3, RoomName = "Jak"},
        new CounselingCenter() { RoomId = 4, RoomName = "Dzis"},
        new CounselingCenter() { RoomId = 5, RoomName = "Leci"}
    };

    private static readonly List<Reservation> reservationsData = new()
    {
        new Reservation()
        {
            ReservationId = 1, RoomId = 1,  PsychologistName = "Hej przystojniaku", DateFrom = DateTime.Now.AddDays(2),
            DateTo = DateTime.Now.AddDays(5), PhoneNumber = "600700800", IsRemoved = false
        },
        new Reservation()
        {
            ReservationId = 2, RoomId = 2, PsychologistName = "Lucyna Malina", DateFrom = DateTime.Now.AddDays(2),
            DateTo = DateTime.Now.AddDays(5), PhoneNumber = "600700800", IsRemoved = false
        },
        new Reservation()
        {
            ReservationId = 3, RoomId = 3, PsychologistName = "Ela Mortadela", DateFrom = DateTime.Now.AddDays(2),
            DateTo = DateTime.Now.AddDays(5), PhoneNumber = "600700800", IsRemoved = false
        },
        new Reservation()
        {
            ReservationId = 4, RoomId = 4, PsychologistName = "Dynia Gdynia", DateFrom = DateTime.Now.AddDays(2),
            DateTo = DateTime.Now.AddDays(5), PhoneNumber = "600700800", IsRemoved = false
        },
        new Reservation()
        {
            ReservationId = 5, RoomId = 1, PsychologistName = "Martyna Kurtyna", DateFrom = DateTime.Now.AddDays(6),
            DateTo = DateTime.Now.AddDays(8), PhoneNumber = "600700800", IsRemoved = false
        },
        new Reservation()
        {
            ReservationId = 6, RoomId = 1, PsychologistName = "Skarbie Barbie", DateFrom = DateTime.Now.AddDays(9),
            DateTo = DateTime.Now.AddDays(10), PhoneNumber = "600700800", IsRemoved = false
        },
        new Reservation()
        {
            ReservationId = 7, RoomId = 4, PsychologistName = "Marcin Gortat", DateFrom = DateTime.Now.AddDays(6),
            DateTo = DateTime.Now.AddDays(7), PhoneNumber = "600700800", IsRemoved = false
        },
        new Reservation()
        {
            ReservationId = 8, RoomId = 3, PsychologistName = "Marika Szarika", DateFrom = DateTime.Now.AddDays(7),
            DateTo = DateTime.Now.AddDays(6), PhoneNumber = "600700800", IsRemoved = false
        }
    };

    [HttpGet("counselingcenter")]
    public ActionResult<List<CounselingCenter>> GetCounselingCenter()
    {
        return cabinetsData;
    }

    [HttpGet("counselingcenter/{id}")]
    public ActionResult<CounselingCenter> GetCounselingCenterById(int id)
    {
        var cabinet = cabinetsData.FirstOrDefault(c=>c.RoomId == id);
        if (cabinet == null)
        {
            return NotFound();
        }

        return cabinet;
    }
    [HttpGet("reservationlist")]
    public ActionResult<List<Reservation>> GetReservationList()
    {
        return reservationsData;
    }
    [HttpGet("reservationlist/{id}")]
    public ActionResult<Reservation> GetReservationListById(int id)
    {
        var reservation = reservationsData.FirstOrDefault(r => r.ReservationId == id);
        if (reservation == null)
        {
            return NotFound();
        }

        return reservation;
    }

    [HttpPost("createreservation")]
    public ActionResult<Reservation>CreateReservation([FromBody] Reservation reservation)
    {
        return Ok();
    }

    [HttpPut("changereservation/{id}")]
    public ActionResult<Reservation> ChangeReservation(int id, [FromBody] Reservation reservation)
    {
        return Ok();
    }
};
