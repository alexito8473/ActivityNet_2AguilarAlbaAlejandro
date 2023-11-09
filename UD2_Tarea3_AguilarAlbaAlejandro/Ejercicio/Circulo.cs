using System;
namespace UD2_Tarea3_AguilarAlbaAlejandro.Ejercicio {
    public class Circulo:Figura {
        private float radio;
        /// <summary>
        /// Constructor de la clase Círculo
        /// </summary>
        /// <remarks>
        /// Constructor que nos genera un circulo, que tendra como atributo si radio.
        /// </remarks>
        /// <param name="radio">Radio del del circulo</param>
        public Circulo( float radio ) {
            this.radio = radio;
        }
        /// <summary>
        /// Método para calcular el area.
        /// </summary>
        /// <remarks>
        /// Método que calcula el area mediante el radio.
        /// </remarks>
        /// <returns>
        /// Devolvera el area del circulo.
        /// </returns>
        public override float Area() {
            return ( float )( Math.PI * Math.Pow( radio, 2 ) );
        }

        /// <summary>
        /// Método para calcular el perimetro.
        /// </summary>
        /// <remarks>
        /// Método que calcula el perimetro medianete el radio.
        /// </remarks>
        /// <returns>
        /// Devolvera el perimetro del circulo.
        /// </returns>
        public override float Perimetro() {
            return ( ( float )( Math.PI * ( radio * 2 ) ) );
        }
    }
}
