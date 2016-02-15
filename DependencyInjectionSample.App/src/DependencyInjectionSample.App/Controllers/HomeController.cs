using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using ThatCSharpGuy.Sample.Services;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace DependencyInjectionSample.App.Controllers
{
    public class HomeController : Controller
    {
        private readonly IOnlineQrService _onlineQrService;

        public HomeController(IOnlineQrService onlineQrService)
        {
            _onlineQrService = onlineQrService;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            ViewBag.ServiceUsed = _onlineQrService.Name;
            ViewBag.QrUrl = _onlineQrService.GetUrl("Hola mundo!", 300);
            return View();
        }
    }
}
