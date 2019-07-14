using Data;
using System;// está mais em branco pois está sendo utilizada
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace aula1
{
    class Program
    {
        static void Main(string[] args)
        {                                 
            Pessoa pessoa = new Pessoa();
       
            Console.WriteLine("LISTA DE ALUNOS");
          
            Console.Write("Digite o nome: ");
            pessoa.Nome = Console.ReadLine();

            Console.Write("Digite o telefone: ");
            pessoa.NumeroTelefone = Console.ReadLine();

           pessoa.Gravar();

            List<Pessoa> pessoas = pessoa.Ler();
            Console.WriteLine("*****Lista Pessoas*****");
            foreach (var p in pessoas)
            {
                Console.WriteLine("Nome: " + p.Nome + "-" + p.NumeroTelefone);
            }

            Console.ReadLine();
    


          
        }
    }
}
