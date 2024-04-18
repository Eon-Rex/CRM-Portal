using Microsoft.AspNetCore.Mvc;
using SAMCOCRMRELATION.Models;
using System.Diagnostics;

namespace SAMCOCRMRELATION.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        [HttpPost]
        public ActionResult GetConflictNumber(string id)
        {
            EditConflictForm conflictForm = new EditConflictForm
            {
                ClientName = "DummyClient",
                IsListedCompany = "1",
                MatterDescription = "Dummy matter description",
                OtherParties = "Dummy other parties",
                Status = "1",
                NationalPracticeGroup = "Dummy practice group",
                SourcedBy = "Dummy source",
                ReferringFirm = "Dummy referring firm",
                RevertRequiredBy = "Dummy revert required by",
                IsFirmPartOfNetwork = "1",
                FirmDropdownvalue = "Dummy firm dropdown value",
                PriceSensitive = "1",
                PreviousConflictCirculated = "1",
                Comments = "Dummy comments"
            };

            return PartialView("_GetConflictNumber", conflictForm);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}