using System;
namespace UD2_Tarea3_AguilarAlbaAlejandro.Ejercicio {
    public class Circulo:Figura {
        private float radio;
        public Circulo( float radio ) {
            this.radio = radio;
        }

        public override float Area() {
            return ( float )( Math.PI * Math.Pow( radio, 2 ) );
        }

        public override float Perimetro() {
            return ( ( float )( Math.PI * ( radio * 2 ) ) );
        }
    }
}
