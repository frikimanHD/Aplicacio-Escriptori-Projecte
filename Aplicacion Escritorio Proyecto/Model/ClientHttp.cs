using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        public Comerç GetComerç(int? idComerç)
        {
            string jsonComerç = client.GetAsync("api/Comerç/"+idComerç).Result.Content.ReadAsStringAsync().Result;
            return JsonConvert.DeserializeObject<Comerç>(jsonComerç);
        }
        public async void PutProducte(Producte p)
        {
            JObject jobjectProducte = JObject.FromObject(p);
            string JSONProducte = jobjectProducte.ToString();
            HttpContent content = new StringContent(JSONProducte, Encoding.UTF8, "application/json");
            var response = await client.PutAsync("api/Productes/"+p.CodiDeBarres, content);
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception(response.ReasonPhrase);
            }
        }
        public async void PostProducte(Producte p)
        {
            JObject jobjectProducte = JObject.FromObject(p);
            string JSONProducte = jobjectProducte.ToString();
            HttpContent content = new StringContent(JSONProducte, Encoding.UTF8, "application/json");
            var response = await client.PostAsync("api/Productes", content);
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception(response.ReasonPhrase);
            }
        }

        public async void PostComerç(Usuari usuari, Comerç comerç)
        {
            JObject jobjectComerç = JObject.FromObject(comerç);
            jobjectComerç.Remove("ComerçId");
            jobjectComerç.Remove("sucursals");
            string JSONComerç = jobjectComerç.ToString();
            HttpContent contentComerç = new StringContent(JSONComerç, Encoding.UTF8, "application/json");
            var response = await client.PostAsync("api/Comerç", contentComerç);
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception(response.ReasonPhrase);
            }
            JSONComerç = response.Content.ReadAsStringAsync().Result;
            comerç = JsonConvert.DeserializeObject<Comerç>(JSONComerç);

            usuari.comerçId = comerç.ComerçId;
            string JSONUsuari = JsonConvert.SerializeObject(usuari);
            HttpContent content = new StringContent(JSONUsuari, Encoding.UTF8, "application/json");
            response = await client.PutAsync("api/Usuaris/"+usuari.usuId, content);
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception(response.ReasonPhrase);
            }
        }
        
        public async void PostSucursal(Sucursal sucursal)
        {
           
            JObject jobjectSucursal = JObject.FromObject(sucursal);
            jobjectSucursal.Remove("SucursalId");
            jobjectSucursal.Remove("comerç");
            string JSONSucursal = jobjectSucursal.ToString();
            HttpContent content = new StringContent(JSONSucursal, Encoding.UTF8, "application/json");
            var response = await client.PostAsync("api/Sucursals", content);

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception(response.ReasonPhrase);
            }
        }
        public List<Sucursal> GetSucursalsComerç(int id)
        {
            string jsonSucursal = client.GetAsync("api/Sucursals/Comerç/" + id).Result.Content.ReadAsStringAsync().Result;
            return JsonConvert.DeserializeObject<List<Sucursal>>(jsonSucursal);
        }
        public async void PostUsuari(Usuari usuari)
        {
            JObject jobjectUsuari = JObject.FromObject(usuari);
            jobjectUsuari.Remove("usuId");
            string JSONUsuari = jobjectUsuari.ToString();
            HttpContent content = new StringContent(JSONUsuari, Encoding.UTF8, "application/json");
            var response = await client.PostAsync("api/Usuaris", content);

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception(response.ReasonPhrase);
            }
        }
        public List<Stock> GetStock(int id)
        {
            string jsonStock = client.GetAsync("api/Stock/Sucur/" + id).Result.Content.ReadAsStringAsync().Result;
            return JsonConvert.DeserializeObject<List<Stock>>(jsonStock);
        }
        public Producte GetProducte(string codi)
        {
            string jsonProducte = client.GetAsync("api/Productes/"+codi).Result.Content.ReadAsStringAsync().Result;
            return JsonConvert.DeserializeObject<Producte>(jsonProducte);
        }
    }
}