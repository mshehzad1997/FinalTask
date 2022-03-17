using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InternshipTasks.Models
{
    public class ManageRoles
    {

        public int Id { get; set; }
        public string RoleName { get; set; }
        public string Description { get; set; }
        public Payment Payments { get; set; }
        public ManageTenant ManageTenants { get; set; }
        public DemoRequest DemoRequests { get; set; }
        public enum Payment
        {
            ViewPayment,
            ChangeStatus

        }
        public enum ManageTenant
        {
            RegisterTenant,
            ViewTenant,
            UpdateTenant,
            UpgradePlan,
            RessetPassword
        }
        public enum DemoRequest
        {
            ViewRequest,
            ApproveRequest
        }
    }
}
