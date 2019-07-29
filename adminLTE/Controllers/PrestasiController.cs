using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using adminLTE.Models;

namespace adminLTE.Controllers
{
    public class PrestasiController : Controller
    {
        private readonly PrestasiContext _context;

        public PrestasiController(PrestasiContext context)
        {
            _context = context;
        }

        // GET: Anggota
        public async Task<IActionResult> Daftarprestasi()
        {
            return View(await _context.Prestasis.ToListAsync());
        }

        // GET: Anggota/Create
        public IActionResult AddorEdit(int id = 0)
        {
            if (id == 0)
                return View(new Prestasi());
            else
                return View(_context.Prestasis.Find(id));
        }

        // POST: Anggota/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddOrEdit([Bind("PrestasiID,Nama,NamaPrestasi,Tahun,Kegiatan")] Prestasi prestasi)
        {
            if (ModelState.IsValid)
            {
                if (prestasi.PrestasiID == 0)
                    _context.Add(prestasi);
                else
                    _context.Update(prestasi);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Daftarprestasi));
            }
            return View(prestasi);
        }

        // GET: Anggota/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            var prestasi = await _context.Prestasis.FindAsync(id);
            _context.Prestasis.Remove(prestasi);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Daftarprestasi));
        }

    }
}
