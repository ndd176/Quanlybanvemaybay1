using Quanlybanvemaybay1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Ajax.Utilities;
using System.Data.Entity;
using System.Web.UI.WebControls;


namespace Quanlybanvemaybay1.extend
{
    public class UserDetail
    {
       
        QuanLyVeMayBayEntities1 db = null;
        public UserDetail()
        {
            db = new QuanLyVeMayBayEntities1();
        }
        public bool CheckUserName(string userName)
        {
            //if (string.IsNullOrEmpty(userName)) ;
            //return true;
            return db.Users.Count(s => s.username == userName)>0;
        }
        public string Insert(User entity)
        {
            try
            {
                db.Users.Add(entity);
                db.SaveChanges();
                return entity.ID;
            }
            catch
            {
                string err_msg = "tao moi that bai";
                return err_msg;
            }


           
        }
       public bool Update(User entity)
        {
            try
            {
                var user = db.Users.Find(entity.ID);
                user.username = entity.username;
                if (!string.IsNullOrEmpty(entity.password))
                {
                    user.password = entity.password;
                }
                db.SaveChanges();
                return true;
            }
            catch(Exception )
            {
                return false;
            }
        }
        public User GetById(string userName)
        {
            return db.Users.SingleOrDefault(x => x.username == userName);
        }
        public User ViewDetail(int id)
        {
            return db.Users.Find(id);
        }
        //public int Login(string username,string password)
        //{
        //    var result = db.Users.SingleOrDefault(x => x.username == username);
        //    if (result == null)
        //    {
        //        return 0;
        //    }
        //    else
        //    {
        //        if (result.Status == false)
        //        {
        //            return -1;
        //        }
        //        else
        //        {
        //            if (result.password == password) 
        //            return 1;
        //            else return -1;

        //        }
        //    }
        //}
        public bool Delete (int id)
        {
            try
            {
                var user = db.Users.Find(id);
                db.Users.Remove(user);
                db.SaveChanges();
                return true;
            }
            catch(Exception)
            {
                return false;
            }
        }
    }
   
}