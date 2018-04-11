using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App02_TipoPaginaXF.TipoPagina.Navigation
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class modal : ContentPage
	{
		public modal ()
		{
			InitializeComponent ();
		}
        private void FecharModal(object sender, EventArgs args)
        {
            /*Navigation.PopAsync();*/// voltar
            /*Navigation.PopToRootAsync(); */// voltar inicio
            Navigation.PopModalAsync();
        }
    }

    
}