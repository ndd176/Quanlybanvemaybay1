using Quanlybanvemaybay1.extend;
using Quanlybanvemaybay1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Quanlybanvemaybay1.Models;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Data.Entity;

namespace Quanlybanvemaybay1.Controllers
{
    public class UserController : Controller
    {
        public ActionResult List()
        {
            using (OurDBContext db = new OurDBContext())
            {
                return View(db.userAccount.ToList()); 
            }
        }
        // GET: User
        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(LoginModel loginModel)
        {
            using (OurDBContext db= new OurDBContext())
            {
                var user = db.userAccount.Single(u=>u.Username==loginModel.UserName && u.Password==loginModel.Password);
                if (user != null)
                {
                    Session["UserID"] = user.ID.ToString();
                    Session["UserName"] = user.name.ToString();
                    return RedirectToAction("LoggedIn ");
                }
                else
                {
                    ModelState.AddModelError("", "Username or password is wrong");
                }

            }
            //if (ModelState.IsValid)
            //{
            //    var userdetail = new UserDetail();
            
            //    if (userdetail.CheckUserName(model.UserName))
            //    {
            //        ModelState.AddModelError("", "ten dang nhap da ton tai");
            //    }
            //    else
            //    {
            //        var user = new User();
            //        user.username = model.UserName;
            //        user.password = model.Password;
            //        var result = userdetail.Insert(user);
            //        if (result != null)
            //        {
            //            ViewBag.Success = "Dang nhap thanh cong";
            //            return RedirectToAction("Index", "Home");
            //        }
            //        else
            //        {
            //            ModelState.AddModelError("", "dang nhap khong thanh cong");
            //        }
            //    }
            //}
            return View();
        }
        [HttpPost]
        public ActionResult Register(Register_Model model)
        {
           if (ModelState.IsValid)
            {
                if (ModelState.IsValid)
                {
                    using (OurDBContext db = new OurDBContext())
                    {
                        db.userAccount.Add(model);
                        db.SaveChanges();
                    }
                    ModelState.Clear();
                    ViewBag.Message = model.Username + " successfully register";

                }
             //   var userdetail = new UserDetail();
             //   if (userdetail.CheckUserName(model.Username))
             //   {
             //       ModelState.AddModelError("", "ten dang nhap da ton tai");
             //   }
             //else
             //   {
             //   var user = new User();
             //       user.username = model.name;
             //       user.password = model.Password;
             //       user.ID = model.ID;
             //       var result = userdetail.Insert(user);
             //       if (result !=null)
             //       {
             //           ViewBag.Success = "Dang ky thanh cong";
             //           model = new Register_Model();
             //       }
             //       else
             //       {
             //           ModelState.AddModelError("", "dang ky khong thanh cong");
             //       }
             //   }
            }
            return View();
        }
        public ActionResult LoggedIn()
        {
            if (Session["UserID"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Index");
            }
        }
    }
}