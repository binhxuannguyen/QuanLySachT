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
    
    public partial class CT_BaoCaoBanHang
    {
        public int ID { get; set; }
        public int GiaBan { get; set; }
        public int SoLuong { get; set; }
        public int ThanhTien { get; set; }
        public int MaBC { get; set; }
        public int MaSach { get; set; }
    
        public virtual BaoCaoBanHang BaoCaoBanHang { get; set; }
        public virtual Sach Sach { get; set; }
    }
}
