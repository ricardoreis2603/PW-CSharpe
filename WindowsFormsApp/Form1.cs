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
            dtgLista.Rows.Clear();
            List<Pessoa> pessoas = new List<Pessoa>();
            pessoas = ps.Ler();
            foreach (var item in pessoas)
            {
                string[] row = new string[3];
                row[0] = item.Id.ToString();
                row[1] = item.Nome;
                row[2] = item.Contato.NumeroTelefone;

                dtgLista.Rows.Add(row);

            }
            if (dtgLista.Columns.Count==3)
	        {
                dtgLista.Columns.Add( addBntExcluir() );

	        }


        }
        private DataGridViewButtonColumn addBntExcluir()
        {
            DataGridViewButtonColumn colBtn = new DataGridViewButtonColumn();
            colBtn.HeaderText = "";
            colBtn.Text = "Excluir";
            colBtn.Name = "btnExcluir";
            colBtn.UseColumnTextForButtonValue = true;
            return colBtn;

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

        private void DtgLista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.ColumnIndex;
            if (index==3)
            {
                
                int indexLinha = e.RowIndex;
                dtgLista.Rows[indexLinha].Cells[1].Value.ToString();
                int id = Convert.ToInt32(dtgLista.Rows[indexLinha].Cells[0].Value);
                ps.Deletar(id);
                CarregarPessoas();
            }
        }
    }
    
}
