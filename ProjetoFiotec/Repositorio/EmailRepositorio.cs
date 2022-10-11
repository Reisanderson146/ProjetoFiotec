using ProjetoFiotec.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ProjetoFiotec.Repositorios
{
    public class EmailRepositorio
    {
        public void CadastrarEmail(Email email)
        {
            var diretorio = "c:\\fiotec";
            var arquivo = $"email_{email.Id}.txt";


            if (!Directory.Exists(diretorio))
                Directory.CreateDirectory(diretorio);


            var streamWriter = new StreamWriter($"{diretorio}\\{arquivo}");


            streamWriter.WriteLine($"ID ...............: {email.Id}");
            streamWriter.WriteLine($"NOME..............: {email.Nome}");
            streamWriter.WriteLine($"REMETENTE.............: {email.Remetente}");
            streamWriter.WriteLine($"DESTINATARIO..........: {email.Destinatario}");
            streamWriter.WriteLine($"CONTEUDO..........: {email.Conteudo}");


            streamWriter.Flush();
            streamWriter.Close();
        }
    }
}
