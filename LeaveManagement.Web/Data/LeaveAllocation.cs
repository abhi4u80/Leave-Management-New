﻿using System.ComponentModel.DataAnnotations.Schema;

namespace LeaveManagement.Web.Data
{
    public class LeaveAllocation: BaseEntity
    {

        

        public int NumberOfDays { get; set; }

        [ForeignKey("LeaveTypeId")]

        //for foreign key referenceto leavetype table
        public LeaveType LeaveType { get; set; }

        public int LeaveTypeId { get; set; }

        public string EmployeeId { get; set; }

      
    }
}
