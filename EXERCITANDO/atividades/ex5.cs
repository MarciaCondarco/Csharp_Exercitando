using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EXERCITANDO
{
    internal class ex5
    {
        public void ExercicioNumeroCinco()
        {
            Console.Clear();
            Console.WriteLine("Crie um programa que determine se um ano é bissexto.");
            Console.WriteLine("Informe um ano desejado");
            int numeroAno = int.Parse(Console.ReadLine());
            Console.Clear();
            if (numeroAno % 4 == 0)
            {
                Console.WriteLine("ano bissexto\n");
            }
            else
            {
                Console.WriteLine("Não é ano bissexto\n");
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
