using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace WebApplication1.Controllers
{
    public class JimController : Controller
    {
        // 
        // GET: /Jim

        public IActionResult Index()
        {
            return View();
        }

        // 
        // GET: /Jim/Welcome

        public string Welcome()
        {
            return "This is the Welcome action method...";
        }
    }
}