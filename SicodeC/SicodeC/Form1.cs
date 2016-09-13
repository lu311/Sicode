using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SicodeC.Classes;
using SicodeC.Banco;

namespace SicodeC
{
    public partial class frmCadastro : Form
    {
        private object bancobf;

        public frmCadastro()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            //teste;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            txtCodigo.Clear();
            txtDataCadastro.Clear();
            txtNome.Clear();
            txtNomeFantasia.Clear();
            txtCpf.Clear();
            txtRg.Clear();

            cbxCategoria.SelectedIndex = -1;

            rdbPessoaFisica.Checked = true;

            ckbCadastroInativo.Checked = false;


        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "")
            {
                MessageBox.Show("O campo nome deve ser preenchido!!", "Atenção");
                txtNome.Focus();
            }

            else if (cbxCategoria.Text == "")
            {
                MessageBox.Show("O tipo de categoria deve ser selecionado!!", "Atenção");
                cbxCategoria.Focus();

            }
            else
            {
                if (MessageBox.Show("Deseja salvar os dados?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Cliente cliente = new Cliente();

                    cliente.TipoCategoria = cbxCategoria.Text;
                    //cliente.Codigo        = Convert.ToInt32(txtCodigo.Text); campo nao tem valor
                    cliente.DataCadastro  = txtDataCadastro.Text;
                    cliente.Nome          = txtNome.Text;
                    cliente.NomeFantasia  = txtNomeFantasia.Text;
                    cliente.Cpf           = txtCpf.Text;
                    cliente.Rg            = txtRg.Text;

                    if (rdbPessoaFisica.Checked)
                        cliente.TipoPessoa = "Fisica";
                    else
                        cliente.TipoPessoa = "Juridica";

                    if (ckbCadastroInativo.Checked)
                        cliente.CadastroInativo = "Inativo";
                    else
                        cliente.CadastroInativo = "Ativo";

                    // teste de acesso ao banco de dados
                    /*
                    BancoFB banco = new BancoFB();
                    banco.abrirConexao();
                    DataTable t = banco.Select("select * from cliente");
                    this.Text = "quantidade de registro na tabela" + t.Rows.Count;
                    lllllllll
                    */
                }
                else
                {
                    txtNome.Focus();
                }
            }
            
        }
    }
}
