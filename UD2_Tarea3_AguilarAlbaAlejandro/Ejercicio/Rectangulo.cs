using System;
namespace UD2_Tarea3_AguilarAlbaAlejandro.Ejercicio {
    /// <summary>
    /// Clase Rectangulo, descendente de Figura
    /// </summary>
    /// <remarks>
    /// Clase modelo del rectangulo, cuya instancia almacenara sus dos lados
    /// y mostrara tanto su perimetro o su area.
    /// </remarks>
    public class Rectangulo:Figura {
        /// <summary>
        /// Propiedad de la clase Rectangulo, un lado
        /// </summary>
        /// <remarks>
        /// Atributo float que almacenara un lado del rectangulo.
        /// </remarks>
        private float lado1;
        /// <summary>
        /// Propiedad de la clase Rectangulo, un lado
        /// </summary>
        /// <remarks>
        /// Atributo float que almacenara un lado del rectangulo.
        /// </remarks>
        private float lado2;
        /// <summary>
        /// Constructor de la clase Rectangulo
        /// </summary>
        /// <remarks>
        /// Constructor que nos genera un rectangulo, que tendra como atributo sus dos lados adyacentes.
        /// </remarks>
        /// <param name="lado1"></param>
        /// <param name="lado2"></param>
        public Rectangulo( float lado1, float lado2 ) {
            this.lado1 = lado1;
            this.lado2 = lado2;
        }
        /// <summary>
        /// Método para calcular el area.
        /// </summary>
        /// <remarks>
        /// Método que calcula el area mediante 2 lados adyacentes de un rectangulo.
        /// </remarks>
        /// <returns>
        /// Devolvera el area del rectangulo.
        /// </returns>
        public override float Area() {
            return ( lado1 * lado2 );
        }
        /// <summary>
        /// Método para calcular el perimetro.
        /// </summary>
        /// <remarks>
        /// Método que calcula el perimetro mediante 2 lados adyacentes de un rectangulo.
        /// </remarks>
        /// <returns>
        /// Devolvera el perimetro del rectangulo.
        /// </returns>
        public override float Perimetro() {
            return  ( lado1 * 2 ) + ( lado2 * 2 );
        }
    }
}
