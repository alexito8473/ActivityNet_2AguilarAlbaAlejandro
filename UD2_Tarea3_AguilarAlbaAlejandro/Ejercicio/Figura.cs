using System;
namespace UD2_Tarea3_AguilarAlbaAlejandro.Ejercicio {
    /// <summary>
    /// Clase Padre de todas las formas geometricas, siendo de caracter abstracto.
    /// </summary>
    /// <remarks>
    /// Clase modelo genética abstracta que nos sirve como padre de las otras formas geométricas, 
    /// que nos deja en si los nombres de los métodos para que sena comun en sus hijos.
    /// </remarks>
    public abstract class Figura {
        /// <summary>
        /// Propiedad de la clase Figura, el la poscion horizontal.
        /// </summary>
        /// <remarks>
        /// Atributo float que la posicion horizontal en un espacio dimensional.
        /// </remarks>
        protected float posición_X;
        /// <summary>
        /// Propiedad de la clase Figura, el la poscion vertical.
        /// </summary>
        /// <remarks>
        /// Atributo float que la posicion vertical en un espacio dimensional.
        /// </remarks>
        protected float posicion_Y;
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
