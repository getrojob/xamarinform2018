using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using App1_Cell.Modelo;

namespace App1_Cell.Pagina
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ImageCellPage : ContentPage
    {
        public ImageCellPage()
        {
            InitializeComponent();

            List<Funcionario> Lista = new List<Funcionario>();
            Lista.Add(new Funcionario() { Foto = "https://secure.gravatar.com/avatar/fa277eb513a17338d73c393f8c3d8706?s=49&d=mm&r=g", Nome = "José", Cargo = "Presidente da Empresa" });
            Lista.Add(new Funcionario() { Foto = "http://www.paulagiannasi.com.br/site/wp-content/uploads/paula-50x50-50x50.png", Nome = "Maria", Cargo = "Gerente de Vendas" });
            Lista.Add(new Funcionario() { Foto = "http://www.paulagiannasi.com.br/site/wp-content/uploads/AnePNG-50x50-50x50.png", Nome = "Elaine", Cargo = "Gerente de Marketing" });
            Lista.Add(new Funcionario() { Foto = "http://www.paulagiannasi.com.br/site/wp-content/uploads/luiz-fernando-lima-appelt-50x50-50x50.png", Nome = "Felipe", Cargo = "Entregador" });
            Lista.Add(new Funcionario() { Foto = "http://0.gravatar.com/avatar/faa30661064303deca9663cade1807e1?s=50&d=mm&r=g", Nome = "João", Cargo = "Vendedor" });

            ListaFuncionario.ItemsSource = Lista;
        }
    }
}