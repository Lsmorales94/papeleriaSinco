using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Sinco.Context;
using Sinco.Models;

namespace Sinco.Controllers
{
    public class PedidoDescripsController : Controller
    {
        private Contexto db = new Contexto();

        // GET: PedidoDescrips
        public ActionResult Index()
        {
            return View(db.Pedidos.ToList());
        }

        // GET: PedidoDescrips/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PedidoDescrip pedidoDescrip = db.Pedidos.Find(id);
            if (pedidoDescrip == null)
            {
                return HttpNotFound();
            }
            return View(pedidoDescrip);
        }

        // GET: PedidoDescrips/Create
        public ActionResult Create()
        {
                       
             IEnumerable<SelectListItem> person = db.Personas        
             .Select(persona => new SelectListItem { Value = persona.codigo.ToString(), Text = persona.nombre });
            ViewBag.personaList = person;
            var model = new PedidoDescrip();
            model.fecha = DateTime.Parse(DateTime.Now.ToShortDateString());
            // ViewBag.personList = new System.Web.Mvc.SelectList(db.Personas.ToList(), "codigo", "nombre");

            IEnumerable<SelectListItem> arti = db.Articulos
             .Select(articulos => new SelectListItem { Value = articulos.nombre.ToString(), Text = articulos.nombre });
            ViewBag.articuloList = arti;

            return View(model);
        }

        // POST: PedidoDescrips/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(PedidoDescrip pedidoDescrip,String personaList)
        {
            if (ModelState.IsValid)
            {
               pedidoDescrip.idUsuario = Int32.Parse(personaList);
                db.Pedidos.Add(pedidoDescrip);               
                                             

                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(pedidoDescrip);
        }


        // GET: PedidoDescrips/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PedidoDescrip pedidoDescrip = db.Pedidos.Find(id);
            if (pedidoDescrip == null)
            {
                return HttpNotFound();
            }
            return View(pedidoDescrip);
        }

        // POST: PedidoDescrips/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,idUsuario,fecha,concepto")] PedidoDescrip pedidoDescrip)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pedidoDescrip).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(pedidoDescrip);
        }

        // GET: PedidoDescrips/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PedidoDescrip pedidoDescrip = db.Pedidos.Find(id);
            if (pedidoDescrip == null)
            {
                return HttpNotFound();
            }
            return View(pedidoDescrip);
        }

        // POST: PedidoDescrips/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PedidoDescrip pedidoDescrip = db.Pedidos.Find(id);
            db.Pedidos.Remove(pedidoDescrip);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
