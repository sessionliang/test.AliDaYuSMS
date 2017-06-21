using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRCode.Core.SDK.SMS
{
    public abstract class SMSResponseBase
    {
        public virtual Dictionary<string, string> ErrorDic { get; }

        public SMSResponseBase(string code)
        {
            Code = code;
        }
        public virtual string Code { get; set; }

        public virtual string Message
        {
            get
            {
                return ErrorDic[Code];
            }
        }

        public abstract bool Success { get; }
    }
}
