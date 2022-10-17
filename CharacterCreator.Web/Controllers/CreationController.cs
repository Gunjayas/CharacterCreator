using CharacterCreator.Data.Models;
using CharacterCreator.Data.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CharacterCreator.Web.Controllers
{
    public class CreationController : Controller
    {
        private readonly ICharacterData db;
        public CreationController(ICharacterData db)
        {
            this.db = db;
        }
        public ActionResult Index()
        {
            var model = db.GetAll();
            return View(model);
        }
        [HttpGet]
        public ActionResult Details(int id)
        {
            var model = db.Get(id);
            return View(model);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult Create(Character character)
        {
            if (ModelState.IsValid)
            {
                db.Add(character);
                return RedirectToAction("Details", new { id = character.Id });
            }
            return View();

        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            var model = db.Get(id);
            if (model == null)
            {
                return View("NotFound");
            }
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Character character)
        {
            if (ModelState.IsValid)
            {
                db.Update(character);
                return RedirectToAction("Details", new { id = character.Id });
            }
            return View();
        }
        [HttpGet]
        public ActionResult Delete(int id)
        {
            var model=db.Get(id);
            if (ModelState.IsValid)
            {
                return View(model);
            }
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id,FormCollection form)
        {

        }

    }
}