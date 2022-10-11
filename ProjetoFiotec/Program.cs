using ProjetoFiotec.Entidades;
using ProjetoFiotec.Repositorios;

namespace ProjetoFiotec
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("\n ***Email ***  \n");

            var email = new Email();

            email.Id = Guid.NewGuid();

            Console.Write("INFORME O NOME........");
            email.Nome = Console.ReadLine();

            Console.Write("INFORME O REMETENTE.....: ");
            email.Remetente = Console.ReadLine();

            Console.Write("INFORME O DESTINATARIO.........: ");
            email.Destinatario = Console.ReadLine();

            Console.Write("Conteudo da Mensagem.....: ");
            email.Conteudo = Console.ReadLine();



            Console.WriteLine("\nDADOS DO EMAIL:");
            Console.WriteLine($"\tID........................: {email.Id}");
            Console.WriteLine($"\tNOME......................: {email.Nome}");
            Console.WriteLine($"\tEMAIL DO REMETENTE........: {email.Remetente}");
            Console.WriteLine($"\tEMAIL DO DESTINATARIO.....: {email.Destinatario}");
            Console.WriteLine($"\tCONTEUDO DA MENSAGEM......: {email.Conteudo}");


            var emailRepositorio = new EmailRepositorio();

            emailRepositorio.CadastrarEmail(email);

            Console.WriteLine("\nARQUIVO GRAVADO COM SUCESSO !");

            Console.ReadKey();
        }
    }
}