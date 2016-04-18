using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{

    interface IImprimible
    {
        void Imprime();          //siempre que se implementa una interfaz se debe implementar los mismos metodos
        void Imprime(int n);
    }
    class Usuario:IComparable, IImprimible  
    {
        public string nombre, correo;
        public Usuario(string n, string c)
        {
            this.nombre = n;
            this.correo = c;
        }

        public override string ToString()
        {
            return String.Format("{0}:{1}" ,this.nombre, this.correo);
        }
        public int CompareTo(object o)
        {
            Usuario temp = (Usuario)o;
            return this.nombre.CompareTo(((Usuario) o ).nombre);
        }



        public void Imprime()
        {
            throw new NotImplementedException();
        }

        public void Imprime(int n)
        {
            throw new NotImplementedException();
        }
    }
    class Program
    {
        static private List<Usuario> Usuarios = new List<Usuario>();

        static void Main(string[] args)
        {
            //Se agregan usuarios a la lista
            Usuarios.Add(new Usuario("ana", "ana@gmail.com")); // Los objetos se crean con new
            Usuarios.Add(new Usuario("ale", "ale@gmail.com"));// Usuario es el constructor
            Usuarios.Add(new Usuario("zoe", "zoe@gmail.com"));
            Usuarios.Add(new Usuario("tom", "tom@gmail.com"));
            Usuarios.Add(new Usuario("coraima", "cori@gmail.com"));
            Console.WriteLine("Desordenados");
            foreach (Usuario u in Usuarios)
            {
                Console.WriteLine(u);

            }

            // Ordena los elementos por orden alfabetico
            // Sort requiere que Usuario implemente la interfaz IComparable
            Usuarios.Sort();
            Console.WriteLine("Ordenados");
            foreach (Usuario u in Usuarios)
            {
                Console.WriteLine(u);
            }
            Console.ReadKey();
        }
    }
}
