using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EXERCITANDO
{
    internal class ex6
    {
        public void ExercicioNumeroSexto()
        {
            Console.Clear();
            Console.WriteLine("Escreva um programa que leia o nome e a idade de uma pessoa e informe se ela pode votar e dirigir (idade mínima de 18 anos).\n");
            Console.WriteLine("Insira o seu nome:");
            string nome = (Console.ReadLine());
            Console.WriteLine("Insira a sua idade:");
            int idade = int.Parse(Console.ReadLine());
            if (idade >= 18)
            {
                Console.WriteLine($"{nome} pode dirigir e votar\n");
            }
            else
            {
                Console.WriteLine($"{nome} não pode dirigir e votar\n");
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
