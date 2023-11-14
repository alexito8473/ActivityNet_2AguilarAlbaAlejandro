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
    /// <summary> Clase donde se ejecuta toda la lógica de procesamiento. </summary>
    /// <remarks>
    /// Clase donde se ejecuta toda la lógica de procesamiento,
    /// donde se instancia las diferentes clases.
    /// </remarks>
    public class MainClass {
        /// <summary> Atributo constante definido para salir del menu </summary>
       private const int SALIR = 0;
        /// <summary> Atributo constante definido para entrar en el apartado del Rectangulo </summary>
        private const int RECTANGULO = 1;
        /// <summary> Atributo constante definido para entrar en el apartado del Circulo </summary>
        private const int CIRCULO = 2;
        /// <summary> Atributo constante definido para entrar en el apartado del Triangulo </summary>
        private const int TRIANGULO = 3;
        /// <summary> Atributo constante definido para saber el contenido total de acciones que tiene el menu </summary>
        private const int MAXIMO = 3;
        /// <summary> Atributo que sirve para las peticiones del teclado. </summary>
        /// <remarks> Atributo que instancia a la clase PedirDatos para poder usar sus métodos para pedir datos del usuario. </remarks>
        private Pedirdatos per= new Pedirdatos();
        /// <summary> Atributo string para definir el menu </summary>
        private const string TEXT_MENU="----MENU---";
        /// <summary> Atributo string para definir la salida </summary>
        private string TEXT_SALIDA = String.Format("{0} -> Salida del programa",SALIR);
        /// <summary> Atributo string para definir la rectangulo  </summary>
        private string TEXT_RECTANGULO = String.Format( "{0} -> Uso del rectángulo", RECTANGULO );
        /// <summary> Atributo string para definir la circulo </summary>
        private string TEXT_CIRCULO = String.Format( "{0} -> Uso del círculo", CIRCULO );
        /// <summary> Atributo string para definir la triangulo </summary>
        private string TEXT_TRIANGULO = String.Format( "{0} -> Uso del triángulo", TRIANGULO );
        /// <summary> Método para iniciar el sistema del menu. </summary>
        /// <remarks>
        /// No es necesario hacer nada, al ejecutar el programa fucniona automaticamente, 
        /// llama al método menu para que inicie todo el sistema.
        /// </remarks>
        private void Tarea3() {
            Menu();
        }
        /// <summary> Método que sirve para crear el texto del menu. </summary>
        /// <remarks> El método sirve para crear un texto que sera visualizado en la terminal. </remarks>
        private void TEXTMENU() {
            Console.WriteLine( TEXT_MENU );
            Console.WriteLine( TEXT_SALIDA );
            Console.WriteLine( TEXT_RECTANGULO );
            Console.WriteLine( TEXT_CIRCULO );
            Console.WriteLine( TEXT_TRIANGULO );
        }
        /// <summary> Método donde se ejecuta toda la lógica del menu. </summary>
        /// <remarks>
        /// Este método se encarga de pedir los datos del usuario, 
        /// con ello tenemos un menu que el usuario debera decir que acción sera.
        /// Las acciones son 4, salir, crear un triangulo a partir de 3 lado, 
        /// crear un rectangulo con 2 lado y por ultimo crear un circulo con el radio.
        /// Después de todo ello se les mostrara el radio y el perimetro de cada figura.
        /// </remarks>
        private void Menu() {
            bool salida = false;
            float lado1;
            float lado2;
            List<float> listaLados= new List<float>();
            Figura figura;
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
                        Console.Write("El perimetro del rectangulo es -> {0}\nEl area del rectángulo es -> {1}\n", figura.Perimetro(), figura.Area());
                        per.PedirstringIntro();
                        break;
                    case CIRCULO:
                        lado1 = per.PedirFloatPositivo( "Introduce el radio del circulo" );
                        figura = new Circulo(lado1);
                        Console.Write( "El perimetro del ciruclo es -> {0}\nEl area del ciruclo es -> {1}\n", figura.Perimetro(), figura.Area() );
                        per.PedirstringIntro();
                        break;
                    case TRIANGULO:
                        Console.Write( "Para formar un triangulo es necesario saber que el lado más grande nunca podra ser mayor que la suma de sus otros dos lados\n" );
                        do {
                            listaLados.Clear();
                            listaLados.Add( per.PedirFloatPositivo( "Introduce un lado1 del triangulo" ) );
                            listaLados.Add( per.PedirFloatPositivo( "Introduce un lado2 del triangulo" ) );
                            listaLados.Add( per.PedirFloatPositivo( "Introduce un lado3 del triangulo" ) );
                        } while ( !Controlador( listaLados ) );
                        figura = new Triángulo( listaLados[0], listaLados[1] , listaLados[2] );
                        Console.Write( "El perimetro del triangulo es -> {0}\nEl area del triangulo es -> {1}\n", figura.Perimetro(), figura.Area() );
                        per.PedirstringIntro();
                        break;
                }
            } while (!salida );
            Console.Write( "Salida del programa con exito" );
        }

        /// <summary> Método que decide si existe o no un triangulo a partir de 3 lados pasados por una lista. </summary>
        /// <remarks>
        ///  El método coge los 3 lados que recibe por parametro mediante una lista.
        ///  Primero se comprueba los 3 lados son iguales, en el caso que no, se comprobaria
        ///  cual es el numero más alto, en el caso que haya 2 números que sean iguales y mas altos, significa
        ///  que si es un triangulo, pero en el que caso que ninguno se repita, se compara los dos mas pequeño contra el grande
        ///  si los dos mas pequeños son mas grande que el mayor lado significa que es un triangulo.
        /// </remarks>
        /// <param name="listaLados">Todos los lados que tiene un triangulo</param>
        /// <exception cref="InvalidOperationException"> No existe triangulo con más de 3 lados.</exception>
        /// <returns>Retorna un false si no es un triángulo y retorna true si es un triangulo. </returns>
        private bool Controlador( List<float> listaLados ) {
            float numeroMaximo = listaLados.Max();
            int contador = 0;
            float lado1, lado2;
            if ( !(listaLados.Count()==3)) {
                throw new InvalidOperationException("La lista debe tener 3 variables");
            }
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
                listaLados.Sort();
                lado1 = listaLados[0];
                lado2 = listaLados[1];
                if ( lado1 +lado2 > numeroMaximo ) {
                    return true;
                } else {
                    Console.Write( "Error: El lado mayor simpre debera ser menor que la suma de los otros dos lados" );
                }
            }
            return false;
        }
        /// <summary> Método estático que arranca el programa </summary>
        /// <remarks> Método estático que arranca el programa </remarks>
        /// <param name="args">lista de string</param>
        public static void Main( string[] args ) {
            new MainClass().Tarea3();
        }
    }
}
