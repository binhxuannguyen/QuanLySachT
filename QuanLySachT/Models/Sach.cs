//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLySachT.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Sach
    {
        public Sach()
        {
            this.CT_BaoCaoBanHang = new HashSet<CT_BaoCaoBanHang>();
            this.CT_PhieuGhiNoDaiLy = new HashSet<CT_PhieuGhiNoDaiLy>();
            this.CT_PhieuKiemKho = new HashSet<CT_PhieuKiemKho>();
            this.CT_PhieuNhap = new HashSet<CT_PhieuNhap>();
            this.CT_PhieuXuat = new HashSet<CT_PhieuXuat>();
            this.CT_PhieuYeuCauBan = new HashSet<CT_PhieuYeuCauBan>();
            this.CT_PhieuYeuCauMua = new HashSet<CT_PhieuYeuCauMua>();
            this.CT_ThongKeChoNXB = new HashSet<CT_ThongKeChoNXB>();
        }
    
        public int MaSach { get; set; }
        public string TenSach { get; set; }
        public string LinhVuc { get; set; }
        public int GiaXuat { get; set; }
        public int GiaNhap { get; set; }
    
        public virtual ICollection<CT_BaoCaoBanHang> CT_BaoCaoBanHang { get; set; }
        public virtual ICollection<CT_PhieuGhiNoDaiLy> CT_PhieuGhiNoDaiLy { get; set; }
        public virtual ICollection<CT_PhieuKiemKho> CT_PhieuKiemKho { get; set; }
        public virtual ICollection<CT_PhieuNhap> CT_PhieuNhap { get; set; }
        public virtual ICollection<CT_PhieuXuat> CT_PhieuXuat { get; set; }
        public virtual ICollection<CT_PhieuYeuCauBan> CT_PhieuYeuCauBan { get; set; }
        public virtual ICollection<CT_PhieuYeuCauMua> CT_PhieuYeuCauMua { get; set; }
        public virtual ICollection<CT_ThongKeChoNXB> CT_ThongKeChoNXB { get; set; }
    }
}