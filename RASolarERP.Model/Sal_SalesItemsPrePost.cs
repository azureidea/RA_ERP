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
    using System.Collections.Generic;
    
    public partial class Sal_SalesItemsPrePost
    {
        public Sal_SalesItemsPrePost()
        {
            this.Sal_SalesItemsWithSerialNoPrePost = new HashSet<Sal_SalesItemsWithSerialNoPrePost>();
        }
    
        public string CustomerCode { get; set; }
        public byte CompSeqNo { get; set; }
        public string ItemCode { get; set; }
        public double ItemQuantity { get; set; }
        public byte FromStoreLocation { get; set; }
        public decimal UnitCost { get; set; }
        public Nullable<decimal> UnitPriceIfSystemReturn { get; set; }
        public string ItemCategory { get; set; }
        public string ItemCapacity { get; set; }
        public string ItemModel { get; set; }
        public string UnitOfMeasure { get; set; }
        public Nullable<byte> WarrantyInMonth { get; set; }
    
        public virtual Inv_ItemMaster Inv_ItemMaster { get; set; }
        public virtual Sal_SalesAgreementPrePost Sal_SalesAgreementPrePost { get; set; }
        public virtual ICollection<Sal_SalesItemsWithSerialNoPrePost> Sal_SalesItemsWithSerialNoPrePost { get; set; }
    }
}
