using HR.LeaveManagement.Application.Modules;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HR.LeaveManagement.Application.Contracts.Infrustructure
{
    public interface IEmailSender
    {
        Task<bool> SendEmail(Email email);
    }
}