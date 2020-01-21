namespace SimpleMVCApp.Controllers
{
    using System.Collections.Generic;
    using System.Collections.Specialized;
    using System.Web.Mvc;
    using Models;

    public class UsersController : Controller
    {
        private readonly UserData userData;

        public UsersController()
        {
            this.userData = new UserData();
        }

        //users/index
        [HttpGet]
        public ActionResult Index()
        {
            List<User> users = this.userData.GetUsers();

            return this.View(users);
        }

        [HttpGet]
        public ActionResult ById(int id)
        {
            var u = this.userData.GetUser(id);

            return this.View(u);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return this.View();
        }

        [HttpPost]
        public ActionResult CreateUser()
        {
            NameValueCollection form = this.Request.Form;

            var userName = form["Name"];

            var email = form["Email"];

            return this.View("Create");
        }

        [HttpPost]
        public ActionResult CreateUser2(User u)
        {
            this.userData.AddUser(u);

            return RedirectToAction("Index");

            //return this.View("Index");
        }
    }
}
