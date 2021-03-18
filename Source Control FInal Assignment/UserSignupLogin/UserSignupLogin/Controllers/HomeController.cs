using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UserSignupLogin.Models;
namespace UserSignupLogin.Controllers
{
    public class HomeController : Controller
    {
        private ILog Logger = LogManager.GetLogger(typeof(HomeController));
        DBuserSignupLoginEntities1 db = new DBuserSignupLoginEntities1();
        // GET: Home
        public ActionResult Index()
        {
            
            try
            {
                throw new Exception("Test");

            }
            catch (Exception ex)
            {

                Logger.Error("Error:", ex);
            }
            return View(db.TBLUserInfoes.ToList());
        }



        public ActionResult Signup()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Signup(TBLUserInfo tBLUserInfo)
        {

            if (db.TBLUserInfoes.Any(x => x.NameUs == tBLUserInfo.NameUs))
            {
                ViewBag.Notification = "This Account already existed";
                return View();
            }
            else
            {
                db.TBLUserInfoes.Add(tBLUserInfo);
                db.SaveChanges();


                Session["IdUsSS"] = tBLUserInfo.IdUs.ToString();
                Session["NameSS"] = tBLUserInfo.NameUs.ToString();
                return RedirectToAction("Index", "Home");



            }
        }

        public ActionResult Logout()
        {
            Session.Clear();
            return RedirectToAction("Index", "Home");
        }



        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(TBLUserInfo tBLUserInfo)
        {
            var checkLogin = db.TBLUserInfoes.Where(x => x.NameUs.Equals(tBLUserInfo.NameUs) && x.PasswordUs.Equals(tBLUserInfo.PasswordUs)).FirstOrDefault();
            if (checkLogin != null)
            {
                Session["IdUsSS"] = tBLUserInfo.IdUs.ToString();
                Session["NameSS"] = tBLUserInfo.NameUs.ToString();
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.Notification = "Wrong Username or Password";
            }
            return View();
        }


    }
}