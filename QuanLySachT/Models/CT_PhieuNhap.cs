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
    using System.Web.Mvc;
    
    public partial class CT_PhieuNhap
    {
        public int ID { get; set; }
        public int DonGiaNhap { get; set; }
        public int SoLuong { get; set; }
        public int ThanhTien { get; set; }
        //[Remote("IsEmpNameExist", "Validation", ErrorMessage = "Employee name already exist")]
        public int MaPhieu { get; set; }

        //[Remote("IsEmpNameandMailExist", "Validation", ErrorMessage = "EmialId is already exist", AdditionalFields = "EmpName")]

        public int MaSach { get; set; }
    
        public virtual PhieuNhap PhieuNhap { get; set; }
        public virtual Sach Sach { get; set; }
    }
}