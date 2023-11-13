using System;
namespace UD2_Tarea3_AguilarAlbaAlejandro.Ejercicio {
    /// <summary>
    /// Clase Triangulo, descendente de Figura
    /// </summary>
    /// <remarks>
    /// Clase modelo del Triangulo, cuya instancia almacenara sus tres lados
    /// y mostrara tanto su perimetro o su area.
    /// </remarks>
    public class Triángulo:Figura {
        /// <summary>
        /// Propiedad de la clase Triangulo, un lado
        /// </summary>
        /// <remarks>
        /// Atributo float que almacenara un lado del Triangulo.
        /// </remarks>
        private float lado1;
        /// <summary>
        /// Propiedad de la clase Triangulo, un lado
        /// </summary>
        /// <remarks>
        /// Atributo float que almacenara un lado del Triangulo.
        /// </remarks>
        private float lado2;
        /// <summary>
        /// Propiedad de la clase Triangulo, un lado
        /// </summary>
        /// <remarks>
        /// Atributo float que almacenara un lado del Triangulo.
        /// </remarks>
        private float lado3;
        /// <summary>
        /// Constructor de la clase Triángulo
        /// </summary>
        /// <remarks>
        /// Constructor que nos genera un triangulo, que tendra como atributo sus 3 lados.
        /// </remarks>
        /// <param name="lado1">Lado del triangulo</param>
        /// <param name="lado2">Lado del triangulo</param>
        /// <param name="lado3">Lado del triangulo</param>
        public Triángulo( float lado1, float lado2 , float lado3 ) {
            this.lado1 = lado1;
            this.lado2 = lado2;
            this.lado3 = lado3;
        }

        /// <summary>
        /// Método para calcular el area.
        /// </summary>
        /// <remarks>
        /// Método que calcula el area mediante sus 3 lados, usando la formula de Herón.
        /// </remarks>
        /// <returns>
        /// Devolvera el area del triangulo.
        /// </returns>
        public override float Area() {
            return ( float )Math.Sqrt( SemiPerimetro() * ( SemiPerimetro() - lado1 ) *( SemiPerimetro() - lado2) *( SemiPerimetro() - lado3) );
        }
        /// <summary>
        /// Método para calcular el semiperimetro.
        /// </summary>
        /// <remarks>
        /// Método que calcula el semiperimetro usando el metodo del calculo del perimetro y lo dividimos entre 2.
        /// </remarks>
        /// <returns>
        /// Devolvera el semiperimetro del triangulo.
        /// </returns>
        private float SemiPerimetro() {
            return Perimetro() / 2;
        }
        /// <summary>
        /// Método para calcular el perimetro.
        /// </summary>
        /// <remarks>
        /// Método que calcula el perimetro sumando sus 3 lados.
        /// </remarks>
        /// <returns>
        /// Devolvera el perimetro del triangulo.
        /// </returns>
        public override float Perimetro() {
            return lado2+lado1+lado3;
        }

    }
}
