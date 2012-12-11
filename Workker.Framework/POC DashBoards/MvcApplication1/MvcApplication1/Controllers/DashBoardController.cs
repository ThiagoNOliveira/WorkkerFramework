using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using MvcApplication1.Models;

namespace MvcApplication1.Controllers
{
    public class DashBoardController : Controller
    {
        //
        // GET: /DashBoard/

        public ActionResult Index()
        {
            return View();
        }

        
        public JsonResult GetCharts()
        {
            List<Chart> charts = new List<Chart>();

            charts.Add(new Chart { Nota = 10, Setor = "Nutrição" });
            charts.Add(new Chart { Nota = 5, Setor = "Concierge" });
            charts.Add(new Chart { Nota = 4, Setor = "UTI" });
            charts.Add(new Chart { Nota = 8, Setor = "Quarto" });
            charts.Add(new Chart { Nota = 10, Setor = "Nutrição" });
            charts.Add(new Chart { Nota = 5, Setor = "Concierge" });
            charts.Add(new Chart { Nota = 4, Setor = "UTI" });
            charts.Add(new Chart { Nota = 8, Setor = "Quarto" });
            charts.Add(new Chart { Nota = 8, Setor = "Quarto" });

            JavaScriptSerializer js = new JavaScriptSerializer();

            return this.Json(js.Serialize(charts), JsonRequestBehavior.AllowGet);
        }
    }
}
