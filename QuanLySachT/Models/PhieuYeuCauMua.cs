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
    
    public partial class PhieuYeuCauMua
    {
        public PhieuYeuCauMua()
        {
            this.CT_PhieuYeuCauMua = new HashSet<CT_PhieuYeuCauMua>();
        }
    
        public int MaPhieu { get; set; }
        public System.DateTime NgayGio { get; set; }
        public int MaDaiLy { get; set; }
        public bool TinhTrang { get; set; }
    
        public virtual ICollection<CT_PhieuYeuCauMua> CT_PhieuYeuCauMua { get; set; }
        public virtual DaiLy DaiLy { get; set; }
    }
}
