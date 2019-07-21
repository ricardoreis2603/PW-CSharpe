using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class AcessoDados
    {
        #region CamposPrivados

            private StreamWriter streamWriter;
            private StreamReader streamReader;
            private string caminhoArquivo;
            private string nomeArquivo;
       
        #endregion    // Utilizado para organização dos Códigos
       
        #region Propriedades


        #endregion

        #region Construtor

        public AcessoDados(string arquivo)
        {
            caminhoArquivo = @"\\svprwy001\Alunos\AlunosMelhorLinguagem\";
            nomeArquivo = arquivo;
        }
        #endregion
        
        #region Metodos

        public void Gravar(string linha)
        {
            streamWriter = File.AppendText( caminhoArquivo + nomeArquivo);
            streamWriter.WriteLine(linha);
            streamWriter.Close();
        }
        public List<string > Ler()
        {
            List<string> linhas = new List<string>();


           
            streamReader = File.OpenText(caminhoArquivo + nomeArquivo);
            while (streamReader.EndOfStream != true)
            {
                string linha = streamReader.ReadLine();
                linhas.Add(linha);
                
               
            }
            streamReader.Close();

            return linhas;

        #endregion
        }  
        

        public void Deletar(string nome)
        {
            List<string> linhas = Ler();
            List<string> linhas2 = new List<string>();

            foreach (var item in linhas)
            {

                if (!item.Contains(nome))
                {
                    linhas2.Add(item);
                }

            }
            GravarDelete(linhas2);
        }

        private void GravarDelete(List<string> linhas)
        {
            System.IO.File.Delete(caminhoArquivo + nomeArquivo);
            streamWriter = File.AppendText(caminhoArquivo + nomeArquivo);
            foreach (var item in linhas)
            {
                streamWriter.WriteLine(item);

            }
            streamWriter.Close();
        }
    }






}
