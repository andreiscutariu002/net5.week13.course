namespace SimpleMVCApp.Controllers
{
    using System.Web.Mvc;

    //Home
    public class HomeController : Controller
    {
        //Home/Index
        public ActionResult Index()
        {
            ViewBag.User = "Andrei";

            return this.View();
        }

        //Home/About
        public ActionResult About()
        {
            return this.View();
        }

        //Home/Contact
        public ActionResult Contact()
        {
            return this.View();
        }
    }
}
