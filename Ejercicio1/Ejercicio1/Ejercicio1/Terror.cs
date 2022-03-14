// See https://aka.ms/new-console-template for more information

namespace Ejercicio1
{
    internal class Terror
    {
        private string _id;

        public Terror(string id, string nombre)
        {
           this. _id = id;
            this.Nombre = nombre;
        }
        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public String Nombre { get; set; }
        public override string ToString()
        {
            return $"Id: {_id}, Nombre: {Nombre}";
        }
    }
}