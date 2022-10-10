using DemoCSharp.Models;

string palabra = "";
int numero = 0;
bool verdadero = true;


Evento lola = new Evento();
lola.Nombre = "Lolapalooza San Beca";
lola.Lugar = "Molino de harina de san bernardo";
lola.Fecha = new DateTime(2022, 11, 23, 15, 00, 00);

//tipo  obj   = instancia
Persona salo = new Persona();
salo.Nombre = "Salomé";
salo.Apellidos = "Mansilla";
salo.Rut = 2312213;
salo.Dv = "K";

Persona andres = new Persona();
andres.Nombre = "Andres";
andres.Apellidos = "Saez";
andres.Rut = 1231233;
andres.Dv = "0";

Persona cristofer = new Persona();

lola.AgregarAsistente(salo);
lola.AgregarAsistente(andres);
lola.AgregarAsistente(cristofer);


Evento fondaPermanente = new Evento();
fondaPermanente.Nombre = "Fonda Permanente Feriado";
fondaPermanente.Fecha = new DateTime(2022, 12, 01, 21, 00, 00);
fondaPermanente.Lugar = "Club Hípico";
fondaPermanente.AgregarAsistente(salo);

salo.Nombre = "Salito";

Console.WriteLine(lola);
Console.WriteLine(fondaPermanente);


Evento vacio = new Evento();


Persona salito = new Persona();
salito.Nombre = "A";

vacio.AgregarAsistente(salito);

salito.Nombre = "B";

vacio.AgregarAsistente(salito);

salito.Nombre = "C";

vacio.AgregarAsistente(salito);

Console.WriteLine(vacio);