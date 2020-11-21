using System;
using System.Collections.Generic;
using System.Text;

namespace Chain
{
    /// <summary>
    /// The 'Handler' abstract class
    /// </summary>
    public abstract class Employee
    {
        public Guid EmployeeId { get; set; }
        public int LeaveDays { get; set; }
        // approve edecek bir sonraki kisi
        public Employee NextApprover { get; set; }

        public Employee()
        {
            EmployeeId = Guid.NewGuid();
            LeaveDays = 15;
        }

        // Event tanimlaniyor
        public delegate void OnLeaveApplied(int requestedDays);
        public event OnLeaveApplied onLeaveApplied = null;

        public abstract void ApproveLeave(int requestedDays);

        // Using this we can apply for leave
        public void ApplyLeave(int requestedDays)
        {
            if (onLeaveApplied != null)
            {
                onLeaveApplied(requestedDays);
            }
        }
    }
}
