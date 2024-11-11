using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EXERCITANDO
{
    internal class ex4
    {
        public void ExercicioNumeroQuatro()
        {
            Console.Clear();
            Console.WriteLine(" Crie um programa que leia três números e determine qual é o maior.\n");
            Console.WriteLine("informe um numero");
            int numeroprimeiro = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("informe outro numero");
            int numerosegundo = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("informe o ultimo numero");
            int numeroterceiro = int.Parse(Console.ReadLine());
            Console.Clear();
            if (numeroprimeiro > numerosegundo && numeroprimeiro > numeroterceiro)
            {
                Console.WriteLine($"{numeroprimeiro} é o maior numero\n");
            }
            if (numerosegundo > numeroprimeiro && numerosegundo > numeroterceiro)
            {
                Console.WriteLine($"{numerosegundo} é o maior numero\n");
            }
            if (numeroterceiro > numeroprimeiro && numeroterceiro > numerosegundo)
            {
                Console.WriteLine($"{numeroterceiro} é o numero maior\n");
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
