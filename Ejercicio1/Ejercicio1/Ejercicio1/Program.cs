// See https://aka.ms/new-console-template for more information

namespace Ejercicio1
{
    class Libreria
    {
        private List<Pelicula> _peliculas;
        private List<Terror> _pelisterror

        public Libreria()
        {
            _peliculas = new List<Pelicula>();
        }

        public void showMenuPrincipal()
        {
            int opcionSeleccionada=0;
            Console.Clear();
            do
            {
                Console.WriteLine("Bienvenido a tu control de peliculas.");
                Console.WriteLine("1.- Peliculas en CD");
            } while (!validaMenu(1,ref opcionSeleccionada));
            switch (opcionSeleccionada)
            {
                case 1: showMenuCd();
                    break;
            }
        }

        private void showMenuCd()
        {
            int opcionSeleccionada = 0;
            Console.Clear();
            do
            {
                Console.WriteLine("Peloiculas en CD:");
                Console.WriteLine("1.- Terror");
                Console.WriteLine("2.- Amor");
                Console.WriteLine("3.- Ciencia Ficción");
                Console.WriteLine("4.- Acción");
                Console.WriteLine("5.- Drama");
                Console.WriteLine("6.- __Regresar__");
            } while (!validaMenu(6, ref opcionSeleccionada));
            switch (opcionSeleccionada)
            {
                case 1: crudTerrorCd();
                    break;
                case 2: crudAmorCd();
                    break;
                case 3: crudCienciaFiccionCd();
                    break;
                case 4: crudAccionCd();
                    break;
                case 5: crudDramaCd();
                    break;
                case 6: crud
            }
        }

        private void crudTerrorCd()
        {
            int opcionSeleccionada = 0;
            Console.Clear();
            do
            {
                Console.WriteLine("Terror");
                Console.WriteLine("1.- Listar");
                Console.WriteLine("2.- Crear");
                Console.WriteLine("3.- Editar");
                Console.WriteLine("4.- Eliminar");
                Console.WriteLine("5.- __Regresar__");
            } while (!validaMenu(5, ref opcionSeleccionada));
            switch (opcionSeleccionada)
            {
                case 1:
                    foreach (Terror item in )
                    break;
                case 2:
                    crudAmor();
                    break;
                case 3:
                    crudCienciaFiccion();
                    break;
                case 4:
                    crudAccion();
                    break;
                case 5:
                    crudDrama();
                    break;
                case 6:
                    crud
            }
        }

        private bool validaMenu(int opciones, ref int opcionSeleccionada)
        {
            int n;
            if (int.TryParse(Console.ReadLine(), out n))
            {
                if (n <= opciones)
                {
                    opcionSeleccionada = n;
                    return true;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Opcion Invalida.");
                    return false;
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Debes agregar un numero del 1 al 2.");
                return false;
            }
        }
    }
}
