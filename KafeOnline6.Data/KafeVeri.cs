﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KafeOnline6.Data
{
    public class KafeVeri
    {
        public int MasaAdet {  get; set; }

        public List<Urun> Urunler { get; set; }=new List<Urun>();//Menü

        public List<Siparis> AktifSiparisler { get; set; }= new();

        public List<Siparis> GecmisSiparisler { get; set; } = new();   /*new List<Siparis>();*/
    }
}