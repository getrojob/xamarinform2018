using System;
using System.Collections.Generic;
using System.Text;
using App1_Mimica.Model;
using Xamarin.Forms;
using System.ComponentModel;

namespace App1_Mimica.ViewModel
{
    public class InicioViewModel : INotifyPropertyChanged 
    {
        public Jogo Jogo { get; set; }
        public Command IniciarComand { get; set; }

        public InicioViewModel()
        {
            IniciarComand = new Command(IniciarJogo);
        }

        private void IniciarJogo()
        {
            App.Current.MainPage = new View.Jogo();
        }
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string NameProperty)
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(NameProperty));
            }
        }
    }
}
