using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Text;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace ChatEngine.Service
{
    public abstract class BaseService
    {
        protected HttpWebRequest httpWebRequest;
        protected HttpWebResponse httpResponse;

        /// <summary>
        /// Отправляет запрос на сервер и возврашает ответ
        /// </summary>
        /// <param name="url">Адрес сервера</param>
        /// <param name="reqType">Тип запроса</param>
        /// <param name="Content">Контент</param>
        /// <returns></returns>
        protected object ServerRequest<T>(string url, object Content)
        {
            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create("http://185.174.172.233:1234/" + url);
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                    string output = JsonConvert.SerializeObject(Content);

                    streamWriter.Write(output);
                    streamWriter.Flush();
                    streamWriter.Close();
            }

            var httpResponse = (HttpWebResponse)(httpWebRequest.GetResponse());
            object result;
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var s = streamReader.ReadToEnd();

                result = JsonConvert.DeserializeObject<T>(s);

            }

            return result;
        }
    }
}
