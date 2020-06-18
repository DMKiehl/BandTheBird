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
using Microsoft.Extensions.DependencyInjection;
using System.Net.Http;
using Newtonsoft.Json;
using System.Text;

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

        public async Task<IActionResult> AllSpecies()
        {
            List<Species> species = await _apiCalls.GetSpecies();
            return View(species);
        }

        public IActionResult AddSpecies()
        {
            return View();
        }

        [HttpPost, ActionName("AddSpecies")]

        public async Task<IActionResult> AddSpecies(Species species)
        {
            using var client = new HttpClient();
            var url = "https://localhost:44304/api/Species";
            var json = JsonConvert.SerializeObject(species);
            var data = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await client.PostAsync(url, data);

            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("AllSpecies");
            }

            return RedirectToAction("AddSpecies");

            
        }

        public ActionResult AddSite()
        {
            return View();
        }

        [HttpPost, ActionName("AddSite")]

        public async Task<IActionResult> AddSite(ResearchSite site)
        {
            var address = site.SiteStreetAddress + ", " + site.SiteCity + ", " + site.SiteState;
            GeoCode geocode = await _apiCalls.GoogleGeocoding(address);
            site.Latitude = geocode.results[0].geometry.location.lat;
            site.Longitude = geocode.results[0].geometry.location.lng;

            _context.ResearchSite.Add(site);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        public ActionResult AllSites()
        {
            IQueryable<ResearchSite> sites = _context.ResearchSite;
            return View(sites);
        }

        public ActionResult EditSite(int id)
        {
            var site = _context.ResearchSite.Where(r => r.SiteId == id).SingleOrDefault();
            return View(site);
        }

        public async Task<IActionResult> EditSite(ResearchSite site)
        {
            var researchSite = _context.ResearchSite.Where(r => r.SiteId == site.SiteId).SingleOrDefault();
            var address = site.SiteStreetAddress + ", " + site.SiteCity + ", " + site.SiteState;
            GeoCode geocode = await _apiCalls.GoogleGeocoding(address);
            researchSite.Latitude = geocode.results[0].geometry.location.lat;
            researchSite.Longitude = geocode.results[0].geometry.location.lng;
            researchSite.SiteCity = site.SiteCity;
            researchSite.SiteName = site.SiteName;
            researchSite.SiteState = site.SiteState;
            researchSite.SiteZip = site.SiteZip;
            researchSite.SiteStreetAddress = site.SiteStreetAddress;
            _context.SaveChanges();
            return RedirectToAction("AllSites");
        }
    }
}