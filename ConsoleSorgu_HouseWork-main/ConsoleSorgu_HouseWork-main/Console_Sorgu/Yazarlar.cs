//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Console_Sorgu
{
    using System;
    using System.Collections.Generic;
    
    public partial class Yazarlar
    {
        public Yazarlar()
        {
            this.Kitaplar = new HashSet<Kitaplar>();
        }
    
        public int ID { get; set; }
        public string AdSoyad { get; set; }
        public string Cinsiyet { get; set; }
        public Nullable<System.DateTime> DogumTarihi { get; set; }
        public string Tel { get; set; }
        public string Mail { get; set; }
        public Nullable<int> TurID { get; set; }
    
        public virtual ICollection<Kitaplar> Kitaplar { get; set; }
        public virtual Turler Turler { get; set; }
    }
}
