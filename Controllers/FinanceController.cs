using Microsoft.AspNetCore.Mvc;

namespace WesCoalMVC.Controllers;

public class FinanceController : Controller
{
    // Dashboard
    public IActionResult Index() => View();

    // Orders awaiting SAP (Queue)
    public IActionResult OrdersQueue() => View();

    // All orders (tracking)
    public IActionResult Orders() => View();

    // Order detail (used from Orders and Queue)
    public IActionResult OrderDetails() => View();

    // Contracts (lifecycle + pricing)
    public IActionResult Contracts() => View();

    // Contract detail
    public IActionResult ContractDetails() => View();

    // Invoices
    public IActionResult Invoices() => View();

    // Invoice detail (includes weighbridge breakdown / reconciliation)
    public IActionResult InvoiceDetails() => View();

    // Payments
    public IActionResult Payments() => View();

    // Analytics dashboards
    public IActionResult Analytics() => View();

    // Formal reports / exports
    public IActionResult Reports() => View();
}