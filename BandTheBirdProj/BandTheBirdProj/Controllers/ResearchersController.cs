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
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore;

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

        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var researcher = _context.Researcher.Where(r => r.IdentityUserId == userId).SingleOrDefault();

            if (researcher == null)
            {
                return NotFound();
            }

            return View(researcher);
        }

 
        public ActionResult Create()
        {
            return View();
        }


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
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var researcher = await _context.Researcher.FindAsync(id);

            if (researcher == null)
            {
                return NotFound();
            }

            return View(researcher);        
        }

        // POST: Researchers/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? id, Researcher researcher)
        {
           if (id != researcher.ResearchId)
            {
                return NotFound();
            }

           if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(researcher);
                    await _context.SaveChangesAsync();
                }

                catch (DbUpdateConcurrencyException)
                {
                    if (!ResearcherExists(researcher.ResearchId))
                    {
                        return NotFound();
                    }

                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));                 
            }
            return View(researcher);
        }

        private bool ResearcherExists(int id)
        {
            return _context.Researcher.Any(e => e.ResearchId == id);
        }
    }
}