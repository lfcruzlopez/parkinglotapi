using Microsoft.AspNetCore.Mvc;

namespace ParkingLotApi.Controllers;

public class ReservationController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}