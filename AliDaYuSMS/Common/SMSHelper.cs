using HRCode.Core.SDK.AliDaYu.Clients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRCode.Core.Common
{
    public static class SMSHelper
    {
        private static Lazy<IDaYuSMSClient> _client = new Lazy<IDaYuSMSClient>(() =>
        {
            return new DaYuSMSClient();
        });

        /// <summary>
        /// 同步发送短信，适用于单条发送
        /// </summary>
        /// <param name="phone">手机号</param>
        /// <param name="msg">发送信息</param>
        /// <param name="returnMsg">返回信息</param>
        /// <returns></returns>
        public static bool Send(string phone, string msg, out string returnMsg)
        {
            var response = _client.Value.Send(phone, msg);
            returnMsg = response.Message;
            return response.Success;
        }

        /// <summary>
        /// 异步发送短信，适用于批量多条发送
        /// </summary>
        /// <param name="phone">手机号</param>
        /// <param name="msg">发送信息</param>
        /// <param name="func">发送回掉函数（是否成功，返回信息）</param>
        public static void SendAsync(string phone, string msg, Func<bool, string, bool> func)
        {
            string returnMsg = string.Empty;

            Func<bool> processer = () =>
            {
                return Send(phone, msg, out returnMsg);
            };
            processer.BeginInvoke((ar) =>
            {
                var result = processer.EndInvoke(ar);
                func.Invoke(result, returnMsg);
            }, null);
        }

    }
}
