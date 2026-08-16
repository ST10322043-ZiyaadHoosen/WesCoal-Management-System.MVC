using Microsoft.AspNetCore.Mvc;

namespace WesCoalMVC.Controllers;

public class LogisticsController : Controller
{
    public IActionResult Index() => View();
    public IActionResult AvailableOrders() => View();
    public IActionResult OrderDetails() => View();
    public IActionResult CollectionType() => View();
    public IActionResult SelectTruck() => View();
    public IActionResult GateCheck() => View();
    public IActionResult WeighIn() => View();
    public IActionResult WeighOut() => View();
    public IActionResult TransactionSummary() => View();
    public IActionResult Fleet() => View();
    public IActionResult WeighbridgeLog() => View();
    public IActionResult TruckDetails() => View();
    public IActionResult DriverDetails() => View();
}
