using Microsoft.AspNetCore.Mvc;

namespace WesCoalMVC.Controllers;

public class ManagementController : Controller
{
    // Dashboard
    public IActionResult Index() => View();

    // Customers
    public IActionResult Customers() => View();
    public IActionResult CustomerDetails() => View();

    // Contracts
    public IActionResult Contracts() => View();
    public IActionResult ContractDetails() => View();

    // Purchase Orders
    public IActionResult Orders() => View();
    public IActionResult OrderDetails() => View();

    // Weighbridge Activity
    public IActionResult Weighbridge() => View();
    public IActionResult TransactionDetails() => View();

    // Invoices
    public IActionResult Invoices() => View();
    public IActionResult InvoiceDetails() => View();

    // Fleet Compliance
    public IActionResult Fleet() => View();
    public IActionResult TruckDetails() => View();
    public IActionResult DriverDetails() => View();

    // Users / Audit / Reports
    public IActionResult Users() => View();
    public IActionResult Audit() => View();
    public IActionResult Reports() => View();


    public IActionResult Analytics() => View();
}