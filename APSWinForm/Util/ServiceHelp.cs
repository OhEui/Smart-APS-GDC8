using Newtonsoft.Json;
using System;
using System.Configuration;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using APSVO;

namespace APSWinForm
{
    public class ServiceHelp : IDisposable
    {
        HttpClient client = new HttpClient();

        public string BaseServiceUrl { get; set; }

        public ServiceHelp(string routePrefix)
        {
            BaseServiceUrl = $"{ConfigurationManager.AppSettings["ApiAddress"]}/{routePrefix}/";

            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
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

        public async Task<WebMessage<T>> PostAsync<T>(string path, T t)
        {
            path = BaseServiceUrl + path;

            WebMessage<T> result = null;
            try
            {
                using (HttpResponseMessage response = await client.PostAsJsonAsync(path, t))
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

        public async Task<WebMessage> PostAsyncNone<T>(string path, T t)
        {
            path = BaseServiceUrl + path;
            //https://localhost:44337/api/User/SaveUser

            WebMessage result = null;
            try
            {                
                using (HttpResponseMessage response = await client.PostAsJsonAsync(path, t))
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
