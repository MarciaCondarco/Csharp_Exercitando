using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EXERCITANDO
{
    internal class ex2
    {
        public void ExercicioNumeroDois()
        {
            Console.Clear();
            Console.WriteLine("Faça um programa que leia a nota de um aluno e informe se ele está aprovado (nota maior ou igual a 7), em recuperação (nota entre 5 e 7) ou reprovado (nota menor que 5).\n");
            Console.WriteLine("Informe a nota que recebeu na prova");
            int segundoexercicio = int.Parse(Console.ReadLine());
            if (segundoexercicio >= 7)
            {
                Console.WriteLine(@"
░█████╗░██████╗░██████╗░░█████╗░██╗░░░██╗░█████╗░██████╗░░█████╗░
██╔══██╗██╔══██╗██╔══██╗██╔══██╗██║░░░██║██╔══██╗██╔══██╗██╔══██╗
███████║██████╔╝██████╔╝██║░░██║╚██╗░██╔╝███████║██║░░██║██║░░██║
██╔══██║██╔═══╝░██╔══██╗██║░░██║░╚████╔╝░██╔══██║██║░░██║██║░░██║
██║░░██║██║░░░░░██║░░██║╚█████╔╝░░╚██╔╝░░██║░░██║██████╔╝╚█████╔╝
╚═╝░░╚═╝╚═╝░░░░░╚═╝░░╚═╝░╚════╝░░░░╚═╝░░░╚═╝░░╚═╝╚═════╝░░╚════╝░");
            }
            else
                if (segundoexercicio >= 5 && segundoexercicio < 7)
            {
                Console.WriteLine(@"
██████╗░███████╗░█████╗░██╗░░░██╗██████╗░███████╗██████╗░░█████╗░░█████╗░░█████╗░░█████╗░
██╔══██╗██╔════╝██╔══██╗██║░░░██║██╔══██╗██╔════╝██╔══██╗██╔══██╗██╔══██╗██╔══██╗██╔══██╗
██████╔╝█████╗░░██║░░╚═╝██║░░░██║██████╔╝█████╗░░██████╔╝███████║██║░░╚═╝███████║██║░░██║
██╔══██╗██╔══╝░░██║░░██╗██║░░░██║██╔═══╝░██╔══╝░░██╔══██╗██╔══██║██║░░██╗██╔══██║██║░░██║
██║░░██║███████╗╚█████╔╝╚██████╔╝██║░░░░░███████╗██║░░██║██║░░██║╚█████╔╝██║░░██║╚█████╔╝
╚═╝░░╚═╝╚══════╝░╚════╝░░╚═════╝░╚═╝░░░░░╚══════╝╚═╝░░╚═╝╚═╝░░╚═╝░╚════╝░╚═╝░░╚═╝░╚════╝░");
            }
            else
            {
                Console.WriteLine(@"
██████╗░███████╗██████╗░██████╗░░█████╗░██╗░░░██╗░█████╗░██████╗░░█████╗░
██╔══██╗██╔════╝██╔══██╗██╔══██╗██╔══██╗██║░░░██║██╔══██╗██╔══██╗██╔══██╗
██████╔╝█████╗░░██████╔╝██████╔╝██║░░██║╚██╗░██╔╝███████║██║░░██║██║░░██║
██╔══██╗██╔══╝░░██╔═══╝░██╔══██╗██║░░██║░╚████╔╝░██╔══██║██║░░██║██║░░██║
██║░░██║███████╗██║░░░░░██║░░██║╚█████╔╝░░╚██╔╝░░██║░░██║██████╔╝╚█████╔╝
╚═╝░░╚═╝╚══════╝╚═╝░░░░░╚═╝░░╚═╝░╚════╝░░░░╚═╝░░░╚═╝░░╚═╝╚═════╝░░╚════╝░");
            }
            Thread.Sleep(3000);
            Console.Clear();

            Exibircabecalho variavelCabecalho = new Exibircabecalho();
            variavelCabecalho.Cabecalho();
            Console.Clear() ;
            MenuExercicio variavelMenu = new MenuExercicio();
            variavelMenu.Menu();
        }
    }
}
