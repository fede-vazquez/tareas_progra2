﻿using ShoppingCine.Enums;

namespace ShoppingCine.Modelos
{
    public class Pelicula
    {
        public string Nombre { get; private set; }
        public string Genero { get; private set; }
        public int DuracionMin { get; private set; }
        public Formato Formato { get; private set; }

        public Pelicula(string nombre, string genero, int duracionMin, Formato formato)
        {
            Nombre = nombre;
            Genero = genero;
            DuracionMin = duracionMin;
            Formato = formato;
        }

        public void Reproducir()
        {
            Console.WriteLine($"Se esta reproduciendo la película: {Nombre}, genero: {Genero}, con el formato: {Formato}");
        }
    }
}