using Microsoft.AspNetCore.Mvc;

namespace FirstProject.Controllers {
    public class ConverterController : Controller {
        public IActionResult convert(double usd) {
            Models.Converter converter = new Models.Converter();
            converter.convertUSDtoVND(usd);
            return View("myview",converter);
        }
        public IActionResult Index()
            {
             return View("myview");
            }
    }
}
