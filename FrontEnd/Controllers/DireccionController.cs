using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using FrontEnd.Helpers.Interfaces;
using FrontEnd.Models;
using Microsoft.AspNetCore.Authorization;

namespace FrontEnd.Controllers
{
    [Authorize]
    public class DireccionController : Controller
    {
        IDireccionHelper _direccionHelper;
        
        public DireccionController (IDireccionHelper direccionHelper)
        {
            _direccionHelper = direccionHelper;
        }

        // GET: DireccionController
        public ActionResult Index()
        {
            var result = _direccionHelper.GetDir();
            return View(result);
        }

        // GET: DireccionController/Details/5
        public ActionResult Details(int id)
        {
            var result = _direccionHelper.GetByID(id);
            return View(result);
        }
        // GET: DireccionController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DireccionController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(DireccionViewModel direccion)
        {
            try
            {
                _direccionHelper.Add(direccion);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: DireccionController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: DireccionController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: DireccionController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: DireccionController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
