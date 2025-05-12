using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion_Escritorio_Proyecto.Model
{
    public class ClientHttp
    {
        HttpClient client;
        public ClientHttp()
        {
            client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7229/");
            client.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json"));
            

        }
        public List<Usuari> GetUsuaris()
        {
            string JSONUsuaris = client.GetAsync("api/Usuaris").Result.Content.ReadAsStringAsync().Result;
            return JsonConvert.DeserializeObject<List<Usuari>>(JSONUsuaris);
        }

        public Usuari GetUsuari(string correu)
        {
            string JSONUsuari = client.GetAsync("api/UsuarisCorreu/" + correu).Result.Content.ReadAsStringAsync().Result;
            return JsonConvert.DeserializeObject<Usuari>(JSONUsuari);
        }

        public async void PostUsuari(Usuari usuari)
        {
            string JSONUsuari = JsonConvert.SerializeObject(usuari);
            JSONUsuari = JSONUsuari.Remove(1, 13);
            HttpContent content = new StringContent(JSONUsuari, Encoding.UTF8, "application/json");
            var response = await client.PostAsync("api/Usuaris", content);

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception(response.ReasonPhrase);
            }
        }

    }
}