using System.Net.Http;
using Unirest.Request;

namespace Unirest.Http
{
    public class Unirest
    {
        // Should add overload that takes URL object
        public static HttpRequest Get(string url)
        {
            return new HttpRequest(HttpMethod.Get, url);
        }

        public static HttpRequest Post(string url)
        {
            return new HttpRequest(HttpMethod.Post, url);
        }

        public static HttpRequest Delete(string url)
        {
            return new HttpRequest(HttpMethod.Delete, url);
        }

        public static HttpRequest Patch(string url)
        {
            return new HttpRequest(new HttpMethod("PATCH"), url);
        }

        public static HttpRequest Put(string url)
        {
            return new HttpRequest(HttpMethod.Put, url);
        }

        public static HttpRequest Options(string url)
        {
            return new HttpRequest(HttpMethod.Options, url);
        }

        public static HttpRequest Head(string url)
        {
            return new HttpRequest(HttpMethod.Head, url);
        }

        public static HttpRequest Trace(string url)
        {
            return new HttpRequest(HttpMethod.Trace, url);
        }

        /// <summary>
        /// Throw System.Threading.Tasks.TaskCanceledException when timeout
        /// </summary>
        /// <param name="connectionTimeout"></param>
        public static void SetTimeouts(long connectionTimeout)
        {
            HttpClientHelper.ConnectionTimeout = connectionTimeout;
        }
    }
}
