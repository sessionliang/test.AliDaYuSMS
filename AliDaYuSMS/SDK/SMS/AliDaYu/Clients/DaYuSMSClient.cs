
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRCode.Core.SDK.Common;
using HRCode.Core.SDK.AliDaYu.Models;
using Top.Api;
using HRCode.Core.SDK.AliDaYu.Core;
using Top.Api.Request;
using Top.Api.Response;
using HRCode.Core.SDK.SMS;

namespace HRCode.Core.SDK.AliDaYu.Clients
{
    public class DaYuSMSClient : IDaYuSMSClient
    {
        public ITopClient client
        {
            get
            {
                return new DefaultTopClient(sdk.GetApiBaseUrl(), sdk.APP_KEY, sdk.SECRET);
            }
        }

        public DaYuSdk sdk
        {
            get
            {
                return new DaYuSdk();
            }
        }

        public SMSResponseBase Send(string phone, string message, string template)
        {
            AlibabaAliqinFcSmsNumSendRequest req = new AlibabaAliqinFcSmsNumSendRequest();
            req.Extend = sdk.Params["Extend"];
            req.SmsType = sdk.Params["SmsType"];
            req.SmsFreeSignName = sdk.Params["SmsFreeSignName"];

            req.SmsParam = message;
            req.RecNum = phone;
            req.SmsTemplateCode = template;
            AlibabaAliqinFcSmsNumSendResponse rsp = client.Execute(req);
            DaYuSMSSendResponse response;
            if (rsp.IsError)
            {
                response = new DaYuSMSSendResponse(rsp.SubErrCode);
            }
            else
            {
                response = new DaYuSMSSendResponse("00");
            }
            return response;
        }

        public SMSResponseBase Send(string phone, string message)
        {
            return Send(phone, message, DaYuSMSTemplates.SEND_VALIDATE_CODE_TEMPLATE);
        }
    }
}
