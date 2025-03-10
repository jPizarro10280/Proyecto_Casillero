using FrontEnd.Helpers.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FrontEnd.Controllers
{
    public class DetalleFacturaController : Controller
    {
        IDetalleFacturaHelper _detalleFacturaHelper;
        public DetalleFacturaController(IDetalleFacturaHelper detalleFacturaHelper)
        {
            _detalleFacturaHelper = detalleFacturaHelper;
        }
        // GET: DetalleFacturaController
        public ActionResult Index()
        {
            var result = _detalleFacturaHelper.GetDetalleFacturas();
            return View(result);
        }

        // GET: DetalleFacturaController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: DetalleFacturaController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DetalleFacturaController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
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

        // GET: DetalleFacturaController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: DetalleFacturaController/Edit/5
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

        // GET: DetalleFacturaController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: DetalleFacturaController/Delete/5
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
