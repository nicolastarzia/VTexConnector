using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VTexConnector
{
    internal static class Util
    {
        internal static string FormatUrl(string url)
        {
            url = url.Replace("{{accountName}}", Configuration.AccountName);
            url = url.Replace("{{environment}}", Configuration.Environment);
            return url;
        }
    }
}
