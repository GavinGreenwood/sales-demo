using Microsoft.AspNetCore.Mvc;
using SalesDemo.Web.Controllers;

namespace SalesDemo.Web.Public.Controllers
{
    public class HomeController : SalesDemoControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}