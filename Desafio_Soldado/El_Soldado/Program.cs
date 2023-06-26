
using System.ComponentModel;

namespace Desafio_Soldado.El_Soldado
{
    class program
    {
        static void Main(string[] args)
        {
            String linea;
            int numero, armaSeleccionada=0;
            List<int> armasSeleccionadas = new List<int>();

            //intanciar las clases
            Escopeta escopeta = new Escopeta();
            Rifle rifle = new Rifle();
            Revolver revolver = new Revolver();

            do
            {
                // Menu interactivo
                Menu menu = new Menu();
                menu.MenuSoldado();
                linea = Console.ReadLine();
                numero = int.Parse(linea);
                Console.Clear();

                //Preguntamos opcion
                switch (numero) 
                {
                    case 1:
                        int num;
                        // Verificar si ya se tiene un arma seleccionada
                        if (armaSeleccionada != 0)
                        {
                            Console.WriteLine("ERROR!!! Ya tienes un arma seleccionada. Debes soltarla antes de elegir una nueva.");
                            break;
                        }
                        // elegir arma
                        menu.MenuRecorgarArma();
                            linea = Console.ReadLine();
                            num = int.Parse(linea);
                            switch (num)
                            {
                            case 1:
                                if (armasSeleccionadas.Contains(1))
                                {
                                    Console.WriteLine("ERROR!!! Ya seleccionaste un arma.");
                                }
                                else
                                {
                                    Console.WriteLine("Eligio el revolver");
                                    armaSeleccionada = 1;
                                    armasSeleccionadas.Add(1);
                                }
                                break;
                            case 2:
                                if (armasSeleccionadas.Contains(2))
                                {
                                    Console.WriteLine("ERROR!!! Ya seleccionaste un arma.");
                                }
                                else
                                {
                                    Console.WriteLine("Eligio el rifle");
                                    armaSeleccionada = 2;
                                    armasSeleccionadas.Add(2);
                                }
                                break;
                            case 3:
                                if (armasSeleccionadas.Contains(3))
                                {
                                    Console.WriteLine("ERROR!!! Ya seleccionaste un arma.");
                                }
                                else
                                {
                                    Console.WriteLine("Eligio escopeta");
                                    armaSeleccionada = 3;
                                    armasSeleccionadas.Add(3);
                                }
                                break;
                            case 4:
                                Console.WriteLine("Manos vacias no eligio nada");
                                armaSeleccionada = 0;
                                armasSeleccionadas.Clear(); // Limpiar la lista cuando se seleccionan manos vacías
                                break;
                            default:
                                Console.WriteLine("ERROR!!! no selecciono nada");
                                break;
                        }
                        break;
                    case 2:
                        //Soltar el arma seleccionada
                        if (armaSeleccionada == 1)
                        {
                            Console.WriteLine("Dejo el arma: Revolver");
                            armaSeleccionada = 0;
                            armasSeleccionadas.Remove(1);
                        }
                        else if (armaSeleccionada == 2)
                        {
                            Console.WriteLine("Dejo el arma: Rifle");
                            armaSeleccionada = 0;
                            armasSeleccionadas.Remove(2);
                        }
                        else if (armaSeleccionada == 3)
                        {
                            Console.WriteLine("Dejo el arma: Escopeta");
                            armaSeleccionada = 0;
                            armasSeleccionadas.Remove(3);
                        }
                        else if (armaSeleccionada == 0)
                        {
                            Console.WriteLine("Manos vacias");
                            armaSeleccionada = 0;
                            armasSeleccionadas.Clear(); // Limpiar la lista cuando se sueltan las manos vacías
                            break;
                        }
                        break;
                    case 3:
                        // opcion de disparar
                        if(armaSeleccionada == 0)
                        {
                            Console.WriteLine("“Parece que el soldado no tiene ningún arma en sus manos...”");
                        }
                        else if (armaSeleccionada == 1)
                        {
                            revolver.Disparar();
                        }
                        else if (armaSeleccionada == 2)
                        {
                            rifle.Disparar();
                        }
                        else if (armaSeleccionada == 3)
                        {
                            escopeta.Disparar();
                        }
                        break;
                    case 4:
                        //opcion ver el arma de uso
                        if (armaSeleccionada == 0)
                        {
                            Console.WriteLine("“Parece que el soldado no tiene ningún arma en sus manos...”");
                        }
                        if (armaSeleccionada == 1)
                        {
                            Console.WriteLine("El soldado tiene en sus manos un Revolver");
                        }
                        else if (armaSeleccionada == 2)
                        {
                            Console.WriteLine("El soldado tiene en sus manos un Rifle");
                        }
                        else if (armaSeleccionada == 3)
                        {
                            Console.WriteLine("El soldado tiene en sus manos una Escopeta");
                        }
                        break;
                    case 5:
                        Console.WriteLine("Salio del programa");
                        break;
                    default:
                        Console.WriteLine("ERROR!! opcion no existente");
                        break;
                }
            }while (numero !=5);
            Console.ReadKey();

        }
    }
}