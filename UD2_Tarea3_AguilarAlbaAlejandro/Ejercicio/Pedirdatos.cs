using System;
namespace UD2_Tarea3_AguilarAlbaAlejandro.Tarea3 {
    public class Pedirdatos {

        /// <summary>
        /// Método para puslsar enter y continuar
        /// </summary>
        /// <remarks>
        /// Consiste en un bucle que va apedir infinitamente un string hasta que lo envie vacio, esto es debido
        /// porque queremos que el usuario le de a enter para realizar una pausa.
        /// Después la consola de la terminal se limpiara.
        /// </remarks>
        public void PedirstringIntro() {
            do {
                Console.Write( "PULSA INTRO PARA CONTINUAR" );
            } while ( !string.IsNullOrEmpty( Console.ReadLine().Trim() ) );
            Console.Clear();
        }
        /// <summary>
        /// Método para pedir un numero entero que debera estar situado en el rango de 2 numeros.
        /// </summary>
        /// <remarks>
        /// Consiste en dos numeros que se observara cual de ellos es el mayor, y se le pedira al usuario
        /// un numero que ente situado entre esos dos, en el caso que no haya acertado se le mostrara un mensaje para 
        /// decirle el rango, además antes de introducir el dato ya sera informado, y todo pasara infinitamente 
        /// hasta que se coloque el dato bién.
        /// </remarks>
        /// <param name="num">Numero máximo o minimo del rango</param>
        /// <param name="num2">Numero máximo o minimo del rango</param>
        /// <returns>
        /// Devolvera un numero int que este comprendido entre los numeros colocados por parametro.
        /// </returns>
        public int PedirIntEnRango(int num, int num2) {
            bool salida = false;
            int numero1;
            int numero2;
            if (num>=num2) {
                numero1 = num2;
                numero2 = num;
            } else {
                numero1 = num;
                numero2 = num2;
            }
            int datoSalida;
            Console.Write("El número introducido debe de ser entre {0} y {1}", numero1, numero2);
            do {   
                datoSalida = PedirInt();
                if (datoSalida<= numero2 && datoSalida>= numero1 ) {
                    salida = true;
                } else {
                    Console.Write("El numero debe estar en el rango");
                }
            } while (!salida);
            return datoSalida;
        }
        /// <summary>
        /// Método para pedir un numero entero.
        /// </summary>
        /// <remarks>
        /// Consiste en perdir un número entero constantemene, y si no lo introduce se le volvera a pedir con un mensaje escrito
        /// indicando que lo escriba bien, hasta que el usuario introduzca el dato correctamente no sera parara de pedirlo.
        /// </remarks>
        /// <returns>
        /// Devolvera un numero entero.
        /// </returns>
        public int PedirInt() {
            bool salida = false;
            int numero = 0;
            do {
                try {
                    Console.Write( "\n-> " );
                    numero = Int32.Parse( Console.ReadLine() );
                    salida = true;
                } catch {
                    Console.Write( "El numero que sea valido" );
                }
            } while ( !salida );
            return numero;
        }

        /// <summary>
        /// Método para pedir un numero float.
        /// </summary>
        /// <remarks>
        /// Consiste en perdir un número float constantemene, y si no lo introduce se le volvera a pedir con un mensaje escrito
        /// indicando que lo escriba bien, hasta que el usuario introduzca el dato correctamente no sera parara de pedirlo.
        /// </remarks>
        /// <returns>
        /// Devolvera un numero float.
        /// </returns>
        public float PedirFloat() {
            bool salida = false;
            float numero = 0.0f;
            do {
                try {
                    Console.Write( "\n-> " );
                    numero = float.Parse( Console.ReadLine() );
                    salida = true;
                } catch {
                    Console.Write( "El numero que sea valido" );
                }
            } while ( !salida );

            return numero;
        }
        /// <summary>
        /// Método para pedir un numero float que sea mayor que 0.
        /// </summary>
        /// <remarks>
        /// Consiste que mediante la ayuda del otro metodo de pedir el float, vamos a validar 
        /// los que son unicamente mayores que 0;
        /// </remarks>
        /// <param name="frase">
        /// Mensaje personalizado
        /// </param>
        /// <returns>
        /// Devolvera un numero float mayor que 0.
        /// </returns>
        public float PedirFloatPositivo( string frase ) {
            bool salida = false;
            float numero = 0.0f;
            do {
                Console.Write( frase );
                numero = PedirFloat();
                if ( numero > 0.0f ) {
                    salida = true;
                } else {
                    Console.Write( "Debe ser mayor a 0" );
                }
            } while ( !salida );

            return numero;
        }
        /// <summary>
        /// Método para pedir un numero entero que sea mayor que 0.
        /// </summary>
        /// <remarks>
        /// Consiste que mediante la ayuda del otro metodo de pedir el entero, vamos a validar 
        /// los que son unicamente mayores que 0;
        /// </remarks>
        /// <param name="frase">
        /// Mensaje personalizado
        /// </param>
        /// <returns>
        /// Devolvera un numero entero mayor que 0.
        /// </returns>
        public int PedirIntPositivo( string frase ) {
            bool salida = false;
            int numero = 0;
            do {
                Console.Write( frase );
                numero = PedirInt();
                if (numero > 0) {
                    salida = true;
                } else{
                    Console.Write( "Debe ser mayor de edad" );
                }
            } while ( !salida );

            return numero;
        }
    }
}
