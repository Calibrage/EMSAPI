//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class EmployeeLeave
    {
        public int LeaveId { get; set; }
        public Nullable<int> EmpId { get; set; }
        public Nullable<int> CasualLeave { get; set; }
        public Nullable<int> PrivilegeLeave { get; set; }
        public Nullable<int> LeaveWithoutPay { get; set; }
        public Nullable<int> TotalLeaves { get; set; }
        public string Duration { get; set; }
    }
}
