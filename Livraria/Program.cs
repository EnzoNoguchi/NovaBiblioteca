using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livraria
{
    class Program
    {
        static void Main(string[] args)
        {
            ControlCliente control = new ControlCliente();//Conectando a classe control com o cliente
            control.ExecutarMenu(); //Estou usando o metodo executar
            Console.ReadLine();//
        }//fim do metodo main
    }//fim da classe
}//fim do projeto
