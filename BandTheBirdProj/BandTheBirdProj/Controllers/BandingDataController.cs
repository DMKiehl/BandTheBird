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
            var items = _context.ResearchSite.ToList();
            if (items != null)
            {
                ViewBag.Sites = items;
            }
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

                return RedirectToAction("CreateBiological", data);
            }
            catch
            {
                return View();
            }
        }

        public async Task<IActionResult> CreateBiological(BandingData data)
        {
            BiologicalViewModel viewModel = new BiologicalViewModel();
            BiologicalData bioData = new BiologicalData();
            viewModel.BiologicalData = bioData;
            viewModel.BiologicalData.BirdId = data.BirdId;
            viewModel.VerifyData = false;

            var species = await _apiCalls.GetSpecies();
            var bird = species.Where(s => s.alphaCode == data.AlphaCode).SingleOrDefault();
            viewModel.Species = bird;

            ViewData["wasInvalid"] = false;
            return View(viewModel);

        }

        [HttpPost, ActionName("CreateBiological")]

        public ActionResult CreateBiological(BiologicalViewModel viewModel)
        {
            var validate = ValidateData(viewModel);

            if (validate == false || viewModel.VerifyData == true)
            {
                _context.BiologicalData.Add(viewModel.BiologicalData);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }


            ViewData["wasInvalid"] = true;
            ViewData["InvalidMessage"] = "One or more measurements are outside of the normal range for this species. Please review wing, tail and exposed culmen measurements. For " + viewModel.Species.alphaCode + " the wing chord should be between " + viewModel.Species.minWing +  " - " + viewModel.Species.maxWing + ". Tail should be between " + 
                viewModel.Species.minTail + " - " + viewModel.Species.maxTail + ". Culmen should be between " + viewModel.Species.minCulmen + " - " + viewModel.Species.maxCulmen + ". If measurements are correct but outside of the normal range please check the box below to verify that the data is correct.";

            return View(viewModel);
           
            


        }

        private bool ValidateData(BiologicalViewModel viewModel)
        {
            if (viewModel.BiologicalData.WingChord < viewModel.Species.minWing || viewModel.BiologicalData.WingChord > viewModel.Species.maxWing)
            {
                return true;
            }
            else if (viewModel.BiologicalData.TailLength < viewModel.Species.minTail || viewModel.BiologicalData.TailLength > viewModel.Species.maxTail)
            {
                return true;
            }
            else if (viewModel.BiologicalData.ExposedCulmen < viewModel.Species.minCulmen || viewModel.BiologicalData.ExposedCulmen > viewModel.Species.maxCulmen)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

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

      

        //public ActionResult ViewData()
        //{
        //    BandingViewModel bandingViewModel = new BandingViewModel();
        //    bandingViewModel.BandingData = _context.
        //}
    }
}