//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Vimas.Models.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class ThongTinVeNuoc
    {
        public int Id { get; set; }
        public int IdThongTinCaNhan { get; set; }
        public Nullable<System.DateTime> NgayDi { get; set; }
        public Nullable<System.DateTime> NgayVe { get; set; }
        public string LyDoVe { get; set; }
        public Nullable<bool> ThanhLyHopDong { get; set; }
        public Nullable<System.DateTime> NgayThanhLy { get; set; }
        public string SoHopDongThanhLy { get; set; }
        public Nullable<System.DateTime> NgayTron { get; set; }
        public Nullable<System.DateTime> NgayBiTrucXuat { get; set; }
        public string GhiChuTheoDoi { get; set; }
        public bool Active { get; set; }
    
        public virtual ThongTinCaNhan ThongTinCaNhan { get; set; }
    }
}
