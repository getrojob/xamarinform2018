using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using App2_lista.Modelo;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App2_lista
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Municipios : ContentPage
     
    {
        private List<Municipio> ListaInternaMunicipio { get; set; }
        private List<Municipio> ListaFiltradaMunicipio { get; set; }
        public Municipios(Estado estado)
		{
			InitializeComponent ();
            ListaInternaMunicipio = Servico.Servico.GetMunicipios(estado.id);
            ListaMunicipios.ItemsSource = ListaInternaMunicipio;

        }

        private void BuscaRapida(object sender, TextChangedEventArgs args)
        {
            ListaFiltradaMunicipio = ListaInternaMunicipio.Where(a => a.nome.Contains(args.NewTextValue)).ToList();

            ListaMunicipios.ItemsSource = ListaFiltradaMunicipio;
        }

    }
}