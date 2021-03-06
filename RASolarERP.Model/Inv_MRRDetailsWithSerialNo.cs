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
    
    public partial class Inv_MRRDetailsWithSerialNo
    {
        public Inv_MRRDetailsWithSerialNo()
        {
            this.Inv_ItemTransactionDetailsWithSerialNo = new HashSet<Inv_ItemTransactionDetailsWithSerialNo>();
        }
    
        public string LocationCode { get; set; }
        public string MRRSeqNo { get; set; }
        public byte CompSeqNo { get; set; }
        public string ItemCode { get; set; }
        public string ItemSerialNo { get; set; }
        public string RefChallanLocationCode { get; set; }
        public string RefChallanSeqNo { get; set; }
        public Nullable<byte> RefChallanCompSeqNo { get; set; }
        public byte Status { get; set; }
        public string ItemSerialNoFoundPhysically { get; set; }
    
        public virtual Inv_ChallanDetailsWithSerialNo Inv_ChallanDetailsWithSerialNo { get; set; }
        public virtual Inv_MRRDetails Inv_MRRDetails { get; set; }
        public virtual ICollection<Inv_ItemTransactionDetailsWithSerialNo> Inv_ItemTransactionDetailsWithSerialNo { get; set; }
        public virtual Inv_ItemNItemCategoryWithSerialNoMaster Inv_ItemNItemCategoryWithSerialNoMaster { get; set; }
    }
}
