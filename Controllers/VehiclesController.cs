using Microsoft.AspNetCore.Mvc;
using WestCoast_Cars.Models;
using WestCoast_Cars.ViewModels;

namespace WestCoast_Cars.Controllers
{
    [Route("vehicles")]
    public class VehiclesController : Controller
    {
        private readonly VehicleModel _model;
        // dependency/contructor injection
        public VehiclesController(VehicleModel model){
            _model = model;
        }
        // GET: VehiclesController

        public async Task<ActionResult> Index()
        {
            // VehicleModel model = new VehicleModel();
            List<VehicleViewModel> vehicleList = await _model.GetVehicles();
            return View("Index", vehicleList);
        }
        
        [HttpGet("details/{id}")]
        public IActionResult Details (int id)
        {
            // VehicleModel model = new();
            VehicleViewModel vehicle = _model.Find(id);
            return View("Details", vehicle);
        }
        

        [HttpDelete("delete/{id}")]
        public IActionResult Delete(int id){
            ViewBag.Message = "Finns inte längre";
            return View("Details");
        }

        //parvisa action metoder för att först hämta ett inmatningsformulär
        // och en för att skicka in nytt data(ny bil)
        [HttpGet("create")]
        public IActionResult Create(){
            //skapa ett nytt objekt av typen VehicleModel och skicka till vy(Create)
            VehicleViewModel vehicle = new();
            return View("Create", vehicle);
        }
        
        [HttpPost("create")]
        public IActionResult Create(VehicleViewModel vehicle){
            return RedirectToAction("Index");
        }
    }
}
