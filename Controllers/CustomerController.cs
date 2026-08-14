using Microsoft.AspNetCore.Mvc;

namespace WesCoalMVC.Controllers;

public class CustomerController : Controller
{
    // Dashboard
    public IActionResult Index() => View();

    // Contracts
    public IActionResult Contracts() => View();
    public IActionResult ContractDetails() => View();

    // Purchase Orders
    public IActionResult Orders() => View();
    public IActionResult OrderDetails() => View();

    // Weekly Fleet
    public IActionResult Fleet() => View();
    public IActionResult FleetUpload() => View();
    public IActionResult FleetAddTruck() => View();
    public IActionResult FleetAddDriver() => View();

    // Invoices
    public IActionResult Invoices() => View();
    public IActionResult InvoiceDetails() => View();

    // Profile
    public IActionResult Profile() => View();
}