using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EXERCITANDO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Exibircabecalho variavelCabecalho = new Exibircabecalho();
            variavelCabecalho.Cabecalho();

            //chamando cabeçalho

            MenuExercicio variavelMenu = new MenuExercicio();
            variavelMenu.Menu();
            //chamando menu
        }
    }
}
