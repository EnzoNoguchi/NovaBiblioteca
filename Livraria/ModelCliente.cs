using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livraria
{
    class ModelCliente
    {
        //Declarar variaveis
        private int codigo;
        private string nomeCompleto;
        private string endereco;
        private string telefone;
        private DateTime dataNascimento;
        private string login;
        private string senha;
        private string menu;
     






        public ModelCliente()
        {
            //Instanciando variaveis
            AcessarCodigo = 0;
            AcessarNome = "";
            AcessarEndereco = "";
            AcessarTelefone = "";
            AcessarDataNascimento = new DateTime();
            AcessarLogin = "";
            AcessarSenha = "";
            AcessarMenu = "";
           
            
        }//fim do metodo construtor 






        //==============================================================================================================================================================================================



        public string AcessarMenu
        {
            get
            {
                return menu;
            }
            set
            {
                this.menu = value;
            }
        }//fim do metodo de acesso do menu





        //Desenvolver os metodos gets e sets
        public int AcessarCodigo
        {
            get
            {
                return codigo;
            }
            set
            {
                this.codigo = value;
            }
        }//fim do metodo de acesso do codigo



        public string AcessarNome
        {
            get
            {
                return nomeCompleto;
            }
            set
            {
                this.nomeCompleto = value;
            }
        }//fim do metodo de acesso do nome


       


        public string AcessarEndereco
        {
            get
            {
                return endereco;
            }
            set
            {
                this.endereco = value;
            }
        }//fim do metodo de acesso do endereco



        public string AcessarTelefone
        {
            get
            {
                return telefone;
            }
            set
            {
                this.telefone = value;
            }
        }//fim do metodo de acesso do telefone


        public DateTime AcessarDataNascimento
        {
            get
            {
                return dataNascimento;
            }
            set
            {
                this.dataNascimento = value;
            }
        }//fim do metodo de acesso do nome




        public string AcessarLogin
        {
            get
            {
                return login;
            }
            set
            {
                this.login = value;
            }
        }//fim do metodo de acesso do nome



        public string AcessarSenha
        {
            get
            {
                return senha;
            }
            set
            {
                this.senha = value;
            }
        }//fim do metodo de acesso do nome









        //====================================================================BOTÕES=================================================================================












        public void PrimeiroCadastro(int codigo, string nomeCompleto, string telefone, string endereco, DateTime dataNascimento, string login, string senha)
        {
            AcessarCodigo = codigo;
            AcessarNome = nomeCompleto;
            AcessarTelefone = telefone;
            AcessarEndereco = endereco;
            AcessarDataNascimento = dataNascimento;
            AcessarLogin = login;
            AcessarSenha = senha;
        }//fim do metodo primeiro cadastro









        public void Cadastrar(int codigo, string nomeCompleto, string telefone, string endereco, DateTime dataNascimento, string login, string senha)
        {
            AcessarCodigo = codigo;
            AcessarNome = nomeCompleto;
            AcessarTelefone = telefone;
            AcessarEndereco = endereco;
            AcessarDataNascimento = dataNascimento;
            AcessarLogin = login;
            AcessarSenha = senha;
        }//fim do metodo cadastrar 










        public string Consultar(int codigo)
        {
            if (AcessarCodigo == codigo) 
            {
                return "Codigo: " + AcessarCodigo +
                       "\nNome Completo: " + AcessarNome +
                       "\nTelefone: " + AcessarTelefone +
                       "\nEndereço: " + AcessarEndereco +
                       "\nData de Nascimento: " + AcessarDataNascimento +
                       "\nLogin: " + AcessarLogin +
                       "\nSenha: " + AcessarSenha; 
            }
            else
            {
                return "Codigo Informado Não é Valido!";
            }
        }//fim do metodo Consultar 






        public string AtualizarNomes(int codigo, string nomeCompleto)
        {
            if (AcessarCodigo == codigo)
            {
                AcessarNome = nomeCompleto;
                return "Nome atualizado com Sucesso!";
            }
            else
            {
                return "Codigo Informado Não é Valido!";
            }
        }//fim do metodo atualizarNome






        public string AtualizarTelefone(int codigo, string telefone)
        {
            if (AcessarCodigo == codigo)
            {
                AcessarTelefone = telefone;
                return "Telefone Atualizado com Sucesso";
            }
            else
            {
                return "Codigo digitado não é valido!";
            }
        }//fim do metodo atualizarTelefone





        public string AtualizarEndereco(int codigo, string endereco)
        {
            if (AcessarCodigo == codigo)
            {
                AcessarEndereco = endereco;
                return "Endereço Atualizado com Sucesso";
            }
            else
            {
                return "Codigo digitado não é valido!";
            }
        }//fim do metodo atualizar Endereco





        public string AtualizarDataNascimento(int codigo, DateTime dataNascimento)
        {
            if (AcessarCodigo == codigo)
            {
                AcessarDataNascimento = dataNascimento;
                return "Data Atualizado com Sucesso";
            }
            else
            {
                return "Codigo digitado não é valido!";
            }
        }//fim do metodo atualizar data nascimento







        public string AtualizarLogin(int codigo, string login)
        {
            if (AcessarCodigo == codigo)
            {
                AcessarLogin = login;
                return "Login Atualizado com Sucesso";
            }
            else
            {
                return "Codigo digitado não é valido!";
            }
        }//fim do metodo atualizar login




        public string AtualizarSenha(int codigo, string senha)
        {
            if (AcessarCodigo == codigo)
            {
                AcessarSenha = senha;
                return "Data Atualizado com Sucesso";
            }
            else
            {
                return "Codigo digitado não é valido!";
            }
        }//fim do metodo atualizar senha





    }//fim da classe ModelCliente
}//Fim do projeto
