//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApp1
{
    using System;
    using System.Collections.Generic;
    
    public partial class TB_PUR
    {
        public int ID { get; set; }
        public Nullable<int> Cat_id { get; set; }
        public Nullable<int> Supp_id { get; set; }
        public string Pur_Name { get; set; }
        public string Pur_Type { get; set; }
        public string Pur_Cat { get; set; }
        public string Pur_Supp { get; set; }
        public string Pur_Det { get; set; }
        public Nullable<double> Pur_Buy { get; set; }
        public Nullable<double> Pur_Sell { get; set; }
        public Nullable<double> Pur_Qt { get; set; }
        public Nullable<double> Pur_Tsell { get; set; }
        public Nullable<double> Pur_Tbuy { get; set; }
        public Nullable<double> Pur_TRev { get; set; }
    
        public virtual TB_CAT TB_CAT { get; set; }
        public virtual TB_SUPP TB_SUPP { get; set; }
    }
}
