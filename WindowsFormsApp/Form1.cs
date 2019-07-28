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
            dtgLista.DataSource = ps.Ler();
        }

        private void BtSalvar_Click(object sender, EventArgs e)
        {
            p.Nome = textBoxNome.Text;
            p.NumeroTelefone = textBoxTelefone.Text;
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
           p.NumeroTelefone = textBoxTelefone.Text;
        }

        
    }
    
}
