using Microsoft.AspNetCore.Mvc;

namespace WesCoalMVC.Controllers;

public class FinanceController : Controller
{
    public IActionResult Index() => View();
    public IActionResult OrdersQueue() => View();
    public IActionResult OrderDetails() => View();
    public IActionResult ActiveOrders() => View();
    public IActionResult Reconciliation() => View();
    public IActionResult Invoices() => View();
    public IActionResult InvoiceDetails() => View();
    public IActionResult Payments() => View();
}
