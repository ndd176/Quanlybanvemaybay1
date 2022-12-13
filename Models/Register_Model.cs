using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.EnterpriseServices.Internal;
using System.Linq;
using System.Web;

namespace Quanlybanvemaybay1.Models
{
    public class Register_Model
    {
        [Key]
        public string ID { get; set; }
        [Required(ErrorMessage = "Vui lòng điền tên đăng nhập")]
        [Display(Name="Tên đăng nhập")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Vui lòng điền mật khẩu")]
        [Display(Name ="Mật khẩu ")]
        [StringLength(20,MinimumLength =6,ErrorMessage ="Tối thiểu 6 kí tự")]
        public string Password { get; set; }

        [Required(ErrorMessage = "vui lòng xác nhận mật khẩu")]
        [Compare("Password",ErrorMessage ="Xác nhận mật khẩu không đúng")]
        [Display(Name = "Xác nhận mật khẩu")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập họ tên")]
        [Display(Name = "Họ tên ")]
        public string name { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập số tuổi")]
        [Display(Name = "Số tuổi ")]
        public int age { get; set; }

    }
}