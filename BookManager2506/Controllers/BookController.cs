using BookManager2506.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace BookManager2506.Controllers
{
    public class BookController : Controller
    {
        // GET: Book
        BookManagerContext context = new BookManagerContext();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ListBook()
        {
            var listBook = context.Saches.ToList();
            return View(listBook);
        }
        [Authorize]
        public ActionResult Create()
        {
            return View();
        }

  
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Author,Tittle,Description,ImageCover,Price")] Sach sach)
        {
            if (ModelState.IsValid)
            {
                context.Saches.Add(sach);
                context.SaveChanges();
                return RedirectToAction("ListBook");

            }

            return View(sach);
        }


        [Authorize]
        public ActionResult Buy(int id)
        {
            BookManagerContext context = new BookManagerContext();
            Sach book = context.Saches.SingleOrDefault(p => p.Id == id);
            if (book == null)
            {
                return HttpNotFound();
            }
            return View(book);
        }

        [Authorize]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sach dbEdit = context.Saches.Find(id);
            dbEdit = context.Saches.Find(id);

            if (dbEdit == null)
            {
                return HttpNotFound();
            }
            return View(dbEdit);
        }

        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Author,Tittle,Description,ImageCover,Price")] Sach dbEdit)
        {

            if (ModelState.IsValid)
            {
                context.Saches.AddOrUpdate(dbEdit);
                context.SaveChanges();
                return RedirectToAction("ListBook");
            }

            return View(dbEdit);
        }
        [Authorize]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sach dbDelete = context.Saches.Find(id);
            dbDelete = context.Saches.Find(id);
            if (dbDelete == null)
            {
                return HttpNotFound();
            }
            return View(dbDelete);
        }

        // POST: Books/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Sach dbDelete = context.Saches.Find(id);
            context.Saches.Remove(dbDelete);
            context.SaveChanges();
            return RedirectToAction("ListBook");
        }
    }
}
  
  
   

