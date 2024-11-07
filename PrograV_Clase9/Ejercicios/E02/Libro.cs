using System;


namespace E02 { 
    public class Libro
    {
        private string Titulo {  get; }
        private string Autor { get; }
        public int NumeroPaginas { set; get; }
        public double Precio { set; get; }


        public Libro(string _titulo, string _autor, int _numeroPaginas, double _precio)
        {
            Titulo = _titulo;
            Autor = _autor;
            NumeroPaginas = _numeroPaginas;
            Precio = _precio;
        }


        public void MostrarDetalles()
        {
            Console.WriteLine("\n");
            Console.WriteLine("*********");
            Console.WriteLine($"Título: {Titulo}");
            Console.WriteLine($"Author: {Autor}");
            Console.WriteLine($"Número de Páginas: {NumeroPaginas}");
            Console.WriteLine($"Precio: {Precio}");
            Console.WriteLine("*********");
        }
    }

}