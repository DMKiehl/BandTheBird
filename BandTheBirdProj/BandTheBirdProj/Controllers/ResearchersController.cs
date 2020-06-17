using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BandTheBirdProj.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BandTheBirdProj.Controllers
{
    public class ResearchersController : Controller
    {

        private readonly ApplicationDbContext _context;

        public ResearchersController(ApplicationDbContext context)
        {
            _context = context;
        }
        // GET: Researchers
        public ActionResult Index()
        {
            return View();
        }

        // GET: Researchers/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Researchers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Researchers/Create
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

        // GET: Researchers/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Researchers/Edit/5
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

        // GET: Researchers/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Researchers/Delete/5
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