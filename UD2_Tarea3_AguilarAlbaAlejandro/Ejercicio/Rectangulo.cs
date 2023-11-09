using System;
namespace UD2_Tarea3_AguilarAlbaAlejandro.Ejercicio {
    public class Rectangulo:Figura {

        private float lado1;
        private float lado2;

        public Rectangulo( float lado1, float lado2 ) {
            this.lado1 = lado1;
            this.lado2 = lado2;
        }

        public override float Area() {
            return ( lado1 * lado2 );
        }

        public override float Perimetro() {
            return  ( lado1 * 2 ) + ( lado2 * 2 );
        }
    }
}
