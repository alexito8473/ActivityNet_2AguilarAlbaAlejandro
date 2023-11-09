using System;
namespace UD2_Tarea3_AguilarAlbaAlejandro.Ejercicio {
    public class Triángulo:Figura {
        private int lado1;
        private int lado2;
        private int lado3;
        public Triángulo( int lado1, int lado2 , int lado3) {
            this.lado1 = lado1;
            this.lado2 = lado2;
            this.lado3 = lado3;
        }

        public override float Area() {
            return ( float )Math.Sqrt( SemiPerimetro() * ( SemiPerimetro() * lado1 ) *( SemiPerimetro() *lado2) *( SemiPerimetro() *lado3) );
        }
        private float SemiPerimetro() {
            return Perimetro() / 2;
        }
        public override float Perimetro() {
            return lado2+lado1+lado3;
        }

    }
}
