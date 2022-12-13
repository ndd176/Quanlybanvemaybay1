using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Quanlybanvemaybay1.Models;

namespace Quanlybanvemaybay1.extend
{
    public class OurDBContext :DbContext
    {
        public DbSet<Register_Model> userAccount { get; set; }

        public System.Data.Entity.DbSet<Quanlybanvemaybay1.Models.LoginModel> LoginModels { get; set; }
    }
}