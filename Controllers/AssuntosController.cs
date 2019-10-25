using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Getec.PortalSef.Database;
using Getec.PortalSef.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Getec.PortalSef.Admin.Web.Controllers
{
    public class AssuntosController : Controller
    {
        private readonly SefDbContext _db;

        public AssuntosController(SefDbContext context)
        {
            _db = context;
        }
        // GET: Assuntos
        public IActionResult Index()
        {
            var assuntos = _db.Assuntos.ToList();
            ViewBag.Entidades = _db.Entidades.ToList();
            ViewBag.Gerencias = _db.Gerencias.ToList();
            ViewBag.Sistemas = _db.Sistemas.ToList();
            ViewBag.Modulos = _db.Modulos.ToList();
            return View();
        }

        // GET: Assuntos/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Assuntos/Create
        public IActionResult Create()
        {
            var assuntos = _db.Assuntos.ToList();
            ViewBag.Entidades = _db.Entidades.ToList();
            ViewBag.Gerencias = _db.Gerencias.ToList();
            ViewBag.Sistemas = _db.Sistemas.ToList();
            ViewBag.Modulos = _db.Modulos.ToList();
            return View(assuntos);
        }

        // POST: Assuntos/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Assuntos/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Assuntos/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Assuntos/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Assuntos/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}