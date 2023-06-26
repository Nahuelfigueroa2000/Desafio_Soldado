using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_Soldado.El_Soldado
{
    internal class Menu
    {
        public void MenuSoldado()
        {
            Console.WriteLine(@"-== Bienvenido al campo de entrenamiento Soldado ==-
           ¿Qué desea hacer?
           (presione el número correspondiente a la opción del menú)
           1- Recoger arma.
           2- Dejar arma.
           3- Disparar.
           4- Ver arma en uso.
           5- Salir.");
        }

        public void MenuRecorgarArma()
        {
            Console.WriteLine("Por favor, escoja el arma que desea utilizar: 1- Revolver ; 2- Rifle ; 3- Escopeta ; 4- Volver atrás");
        }
    }
}
