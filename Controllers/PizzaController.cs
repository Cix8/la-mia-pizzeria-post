using la_mia_pizzeria_static.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace la_mia_pizzeria_static.Controllers
{
    public class PizzaController : Controller
    {
        private readonly ILogger<PizzaController> _logger;

        public PizzaController(ILogger<PizzaController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            List<Pizza> pizzaList = new List<Pizza>();

            Pizza firstPizza = new Pizza("Margherita", "La classica pizza napoletana", "pizza-margherita.jfif", 5.99);
            Pizza secondPizza = new Pizza("Capricciosa", "La pizza capricciosa è una pizza tipica della cucina italiana caratterizzata da un condimento di pomodoro, mozzarella, prosciutto cotto, funghi, olive verdi e nere, e carciofini", "pizza-capricciosa.jfif", 7.99);
            Pizza thirdPizza = new Pizza("Salame Piccante", "Pizza base margherita con aggiunta di salame piccante", "pizza-salame.jfif", 6.99);

            pizzaList.Add(firstPizza);
            pizzaList.Add(secondPizza);
            pizzaList.Add(thirdPizza);

            return View(pizzaList);
        }

        public IActionResult Details(int id)
        {
            List<Pizza> pizzaList = new List<Pizza>();

            Pizza firstPizza = new Pizza("Margherita", "La classica pizza napoletana", "pizza-margherita.jfif", 5.99);
            Pizza secondPizza = new Pizza("Capricciosa", "La pizza capricciosa è una pizza tipica della cucina italiana caratterizzata da un condimento di pomodoro, mozzarella, prosciutto cotto, funghi, olive verdi e nere, e carciofini", "pizza-capricciosa.jfif", 7.99);
            Pizza thirdPizza = new Pizza("Salame Piccante", "Pizza base margherita con aggiunta di salame piccante", "pizza-salame.jfif", 6.99);

            pizzaList.Add(firstPizza);
            pizzaList.Add(secondPizza);
            pizzaList.Add(thirdPizza);

            return View("Show", pizzaList[id]);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}