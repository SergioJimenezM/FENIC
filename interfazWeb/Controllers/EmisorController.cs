using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LogicaDeNegocio;
namespace interfazWeb.Controllers
{
    public class EmisorController : Controller
    {
        // GET: Emisor
        public ActionResult Index()
        {
            Emisor operacionEmisor = new Emisor();
            var lista = operacionEmisor.Listar();

            return View(lista);
        }

        // GET: Emisor/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Emisor/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Emisor/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Emisor/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Emisor/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Emisor/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Emisor/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
