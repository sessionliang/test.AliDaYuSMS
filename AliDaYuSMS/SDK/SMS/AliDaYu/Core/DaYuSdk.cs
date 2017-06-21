using HRCode.Core.SDK.Common;
using HRCode.Core.SDK.SMS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRCode.Core.SDK.AliDaYu.Core
{
    /// <summary>
    /// 阿里大于短信服务配置
    /// 1. 配置APP_KEY <see cref="APP_KEY"/>
    /// 2. 配置SECRET <see cref="SECRET"/>
    /// 3. 配置短信签名 <see cref="SING_NAME"/> 
    /// 4. 配置短信模板 <see cref="HRCode.Core.SDK.AliDaYu.Core.DaYuSMSTemplates"/>
    /// </summary>
    public class DaYuSdk : SDKBase, ISMSSdk
    {
        public string APP_KEY
        {
            get { return "24453216"; }
        }

        public string SECRET
        {
            get { return "05fdb3dd36fde8da5e8f11d0f9a1dbb8"; }
        }

        public string SING_NAME
        {
            get { return "HRCode测试"; }
        }

        public override string ApiBase
        {
            get
            {
                return "http://gw.api.taobao.com/router/rest";
            }
        }

        public override string TestApiBase
        {
            get
            {
                return "http://gw.api.tbsandbox.com/router/rest";
            }
        }

        public override bool IsTest
        {
            get
            {
                return false;
            }
        }

        public override Dictionary<string, string> Params
        {
            get
            {
                Dictionary<string, string> dic = new Dictionary<string, string>();
                dic.Add("Extend", "");
                dic.Add("SmsType", "normal");
                dic.Add("SmsFreeSignName", SING_NAME);
                return dic;
            }
        }

    }
}
