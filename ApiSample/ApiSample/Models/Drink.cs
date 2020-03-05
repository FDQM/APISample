using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace ApiSample.Models
{
    public class Drink
    {
        [JsonProperty("strDrink")]
        public string StrDrink { get; set; }

        [JsonProperty("strDrinkThumb")]
        public string StrDrinkThumb { get; set; }

        [JsonProperty("idDrink")]
        public string IdDrink { get; set; }
    }

    public class RootDrink
    {
        [JsonProperty("drinks")]
        public IList<Drink> Drinks { get; set; }
    }
}
