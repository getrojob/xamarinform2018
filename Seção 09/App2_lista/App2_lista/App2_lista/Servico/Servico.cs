using System;
using System.Collections.Generic;
using System.Text;
using App2_lista.Modelo;
using System.Net;
using Newtonsoft.Json;

namespace App2_lista.Servico
{
    class Servico
    {

        private static string URLestado = "https://servicodados.ibge.gov.br/api/v1/localidades/estados";
        private static string URLmunicipio = "https://servicodados.ibge.gov.br/api/v1/localidades/estados/{0}/municipios";

        public static List<Estado> GetEstados()
        {
            WebClient wc = new WebClient();
            string conteudo = wc.DownloadString(URLestado);

            return JsonConvert.DeserializeObject<List<Estado>>(conteudo);
        }

        public static List<Municipio> GetMunicipios(int estado)
        {
            string NewURL = string.Format(URLmunicipio, estado);
            WebClient wc = new WebClient();
            string conteudo = wc.DownloadString(NewURL);

            return JsonConvert.DeserializeObject<List<Municipio>>(conteudo);

        }
    }
}
