using HRCode.Core.SDK.SMS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRCode.Core.SDK.AliDaYu.Models
{
    public class DaYuSMSSendResponse : SMSResponseBase
    {

        public override Dictionary<string, string> ErrorDic
        {
            get
            {
                var dic = new Dictionary<string, string>();
                dic.Add("00", "提交成功");
                dic.Add("isv.OUT_OF_SERVICE", "业务停机");
                dic.Add("isv.PRODUCT_UNSUBSCRIBE", "产品服务未开通");
                dic.Add("isv.ACCOUNT_NOT_EXISTS", "账户信息不存在");
                dic.Add("isv.ACCOUNT_ABNORMAL", "账户信息异常");
                dic.Add("isv.SMS_TEMPLATE_ILLEGAL", "模板不合法");
                dic.Add("isv.SMS_SIGNATURE_ILLEGAL", "签名不合法");
                dic.Add("isv.MOBILE_NUMBER_ILLEGAL", "手机号码格式错误");
                dic.Add("isv.MOBILE_COUNT_OVER_LIMIT", "手机号码数量超过限制");
                dic.Add("isv.TEMPLATE_MISSING_PARAMETERS", "短信模板变量缺少参数");
                dic.Add("isv.INVALID_PARAMETERS", "参数异常");
                dic.Add("isv.BUSINESS_LIMIT_CONTROL", "触发业务流控限制");
                dic.Add("isv.INVALID_JSON_PARAM", "JSON参数不合法");
                dic.Add("isp.SYSTEM_ERROR", "isp.SYSTEM_ERROR");
                dic.Add("isv.BLACK_KEY_CONTROL_LIMIT", "模板变量中存在黑名单关键字。如：阿里大鱼");
                dic.Add("isv.PARAM_NOT_SUPPORT_URL", "不支持url为变量");
                dic.Add("isv.PARAM_LENGTH_LIMIT", "变量长度受限");
                dic.Add("isv.AMOUNT_NOT_ENOUGH", "余额不足");
                dic.Add("isv.appkey-not-exists", "APPKey不存在");
                return dic;
            }
        }

        public DaYuSMSSendResponse(string code)
            : base(code)
        {

        }

        public override bool Success
        {
            get
            {
                return Code == "00";
            }
        }
    }
}
