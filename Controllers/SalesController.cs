using Microsoft.AspNetCore.Mvc;

namespace WesCoalMVC.Controllers;

public class SalesController : Controller
{
    public IActionResult Index() => View();
    public IActionResult Customers() => View();
    public IActionResult CustomerDetails() => View();
    public IActionResult CreateCustomer() => View();
    public IActionResult Contracts() => View();
    public IActionResult ContractDetails() => View();
    public IActionResult CreateContract() => View();
    public IActionResult PurchaseOrders() => View();
    public IActionResult PurchaseOrderDetails() => View();
    public IActionResult CreatePurchaseOrder() => View();
}
