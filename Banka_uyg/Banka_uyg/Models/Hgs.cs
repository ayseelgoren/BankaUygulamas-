//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Banka_uyg.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Hgs
    {
        public int HgsId { get; set; }
        public int HgsHesap { get; set; }
        public string MusteriTc { get; set; }
        public decimal Tutar { get; set; }
        public Nullable<System.DateTime> Tarih { get; set; }
        public string Kanal { get; set; }
    
        public virtual Hgs Hgs1 { get; set; }
        public virtual Hgs Hgs2 { get; set; }
    }
}
