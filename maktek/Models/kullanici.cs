//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace maktek.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class kullanici
    {
        public int Id { get; set; }
        public string kullaniciadi { get; set; }
        public string sifre { get; set; }
        public string email { get; set; }
        public Nullable<System.DateTime> ekleme_tarihi { get; set; }
        public string ekleyen_kul { get; set; }
        public Nullable<System.DateTime> degisim_tarihi { get; set; }
        public string degistiren_kul { get; set; }
        public string resim { get; set; }
    }
}
