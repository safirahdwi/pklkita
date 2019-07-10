using adminLTE.Data;
using adminLTE.Data.Repository;
using adminLTE.Models;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace adminLTE.Controllers
{
    public class HomeController : Controller
    {
        private IRepository _repo;

        public HomeController(IRepository repo)
        {
            _repo = repo;
        }

        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Profile()
        {
            return View();
        }

        public IActionResult Beranda()
        {
            var publikasis = _repo.GetAllPublikasis();
            return View(publikasis);
        }
        public IActionResult Daftaranggota()
        {
            return View();
        }

        public  IActionResult editPublikasi(int id)
        {
            var editPublikasi = _repo.GetPublikasi(id);
            return View(editPublikasi);
        } 
       
        public IActionResult KalenderKegiatan()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Publikasi(int? id)
        {
            if(id==null)
                return View(new editPublikasi());
            else
            {
                var publikasi = _repo.GetPublikasi((int)id);
                return View(publikasi);
            }
        }


        [HttpPost]
        public async Task<IActionResult> Publikasi(editPublikasi publikasi)
        {
            if (publikasi.Id > 0)
                _repo.UpdatePublikasi(publikasi);
            else
                _repo.AddPublikasi(publikasi);

            if (await _repo.SaveChangesAsync())
                return RedirectToAction("Beranda");
            else
                return View(publikasi);
        }
        [HttpGet]
        public async Task<IActionResult> Remove(int id)
        {
            _repo.RemovePublikasi(id);
            await _repo.SaveChangesAsync();
            return RedirectToAction("Beranda");
        }
    }
}