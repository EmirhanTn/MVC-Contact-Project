using MvcRehber.Models.Context;
using MvcRehber.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcRehberhelele1.Controllers
{
    public class TBLUserInfoController : Controller
    {

        MvcRehberContext db = new MvcRehberContext();

   
        public ActionResult Index()
        {
            return RedirectToAction("Login", "Home");
      
        }

        public ActionResult Signup()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Signup(TBLUserInfo tBLUserInfo)
        {
            if (db.TBLUserInfoes.Any(x => x.Username == tBLUserInfo.Username))
            {
                ViewBag.Notification = "Bu hesap daha önce oluşturulmuş";
                return View();
            }
            else
            {
                db.TBLUserInfoes.Add(tBLUserInfo);
                db.SaveChanges();

                Session["IdSS"] = tBLUserInfo.Id.ToString();
                Session["UsernameSS"] = tBLUserInfo.Username.ToString();
                return RedirectToAction("Index", "Kisi");
            }
        }
        public ActionResult Logout(Kisi kisi)
        {
            Session.Clear();
            kisi.CurrentId = 0;
            return RedirectToAction("Login", "TBLUserInfo");
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
            var checklogin = db.TBLUserInfoes.Where(x => x.Username.Equals(tBLUserInfo.Username) && x.Password.Equals(tBLUserInfo.Password)).FirstOrDefault();
            if (checklogin != null)
            {
                Session["IdSS"] = checklogin.Id;
                Session["UsernameSS"] = checklogin.Username.ToString();
                return RedirectToAction("Index", "Kisi");
            }
            else
            {
                ViewBag.Notification = "Kullanıcı veya şifre hatalı";
            }
            return View();
        }

    }
}