using System.Net.Http;
using System.Text;
using Newtonsoft.Json;

namespace LibreTranslate.Net.Enhanced.Utils
{
    internal static class RequestUtils
    {
        public static StringContent ToStringContent<T>(T content)
        {
            return new StringContent(JsonConvert.SerializeObject(content), Encoding.UTF8, "application/json");
        }
    }
}