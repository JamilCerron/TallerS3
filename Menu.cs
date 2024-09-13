using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller06._09._24
{
    internal class Menu
    {
        int valor;
        bool continuarPreguntandoFigura;
        bool continuarCalculando=true;
        bool continuarEnElMenu=true;
        
        public void EjecutarPrograma()
        {
           
            while (continuarEnElMenu)
            {
                continuarPreguntandoFigura=true;

                while (continuarPreguntandoFigura)
                {
                    Console.WriteLine("¿Que figura desea operar?");
                    Console.WriteLine("1.Triangulo");
                    Console.WriteLine("2.Circulo");
                    Console.WriteLine("3.Rectangulo");

                    string a = Console.ReadLine();

                    if (float.TryParse(a, out float valor) && valor <= 3)
                    {
                        continuarPreguntandoFigura = false;
                        switch (valor)
                        {
                            case 1:
                                Console.WriteLine("Escriba la base");
                                string bx = Console.ReadLine();

                                if (float.TryParse(bx, out float baseFigura))
                                {
                                    Console.WriteLine("Escriba la altura");
                                    string ax = Console.ReadLine();

                                    if (float.TryParse(ax, out float alturaFigura))
                                    {
                                        Console.WriteLine($"El area de la figura es {new Rectangulo(baseFigura, alturaFigura).CalcularArea()}");
                                    }

                                    else MensajeDeOpcionInvalida1(); break;
                                }

                                else MensajeDeOpcionInvalida1(); break;


                            case 2:
                                Console.WriteLine("Escriba el radio");
                                string r = Console.ReadLine();

                                if (float.TryParse(r, out float radio))
                                {

                                    Console.WriteLine($"El area de la figura es {new Circulo(radio).CalcularArea()}π ");
                                }

                                else MensajeDeOpcionInvalida1(); break;

                            case 3:

                                Console.WriteLine("Escriba la base");
                                bx = Console.ReadLine();

                                if (float.TryParse(bx, out baseFigura))
                                {
                                    Console.WriteLine("Escriba la altura");
                                    string ax = Console.ReadLine();

                                    if (float.TryParse(ax, out float alturaFigura))
                                    {
                                        Console.WriteLine($"El area de la figura es {new Triangulo(baseFigura, alturaFigura).CalcularArea()}");

                                    }

                                    else MensajeDeOpcionInvalida1(); break;
                                }

                                else MensajeDeOpcionInvalida1(); break;

                        }
                    }

                    else MensajeDeOpcionInvalida1();

                }


                while (continuarCalculando)
                {
                    Console.WriteLine("¿Desear continuar operando?");
                    Console.WriteLine("1.Si");
                    Console.WriteLine("2.No");
                    string entrada = Console.ReadLine();

                    if (int.TryParse(entrada, out int d) && (d == 1 || d == 2))
                    {
                        continuarCalculando = false;

                        if (d == 2)
                        {
                            Console.WriteLine("Programa finalizado.Pulse cualquier tecla para salir...");
                            Console.ReadKey();
                            continuarEnElMenu = false;
                        }

                    }

                    else
                    {
                        MensajeDeOpcionInvalida2();
                    }
                }
                continuarCalculando = true;
            }
        }

        void MensajeDeOpcionInvalida1()
        {
            Console.WriteLine("Lectura invalida.Porfavor ,vuelva a digitar los valores correspondientes");
        }

        void MensajeDeOpcionInvalida2()
        {
            Console.WriteLine("Opción invalida. Porfavor vuelva a marcar una de las opciones");
        }
    }
}
