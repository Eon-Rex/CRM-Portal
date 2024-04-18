using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SAMCOCRMRELATION.Models;

namespace SAMCOCRMRELATION.Controllers
{
    public class EditController : Controller
    {
        [HttpGet]
        public ActionResult GetConflictNumber()
        {
            string id = Request.Query["id"].ToString();

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
                IsFirmPartOfNetwork = "0",
                FirmDropdownvalue = "value auto popate",
                PriceSensitive = "1",
                PreviousConflictCirculated = "1",
                Comments = "Dummy comments"
            };

            return View(conflictForm);
        }

        [HttpPost]
        public ActionResult SaveEdit( EditData formData)
        {
            return Json(new { success = true });
        }
    }
    public class EditData
    {
        public string clientName { get; set; }
        public string listedCompany { get; set; }
        public string matterDescription { get; set; }
        public string otherParties { get; set; }
        public string status { get; set; }
        public string nationalPracticeGroup { get; set; }
        public string sourcedBy { get; set; }
        public string referringFirm { get; set; }
        public string revertRequiredBy { get; set; }
        public string network { get; set; }
        public string priceSensitive { get; set; }
        public string previousConflict { get; set; }
        public string comments { get; set; }
    }
}
