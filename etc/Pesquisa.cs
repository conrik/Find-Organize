using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Find_And_Organize
{
    public class Pesquisa
    {
        public static IEnumerable<string> Arvore(string raiz)
        {
            var arquivos = new Queue<string>();
            arquivos.Enqueue(raiz);

            while (arquivos.Count > 0)
            {
                string dir = arquivos.Dequeue();
                string[] subdir = new string[0];
                string[] arq = new string[0];

                try
                {
                    subdir = Directory.GetDirectories(dir);
                    arq = Directory.GetFiles(dir, "*");
                }
                catch
                {
                }

                foreach (string sub in subdir)
                    arquivos.Enqueue(sub);
                foreach (string nome in arq)
                    yield return nome;
            }
        }

        public static string[] filtro_imagem = { ".gif", ".jpg", ".png", ".bmp" };

        public static string[] filtro_musica = { ".mp3", ".flac", ".wav", ".wma", "", ".XM", ".xm", ".MOD", ".it", ".S3M", ".ogg", ".s3m", ".IT", ".mid", ".MID", ".OXM", ".keygen", ".v2m", ".sc68", ".fc14", ".fc13", ".d00", ".rad", ".ym", ".ahx", ".sid", ".hsc", ".bp", ".mo3", ".mtm", ".amd" };

        public static string[] filtro_documento = { ".docx", ".doc", ".pdf", ".txt", ".pub", ".pubx", ".xls", ".xlsx", ".mobi", ".one" };

        public static string[] filtro_video = { ".mp4", ".mkv", ".wmv", ".flv", ".avi", ".mpg" };

        public static string VefTipo(string extensao)
        {
                for (int i = 0; i < filtro_imagem.Length; i++)
                    if (extensao.Equals(filtro_imagem[i]))
                        return "IMG";

                for (int i = 0; i < filtro_musica.Length; i++)
                    if (extensao.Equals(filtro_musica[i]))
                        return "MUS";

                for (int i = 0; i < filtro_documento.Length; i++)
                    if (extensao.Equals(filtro_documento[i]))
                        return "DOC";

                for (int i = 0; i < filtro_video.Length; i++)
                    if (extensao.Equals(filtro_video[i]))
                        return "VID";

            return null;
        }
    }
}
