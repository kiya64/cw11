using Microsoft.AspNetCore.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class StorageController : Controller
    {
      Repository.Repository_Com repo = new Repository.Repository_Com();
        public IActionResult Index()
        {

            return View(sample_data.comList.commodities);
        }
        
        public IActionResult AddCom() {
            return View();

        }
        [HttpPost]
        public IActionResult AddCom(Commodity commodity)
        {
             repo.AddCom(commodity);
            return RedirectToAction("Index");

        }
        public IActionResult delCom(int id)
        {
            repo.DelCom(id);

            return RedirectToAction("Index");

        }
        public IActionResult UPCom(int id)
        {
         

            return View(repo.Get_id(id));
        }
        [HttpPost]
        public IActionResult UPCom(Commodity commodity)
        {

            repo.UpCom(commodity);
            return RedirectToAction("Index");
        }
    }
}
