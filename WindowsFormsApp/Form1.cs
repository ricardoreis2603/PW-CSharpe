using Dominio;
using Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {

        Pessoa p = new Pessoa();
        PessoaService ps = new PessoaService();


        public Form1()
        {
            InitializeComponent();
            CarregarPessoas();

        }

        private void CarregarPessoas()
        {
            List<Pessoa> pessoas = new List<Pessoa>();
            pessoas = ps.Ler();
            foreach (var item in pessoas)
            {
                DataGridViewRow row = new DataGridViewRow();
                
                dtgLista.Rows.Add(row);
                
                
            }


        }

        private void BtSalvar_Click(object sender, EventArgs e)
        {
            p.Nome = textBoxNome.Text;
            p.Contato.NumeroTelefone = textBoxTelefone.Text;
            ps.Gravar(p);
            Limpar();
            CarregarPessoas();

        }


        private void BtLimpar_Click(object sender, EventArgs e)
        {
            Limpar();

        }

        

        private void Limpar ()
        {
            textBoxNome.Text = string.Empty;
            textBoxTelefone.Text = string.Empty;
        }
        private void Gravar()
        {
           p.Nome = textBoxNome.Text;
           p.Contato.NumeroTelefone = textBoxTelefone.Text;
        }

        
    }
    
}
