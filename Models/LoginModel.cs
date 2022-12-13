using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace Quanlybanvemaybay1.Models
{
    public class LoginModel
    {
        [Key]
        [Required(ErrorMessage = "Vui lòng điền tên đăng nhập")]
        [Display(Name = "Tên đăng nhập")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Vui lòng điền mật khẩu")]
        [Display(Name = "Mật khẩu ")]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "Tối thiểu 6 kí tự")]
        public string Password { get; set; }
    }
}