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
    
    public partial class Sal_Validation_CustomerTypeVsModeOfPayment
    {
        public Sal_Validation_CustomerTypeVsModeOfPayment()
        {
            this.Sal_Validation_CustomerTypeVsModeOfPaymentVsPackage = new HashSet<Sal_Validation_CustomerTypeVsModeOfPaymentVsPackage>();
            this.Sal_Validation_ProgramVsCustomerTypeNModeOfPayment = new HashSet<Sal_Validation_ProgramVsCustomerTypeNModeOfPayment>();
        }
    
        public string CustomerType { get; set; }
        public string ModeOfPaymentID { get; set; }
        public byte Status { get; set; }
    
        public virtual Sal_CustomerType Sal_CustomerType { get; set; }
        public virtual Sal_ModeOfPayment Sal_ModeOfPayment { get; set; }
        public virtual ICollection<Sal_Validation_CustomerTypeVsModeOfPaymentVsPackage> Sal_Validation_CustomerTypeVsModeOfPaymentVsPackage { get; set; }
        public virtual ICollection<Sal_Validation_ProgramVsCustomerTypeNModeOfPayment> Sal_Validation_ProgramVsCustomerTypeNModeOfPayment { get; set; }
    }
}
