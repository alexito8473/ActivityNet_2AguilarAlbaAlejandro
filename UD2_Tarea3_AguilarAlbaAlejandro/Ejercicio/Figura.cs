using System;
namespace UD2_Tarea3_AguilarAlbaAlejandro.Ejercicio {
    public abstract class Figura {
       protected  int posición_X;
       protected  int posicion_Y;
        /// <summary>
        /// Método para calcular el perimetro.
        /// </summary>
        /// <remarks>
        /// Método que se va a utilizar para que los hijos hereden el método, es decir su firma,
        ///  debidoa a que los hijos los sobreescribira para sus intereses.
        /// </remarks>
        /// <returns>
        /// Devolvera su perimetro.
        /// </returns>
        public virtual float Perimetro() {
            return 0.0f;
        }
        /// <summary>
        /// Método para calcular el area.
        /// </summary>
        /// <remarks>
        /// Método que se va a utilizar para que los hijos hereden el método, es decir su firma,
        /// debidoa a que los hijos los sobreescribira para sus intereses.
        /// </remarks>
        /// <returns>
        /// Devolvera su area.
        /// </returns>
        public virtual float Area() {
            return 0.0f;
       }
    }
}
