using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SicodeC.Classes
{
    class Cliente
    {
        private string tipoPessoa;
        private string tipoCategoria;
        private string cadastroInativo;
        private int codigo;
        private string dataCadastro;
        private string nome;
        private string nomeFantasia;
        private string cpf;
        private string rg;

        public string TipoPessoa
        {
            get
            {
                return tipoPessoa;
            }

            set
            {
                tipoPessoa = value;
            }
        }
        public string TipoCategoria
        {
            get
            {
                return tipoCategoria;
            }

            set
            {
                tipoCategoria = value;
            }
        }
        public string CadastroInativo
        {
            get
            {
                return cadastroInativo;
            }

            set
            {
                cadastroInativo = value;
            }
        }
        public int Codigo
        {
            get
            {
                return codigo;
            }

            set
            {
                codigo = value;
            }
        }
        public string DataCadastro
        {
            get
            {
                return dataCadastro;
            }

            set
            {
                dataCadastro = value;
            }
        }
        public string Nome
        {
            get
            {
                return nome;
            }

            set
            {
                nome = value;
            }
        }
        public string NomeFantasia
        {
            get
            {
                return NomeFantasia1;
            }

            set
            {
                NomeFantasia1 = value;
            }
        }
        public string Cpf
        {
            get
            {
                return cpf;
            }

            set
            {
                cpf = value;
            }
        }
        public string Rg
        {
            get
            {
                return rg;
            }

            set
            {
                rg = value;
            }
        }
        
    }
}
