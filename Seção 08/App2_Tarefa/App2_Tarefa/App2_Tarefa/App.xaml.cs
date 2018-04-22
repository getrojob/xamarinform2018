﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using App2_Tarefa.Telas;

using Xamarin.Forms;

namespace App2_Tarefa
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();

			MainPage = new NavigationPage(new App2_Tarefa.Telas.Inicio());
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
