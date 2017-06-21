using HRCode.Core.SDK.AliDaYu.Core;
using HRCode.Core.SDK.Common;
using HRCode.Core.SDK.SMS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Top.Api;

namespace HRCode.Core.SDK.AliDaYu.Clients
{
    public interface IDaYuSMSClient
    {
        ITopClient client { get; }

        DaYuSdk sdk { get; }

        SMSResponseBase Send(string phone, string message, string template);

        SMSResponseBase Send(string phone, string message);
    }
}
