using System;
namespace DemoCSharp.Models
{
	public class Evento
	{
        public string Nombre { get; set; }
        public DateTime Fecha { get; set; }
        public string Lugar { get; set; }
        public int Precio { get; set; }
        public List<Persona> Asistentes { get; set; }

        public Evento()
        {
            this.Nombre = "";
            this.Fecha = new DateTime();
            this.Lugar = "";
            this.Precio = 0;
            this.Asistentes = new List<Persona>();
        }

        public void AgregarAsistente(Persona persona)
        {
            this.Asistentes.Add(persona);
        }

        public override string ToString()
        {
            string listaAsistentes = "";

            foreach (Persona asistente in this.Asistentes)
            {
                listaAsistentes += asistente.ToString() + '\n';
            }


            string impresion = string.Format(@"
========================
EVENTO {0}
Fecha: {1}
Lugar: {2}
========================
{3}
", this.Nombre, this.Fecha.ToString("dd-MM-yyyy"), this.Lugar, listaAsistentes);

            return impresion;
        }
    }
}