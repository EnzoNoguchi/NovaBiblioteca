using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livraria
{
    class Livros
    {
        //declarar variaveis 
        private int codigo;
        private string livro;
        private double preco;
        private int disponibilidade;
        private string titulo;
        private int anoLancamento;
        private string editora;
        private int numPaginas;





        public Livros()
        {
            //instaciando as variaveis
            AcessarCodigo = 0;
            AcessarLivros = "";
            AcessarPreco = 0;
            AcessarDisponibilidade = 0;
            AcessarTitulo = "";
            AcessarAnoLancamento = 0;
            AcessarEditora = "";
            AcessarNumPaginas = 0;

        }//fim do metodo construtor




        //=============================================================================GETS E SETS==================================================================================


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
        }//fim do metodo de acesso codigo






        public string AcessarLivros
        {
            get
            {
                return livro;
            }
            set
            {
                this.livro = value;
            }
        }//fim do metodo de acesso do livro





        public double AcessarPreco
        {
            get
            {
                return preco;
            }
            set
            {
                this.preco = value;
            }
        }//fim do metodo de acesso do preco





        public int AcessarDisponibilidade
        {
            get
            {
                return disponibilidade;
            }
            set
            {
                this.disponibilidade = value;
            }
        }//fim do metodo de acesso do preco



        public string AcessarTitulo
        {
            get
            {
                return titulo;
            }
            set
            {
                this.titulo = value;
            }
        }//fim do metodo de acesso do livro



        public int AcessarAnoLancamento
        {
            get
            {   
                return anoLancamento;
            }
            set
            {
                this.anoLancamento = value;
            }
        }//fim do metodo de acesso do livro



        public string AcessarEditora
        {
            get
            {
                return editora;
            }
            set
            {
                this.editora = value;
            }
        }//fim do metodo de acesso do livro




        public int AcessarNumPaginas
        {
            get
            {
                return numPaginas;
            }
            set
            {
                this.numPaginas = value;
            }
        }//fim do metodo de acesso do livro

        //====================================================================BOTÕES=================================================================================






        public void CadastrarLivros(int codigo, string livro, double preco, int disponibilidade, string titulo, int anoLancamento, string editora, int numPaginas)
        {
            AcessarCodigo = codigo;
            AcessarLivros = livro;
            AcessarPreco = preco;
            AcessarDisponibilidade = disponibilidade;
            AcessarTitulo = titulo;
            AcessarAnoLancamento = anoLancamento;
            AcessarEditora = editora;
            AcessarNumPaginas = numPaginas;
            
        }//fim do metodo Cadastrar Livro








        public string ConsultarLivros(int codigo)
        {
            if (AcessarCodigo == codigo)
            {
                return "Codigo: " + AcessarCodigo +
                       "\nNome do Livro: " + AcessarLivros +
                       "\nPreço: " + AcessarPreco +
                       "\nDisponibilidade: " + AcessarDisponibilidade +
                       "\nAno de Lançamento: " + AcessarAnoLancamento +
                       "\nEditora: " + AcessarEditora +
                       "\nNumero de Paginas: " + AcessarNumPaginas;
            }
            else
            {
                return "Dado Informado Não é Valido!";
            }
        }//fim do metodo ConsultarLivros








        public string AtualizarPreco(int codigo, double preco)
        {
            if (AcessarCodigo == codigo)
            {
                AcessarPreco = preco;
                return "Preço atualizado com Sucesso!";
            }
            else
            {
                return "Dado Informado Não é Valido!";
            }

        }//fim do metodo att preco






        public string AtualizarDisponibilidade(int codigo, int disponibilidade)
        {
            if (AcessarCodigo == codigo)
            {
                AcessarDisponibilidade = disponibilidade;
                return "Disponibilidade atualizada com Sucesso!";
            }
            else
            {
                return "Dado Informado Não é Valido!";
            }
        }//fim do att disponi






        public string AtualizarTitulo(int codigo, string titulo)
        {
            if (AcessarCodigo == codigo)
            {
                AcessarTitulo = titulo;
                return "Titulo atualizado com Sucesso!";
            }
            else
            {
                return "Dado Informado Não é Valido!";
            }
        }//fim do metodo att titulo






        public string AtualizarAnoLancamento(int codigo, int anoLancamento)
        {
            if (AcessarCodigo == codigo)
            {
                AcessarAnoLancamento = anoLancamento;
                return "Ano de Lançamento atualizado com Sucesso!";
            }
            else
            {
                return "Dado Informado Não é Valido!";
            }
        }//fim do metodo att ano lancamento




        public string AtualizarEditora(int codigo, string editora)
        {
            if (AcessarCodigo == codigo)
            {
                AcessarEditora = editora;
                return "Editora atualizada com Sucesso!";
            }
            else
            {
                return "Dado Informado Não é Valido!";
            }
        }//fim do metodo att editora




        public string AtualizarNumPaginas(int codigo, string livro, double preco, int disponibilidade, string titulo, int anoLancamento, string editora, int numPaginas)
        {
            if (AcessarCodigo == codigo)
            {
                AcessarNumPaginas = numPaginas;
                return "Numero de Paginas atualizada com Sucesso!";
            }
            else
            {
                return "Dado Informado Não é Valido!";
            }
        }//fim do metodo att num paginas




    }//fim da classe livros
}//fim do projeto
