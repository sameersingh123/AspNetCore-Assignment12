using Microsoft.AspNetCore.Mvc;
using Assignment12.Models;
namespace Assignment12.Controllers
{
    public class HomeController : Controller
    {
        [Route("/order")]
        public IActionResult Index([Bind(nameof(Order.OrderDate), nameof(Order.InvoicePrice), nameof(Order.Products))] Order order)
        {
            if (ModelState.IsValid == false)
            {
                string errors = string.Join("\n", ModelState.Values.SelectMany(value => value.Errors).Select(err => err.ErrorMessage));
                return BadRequest(errors);
            }

            Random random = new Random();
            int randonOrderNumber = random.Next(1, 99999);

            return Json(new {OrderNumber= randonOrderNumber});

        }
    }
}
