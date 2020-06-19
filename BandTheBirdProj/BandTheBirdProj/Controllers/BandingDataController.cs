using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using BandTheBirdProj.Contracts;
using BandTheBirdProj.Data;
using BandTheBirdProj.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BandTheBirdProj.Controllers
{
    public class BandingDataController : Controller
    {
        private readonly ApplicationDbContext _context;
        private IAPIService _apiCalls;

        public BandingDataController(ApplicationDbContext context, IAPIService apiCalls)
        {
            _context = context;
            _apiCalls = apiCalls;
            
        }
        // GET: BandingData
        public ActionResult Index()
        {
            return View();
        }

        // GET: BandingData/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: BandingData/Create
        public ActionResult CreateBird()
        {
            return View();
        }

        // POST: BandingData/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateBird(BandingData data)
        {
            try
            {
                var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
                data.IdentityUserId = userId;
                var site = _context.ResearchSite.Where(r => r.SiteId == data.SiteId).SingleOrDefault();
                data.SiteName = site.SiteName;
                _context.BandingData.Add(data);
                _context.SaveChanges();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public async Task<IActionResult> CreateBiological()

        public ActionResult AddEnvironment()
        {
            var items = _context.ResearchSite.ToList();
            if (items != null)
            {
                ViewBag.Sites = items;
            }
            return View();
        }

        [HttpPost, ActionName("AddEnvironment")]

        public IActionResult AddEnvironment(Environmental environmental)
        {
            var site = _context.ResearchSite.Where(r => r.SiteId == environmental.SiteId).SingleOrDefault();
            environmental.SiteName = site.SiteName;

            _context.Environmental.Add(environmental);
            _context.SaveChanges();
            
            return RedirectToAction("Index", "Researchers");
        }

        public async Task<IActionResult> SelectSpecies()
        {
            var species = await _apiCalls.GetSpecies();
            ViewBag.Species = species;
            return View();
        }

        //public ActionResult ViewData()
        //{
        //    BandingViewModel bandingViewModel = new BandingViewModel();
        //    bandingViewModel.BandingData = _context.
        //}
    }
}