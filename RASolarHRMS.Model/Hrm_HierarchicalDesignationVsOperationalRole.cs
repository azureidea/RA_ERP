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
    
    public partial class Hrm_HierarchicalDesignationVsOperationalRole
    {
        public Hrm_HierarchicalDesignationVsOperationalRole()
        {
            this.Hrm_EmployeeInfo = new HashSet<Hrm_EmployeeInfo>();
        }
    
        public string HDesignationID { get; set; }
        public string OperationalRoleID { get; set; }
        public Nullable<byte> SortingOrder { get; set; }
        public Nullable<byte> Status { get; set; }
    
        public virtual ICollection<Hrm_EmployeeInfo> Hrm_EmployeeInfo { get; set; }
        public virtual Hrm_HierarchicalDesignation Hrm_HierarchicalDesignation { get; set; }
        public virtual Hrm_OperationalRole Hrm_OperationalRole { get; set; }
    }
}