using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BlackKiwi.CodeDiffViewer.FileHelpers;

namespace BlackKiwi.CodeDiffViewer.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult UploadFile()
        {

            var files = Request.Files;
            var diff = new Diff();
            using (var sr = new StreamReader(files[0].InputStream))
            {
                diff.Load(sr);
            }
            var formattedDiff = new FormattedDiff(diff);
            return View("Index",formattedDiff);
        }
    }
}