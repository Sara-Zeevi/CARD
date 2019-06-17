using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GUI.Controllers
{
    public class UserInformationController : Controller
    {
        // GET: UserInformation
        public ActionResult List()
        {
            return View(BL.ServiseUser.GetAllUser());
        }
      
      
        /// <summary>
        /// User details page for updating details
        /// </summary>
        /// <returns></returns>
        public ActionResult EditUser(int id)
        {
            return View(BL.ServiseUser.SearchUser(id));
        }

        /// <summary>
        /// User details page for adding a new user
        /// </summary>
        /// <returns></returns>
        public ActionResult AddUser()
        {
            return View();
        }

        /// <summary>
        /// add new user
        /// </summary>
        /// <param name="user"></param>
        public void AddNewUserUser(User user)
        {
            if (user.DateOfBirth != null && !string.IsNullOrEmpty(user.Name) && user.TZ != 0)
                BL.ServiseUser.AddNewUser(user);
        }
        /// <summary>
        /// edit user
        /// </summary>
        /// <param name="user"></param>
        public void Edit(User user)
        {
            if (user.DateOfBirth != null && !string.IsNullOrEmpty(user.Name) && user.TZ != 0)
                BL.ServiseUser.UpdateUser(user);
        }
        /// <summary>
        /// delete user
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult DeleteUser(int id)
        {       
                BL.ServiseUser.RemoveUser(id);
            return RedirectToAction("List");
        }
    }
}