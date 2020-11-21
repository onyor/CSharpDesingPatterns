using System;
using System.Collections.Generic;
using System.Text;

namespace Chain
{
    /// <summary>
    /// The 'ConcreteHandler' class
    /// </summary>
    public class Engineer : Employee
    {
        public Engineer()
        {
            this.onLeaveApplied += Engineer_onLeaveApplied;
        }

        private void Engineer_onLeaveApplied(int requestedDays)
        {
            if (NextApprover != null)
            {
                NextApprover.ApplyLeave(requestedDays);
            }
        }

        public override void ApproveLeave(int requestedDays)
        {
            Console.WriteLine(@"Engineer does not have
                       approve permission.");
        }
    }
}
