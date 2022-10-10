using System;

namespace DemoCSharp.Models
{
	public class Persona
	{
        // 1. La Encapsulación : Hacer dueño de sus parámetros a una clase.

        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public int Rut { get; set; }
        public string Dv { get; set; }

        // 2. Polimorfismo : Para coexistir sobrecargas (más de una forma de hacer lo mismo)
        public Persona()
        {
            this.Nombre = "Sin nombre";
            this.Apellidos = "Sin Apellido";
            this.Rut = -1;
            this.Dv = "F";
        }

        public Persona(string Nombre, string Apellidos, int Rut, string Dv)
        {
            this.Nombre = Nombre;
            this.Apellidos = Apellidos;
            this.Rut = Rut;
            this.Dv = Dv;
        }

        // Sobre carga

        /// <summary>
        /// Imprime todos los atributos disponibles del objeto.
        /// </summary>
        /// <returns>string de datos</returns>
        public string Imprimir() {
            return this.Nombre + " " + this.Apellidos + " "
                + this.Rut + "-" + this.Dv;
        }
        /// <summary>
        /// Imprime todos los atributos disponibles del objeto.
        /// </summary>
        /// <param name="soloNombre">Define si imprime solo el nombre o todo el elemento</param>
        /// <returns></returns>
        public string Imprimir(bool soloNombre)
        {
            if (soloNombre)
            {
                return this.Nombre + " " + this.Apellidos;
            }
            return Imprimir();
        }

        // Sobre carga explícita
        public override String ToString()
        {
            return Imprimir();
        }
    }
}

