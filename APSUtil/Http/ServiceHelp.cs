using Newtonsoft.Json;
using System;
using System.Configuration;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using APSVO;
using System.Web.Configuration;
using System.Collections.Generic;

namespace APSUtil.Http
{
    /// <summary>
    /// Web API 사용을 위한 유틸리티입니다
    /// </summary>
    public class ServiceHelp : IDisposable
    {
        HttpClient client = new HttpClient();


        public string BaseServiceUrl { get; set; }

        public System.Net.HttpStatusCode StatusCode { get; set; }

        /// <summary>
        /// Web API 사용을 위한 ServiceHelp 인스턴스를 생성합니다. <br/>
        /// <br/>
        /// API 주소: ApiAddress/routePrefix/ <br/>
        /// ApiAddress는 App.config에 저장되어 있습니다. <br/>
        /// <br/>
        /// <br/>
        /// 예시<br/>
        /// ApiAddress: https:localhost::44309<br/>
        /// routePrefix: api/Sample<br/>
        /// => <br/>
        /// API 주소: https:localhost::44309/api/Sample
        /// </summary>
        /// <param name="routePrefix"></param>
        public ServiceHelp(string routePrefix, bool IsWebClient = false)
        {
            string prefix = !string.IsNullOrWhiteSpace(routePrefix) ? $"{routePrefix}/" : string.Empty;

            if (IsWebClient)
            {
                BaseServiceUrl = $"{WebConfigurationManager.AppSettings["ApiAddress"]}/{prefix}";
            }
            else 
            {
                BaseServiceUrl = $"{ConfigurationManager.AppSettings["ApiAddress"]}/{prefix}";
            }
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public ServiceHelp(string routePrefix, string authorization, bool IsWebClient = false) : this(routePrefix, IsWebClient)
        {
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", authorization); // TEST_CODE
        }

        public async Task<T> GetListAsync<T>(string path, T t)
        {
            path = BaseServiceUrl + path;

            T list = default(T);
            try
            {
                using (HttpResponseMessage response = await client.GetAsync(path))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        list = JsonConvert.DeserializeObject<T>(await response.Content.ReadAsStringAsync());
                    }
                }
                return list;
            }
            catch
            {
                return list;
            }
        }

        public async Task<string> GetJsonStringAsync(string path)
        {
            path = BaseServiceUrl + path;

            string result = null;
            try
            {
                using (HttpResponseMessage response = await client.GetAsync(path))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        result = await response.Content.ReadAsStringAsync();
                    }
                }
                return result;
            }
            catch
            {
                return result;
            }
        }

        public async Task<T> GetAsync<T>(string path, T t)
        {
            path = BaseServiceUrl + path;

            T obj = default(T);
            try
            {
                using (HttpResponseMessage response = await client.GetAsync(path))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        WebMessage<T> msg = JsonConvert.DeserializeObject<WebMessage<T>>(await response.Content.ReadAsStringAsync());
                        obj = msg.Data;
                    }
                }
                return obj;
            }
            catch
            {
                return obj;
            }
        }

        public async Task<WebMessage> GetAsync(string path)
        {
            path = BaseServiceUrl + path;

            WebMessage msg = null;
            try
            {
                using (HttpResponseMessage response = await client.GetAsync(path))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        msg = JsonConvert.DeserializeObject<WebMessage>(await response.Content.ReadAsStringAsync());
                    }
                }
                return msg;
            }
            catch
            {
                return msg;
            }
        }

        public async Task<WebMessage<T>> PostAsync<T>(string path, T value)
        {
            path = BaseServiceUrl + path;

            WebMessage<T> result = null;
            try
            {
                using (HttpResponseMessage response = await client.PostAsJsonAsync(path, value))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        result = JsonConvert.DeserializeObject<WebMessage<T>>(await response.Content.ReadAsStringAsync());
                    }
                }
                return result;
            }
            catch
            {
                return result;
            }
        }
        public async Task<T> PostAsyncFormRequest<T>(string path, Dictionary<string, string> request) where T : class
        {
            path = BaseServiceUrl + path;

            var response = await client.PostAsync(path, new FormUrlEncodedContent(request));
            StatusCode = response.StatusCode;
            if (response.IsSuccessStatusCode)
            {
                return response.Content.ReadAsAsync<T>().Result;
            }
            else 
            {
                return default;
            }

        }

        public async Task<WebMessage<TResponse>> PostAsync<TRequest, TResponse>(string path, TRequest value)
        {
            path = BaseServiceUrl + path;

            WebMessage<TResponse> result = null;
            try
            {
                using (HttpResponseMessage response = await client.PostAsJsonAsync(path, value))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        result = JsonConvert.DeserializeObject<WebMessage<TResponse>>(await response.Content.ReadAsStringAsync());
                    }
                }
                return result;
            }
            catch
            {
                return result;
            }
        }

        public async Task<WebMessage> PostAsyncNone<T>(string path, T value)
        {
            path = BaseServiceUrl + path;
            //https://localhost:44337/api/User/SaveUser

            WebMessage result = null;
            try
            {                
                using (HttpResponseMessage response = await client.PostAsJsonAsync(path, value))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        result = JsonConvert.DeserializeObject<WebMessage>(await response.Content.ReadAsStringAsync());
                    }
                }
                return result;
            }
            catch
            {
                return result;
            }
        }

        public void Dispose()
        {
            client.Dispose();
        }
    }
}
