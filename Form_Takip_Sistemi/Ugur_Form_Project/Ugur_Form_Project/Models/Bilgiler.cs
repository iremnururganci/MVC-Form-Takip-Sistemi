//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Ugur_Form_Project.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Bilgiler
    {
        public int PersonelID { get; set; }
        public string AdSoyad { get; set; }
        public string SicilNo { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }
        public System.DateTime Tarih { get; set; }
        public int NitelikID { get; set; }
        public string Konu { get; set; }
    
        public virtual Nitelik Nitelik { get; set; }
    }
}
