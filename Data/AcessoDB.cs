using Data.Contexto;
using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class AcessoDB
    {
        public List<Pessoa> LerTodos()
        {

            List<Pessoa> pessoas = new List<Pessoa>();
            using (ContextoProway contexto = new ContextoProway())
            {
                pessoas = contexto.Pessoa.ToList();
            }
            return pessoas;
        }
        public void Create(Pessoa pessoa)
        {
            using (ContextoProway contexto = new ContextoProway())
            {
                contexto.Pessoa.Add(pessoa);
                contexto.SaveChanges();
            }
        }
        public void Delete(int id)
        {
            Pessoa p = ListarPorId(id);
            using (ContextoProway contexto = new ContextoProway())
            {

                contexto.Pessoa.Remove(p);
                contexto.SaveChanges();

            }
        }

        public Pessoa ListarPorId(int id)
        {
            Pessoa pessoa = new Pessoa();
            using (ContextoProway contexto = new ContextoProway())
            {
                pessoa = contexto.Pessoa.FirstOrDefault(p=>p.Id == id);

            }
            return pessoa;
        }



    }
}
