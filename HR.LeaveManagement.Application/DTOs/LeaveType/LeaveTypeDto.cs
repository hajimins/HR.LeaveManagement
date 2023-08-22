using HR.LeaveManagement.Application.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace HR.LeaveManagement.Application.DTOs.LeaveType
{
    public class UpdateLeaveTypeDto : BaseDto, ILeaveTypeDto

    {
        public string Name { get; set; }
        public int DefaultDays { get; set; }
    }
}