using System;


namespace E04 { 
    public class Libro
    {
        private string Titulo {  get; }
        private string Autor { get; }
        public int NumeroPaginas { set; get; }
        public double Precio { set; get; }


        public Libro(string _titulo, string _autor)
        {
            Titulo = _titulo;
            Autor = _autor;
        }

        public Libro(string _titulo, string _autor, int _numeroPaginas, double _precio)
        {
            Titulo = _titulo;
            Autor = _autor;
            NumeroPaginas = _numeroPaginas;
            Precio = _precio;
        }     

        public void AplicaDescuento(double _porcentajeDescuento)
        {
            double discount = ((_porcentajeDescuento /100  ) * Precio);
            double newPrice = Precio - discount;
            Console.WriteLine($"Precio original: {Precio}");
            Console.WriteLine($"Descuento: {discount}");
            Console.WriteLine($"Nuevo precio: {newPrice}");

            Precio = newPrice;
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