using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using BandTheBirdProj.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BandTheBirdProj.Models;
using BandTheBirdProj.Contracts;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BandTheBirdProj.Controllers
{
    public class ResearchersController : Controller
    {

        private readonly ApplicationDbContext _context;
        private IAPIService _apiCalls;

        public ResearchersController(ApplicationDbContext context, IAPIService apiCalls)
        {
            _context = context;
            _apiCalls = apiCalls;
        }
        // GET: Researchers
        public async Task<IActionResult> Index()
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var researcherProfile = _context.Researcher.Where(r => r.IdentityUserId == userId).ToList();

            if (researcherProfile.Count == 0)
            {
                return RedirectToAction("Create", "Researchers");
            }
            var researcher = _context.Researcher.Where(r => r.IdentityUserId == userId).SingleOrDefault();
            CurrentWeather weather = await _apiCalls.GetCurrentWeather(researcher.ResearchSiteZip);
            return View(weather);
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
        public async Task<IActionResult> Create(Researcher researcher)
        {
            if (ModelState.IsValid)
            {
                var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
                researcher.IdentityUserId = userId;
                _context.Add(researcher);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewData["IdentityUserId"] = new SelectList(_context.Users, "Id", "Id", researcher.IdentityUserId);
            return View(researcher);
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