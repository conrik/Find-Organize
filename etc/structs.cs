using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Find_And_Organize
{
    public class structs
    {
        public struct Arquivo
        {
            public int chave;
            public string nome;
            public string caminho;
            public string extensao;

            public Arquivo(int _chave, string _nome, string _caminho, string _extensao)
            {
                chave = _chave;
                nome = _nome;
                caminho = _caminho;
                extensao = _extensao;
            }
        }

        public struct ListaArquivos
        {
            public List<Arquivo> imagem;
            public List<Arquivo> musica;
            public List<Arquivo> documento;
            public List<Arquivo> video;
        }
    }
}
