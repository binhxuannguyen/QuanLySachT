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
    
    public partial class PhieuGhiNoDaiLy
    {
        public PhieuGhiNoDaiLy()
        {
            this.CT_PhieuGhiNoDaiLy = new HashSet<CT_PhieuGhiNoDaiLy>();
        }
    
        public int MaPhieu { get; set; }
        public System.DateTime NgayGio { get; set; }
        public int TongNo { get; set; }
        public bool TinhTrang { get; set; }
    
        public virtual ICollection<CT_PhieuGhiNoDaiLy> CT_PhieuGhiNoDaiLy { get; set; }
    }
}
