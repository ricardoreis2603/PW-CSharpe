using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Anotações: .vb; .cs para C#; .java para Java; é possível 2 linguagens para o mesmo programa, pois o .NET assim permite, mas não é recomendável

/*
 * 
 * para comentário longo
 * 
 */

//Atalho 'Ctrl k c' cria comentário para o conteúdo selecionado; 'Ctrl k u' volta tudo
//Atalho 'Ctrl l' apaga uma linha
//Atalho 'Windows' e abre o explorador de arquivos

namespace aula1//cria um grupo classes, ou seja, o namespace é um grupamento de classes; forma-se o namespace, assim, organizam-se distintas classes
{
    class Pessoa
    {
        public string Nome { get; set; }//get pega o método; set atribui o método; a propriedade get set no .NET é uma forma para armazenar o conteúdo dentro da 
        public string NumeroTelefone { get; set;}
        public string Arquivo { get; set; }

        public Pessoa()//atalho para o construtor 'ctor tab tab'  
        {
            Arquivo = @"\\svprwy001\Alunos\AlunosMelhorLinguagem\ListaDeContatos.txt";//@ ignora os caracteres especiais no string; o caminho onde o arquivo é gerado é C:\Users\65471\source\repos\aula1.1\aula1\bin\Debug; acessar via solução - botão direito - abrir pasta no gerenciador de arquivos
        }

        public string DadosPessoa()
        {
            string pessoaDados = Nome + "-" + NumeroTelefone;

            return pessoaDados;
        }

        public void Gravar(Pessoa p)//Gravar é método, dentro dele há a inteligência/lógica
        {
            StreamWriter stream;//ctrl . e selecionar System.IO; StreamWriter para escrever na memória
            stream = File.AppendText(Arquivo);
            stream.WriteLine( p.DadosPessoa() ); 
            stream.Close(); 
        }

        public List<Pessoa> Ler()
        {
            List<Pessoa> pessoas = new List<Pessoa>();

            StreamReader stream;//StreamReader para ler a informação na memória
            stream = File.OpenText(Arquivo);
            while (stream.EndOfStream != true)//whi mais tab tab é o atalho; '!= true' corresponde a '== false'
            {
                string linha = stream.ReadLine();
                string[] pessoaLinha = linha.Split('-');//o Split serve para quebrar uma string de acordo com o caracter
                Pessoa pessoa = new Pessoa(); 
                pessoa.Nome = pessoaLinha[0];
                pessoa.NumeroTelefone = pessoaLinha[1];
                pessoas.Add(pessoa);
            }
            stream.Close();
            return pessoas; 

            //List<Pessoa> pessoas = new List<Pessoa>();//List faz com que se retorne vários dados (pessoas); é uma verdadeira lista; (); chama o construtor da classe

            //Pessoa pessoa1 = new Pessoa();
            //pessoa1.Nome = "João";
            //pessoa1.NumeroTelefone = "1111-1111";

            //Pessoa pessoa2 = new Pessoa();
            //pessoa2.Nome = "Maria";
            //pessoa2.NumeroTelefone = "2222-2222";

            //pessoas.Add(pessoa1);
            //pessoas.Add(pessoa2);
            return pessoas;

        }
    }
}