using ShoppingCine.Enums;
using ShoppingCine.Modelos;

class Program
{
    static void Main()
    {
        Asiento asiento1 = new Asiento('A', 1, TipoAsiento.Estandar);
        Asiento asiento2 = new Asiento('B', 2, TipoAsiento.Superseat);

        Pelicula LOTR1 = new Pelicula("El señor de los anillos", "Fantasia", 228, Formato._3D_Doblada);

        Sala sala1 = new Sala(1, asiento1, 4000);
        sala1.AgregarAsiento(asiento2);

        Cine cine = new Cine("Show Movies", sala1);

        Funcion funcion1 = new Funcion(sala1, LOTR1, new DateTime(2024, 09, 11), new TimeOnly(8, 0));

        Entrada entrada1 = new Entrada(cine, funcion1, asiento1);
        //Entrada entrada2 = new Entrada(cine, funcion1, asiento1);

        funcion1.ReproducirPelicula();
    }
}