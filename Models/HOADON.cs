//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Quanlybanvemaybay1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class HOADON
    {
        public string MaHD { get; set; }
        public string MaKM { get; set; }
        public string MaKH { get; set; }
        public Nullable<System.DateTime> NgayKhoiHanh { get; set; }
        public Nullable<int> Soghe { get; set; }
        public string Khoang { get; set; }
        public string NoiDen { get; set; }
        public Nullable<int> TongTien { get; set; }
    
        public virtual KHACHHANG KHACHHANG { get; set; }
        public virtual KHUYENMAI KHUYENMAI { get; set; }
    }
}
