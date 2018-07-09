﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Net.Http;
using App1_NossoChat.Model;
using Newtonsoft.Json;

namespace App1_NossoChat.Service
{
    public class ServiceWS
    {
        private static string EndererecoBase = "http://ws.spacedu.com.br/xf2018/rest/api";
        public static Usuario GetUsuario(Usuario usuario)
        {
            var URL = EndererecoBase + "/usuario";

            /* 
             * QueryString
             * StringContent param = new StringContent(string.Format("nome={0}&password={1}", usuario.password));
             */
            FormUrlEncodedContent param = new FormUrlEncodedContent(new[] {
                new KeyValuePair<string, string>("nome", usuario.nome),
                new KeyValuePair<string, string>("nome", usuario.password)
            });

            HttpClient requisicao = new HttpClient();
            HttpResponseMessage resposta = requisicao.PostAsync(URL, param).GetAwaiter().GetResult();

            if(resposta.StatusCode == HttpStatusCode.OK)
            {
                //TODO - Deserializar, retonar no met e Salvar como login

            }

            return null;
        }

        public static List<Chat> GetChats()
        {
            var URL = EndererecoBase + "/chats";

            HttpClient requisicao = new HttpClient();
            HttpResponseMessage resposta = requisicao.GetAsync(URL).GetAwaiter().GetResult();

            if (resposta.StatusCode == HttpStatusCode.OK)
            {
               string conteudo = resposta.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                if(conteudo.Length > 2)
                {
                    List<Chat> lista = JsonConvert.DeserializeObject<List<Chat>>(conteudo);
                }
                else
                {
                    return null;
                } 
            }
            
            return null;
            
        }
        
        public static bool InsertChat(Chat chat)
        {
            var URL = EndererecoBase + "/chat";

            FormUrlEncodedContent param = new FormUrlEncodedContent(new[] {
                new KeyValuePair<string, string>("nome", chat.nome),

            });

            HttpClient requisicao = new HttpClient();
            HttpResponseMessage resposta = requisicao.PostAsync(URL, param).GetAwaiter().GetResult();

            if (resposta.StatusCode == HttpStatusCode.OK)
            {
                return true;
            }

            return false;
        }
        public static bool RenomearChat(Chat chat)
        {
            var URL = EndererecoBase + "/chat/" + chat.id;

            FormUrlEncodedContent param = new FormUrlEncodedContent(new[] {
                new KeyValuePair<string, string>("nome", chat.nome),

            });

            HttpClient requisicao = new HttpClient();
            HttpResponseMessage resposta = requisicao.PutAsync(URL, param).GetAwaiter().GetResult();

            if (resposta.StatusCode == HttpStatusCode.OK)
            {
                return true;
            }

            return false;
        }
        public static bool DeleteChat(Chat chat)
        {
            var URL = EndererecoBase + "/chat/delete" + chat.id;

            HttpClient requisicao = new HttpClient();
            HttpResponseMessage resposta = requisicao.DeleteAsync(URL).GetAwaiter().GetResult();

            if (resposta.StatusCode == HttpStatusCode.OK)
            {
                return true;
            }
            return false;
        }
        public static bool GetMensagemChat(Chat chat)
        {
            var URL = EndererecoBase + "/chat/delete" + chat.id;

            HttpClient requisicao = new HttpClient();
            HttpResponseMessage resposta = requisicao.DeleteAsync(URL).GetAwaiter().GetResult();

            if (resposta.StatusCode == HttpStatusCode.OK)
            {
                return true;
            }
            return false;
        }
        public static List<Mensagem> GetMensagensChat(Chat chat)
        {
            var URL = EndererecoBase + "/chat/" + chat.id + "/msg";

            HttpClient requisicao = new HttpClient();
            HttpResponseMessage resposta = requisicao.GetAsync(URL).GetAwaiter().GetResult();

            if (resposta.StatusCode == HttpStatusCode.OK)
            {
                string conteudo = resposta.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                if(conteudo.Length > 2) { }
                List<Mensagem> lista = JsonConvert.DeserializeObject<List<Mensagem>>(conteudo);
                return lista;
            }
            else
            {
                return null;
            }
         return null;
        }
        public static bool InsertMensagem(Mensagem mensagem)
        {
            var URL = EndererecoBase + "/chat/" + mensagem.id_chat + "/msg";

            FormUrlEncodedContent param = new FormUrlEncodedContent(new[] {
                new KeyValuePair<string, string>("mensagem", mensagem.mensagem),
                new KeyValuePair<string, string>("id_usuario", mensagem.id_usuario.ToString())

            });

            HttpClient requisicao = new HttpClient();
            HttpResponseMessage resposta = requisicao.PostAsync(URL, param).GetAwaiter().GetResult();

            if (resposta.StatusCode == HttpStatusCode.OK)
            {
                return true;
            }

            return false;

        }

    }
}
