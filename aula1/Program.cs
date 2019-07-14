using System;// está mais em branco pois está sendo utilizada
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// > Aula 07/07/2019 - anotações.
// - C# Fundamentos: solução é um contêiner que abarca vários projetos; C# é linguagem orientada a objetos.

namespace aula1
{
    class Program//termos reservados para a linguagem; pode usar o underline para diferenciar
    {
        static void Main(string[] args)//classe padrão; sempre irá mostrar estes parâmetros; dentro da classe há os métodos; String, com letra maiúscula, tem mais recursos que o string
                                       //método Main retorna o static void   
        {
            Console.WriteLine("LISTA DE ALUNOS");
            Console.WriteLine(" ");

            Pessoa pessoa = new Pessoa();//atalho 'Ctrl .' dá sugestões quando estiver sublinhado em vermelho; projetos precisam estar no mesmo nível de pastas

            Console.Write("Digite o nome: ");
            pessoa.Nome = Console.ReadLine();

            Console.Write("Digite o telefone: ");
            pessoa.NumeroTelefone = Console.ReadLine();//overflow ocorre quando estoura o número que se tentou armazenar na variável; solução, muda-se de int para string

            string pessoaDados = pessoa.Nome + " - " + pessoa.NumeroTelefone;
            Console.WriteLine(pessoaDados);

            string dados = pessoa.DadosPessoa();//dá para chamar o método .DadosPessoa, o Visual Studio indica-o automaticamente
            Console.WriteLine(dados);

            pessoa.Gravar(pessoa); 


            //List<Pessoa> pessoas = pessoa.Ler();

            //Console.WriteLine(pessoas.Count);//contador
            //Console.WriteLine("Contador.");

            //Console.WriteLine ( pessoas.Last() );//exibe o último objeto da lista
            //Console.WriteLine("Último da lista.");

            //Console.WriteLine ( pessoas.Last().Nome );//exibe o último objeto da lista com o nome
            //Console.WriteLine(" ");

            //foreach (Pessoa p in pessoas)//Pessoa pode ser substituído por var; para formar um laço de repetição
            //{
            //    Console.WriteLine( p.DadosPessoa() );
            //}
            //Console.WriteLine(" ");

            //Pessoa p1 = pessoas.Last();//Last pode ser substituído por First
            //Console.WriteLine( p1.DadosPessoa() );
            //Console.WriteLine(" ");
           

            Console.ReadLine();


            //primeiro código

            string frase;//string é conjunto de letras; declaração da variável; para armazenar este tipo de dado; int é para números inteiros

            Console.WriteLine("Olá mundo.");//escreve uma linha 

            Console.Write("Digite uma frase: ");
            frase = Console.ReadLine(); //lê e mostra a frase, isto é, o conteúdo armazenado dentro da variável frase

            Console.Write("A frase escrita foi: ");//no Write não se pula linha; no WriteLine pula a linha
            Console.WriteLine(frase);//atalho 'cw tab tab' cola o código: Console.WriteLine();  

            Console.ReadLine();
        }
    }
}
