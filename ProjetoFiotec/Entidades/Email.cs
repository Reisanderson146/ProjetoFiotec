using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//localização da classe do projeto 
namespace ProjetoFiotec.Entidades
{
    //definição da classe
    public class Email
    {
        //prop + 2x[tab]
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Remetente { get; set; }
        public string Destinatario { get; set; }

        public string Conteudo { get; set; }
    }
}
