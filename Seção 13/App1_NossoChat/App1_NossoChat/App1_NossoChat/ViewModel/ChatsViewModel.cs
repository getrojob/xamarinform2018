﻿using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using App1_NossoChat.Model;
using App1_NossoChat.Service;
using Xamarin.Forms;
using System.Linq;

namespace App1_NossoChat.ViewModel
{
    public class ChatsViewModel : INotifyPropertyChanged
    {
        private List<Chat> _chats;
        public List<Chat> Chats {
            get { return _chats; }
            set {
                _chats = value;
                OnPropertyChanged("Chats");
            }
        }

        public Command AdicionarCommand {get; set;}
        public Command OrdenarCommand { get; set; }
        public Command AtualizarCommand { get; set; }

        public ChatsViewModel()
        {
            Chats = ServiceWS.GetChats();

            AdicionarCommand = new Command(Adicionar);
            OrdenarCommand = new Command(Ordenar);
            AtualizarCommand = new Command(Atualizar);
        }

        private void Adicionar()
        {
            ((NavigationPage)App.Current.MainPage).Navigation.PushAsync(new View.CadastrarChat());
        }

        private void Ordenar()
        {
            Chats = Chats.OrderBy(a => a.nome).ToList();
        }

        public void Atualizar()
        {
            Chats = ServiceWS.GetChats();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string PropertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(PropertyName));
            }
        }
    }
}
