using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography.Xml;
using System.Threading.Tasks;
using BandTheBirdProj.Contracts;
using BandTheBirdProj.Data;
using BandTheBirdProj.Models;
using ClosedXML.Excel;
using DocumentFormat.OpenXml.Bibliography;
using DocumentFormat.OpenXml.Spreadsheet;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Web;
using Microsoft.AspNetCore.Hosting;
using DocumentFormat.OpenXml.EMMA;

namespace BandTheBirdProj.Controllers
{
    public class BandingDataController : Controller
    {
        private readonly ApplicationDbContext _context;
        private IAPIService _apiCalls;
        public DateTime today;
        private readonly IWebHostEnvironment webHostEnvironment;

        public BandingDataController(ApplicationDbContext context, IAPIService apiCalls, IWebHostEnvironment hostEnvironment)
        {
            _context = context;
            _apiCalls = apiCalls;
            today = DateTime.Today;
            webHostEnvironment = hostEnvironment;

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
        public async Task<IActionResult> CreateBird()
        {
            //ViewBag.Species = new SelectList(species, "alphaCode", "alphaCode");
            var items = _context.ResearchSite;
            ViewBag.Sites = new SelectList(items, "SiteId", "SiteName");
            var type = _context.BandType;
            ViewBag.Type = new SelectList(type, "Code", "Name");
            ViewBag.Size = new SelectList(_context.BandSize, "Size", "Size");
            var species = await _apiCalls.GetSpecies();
            ViewBag.Species = new SelectList(species, "alphaCode", "alphaCode");
            ViewBag.Names = new SelectList(species, "speciesName", "speciesName");
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

            ViewBag.Age = new SelectList(_context.Age, "Id", "Name");
            ViewBag.Sex = new SelectList(_context.Sex, "Code", "Name");
            ViewBag.How = new SelectList(_context.HowAgeSex, "Code", "Name");
            ViewBag.Skull = new SelectList(_context.Skull, "Id", "Name");
            ViewBag.ClP = new SelectList(_context.CP, "Id", "Name");
            ViewBag.BrP = new SelectList(_context.BP, "Code", "Name");
            ViewBag.fat = new SelectList(_context.Fat, "Code", "Name");
            ViewBag.BM = new SelectList(_context.BodyMolt, "Code", "Name");
            ViewBag.FM = new SelectList(_context.FlightMolt, "Code", "Name");
            ViewBag.FW = new SelectList(_context.FlightWear, "Code", "Name");

            ViewData["wasInvalid"] = false;
            return View(viewModel);

        }

        [HttpPost, ActionName("CreateBiological")]

        public ActionResult CreateBiological(BiologicalViewModel viewModel)
        {
            var validate = ValidateData(viewModel);

            if (validate == false || viewModel.VerifyData == true)
            {
                if (viewModel.BiologicalData.Skull == 10)
                {
                    viewModel.BiologicalData.Skull = 0;
                }
                if (viewModel.BiologicalData.Age == 3)
                {
                    viewModel.BiologicalData.Age = 0;
                }
                if (viewModel.BiologicalData.CloacalProtuberance == 4)
                {
                    viewModel.BiologicalData.CloacalProtuberance = 0;
                }
                _context.BiologicalData.Add(viewModel.BiologicalData);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewData["wasInvalid"] = true;
            ViewData["InvalidMessage"] = "One or more measurements are outside of the normal range for this species. Please review wing, tail and exposed culmen measurements. For " + viewModel.Species.alphaCode + " the wing chord should be between " + viewModel.Species.minWing + " - " + viewModel.Species.maxWing + ". Tail should be between " +
                viewModel.Species.minTail + " - " + viewModel.Species.maxTail + ". Culmen should be between " + viewModel.Species.minCulmen + " - " + viewModel.Species.maxCulmen + ". If measurements are correct but outside of the normal range please check the box below to verify that the data is correct.";
          
            ViewBag.Age = new SelectList(_context.Age, "Id", "Name");
            ViewBag.Sex = new SelectList(_context.Sex, "Code", "Name");
            ViewBag.How = new SelectList(_context.HowAgeSex, "Code", "Name");
            ViewBag.Skull = new SelectList(_context.Skull, "Id", "Name");
            ViewBag.ClP = new SelectList(_context.CP, "Id", "Name");
            ViewBag.BrP = new SelectList(_context.BP, "Code", "Name");
            ViewBag.fat = new SelectList(_context.Fat, "Code", "Name");
            ViewBag.BM = new SelectList(_context.BodyMolt, "Code", "Name");
            ViewBag.FM = new SelectList(_context.FlightMolt, "Code", "Name");
            ViewBag.FW = new SelectList(_context.FlightWear, "Code", "Name");

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
            var items = _context.ResearchSite;
            ViewBag.Sites = new SelectList(items, "SiteId", "SiteName");


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



        public ActionResult ViewAllData(string AlphaSearch, string BandSearch)
        {
            var birds = _context.BiologicalData.ToList();
            foreach (var item in birds)
            {
                BiologicalData bioData = new BiologicalData();
                var band = _context.BandingData.Where(b => b.BirdId == item.BirdId).SingleOrDefault();
                bioData.BandingData = band;

            }
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var researcherBirds = birds.Where(b => b.BandingData.IdentityUserId == userId);

            if (!String.IsNullOrEmpty(AlphaSearch))
            {
                researcherBirds = researcherBirds.Where(r => r.BandingData.AlphaCode.Contains(AlphaSearch));
            }

            if (!String.IsNullOrEmpty(BandSearch))
            {
                researcherBirds = researcherBirds.Where(r => r.BandingData.BandSize.Contains(BandSearch));
            }

            return View(researcherBirds);

        }

        public IEnumerable<BiologicalData> getAllData()
        {
            var birds = _context.BiologicalData.ToList();
            foreach (var item in birds)
            {
                BiologicalData bioData = new BiologicalData();
                var band = _context.BandingData.Where(b => b.BirdId == item.BirdId).SingleOrDefault();
                bioData.BandingData = band;

            }

            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var researcherBirds = birds.Where(b => b.BandingData.IdentityUserId == userId).ToList();

            return researcherBirds;

        }

        public IEnumerable<BiologicalData> getTodayData()
        {
            var birds = _context.BiologicalData.ToList();
            foreach (var item in birds)
            {
                BiologicalData bioData = new BiologicalData();
                var band = _context.BandingData.Where(b => b.BirdId == item.BirdId).SingleOrDefault();
                bioData.BandingData = band;

            }

            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var researcherBirds = birds.Where(b => b.BandingData.IdentityUserId == userId).ToList();
            researcherBirds = researcherBirds.Where(b => b.BandingData.CaptureDate == today).ToList();

            return researcherBirds;
        }

        public ActionResult ExportAllData()
        {
            IEnumerable<BiologicalData> data = getAllData();
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Data");
                var currentRow = 1;
                worksheet.Cell(currentRow, 1).Value = "Band Number";
                worksheet.Cell(currentRow, 2).Value = "Capture Date";
                worksheet.Cell(currentRow, 3).Value = "Alpha Code";
                worksheet.Cell(currentRow, 4).Value = "Species Name";
                worksheet.Cell(currentRow, 5).Value = "Bander Intials";
                worksheet.Cell(currentRow, 6).Value = "Capture Time";
                worksheet.Cell(currentRow, 7).Value = "Net Number";
                worksheet.Cell(currentRow, 8).Value = "Band Type";
                worksheet.Cell(currentRow, 9).Value = "Band Size";
                worksheet.Cell(currentRow, 10).Value = "Site Name";
                worksheet.Cell(currentRow, 11).Value = "Age";
                worksheet.Cell(currentRow, 12).Value = "How Aged";
                worksheet.Cell(currentRow, 13).Value = "Sex";
                worksheet.Cell(currentRow, 14).Value = "How Sexed";
                worksheet.Cell(currentRow, 15).Value = "CP";
                worksheet.Cell(currentRow, 16).Value = "BP";
                worksheet.Cell(currentRow, 17).Value = "Skull";
                worksheet.Cell(currentRow, 18).Value = "Fat";
                worksheet.Cell(currentRow, 19).Value = "Body Molt";
                worksheet.Cell(currentRow, 20).Value = "Flight Feather Molt";
                worksheet.Cell(currentRow, 21).Value = "Flight Feather Wear";
                worksheet.Cell(currentRow, 22).Value = "Mass";
                worksheet.Cell(currentRow, 23).Value = "Wing Chord";
                worksheet.Cell(currentRow, 24).Value = "Tail Length";
                worksheet.Cell(currentRow, 25).Value = "Exposed Culmen";
                worksheet.Cell(currentRow, 26).Value = "Tarsus";
                worksheet.Cell(currentRow, 27).Value = "Notes";

                foreach (var bird in data)
                {
                    currentRow++;
                    worksheet.Cell(currentRow, 1).Value = bird.BandingData.BandNumber;
                    worksheet.Cell(currentRow, 2).Value = bird.BandingData.CaptureDate;
                    worksheet.Cell(currentRow, 3).Value = bird.BandingData.AlphaCode;
                    worksheet.Cell(currentRow, 4).Value = bird.BandingData.SpeciesName;
                    worksheet.Cell(currentRow, 5).Value = bird.BandingData.BanderIntials;
                    worksheet.Cell(currentRow, 6).Value = bird.BandingData.CaptureTime;
                    worksheet.Cell(currentRow, 7).Value = bird.BandingData.NetNumber;
                    worksheet.Cell(currentRow, 8).Value = bird.BandingData.BandType;
                    worksheet.Cell(currentRow, 9).Value = bird.BandingData.BandSize;
                    worksheet.Cell(currentRow, 10).Value = bird.BandingData.SiteName;
                    worksheet.Cell(currentRow, 11).Value = bird.Age;
                    worksheet.Cell(currentRow, 12).Value = bird.HowAged;
                    worksheet.Cell(currentRow, 13).Value = bird.Sex;
                    worksheet.Cell(currentRow, 14).Value = bird.HowSexed;
                    worksheet.Cell(currentRow, 15).Value = bird.CloacalProtuberance;
                    worksheet.Cell(currentRow, 16).Value = bird.BroodPatch;
                    worksheet.Cell(currentRow, 17).Value = bird.Skull;
                    worksheet.Cell(currentRow, 18).Value = bird.Fat;
                    worksheet.Cell(currentRow, 19).Value = bird.BodyMolt;
                    worksheet.Cell(currentRow, 20).Value = bird.FlightFeatherMolt;
                    worksheet.Cell(currentRow, 21).Value = bird.FlightFeatherWear;
                    worksheet.Cell(currentRow, 22).Value = bird.Mass;
                    worksheet.Cell(currentRow, 23).Value = bird.WingChord;
                    worksheet.Cell(currentRow, 24).Value = bird.TailLength;
                    worksheet.Cell(currentRow, 25).Value = bird.ExposedCulmen;
                    worksheet.Cell(currentRow, 26).Value = bird.Tarsus;
                    worksheet.Cell(currentRow, 27).Value = bird.Notes;
                }

                using (var stream = new MemoryStream())
                {
                    workbook.SaveAs(stream);
                    var content = stream.ToArray();

                    return File(
                        content, "application/vnd.openxmlformats-officedocument.spreadsheet.sheet", "data.xlsx");
                }
            }

        }

        public ActionResult ExportTodayData()
        {
            IEnumerable<BiologicalData> data = getTodayData();
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Data");
                var currentRow = 1;
                worksheet.Cell(currentRow, 1).Value = "Band Number";
                worksheet.Cell(currentRow, 2).Value = "Capture Date";
                worksheet.Cell(currentRow, 3).Value = "Alpha Code";
                worksheet.Cell(currentRow, 4).Value = "Species Name";
                worksheet.Cell(currentRow, 5).Value = "Bander Intials";
                worksheet.Cell(currentRow, 6).Value = "Capture Time";
                worksheet.Cell(currentRow, 7).Value = "Net Number";
                worksheet.Cell(currentRow, 8).Value = "Band Type";
                worksheet.Cell(currentRow, 9).Value = "Band Size";
                worksheet.Cell(currentRow, 10).Value = "Site Name";
                worksheet.Cell(currentRow, 11).Value = "Age";
                worksheet.Cell(currentRow, 12).Value = "How Aged";
                worksheet.Cell(currentRow, 13).Value = "Sex";
                worksheet.Cell(currentRow, 14).Value = "How Sexed";
                worksheet.Cell(currentRow, 15).Value = "CP";
                worksheet.Cell(currentRow, 16).Value = "BP";
                worksheet.Cell(currentRow, 17).Value = "Skull";
                worksheet.Cell(currentRow, 18).Value = "Fat";
                worksheet.Cell(currentRow, 19).Value = "Body Molt";
                worksheet.Cell(currentRow, 20).Value = "Flight Feather Molt";
                worksheet.Cell(currentRow, 21).Value = "Flight Feather Wear";
                worksheet.Cell(currentRow, 22).Value = "Mass";
                worksheet.Cell(currentRow, 23).Value = "Wing Chord";
                worksheet.Cell(currentRow, 24).Value = "Tail Length";
                worksheet.Cell(currentRow, 25).Value = "Exposed Culmen";
                worksheet.Cell(currentRow, 26).Value = "Tarsus";
                worksheet.Cell(currentRow, 27).Value = "Notes";

                foreach (var bird in data)
                {
                    currentRow++;
                    worksheet.Cell(currentRow, 1).Value = bird.BandingData.BandNumber;
                    worksheet.Cell(currentRow, 2).Value = bird.BandingData.CaptureDate;
                    worksheet.Cell(currentRow, 3).Value = bird.BandingData.AlphaCode;
                    worksheet.Cell(currentRow, 4).Value = bird.BandingData.SpeciesName;
                    worksheet.Cell(currentRow, 5).Value = bird.BandingData.BanderIntials;
                    worksheet.Cell(currentRow, 6).Value = bird.BandingData.CaptureTime;
                    worksheet.Cell(currentRow, 7).Value = bird.BandingData.NetNumber;
                    worksheet.Cell(currentRow, 8).Value = bird.BandingData.BandType;
                    worksheet.Cell(currentRow, 9).Value = bird.BandingData.BandSize;
                    worksheet.Cell(currentRow, 10).Value = bird.BandingData.SiteName;
                    worksheet.Cell(currentRow, 11).Value = bird.Age;
                    worksheet.Cell(currentRow, 12).Value = bird.HowAged;
                    worksheet.Cell(currentRow, 13).Value = bird.Sex;
                    worksheet.Cell(currentRow, 14).Value = bird.HowSexed;
                    worksheet.Cell(currentRow, 15).Value = bird.CloacalProtuberance;
                    worksheet.Cell(currentRow, 16).Value = bird.BroodPatch;
                    worksheet.Cell(currentRow, 17).Value = bird.Skull;
                    worksheet.Cell(currentRow, 18).Value = bird.Fat;
                    worksheet.Cell(currentRow, 19).Value = bird.BodyMolt;
                    worksheet.Cell(currentRow, 20).Value = bird.FlightFeatherMolt;
                    worksheet.Cell(currentRow, 21).Value = bird.FlightFeatherWear;
                    worksheet.Cell(currentRow, 22).Value = bird.Mass;
                    worksheet.Cell(currentRow, 23).Value = bird.WingChord;
                    worksheet.Cell(currentRow, 24).Value = bird.TailLength;
                    worksheet.Cell(currentRow, 25).Value = bird.ExposedCulmen;
                    worksheet.Cell(currentRow, 26).Value = bird.Tarsus;
                    worksheet.Cell(currentRow, 27).Value = bird.Notes;
                }

                using (var stream = new MemoryStream())
                {
                    workbook.SaveAs(stream);
                    var content = stream.ToArray();

                    return File(
                        content, "application/vnd.openxmlformats-officedocument.spreadsheet.sheet", "data.xlsx");
                }
            }

        }

        public ActionResult ExportEnvironment()
        {
            var researchSites= _context.ResearchSite;
            ViewBag.Sites = new SelectList(researchSites, "SiteName", "SiteName");

            return View();

        }

        [HttpPost, ActionName("ExportEnvironment")]

        public ActionResult ExportEnvironment(ResearchSite research)
        {
            var sites = _context.Environmental.Where(e => e.SiteName == research.SiteName).ToList();
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("SiteInformation");
                var currentRow = 1;
                worksheet.Cell(currentRow, 1).Value = "Research Date";
                worksheet.Cell(currentRow, 2).Value = "Opening Temperature";
                worksheet.Cell(currentRow, 3).Value = "Closing Temperature";
                worksheet.Cell(currentRow, 4).Value = "Cloud Cover";
                worksheet.Cell(currentRow, 5).Value = "Precipitation";
                worksheet.Cell(currentRow, 6).Value = "Open Time";
                worksheet.Cell(currentRow, 7).Value = "Close Time";
                worksheet.Cell(currentRow, 8).Value = "Site Name";

                foreach (var site in sites)
                {
                    currentRow++;
                    worksheet.Cell(currentRow, 1).Value = site.ResearchDate;
                    worksheet.Cell(currentRow, 2).Value = site.OpenTemp;
                    worksheet.Cell(currentRow, 3).Value = site.CloseTemp;
                    worksheet.Cell(currentRow, 4).Value = site.CloudCover;
                    worksheet.Cell(currentRow, 5).Value = site.Precipitation;
                    worksheet.Cell(currentRow, 6).Value = site.OpenTime;
                    worksheet.Cell(currentRow, 7).Value = site.CloseTime;
                    worksheet.Cell(currentRow, 8).Value = site.SiteName;

                }

                using (var stream = new MemoryStream())
                {
                    workbook.SaveAs(stream);
                    var content = stream.ToArray();

                    return File(
                        content, "application/vnd.openxmlformats-officedocument.spreadsheet.sheet", "SiteInformation.xlsx");
                }

            }
        }

