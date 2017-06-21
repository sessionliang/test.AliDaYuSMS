using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRCode.Core.SDK.Common
{
    public abstract class SDKBase : ISdk
    {
        public virtual string Version
        {
            get { return "1.0.0"; }
        }

        public virtual int DefaultReadAndWriteTimeout
        {
            get
            {
                return 1200000;
            }
        }

        public virtual int DefaultTimeout
        {
            get
            {
                return 1200000;
            }
        }

        public virtual string GetApiBaseUrl()
        {
            if (IsTest)
                return TestApiBase;
            else
                return ApiBase;
        }

        public abstract string ApiBase { get; }

        public abstract string TestApiBase { get; }

        public abstract bool IsTest { get; }

        public abstract Dictionary<string, string> Params { get; }
    }
}
