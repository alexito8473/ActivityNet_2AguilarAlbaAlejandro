﻿using System;
namespace UD2_Tarea3_AguilarAlbaAlejandro.Tarea3 {
    public class Pedirdatos {
        public bool Pedirbool(String linea1,String linea2) {
            bool salida = false;
            bool resultado = false; string frase;
            do {
                Console.Write( "Escribe un {0} o un {1} \n",linea1,linea2 );
                frase = PedirString();
                if ( frase.Equals( linea1 ) ) {
                    salida = true;
                    resultado = true;
                } else if ( frase.Equals( linea2 ) ) {
                    salida = true;
                    resultado = false;
                } else {
                    Console.Write( "Escribe bien el si o no\n" );
                }
            } while ( !salida );
            return resultado;
        }

        internal int PedirIntEnRango() {
            throw new NotImplementedException();
        }

        public String PedirString() {
            bool salida = false;
            String frase;
            do {
                Console.Write( "\n->" );
                frase = Console.ReadLine().Trim();
                if ( frase.Length > 0 ) {
                    salida = true;
                } else {
                    Console.Write( "Escribe algo\n" );
                }
            } while ( !salida );
            return frase;
        }
        public String PedirStringSinControl() {
            Console.Write( "\n->" );
            return Console.ReadLine().Trim();
        }
        public String PedirStringSinControl(string frase) {
            Console.Write( frase );
            return PedirStringSinControl();
        }
        public String PedirString(string muestra) {
            Console.Write( muestra );
            return PedirString();
        }

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
        public float PedirFloatPositivo() {
            bool salida = false;
            float numero = 0.0f;
            do {
                numero = PedirFloat();
                if ( numero > 0.0f ) {
                    salida = true;
                } else {
                    Console.Write( "Debe ser mayor a 0" );
                }
            } while ( !salida );

            return numero;
        }
        public float PedirFloatPositivo(string frase ) {
            Console.Write( frase );
            return PedirFloatPositivo();
        }
        public int PedirIntPositivo() {
            bool salida = false;
            int numero = 0;
            do {
                numero = PedirInt();
                if (numero > 0) {
                    salida = true;
                } else{
                    Console.Write( "Debe ser mayor de edad" );
                }
            } while ( !salida );

            return numero;
        }

        public int PedirIntPositivo(string frase) {
            Console.Write( frase );
            return PedirIntPositivo();
        }
    }
}
