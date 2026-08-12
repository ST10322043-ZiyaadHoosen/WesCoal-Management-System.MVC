using Microsoft.AspNetCore.Mvc;

namespace WesCoalMVC.Controllers;

public class CustomerController : Controller
{
    public IActionResult Index() => View();
    public IActionResult Contracts() => View();
    public IActionResult ContractDetails() => View();
    public IActionResult Orders() => View();
    public IActionResult OrderDetails() => View();
    public IActionResult Fleet() => View();
    public IActionResult FleetDetails() => View();
    public IActionResult Invoices() => View();
    public IActionResult InvoiceDetails() => View();
}
