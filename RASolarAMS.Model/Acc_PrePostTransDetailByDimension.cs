//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RASolarAMS.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Acc_PrePostTransDetailByDimension
    {
        public string LocationCode { get; set; }
        public System.DateTime TransDate { get; set; }
        public string ProjectCode { get; set; }
        public string TransNo { get; set; }
        public int SerialNo { get; set; }
        public string DimensionCode { get; set; }
        public string DimensionValueID { get; set; }
        public decimal Amount { get; set; }
        public string RefAccountNo { get; set; }
    
        public virtual Acc_PrePostTransDetail Acc_PrePostTransDetail { get; set; }
        public virtual Acc_GLAccountVsDimension Acc_GLAccountVsDimension { get; set; }
    }
}