using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using Region;
using System.Threading;
using System.Net.Http;
using System.Threading.Tasks;


namespace Region.Controler
{
   public class ControlPaises
    {
        public async static Task<List<Models.Paises.PAIS>> getpaisAme()
        {
            List<Models.Paises.PAIS> lispais = new List<Models.Paises.PAIS>();

            using (HttpClient client = new HttpClient())
            {
                var response = await client.GetAsync("https://restcountries.com/v3.1/region/america");
                if (response.IsSuccessStatusCode)
                {
                    var contenido = response.Content.ReadAsStringAsync().Result;
                    lispais = JsonConvert.DeserializeObject<List<Models.Paises.PAIS>>(contenido);

                }
            }
            return lispais;
        }
        ////////////////////////////////////////////
        
        public async static Task<List<Models.Paises.PAIS>> getpaiAsia()
        {
            List<Models.Paises.PAIS> lispais = new List<Models.Paises.PAIS>();

            using (HttpClient client = new HttpClient())
            {
                var response = await client.GetAsync("https://restcountries.com/v3.1/region/Asia");
                if (response.IsSuccessStatusCode)
                {
                    var contenido = response.Content.ReadAsStringAsync().Result;
                    lispais = JsonConvert.DeserializeObject<List<Models.Paises.PAIS>>(contenido);

                }
            }
            return lispais;
        }
        ///////////////////
        ///

        public async static Task<List<Models.Paises.PAIS>> getpaisEuropa()
        {
            List<Models.Paises.PAIS> lispais = new List<Models.Paises.PAIS>();

            using (HttpClient client = new HttpClient())
            {
                var response = await client.GetAsync("https://restcountries.com/v3.1/region/Europa");
                if (response.IsSuccessStatusCode)
                {
                    var contenido = response.Content.ReadAsStringAsync().Result;
                    lispais = JsonConvert.DeserializeObject<List<Models.Paises.PAIS>>(contenido);

                }
            }
            return lispais;
        }
        /////
        ///
        public async static Task<List<Models.Paises.PAIS>> getpaisOceania()
        {
            List<Models.Paises.PAIS> lispais = new List<Models.Paises.PAIS>();

            using (HttpClient client = new HttpClient())
            {
                var response = await client.GetAsync("https://restcountries.com/v3.1/region/Oceania");
                if (response.IsSuccessStatusCode)
                {
                    var contenido = response.Content.ReadAsStringAsync().Result;
                    lispais = JsonConvert.DeserializeObject<List<Models.Paises.PAIS>>(contenido);

                }
            }
            return lispais;
        }
        /////////
        ///
        public async static Task<List<Models.Paises.PAIS>> getpaisAfrica()
        {
            List<Models.Paises.PAIS> lispais = new List<Models.Paises.PAIS>();

            using (HttpClient client = new HttpClient())
            {
                var response = await client.GetAsync("https://restcountries.com/v3.1/region/Africa");
                if (response.IsSuccessStatusCode)
                {
                    var contenido = response.Content.ReadAsStringAsync().Result;
                    lispais = JsonConvert.DeserializeObject<List<Models.Paises.PAIS>>(contenido);

                }
            }
            return lispais;
        }
    }
}

