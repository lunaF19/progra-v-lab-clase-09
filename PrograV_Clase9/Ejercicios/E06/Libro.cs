using System;


namespace E06 { 
    public class Libro
    {
        public string Titulo {  get; private set; }
        public string Autor { get; private set; }
        private int NumeroPaginas { get ; set ; }
        private double Precio { get; set; }


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

        public double getPrecio()
        {
            return Precio;
        }

        public double getNumeroPaginas()
        {
            return NumeroPaginas;
        }
        public void setPrecio(double _nuevoPrecio)
        {
            if (_nuevoPrecio < 0) throw new ArgumentOutOfRangeException("Precio no puede ser menor a 0");

            Precio = _nuevoPrecio;
        }

        public void setNumeroPaginas(int _nuevoNumeroPaginas)
        {
            if (_nuevoNumeroPaginas < 0) throw new ArgumentOutOfRangeException("La cantidad de paginas no puede ser menor a 0");

            NumeroPaginas = _nuevoNumeroPaginas;
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

        public void MostrarDetalles(Boolean _mostrarPrecio)
        {
            Console.WriteLine("\n");
            Console.WriteLine("*********");
            Console.WriteLine($"Título: {Titulo}");
            Console.WriteLine($"Author: {Autor}");
            Console.WriteLine($"Número de Páginas: {NumeroPaginas}");
            if (_mostrarPrecio) Console.WriteLine($"Precio: {Precio}");
            Console.WriteLine("*********");
        }
    }

}