using HRCode.Core.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AliDaYuSMS.Controllers
{
    public class ValuesController : ApiController
    {
        /// <summary>
        /// http://localhost:62358/api/Values/SendSmsTest?phone=手机号码
        /// </summary>
        /// <param name="phone"></param>
        /// <returns></returns>
        [HttpGet]
        public bool SendSmsTest(string phone)
        {
            var code = CreateValidateCode();
            var returnMsg = string.Empty;
            var message = "{name:'test',code:'1234'}";
            SMSHelper.Send(phone, message, out returnMsg);
            return true;
        }

        /// <summary>
        /// 创建验证码
        /// </summary>
        /// <returns></returns>
        private string CreateValidateCode()
        {
            var validateCode = "";

            char[] s = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            var r = new Random();
            for (var i = 0; i < 4; i++)
            {
                validateCode += s[r.Next(0, s.Length)].ToString();
            }
           
            return validateCode;
        }
    }
}
