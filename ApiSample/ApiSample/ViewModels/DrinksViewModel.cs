using ApiSample.Models;
using ApiSample.Services;
using Refit;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace ApiSample.ViewModels
{
    class DrinksViewModel : INotifyPropertyChanged
    {
        ICocktailApi _service = new ApiService();
        public RootDrink Drinks { get; set; }
        public ObservableCollection<Drink> DrinkList { get; set; }
      
        public ICommand GetDrinksCommand { get; set; }
        public string Category { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
        async void GetDataAsync()
        {
            if (Connectivity.NetworkAccess == NetworkAccess.Internet)
            {
                try
                {
                     var list = await _service.GetDrinks(Category);
                    DrinkList = new ObservableCollection<Drink>( list.Drinks);
                    
                }
                catch (Exception ex)
                {
                    Debug.WriteLine($"API EXCEPTION {ex}");
                }

            }
            else
            {
                await App.Current.MainPage.DisplayAlert("No internet Conecction", "Please connect to Internet", "Ok");
            }

        }

        public DrinksViewModel()
        {
            GetDrinksCommand = new Command(GetDataAsync);
            GetDataAsync();
        }
    }
}
