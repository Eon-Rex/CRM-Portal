using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Data;
using System.Xml;

namespace SAMCOCRMRELATION.Controllers
{
    public class ConflictFormController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public JsonResult FirmName()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Value", typeof(string));
            dt.Rows.Add("--select--", "-1");
            dt.Rows.Add("Lex Mundi", "1");
            dt.Rows.Add("FLI", "2");
            dt.Rows.Add("Slaughter & May Best Friends Network", "3");
            dt.Rows.Add("Baker Mckenzie", "4");
            dt.Rows.Add("Other Networks or Associations", "5");


            string json = JsonConvert.SerializeObject(dt);

            return Json(new{success = true, data = json});
        }

        [HttpPost]
        public JsonResult EditSubmit()
        {
            return Json(new { success = true, });
        }
    }
}
