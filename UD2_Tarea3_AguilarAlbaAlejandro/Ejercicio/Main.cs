using System;
using UD2_Tarea3_AguilarAlbaAlejandro.Tarea3;

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
        private string TEXT_TRIANGULO = String.Format( "{0} -> Uso del círculo", TRIANGULO );

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
            Console.WriteLine("Programa sobre las figuras geométricas");
            TEXTMENU();
            do {
                switch ( per.PedirIntEnRango( SALIR, MAXIMO ) ) {
                    case SALIR:
                        salida = true;
                        break;
                    case RECTANGULO:
                        Console.Write( "b" );
                        break;
                    case CIRCULO:
                        Console.Write( "c" );
                        break;
                    case TRIANGULO:
                        Console.Write( "" );
                        break;
                }
            } while (!salida );
            Console.Write( "Salida del programa con exito" );
        }
        public static void Main( string[] args ) {
            new MainClass().Tarea3();
        }
    }
}
