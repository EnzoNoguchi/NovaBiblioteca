using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livraria
{
    class ControlCliente
    {
        ModelCliente modelCliente;//conectando a model a control
        
        private int opcao;
        private int menu;




        public ControlCliente()
        {
            modelCliente = new ModelCliente();
        }//fim do contrutor




        //==============================================================================================================================================================================================



        public int AcessarOpcao
        {
            get
            {
                return opcao;
            }
            set
            {
                this.opcao = value;
            }
        }//fim da opcao





        public int AcessarMenu
        {
            get
            {
                return menu;
            }
            set
            {
                this.menu = value;
            }
        }//fim da opcao










        //===============================================================PrimeiroMenu=============================================================================================






        public void PrimeiroMenu()
        {
            Console.WriteLine("Escolha uma das opções abaixo: \n\n" +
                              "1. Cadastrar \n" +
                              "2. Login");
            AcessarMenu = Convert.ToInt32(Console.ReadLine());
        }//fim do metodo menu




        public void ExecutarMenu()
        {
            do
            {
                PrimeiroMenu();
                //executando a ação
                switch(AcessarMenu)
                {
                    case 0:
                        Console.WriteLine("Obrigado!");
                        break;


                    case 1:
                        Console.WriteLine("Crie um login: ");
                        string login = Convert.ToString(Console.ReadLine());
                        Console.WriteLine("Crie um senha: ");
                        string senha = Convert.ToString(Console.ReadLine());
                        Console.WriteLine("Informe um codigo: ");
                        int codigo = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Informe um nome: ");
                        string nomeCompleto = Console.ReadLine();
                        Console.WriteLine("Informe um telefone: ");
                        string telefone = Console.ReadLine();
                        Console.WriteLine("informe um endereço: ");
                        string endereco = Console.ReadLine();
                        Console.WriteLine("informe sua data de nascimento: ");
                        DateTime dataNascimento = Convert.ToDateTime(Console.ReadLine());
                        
                        //Passei o dado por parametro para o metodo
                        modelCliente.Cadastrar(codigo, nomeCompleto, telefone, endereco, dataNascimento, login, senha);
                        //Mostro o dado em tela
                        Console.Clear();
                        Console.WriteLine("Cadastro com Sucesso!");
                        break;






                    case 2:
                        //Pedir para o usuario digitar um codigo
                        Console.WriteLine("Informe o codigo: ");
                        codigo = Convert.ToInt32(Console.ReadLine());
                        //mostrar o resultado da operação
                        Console.WriteLine(modelCliente.Consultar(codigo));
                        Console.Clear();
                        Executar();
                        break;
                   

                }
                    

            } while (AcessarMenu != 0);
        }//fim do executar menu








        //==================================================================Fim PrimeiroMenu=============================================================================================































        //============================================================================================M E N U=============================================================================================



        public void Menu()
        {
            Console.WriteLine("Escolha uma das opções abaixo: \n\n" +
                              "1. Cadastrar \n" +
                              "2. Consultar Usuario \n" +
                              "3. Atualizar Nome\n" +
                              "4. Atualizar Telefone\n" +
                              "5. Atualizar Endereço\n" +
                              "6. Atualizar Data de Nascimento \n" +
                              "7. Atualizar Login \n" +
                              "8. Atualizar Senha \n" +
                              "9. Livros \n" +
                              "9. Sair");
            AcessarOpcao = Convert.ToInt32(Console.ReadLine());

        }//fim do metodo menu




        //==============================================================================================================================================================================================





        public void Executar()
        {
            do
            {
                Menu();
                //executar a ação
                switch (AcessarOpcao)
                {
                    case 0:
                        Console.WriteLine("Obrigado!");
                        break;


                    case 1:
                        Console.WriteLine("Crie um login: ");
                        string login = Convert.ToString(Console.ReadLine());
                        Console.WriteLine("Crie um senha: ");
                        string senha = Convert.ToString(Console.ReadLine());
                        Console.WriteLine("Informe um codigo: ");
                        int codigo = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Informe um nome: ");
                        string nomeCompleto = Console.ReadLine();
                        Console.WriteLine("Informe um telefone: ");
                        string telefone = Console.ReadLine();
                        Console.WriteLine("informe um endereço: ");
                        string endereco = Console.ReadLine();
                        Console.WriteLine("informe sua data de nascimento: ");
                        DateTime dataNascimento = Convert.ToDateTime(Console.ReadLine());

                        //Passei o dado por parametro para o metodo
                        modelCliente.Cadastrar(codigo, nomeCompleto, telefone, endereco, dataNascimento, login, senha);
                        //Mostro o dado em tela
                        Console.WriteLine("Cadastro com Sucesso!");
                        break;

                    
                    
                    
                    
                    
                    case 2:
                        //Pedir para o usuario digitar um codigo
                        Console.WriteLine("Informe o codigo: ");
                        codigo = Convert.ToInt32(Console.ReadLine());
                        //mostrar o resultado da operação
                        Console.Clear();
                        Console.WriteLine(modelCliente.Consultar(codigo));
                        break;






                    case 3:
                        //Pedir para o usuario digitar o codigo e o novo nome
                        Console.WriteLine("Informe um codigo: ");
                        codigo = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Informe um nome: ");
                        nomeCompleto = Console.ReadLine();
                        //Utilizar o metodo da classe model
                        Console.Clear();
                        Console.WriteLine(modelCliente.AtualizarNomes(codigo, nomeCompleto));
                        break;





                    case 4:
                        //Pedir para o usuario digitar o codigo e o novo nome
                        Console.WriteLine("Informe um codigo: ");
                        codigo = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Informe um telefone: ");
                        telefone = Console.ReadLine();
                        //Utilizar o metodo da classe model
                        Console.Clear();
                        Console.WriteLine(modelCliente.AtualizarTelefone(codigo, telefone));
                        break;



                    case 5:
                        //Pedir para o usuario digitar o codigo e o novo nome
                        Console.WriteLine("Informe um codigo: ");
                        codigo = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Informe um endereço: ");
                        endereco = Console.ReadLine();
                        //Utilizar o metodo da classe model
                        Console.Clear();
                        Console.WriteLine(modelCliente.AtualizarNomes(codigo, endereco));
                        break;




                    case 6:
                        //Pedir para o usuario digitar o codigo e o novo nome
                        Console.WriteLine("Informe um codigo: ");
                        codigo = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Informe sua data de nascimento: ");
                        dataNascimento = Convert.ToDateTime(Console.ReadLine());
                        //Utilizar o metodo da classe model
                        Console.Clear();
                        Console.WriteLine(modelCliente.AtualizarDataNascimento(codigo, dataNascimento));
                        break;




                    case 7:
                        //Pedir para o usuario digitar o codigo e o novo nome
                        Console.WriteLine("Informe um codigo: ");
                        codigo = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Informe o sue login: ");
                        login = Console.ReadLine();
                        //Utilizar o metodo da classe model
                        Console.Clear();
                        Console.WriteLine(modelCliente.AtualizarLogin(codigo, login));
                        break;




                    case 8:
                        //Pedir para o usuario digitar o codigo e o novo nome
                        Console.WriteLine("Informe um codigo: ");
                        codigo = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Informe a sua senha: ");
                        senha = Console.ReadLine();
                        //Utilizar o metodo da classe model
                        Console.Clear();
                        Console.WriteLine(modelCliente.AtualizarSenha(codigo, senha));
                        break;


                    case 9:












                    default:
                        Console.Clear();
                        Console.WriteLine("Codigo digitado não é valido!");
                        break;

                }//fim do switch
            } while (AcessarOpcao != 0);



        }//fim do executar




    }//fim da control
}//fim do projeto
