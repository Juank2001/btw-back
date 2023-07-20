using System.Net.Http.Headers;

namespace Btw.models
{
    public class http
    {
        public dynamic httpRequest(string request, string path, object data)
        {
            try
            {
                HttpClient client = new HttpClient();

                if (client.BaseAddress == null)
                    client.BaseAddress = new Uri("https://api.escuelajs.co/api/v1/");
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = new HttpResponseMessage();
                if (request == "post")
                {
                    response = client.PostAsJsonAsync(path, data).Result;
                }else if (request == "get")
                {
                    response = client.GetAsync(path).Result;
                }

                if (response.IsSuccessStatusCode)
                {
                    var resultado = response.Content.ReadAsStringAsync().Result;
                    return resultado;
                }
                else
                {
                    var resultado = response.Content.ReadAsStringAsync().Result;
                    throw new Exception(string.Format("Message:{0}, ExceptionMessage: {1}"));
                }

            }
            catch (Exception ex)
            {
                throw new Exception(string.Format("Message:{0}, ExceptionMessage: {1}", ex.Message));
            }
        }
    }
}
