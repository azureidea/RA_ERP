//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RASolarERP.Model
{
    using System;
    
    public partial class PackageDetailsForSystemReturn
    {
        public string ItemCode { get; set; }
        public double ItemQuantity { get; set; }
        public decimal UnitCost { get; set; }
        public decimal UnitPriceIfSystemReturn { get; set; }
        public decimal TotalPurchaePrice { get; set; }
        public decimal TotalSystemPrice { get; set; }
        public double ReturnQuantity { get; set; }
        public string ItemSerialNo { get; set; }
        public Nullable<decimal> UsageChargeForCustomer { get; set; }
        public Nullable<decimal> UsageChargeForSystem { get; set; }
        public Nullable<decimal> ReturnValue { get; set; }
        public Nullable<decimal> NonReturnValue { get; set; }
        public Nullable<double> ReturnItemValue { get; set; }
        public Nullable<double> NonReturnItemValue { get; set; }
        public string ItemName { get; set; }
        public bool IsItASerializableItem { get; set; }
        public string ItemCategory { get; set; }
    }
}