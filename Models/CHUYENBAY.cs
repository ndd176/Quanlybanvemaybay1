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
    
    public partial class CHUYENBAY
    {
        public string MaChuyenBay { get; set; }
        public string MaChiTietChuyenBay { get; set; }
        public Nullable<int> SoVe { get; set; }
    
        public virtual CHITIETCHUYENBAY CHITIETCHUYENBAY { get; set; }
    }
}