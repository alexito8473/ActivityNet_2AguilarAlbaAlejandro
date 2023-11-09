using System;
namespace UD2_Tarea3_AguilarAlbaAlejandro.Ejercicio {
    public abstract class Figura {
       protected  int posición_X;
       protected  int posicion_Y;

       public virtual float Perimetro() {
            return 0.0f;
        }
           
        public virtual float Area() {
            return 0.0f;
       }
    }
}
