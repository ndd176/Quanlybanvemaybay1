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
    
    public partial class PHIEUKYGUIHANHLY
    {
        public string MaPhieu { get; set; }
        public string MaGoi { get; set; }
        public string MaKH { get; set; }
        public Nullable<int> SoKy { get; set; }
    
        public virtual GOIHANHLY GOIHANHLY { get; set; }
        public virtual KHACHHANG KHACHHANG { get; set; }
    }
}
