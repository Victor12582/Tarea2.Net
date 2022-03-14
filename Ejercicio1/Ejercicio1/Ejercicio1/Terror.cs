// See https://aka.ms/new-console-template for more information

namespace Ejercicio1
{
    internal class Terror
    {
        private int _id;
        private string _nombre;
        
        public Terror(int id, string nombre)
        {
           this. _id = id;
            this._nombre = nombre;
        }
        public int id
        {
            get { return _id; }
            set { _id = value; }
        }
        public String nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        public override string ToString()
        {
            return $"Id: {_id}, Nombre: {_nombre}";
        }
    }
}