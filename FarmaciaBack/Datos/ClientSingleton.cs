using FarmaciaBack.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaciaBack.Http
{
    public class ClientSingleton
    {
        private static ClientSingleton instancia;
        private HttpClient client;
        private ClientSingleton()
        {
            client = new HttpClient();
        }
        public static ClientSingleton GetInstance()
        {
            if (instancia == null)
                instancia = new ClientSingleton();
            return instancia;
        }
        public async Task<ResponseHttp> GetAsync(string url) //los metodos siempre devuelven una cadena (json)
        {
            var result = await client.GetAsync(url);
            var content = await result.Content.ReadAsStringAsync();

            return new ResponseHttp(result.StatusCode, content);
        }
        public async Task<ResponseHttp> PostAsync(string url, string json) //los metodos siempre devuelven una cadena (json)
        {
            var result = await client.PostAsync(url, new StringContent(json, Encoding.UTF8, "Application/Json")); //quiero hacer un post y el contenido es una cadena formato HttpContent
            var content = await result.Content.ReadAsStringAsync();

            return new ResponseHttp(result.StatusCode, content);
        }
    }
}
