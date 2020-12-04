using System;
using System.Collections.Generic;
using System.Text;

namespace Chain
{
    /// <summary>
    /// The 'ConcreteHandler' class
    /// </summary>
    public class HR : Employee
    {
        public HR()
        {
            this.onLeaveApplied += HR_onLeaveApplied;
        }

        private void HR_onLeaveApplied(int requestedDays)
        {
            ApproveLeave(requestedDays);
            if (NextApprover != null)
                NextApprover.ApplyLeave(requestedDays);
        }

        // If we can process lets show the output
        public override void ApproveLeave(int requestedDays)
        {
            Console.WriteLine(@"EmployeeId: {0} Requested Days: {1} 
                 Approve: {2}",
                this.EmployeeId, requestedDays, "HR");
        }
    }
}