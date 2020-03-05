using ApiSample.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ApiSample.Services
{
    class ApiService: ICocktailApi
    {
        const string URL = "https://www.thecocktaildb.com/api/json/v1/1/filter.php?c=";
        public async Task<RootDrink> GetDrinks(string Category)
        {
            HttpClient client = new HttpClient();
            string text = await client.GetStringAsync($"{URL}"+$"{Category}");
            return JsonConvert.DeserializeObject<RootDrink>(text);
        }
    }
}
