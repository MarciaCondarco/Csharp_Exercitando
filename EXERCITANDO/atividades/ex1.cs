using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EXERCITANDO
{
    internal class ex1
    {
        public void ExercicioNumeroUm()
        {
            Console.Clear();
            Console.WriteLine("Crie um programa que leia a idade de uma pessoa e informe se ela é maior de idade (18 anos ou mais) ou menor de idade.\n");
            Console.WriteLine("Informe sua idade:");
            int primeiroexercicio = int.Parse(Console.ReadLine());
            if (primeiroexercicio >= 18)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(@"Você é 
█▀▄▀█ ▄▀█ █ █▀█ █▀█   █▀▄ █▀▀   █ █▀▄ ▄▀█ █▀▄ █▀▀
█░▀░█ █▀█ █ █▄█ █▀▄   █▄▀ ██▄   █ █▄▀ █▀█ █▄▀ ██▄\n");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(@"Você é 
█▀▄▀█ █▀▀ █▄░█ █▀█ █▀█   █▀▄ █▀▀   █ █▀▄ ▄▀█ █▀▄ █▀▀
█░▀░█ ██▄ █░▀█ █▄█ █▀▄   █▄▀ ██▄   █ █▄▀ █▀█ █▄▀ ██▄\n");
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
