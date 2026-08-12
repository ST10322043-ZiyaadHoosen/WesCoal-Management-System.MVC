using Microsoft.AspNetCore.Mvc;

namespace WesCoalMVC.Controllers;

public class ManagementController : Controller
{
    public IActionResult Index() => View();
    public IActionResult Customers() => View();
    public IActionResult Contracts() => View();
    public IActionResult Orders() => View();
    public IActionResult Weighbridge() => View();
    public IActionResult Invoices() => View();
    public IActionResult Fleet() => View();
    public IActionResult Users() => View();
    public IActionResult Audit() => View();
    public IActionResult Reports() => View();
}
