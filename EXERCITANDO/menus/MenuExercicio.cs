using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EXERCITANDO
{
    internal class MenuExercicio
    {
        public void Menu()
        {
            //TIRAR O STATIC POR QUE LEVE CHAMA COMO ARQUIVO E NÃO COMO OBJETO MAIS FLEXIVEL 
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("0 - Sair");
            Console.WriteLine("1 - exercicio 01");
            Console.WriteLine("2 - exercicio 02");
            Console.WriteLine("3 - exercicio 03");
            Console.WriteLine("4 - exercicio 04");
            Console.WriteLine("5 - exercicio 05");
            Console.WriteLine("6 - exercicio 06");
            Console.WriteLine("Escolha o exercicio que você gostaria de fazer?");
            int numeroEscolhido = int.Parse(Console.ReadLine());

            switch (numeroEscolhido)
            {
                case 1:

//nome do arquivo   , nome da variavel = nome da função 
                    ex1 variavelex1 = new ex1();
                    //nome da função vai puxar o exercicio
                    variavelex1.ExercicioNumeroUm();
                    break;
                case 2:
                    ex2 variavelex2 = new ex2();
                    variavelex2.ExercicioNumeroDois();
                    break;
                case 3:
                    ex3 variavelex3 = new ex3();
                    variavelex3.ExercicioNumeroTres();
                    break;
                case 4:
                    ex4 variavelex4 = new ex4();
                    variavelex4.ExercicioNumeroQuatro();
                    break;
                case 5:
                    ex5 variavelex5 = new ex5();
                    variavelex5.ExercicioNumeroCinco();
                    break;
                case 6:
                    ex6 variavelex6 = new ex6();
                    variavelex6.ExercicioNumeroSexto();
                    break;
                case 0:
                    Console.Clear();
                    Console.WriteLine(@"
░██████╗░█████╗░██╗███╗░░██╗██████╗░░█████╗░
██╔════╝██╔══██╗██║████╗░██║██╔══██╗██╔══██╗
╚█████╗░███████║██║██╔██╗██║██║░░██║██║░░██║
░╚═══██╗██╔══██║██║██║╚████║██║░░██║██║░░██║
██████╔╝██║░░██║██║██║░╚███║██████╔╝╚█████╔╝
╚═════╝░╚═╝░░╚═╝╚═╝╚═╝░░╚══╝╚═════╝░░╚════╝░");
                    Thread.Sleep(3000);
                    Console.Clear();
                    break;
            }

        }
    }
}
