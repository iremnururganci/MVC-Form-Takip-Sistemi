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
    
    public partial class Olay
    {
        public int PersonelID { get; set; }
        public Nullable<System.DateTime> Tarih { get; set; }
        public Nullable<System.DateTime> Saat { get; set; }
        public string Yer { get; set; }
        public string Olay1 { get; set; }
        public int DurumID { get; set; }
        public string Oneri { get; set; }
        public string AdSoyad { get; set; }
    
        public virtual Durum Durum { get; set; }
    }
}