        public async Task<IActionResult> UploadImage()
        {
            var birds = _context.BandingData;
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var researcherBirds = birds.Where(b => b.IdentityUserId == userId).ToList();
            ViewBag.Birds = new SelectList(researcherBirds, "BandNumber", "BandNumber");

            var species = await _apiCalls.GetSpecies();
            ViewBag.Species = new SelectList(species, "alphaCode", "alphaCode");
            ViewData["NotSuccess"] = false;
            return View();
        }

        [HttpPost, ActionName("UploadImage")]

        public ActionResult UploadImage(ImageViewModel viewModel)
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var researcher = _context.Researcher.Where(b => b.IdentityUserId == userId).SingleOrDefault();

            if (ModelState.IsValid)
            {
                string uniqueFileName = UploadedFile(viewModel);

                Images image = new Images
                {
                    AlphaCode = viewModel.AlphaCode,
                    BandNumber = viewModel.BandNumber,
                    BirdImage = uniqueFileName,
                    IdentityUserId = researcher.IdentityUserId,
                };

                _context.Add(image);
                _context.SaveChanges();

                return RedirectToAction("Index");
            }

            ViewData["NotSuccess"] = true;
            ViewData["InvalidUpload"] = "Upload not a Success, please try again.";
            return View(viewModel);

           
        }

        public string UploadedFile(ImageViewModel viewModel)
        {
            string uniqueFileName = null;

            if (viewModel.BirdImage != null)
            {
                string uploadsFolder = Path.Combine(webHostEnvironment.WebRootPath, "Images");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + viewModel.BirdImage.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    viewModel.BirdImage.CopyTo(fileStream);
                }
            }

            return uniqueFileName;
        }

        public ActionResult ViewDailySiteData()
        {
            var researchSites = _context.ResearchSite;
            ViewBag.Sites = new SelectList(researchSites, "SiteName", "SiteName");

            return View();
        }

        [HttpPost, ActionName("ViewDailySiteData")]
        public ActionResult ViewDailySiteData(ResearchSite research)
        {
            var siteData = _context.Environmental.Where(e => e.SiteName == research.SiteName).ToList();
            return View("DisplayData", siteData);
        }

        public ActionResult DisplayData(List<Environmental> data)
        {
            return View(data);
        }
    }    
}