using System;


namespace E09
{
    public class Libro : E09.Producto   
    {
        public string Titulo { get; private set; }
        public string Autor { get; private set; }
        private int NumeroPaginas { get; set; }
        private double Precio { get; set; }

        public Libro() { }
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

        public double GetPrecio()
        {
            return Precio;
        }

        public double GetNumeroPaginas()
        {
            return NumeroPaginas;
        }

        public void SetTitulo(string _nuevoTitulo)
        {

            Titulo = _nuevoTitulo;
        }

        public void SetAutor(string _nuevoAutor)
        {

            Autor = _nuevoAutor;
        }

        public void SetPrecio(double _nuevoPrecio)
        {
            if (_nuevoPrecio < 0) throw new ArgumentOutOfRangeException("Precio no puede ser menor a 0");

            Precio = _nuevoPrecio;
        }

        public void SetNumeroPaginas(int _nuevoNumeroPaginas)
        {
            if (_nuevoNumeroPaginas < 0) throw new ArgumentOutOfRangeException("La cantidad de paginas no puede ser menor a 0");

            NumeroPaginas = _nuevoNumeroPaginas;
        }

        public void AplicaDescuento(double _porcentajeDescuento)
        {
            double discount = ((_porcentajeDescuento / 100) * Precio);
            double newPrice = Precio - discount;
            Console.WriteLine($"Precio original: {Precio}");
            Console.WriteLine($"Descuento: {discount}");
            Console.WriteLine($"Nuevo precio: {newPrice}");

            Precio = newPrice;
        }

        public virtual void MostrarDetalles()
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

        public double CalcularPrecioConImpuesto()
        {
            return Precio*1.13;
        }
    }


    public class LibroDigital : Libro
    {
        public double tamanioArchivo { get; set; }

        public LibroDigital(string _titulo, string _autor, int _numeroPaginas, double _precio, double _tamanioArchivo)
        {
            SetTitulo(_titulo);
            SetAutor(_autor);
            SetNumeroPaginas(_numeroPaginas);
            SetPrecio(_precio);
            tamanioArchivo = _tamanioArchivo;
        }

        public override void MostrarDetalles()
        {
            Console.WriteLine("\n");
            Console.WriteLine("*********");
            Console.WriteLine($"Título: {Titulo}");
            Console.WriteLine($"Author: {Autor}");
            Console.WriteLine($"Número de Páginas: {GetNumeroPaginas()}");
            Console.WriteLine($"Precio: {GetPrecio()}");
            Console.WriteLine($"Tamaño Archivo: {tamanioArchivo}");
            Console.WriteLine("*********");
        }

        public void Descargar()
        {
            Console.WriteLine($"Se esta descargando: {Titulo}");
        }
    }
}