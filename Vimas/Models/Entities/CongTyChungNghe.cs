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
    
    public partial class CongTyChungNghe
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CongTyChungNghe()
        {
            this.ThongTinPhongVans = new HashSet<ThongTinPhongVan>();
        }
    
        public int id { get; set; }
        public string TenVietTat { get; set; }
        public string TenTiengAnh { get; set; }
        public string TenTiengViet { get; set; }
        public string DiaChiTiengAnh { get; set; }
        public string DiaChiTiengViet { get; set; }
        public string DienThoai { get; set; }
        public string NguoiDaiDien { get; set; }
        public string ChucDanh { get; set; }
        public Nullable<decimal> VonDieuLe { get; set; }
        public Nullable<int> SoNhanVien { get; set; }
        public Nullable<bool> isActive { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ThongTinPhongVan> ThongTinPhongVans { get; set; }
    }
}
