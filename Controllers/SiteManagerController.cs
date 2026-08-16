using Microsoft.AspNetCore.Mvc;

namespace WesCoalMVC.Controllers;

public class SiteManagerController : Controller
{
    public IActionResult Index() => View();
    public IActionResult Tracking() => View();
    public IActionResult TrackingDetails() => View();
    public IActionResult Weighbridge() => View();
    public IActionResult TransactionDetails() => View();
    public IActionResult Fleet() => View();
    public IActionResult TruckDetails() => View();
    public IActionResult DriverDetails() => View();
    public IActionResult Audit() => View();
}