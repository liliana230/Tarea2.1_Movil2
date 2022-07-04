using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Region.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Region.Controler;
using Xamarin.Essentials;

namespace Region
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PagePaises : ContentPage
    {
        public PagePaises()
        {
            InitializeComponent();
        }

        private async void Listapais_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var datos = e.SelectedItem as Paises.PAIS;
            String nombrepais = datos.name.common;
            String capitalpais = datos.capital[0];
            String area = datos.area.ToString();
            String zonah = datos.timezones.ToString();
            Double Lat = datos.latlng[0];
            Double Long = datos.latlng[1];
            String pob = datos.population.ToString();

            Ubicacion ubi = new Ubicacion
            {
                latitud = Lat,
                longitud = Long,
                nombre = nombrepais,
                pcapital = capitalpais,
                area = area,
                zonahoraria = zonah,
                poblacion = pob
            };

            var page = new Mapa();
            page.BindingContext = ubi;
            //await Navigation.PushAsync(page);
            await Navigation.PushAsync(new NavigationPage(page));


        }


        private async void PicketPais_SelectedIndexChanged(object sender, EventArgs e)
        {
            var current = Connectivity.NetworkAccess;

            if (current == NetworkAccess.Internet)
            {
                var picker = (Picker)sender;
                int selectedIndex = picker.SelectedIndex;

                if (selectedIndex == 0)
                {
                    List<Paises.PAIS> ListPais = new List<Paises.PAIS>();
                    ListPais = await ControlPaises.getpaisOceania();
                    Listapais.ItemsSource = ListPais;

                }
                else if (selectedIndex == 1)
                {
                    List<Paises.PAIS> ListPais = new List<Paises.PAIS>();
                    ListPais = await ControlPaises.getpaisAfrica();
                    Listapais.ItemsSource = ListPais;
                }
                else if (selectedIndex == 2)
                {
                    List<Paises.PAIS> ListPais = new List<Paises.PAIS>();
                    ListPais = await ControlPaises.getpaiAsia();
                    Listapais.ItemsSource = ListPais;


                }
                else if (selectedIndex == 3)
                {
                    List<Paises.PAIS> ListPais = new List<Paises.PAIS>();
                    ListPais = await ControlPaises.getpaisEuropa();
                    Listapais.ItemsSource = ListPais;

                }
                else if (selectedIndex == 4)
                {

                    List<Paises.PAIS> ListPais = new List<Paises.PAIS>();
                    ListPais = await ControlPaises.getpaisAme();
                    Listapais.ItemsSource = ListPais;

                }

            }
            else
            {
                await DisplayAlert("Conexion", "No tiene conectividad con Internet", "Ok");

            }

        }
    }
}