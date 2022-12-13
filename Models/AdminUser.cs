using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Quanlybanvemaybay1.Models
{
    public class AdminUser
    {
        [Required(ErrorMessage="ID is not empty...")]
        [Display(Name ="Ma user")]
        public int Id { get; set; }
       
        [Required(ErrorMessage="Name not empty...")]
        [StringLength(50,MinimumLength=5)]
        [Display(Name = "Ten user")]
        public string UserName { get; set; }

        [Display(Name = "role")]
        public string RoleUser { get; set; }

        [Display(Name = "nhap mat khau")]
        [Required(ErrorMessage = "password is not empty...")]
        [DataType(DataType.Password)]

        public string PasswordUser { get; set; }

        [NotMapped]
        [Compare("PasswordUser")]
        [Display(Name = "nhap lai mat khau")]

        public string ConfirmPass { get; set; }
        [NotMapped]
        public string ErrorLogin { get; set; }




    }
}