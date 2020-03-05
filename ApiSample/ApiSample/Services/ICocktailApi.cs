using ApiSample.Models;
using Refit;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

namespace ApiSample.Services
{
    interface ICocktailApi
    {
        Task<RootDrink> GetDrinks(string Category);
    }
}
