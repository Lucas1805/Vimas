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
    
    public partial class TrungTamGTVL
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TrungTamGTVL()
        {
            this.ThongTinCaNhans = new HashSet<ThongTinCaNhan>();
        }
    
        public int Id { get; set; }
        public string MaNguon { get; set; }
        public string TenCoSo { get; set; }
        public string DiaChi { get; set; }
        public string DienThoai { get; set; }
        public string Fax { get; set; }
        public string SoHDLK { get; set; }
        public Nullable<System.DateTime> NgayKyHopDong { get; set; }
        public Nullable<System.DateTime> NgayHetHan { get; set; }
        public string NguoiDaiDien { get; set; }
        public string ChucDanh { get; set; }
        public Nullable<bool> Active { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ThongTinCaNhan> ThongTinCaNhans { get; set; }
    }
}
