using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EXERCITANDO
{
    internal class ex3
    {
        public void ExercicioNumeroTres()
        {
            Console.Clear();
            Console.WriteLine("Escreva um programa que verifique se um número fornecido pelo usuário é positivo, negativo ou zero.\n");
            Console.WriteLine("Informe um numero");
            int NumeroEscolhidoExercicioTres = int.Parse(Console.ReadLine());
            if (NumeroEscolhidoExercicioTres >= 1)
            {
                Console.WriteLine(@"
██████╗░░█████╗░░██████╗██╗████████╗██╗██╗░░░██╗░█████╗░
██╔══██╗██╔══██╗██╔════╝██║╚══██╔══╝██║██║░░░██║██╔══██╗
██████╔╝██║░░██║╚█████╗░██║░░░██║░░░██║╚██╗░██╔╝██║░░██║
██╔═══╝░██║░░██║░╚═══██╗██║░░░██║░░░██║░╚████╔╝░██║░░██║
██║░░░░░╚█████╔╝██████╔╝██║░░░██║░░░██║░░╚██╔╝░░╚█████╔╝
╚═╝░░░░░░╚════╝░╚═════╝░╚═╝░░░╚═╝░░░╚═╝░░░╚═╝░░░░╚════╝░");
            }
            if (NumeroEscolhidoExercicioTres < 0)
            {
                Console.WriteLine(@"
███╗░░██╗███████╗░██████╗░░█████╗░████████╗██╗██╗░░░██╗░█████╗░
████╗░██║██╔════╝██╔════╝░██╔══██╗╚══██╔══╝██║██║░░░██║██╔══██╗
██╔██╗██║█████╗░░██║░░██╗░███████║░░░██║░░░██║╚██╗░██╔╝██║░░██║
██║╚████║██╔══╝░░██║░░╚██╗██╔══██║░░░██║░░░██║░╚████╔╝░██║░░██║
██║░╚███║███████╗╚██████╔╝██║░░██║░░░██║░░░██║░░╚██╔╝░░╚█████╔╝
╚═╝░░╚══╝╚══════╝░╚═════╝░╚═╝░░╚═╝░░░╚═╝░░░╚═╝░░░╚═╝░░░░╚════╝░");
            }
            if (NumeroEscolhidoExercicioTres == 0)
            {
                Console.WriteLine(@"
███████╗███████╗██████╗░░█████╗░
╚════██║██╔════╝██╔══██╗██╔══██╗
░░███╔═╝█████╗░░██████╔╝██║░░██║
██╔══╝░░██╔══╝░░██╔══██╗██║░░██║
███████╗███████╗██║░░██║╚█████╔╝
╚══════╝╚══════╝╚═╝░░╚═╝░╚════╝░");
            }
            Thread.Sleep(3000);
            Console.Clear();

            Exibircabecalho variavelCabecalho = new Exibircabecalho();
            variavelCabecalho.Cabecalho();

            MenuExercicio variavelMenu = new MenuExercicio();
            variavelMenu.Menu();
        }
    }
}
