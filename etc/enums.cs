using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Find_And_Organize
{
    public class enums
    {
        public enum Modos_Pesquisa
        {
            MFT,
            Arvore,
            Nenhum
        }

        public enum Destino
        {
            Unico,
            Multiplo,
            Padrao
        }

        public enum Modo
        {
            Imagem,
            Musica,
            Video,
            Documento,
            Todos
        }
    }
}
