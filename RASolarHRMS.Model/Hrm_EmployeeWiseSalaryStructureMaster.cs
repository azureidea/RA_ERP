//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RASolarHRMS.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Hrm_EmployeeWiseSalaryStructureMaster
    {
        public Hrm_EmployeeWiseSalaryStructureMaster()
        {
            this.Hrm_EmployeeWiseSalaryStructureDetails = new HashSet<Hrm_EmployeeWiseSalaryStructureDetails>();
            this.Hrm_EmployeeInfo = new HashSet<Hrm_EmployeeInfo>();
        }
    
        public string EmployeeID { get; set; }
        public byte SalaryStructureSeqNo { get; set; }
        public string HDesignationID { get; set; }
        public string EmploymentTypeID { get; set; }
        public System.DateTime SSEffectiveFromDate { get; set; }
        public System.DateTime SSEffectiveToDate { get; set; }
    
        public virtual ICollection<Hrm_EmployeeWiseSalaryStructureDetails> Hrm_EmployeeWiseSalaryStructureDetails { get; set; }
        public virtual Hrm_EmploymentTypeInfo Hrm_EmploymentTypeInfo { get; set; }
        public virtual Hrm_HierarchicalDesignation Hrm_HierarchicalDesignation { get; set; }
        public virtual Hrm_Validation_EmployeeWiseDesignationVsEmploymentType Hrm_Validation_EmployeeWiseDesignationVsEmploymentType { get; set; }
        public virtual ICollection<Hrm_EmployeeInfo> Hrm_EmployeeInfo { get; set; }
    }
}