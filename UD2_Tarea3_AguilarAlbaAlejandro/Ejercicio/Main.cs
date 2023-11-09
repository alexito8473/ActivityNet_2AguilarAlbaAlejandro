using System;
using System.Linq;
using System.Collections.Generic;
using UD2_Tarea3_AguilarAlbaAlejandro.Tarea3;
///////////////////////////////////////////
// Tarea: UD2T3
// Alumno/a: Aguilar Alba Alejandro
// Curso: 2023/2024
///////////////////////////////////////////
namespace UD2_Tarea3_AguilarAlbaAlejandro.Ejercicio {
    public class MainClass {
        private const int SALIR = 0;
        private const int RECTANGULO = 1;
        private const int CIRCULO = 2;
        private const int TRIANGULO = 3;
        private const int MAXIMO = 3;
        private Pedirdatos per= new Pedirdatos();
        private const string TEXT_MENU="----MENU---";
        private string TEXT_SALIDA = String.Format("{0} -> Salida del programa",SALIR);
        private string TEXT_RECTANGULO = String.Format( "{0} -> Uso del rectángulo", RECTANGULO );
        private string TEXT_CIRCULO = String.Format( "{0} -> Uso del círculo", CIRCULO );
        private string TEXT_TRIANGULO = String.Format( "{0} -> Uso del triángulo", TRIANGULO );

        private void Tarea3() {
            Menu();
        }
        private void TEXTMENU() {
            Console.WriteLine( TEXT_MENU );
            Console.WriteLine( TEXT_SALIDA );
            Console.WriteLine( TEXT_RECTANGULO );
            Console.WriteLine( TEXT_CIRCULO );
            Console.WriteLine( TEXT_TRIANGULO );
        }
        private void Menu() {
            bool salida = false;
            float lado1;
            float lado2;
            List<float> listaLados= new List<float>();
            Figura figura;
            bool salidaMetodo = false;
            Console.WriteLine("Programa sobre las figuras geométricas");
            do {
                TEXTMENU();
                switch ( per.PedirIntEnRango( SALIR, MAXIMO ) ) {
                    case SALIR:
                        salida = true;
                        break;
                    case RECTANGULO:
                            lado1 = per.PedirFloatPositivo( "Introduce el primer lado del trinagulo");
                            lado2 = per.PedirFloatPositivo( "Introduce el segundo lado del trinagulo" );
                            figura = new Rectangulo( lado1 ,lado2);
                        Console.Clear();
                        Console.Write("El perimetro del rectangulo es -> {0}\nEl area del rectángulo es -> {1}\n", figura.Perimetro(), figura.Area());
                        break;
                    case CIRCULO:
                        lado1 = per.PedirFloatPositivo( "Introduce el radio del circulo" );
                        figura = new Circulo(lado1);
                        Console.Clear();
                        Console.Write( "El perimetro del ciruclo es -> {0}\nEl area del ciruclo es -> {1}\n", figura.Perimetro(), figura.Area() );
                        break;
                    case TRIANGULO:
                        Console.Write( "Para formar un triangulo es necesario saber que el lado más grande nunca podra ser mayor que la suma de sus otros dos lados\n" );
                        do {
                            listaLados.Add( per.PedirFloatPositivo( "Introduce un lado1 del triangulo" ) );
                            listaLados.Add( per.PedirFloatPositivo( "Introduce un lado2 del triangulo" ) );
                            listaLados.Add( per.PedirFloatPositivo( "Introduce un lado3 del triangulo" ) );
                        } while ( !Controlador( listaLados ) );  
                        break;
                }
               // salidaMetodo = false;
            } while (!salida );
            Console.Write( "Salida del programa con exito" );
        }
        public static void Main( string[] args ) {
            new MainClass().Tarea3();

        }

        private bool Controlador( List<float> listaLados ) {
            float numeroMaximo = listaLados.Max();
            int contador = 0;
            float lado1, lado2;
            if (listaLados.Max().Equals( listaLados.Min() )) {
                return true;
            }
            foreach (float lado in listaLados ) {
                if ( lado.Equals( numeroMaximo ) ) {
                    contador++;
                }
            }
            if ( contador == 2) {
                return true;
            } else {
                listaLados.Reverse();
                lado1 = listaLados[0];
                lado2 = listaLados[1];
                if ( lado1 +lado2> numeroMaximo ) {
                    return true;
                } else {
                    Console.Write( "Error: El lado mayor simpre debera ser menor que la suma de los otros dos lados" );
                }
            }
            return false;
        }
    }
}
