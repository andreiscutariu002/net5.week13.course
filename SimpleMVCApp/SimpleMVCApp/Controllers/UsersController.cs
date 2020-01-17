namespace SimpleMVCApp.Controllers
{
    using System.Collections.Generic;
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
        public ActionResult Index()
        {
            List<User> users = this.userData.GetUsers();

            return this.View(users);
        }

        public ActionResult ById(int id)
        {
            var u = this.userData.GetUser(id);

            return this.View(u);
        }
    }
}
