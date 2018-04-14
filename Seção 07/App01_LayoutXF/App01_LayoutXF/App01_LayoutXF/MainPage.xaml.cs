using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App01_LayoutXF
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        private void GoPaginaStack(object send, EventArgs arg)
        {
            Navigation.PushAsync(new Layouts.Stack.StackPage());
        }
        private void GoPaginaGrid(object send, EventArgs arg)
        {
            Navigation.PushAsync(new Layouts.Grid.GridPage());
        }
        private void GoPaginaAbsolute(object send, EventArgs arg)
        {
            Navigation.PushAsync(new Layouts.Absolute.AbsolutePage());
        }
        private void GoPaginaRelative(object send, EventArgs arg)
        {
            Navigation.PushAsync(new Layouts.Relative.RelativePage());
        }
        private void GoPaginaScroll(object send, EventArgs arg)
        {
            Navigation.PushAsync(new Layouts.Scroll.ScrollPage());
        }
    }
}
