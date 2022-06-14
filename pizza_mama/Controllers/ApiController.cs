using Microsoft.AspNetCore.Mvc;
using pizza_mama.Data;
using pizza_mama.Models;
using System.Collections.Generic;
using System.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace pizza_mama.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ApiController : Controller
    {

        DataContext datacontext;
        public ApiController(DataContext dataContext)
        {
            this.datacontext = dataContext;
        }


        [HttpGet]
        [Route("GetPizzas")]
        public IActionResult GetPizzas()
        {
            //var pizza = new Pizza() { nom = "pizza_test", prix = 8, vegetarienne = false, ingredients = "tomate, oignons, oeuf" };


            var pizzas = datacontext.Pizzas.ToList();

            return Json(pizzas);
        }

    }
}
