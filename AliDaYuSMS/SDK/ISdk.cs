using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRCode.Core.SDK
{
    /// <summary>
    /// 接口中公用的配置
    /// </summary>
    public interface ISdk
    {
        /// <summary>
        /// 接口版本，每一个sdk都有自己的版本号
        /// </summary>
        string Version { get; }
        /// <summary>
        /// api基础地址，以/结尾
        /// </summary>
        string ApiBase { get; }
        /// <summary>
        /// api测试地址，以/结尾
        /// </summary>
        string TestApiBase { get; }
        /// <summary>
        /// 是否是测试
        /// </summary>
        bool IsTest { get; }
        /// <summary>
        /// 请求超时时间
        /// </summary>
        int DefaultTimeout { get; }
        /// <summary>
        /// http流读写超时时间
        /// </summary>
        int DefaultReadAndWriteTimeout { get; }
        /// <summary>
        /// 获取地址
        /// </summary>
        /// <returns></returns>
        string GetApiBaseUrl();
        /// <summary>
        /// 参数集合
        /// </summary>
        Dictionary<string, string> Params { get; }
    }
}
