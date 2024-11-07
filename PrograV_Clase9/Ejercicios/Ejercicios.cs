

using System.Runtime.InteropServices;

class Ejercicios {

    public static void InitMessage(int _numEjercicio) {
        Console.Clear();
        Console.WriteLine("***********************************************");
        Console.WriteLine($"*************Inicio Ejercicio: {_numEjercicio.ToString().PadLeft(2,'0')}*************");
    }

    public static void EndMessage(int _numEjercicio)
    {
        Console.WriteLine($"*************Fin Ejercicio: {_numEjercicio.ToString().PadLeft(2, '0')}*************");
        Console.WriteLine("***********************************************");
        Console.WriteLine("\n");
        Console.WriteLine("\n");

    }
    public static void Ejer01()
    {
        InitMessage(1);
        Console.WriteLine("Definición de Clases y Creación de Objetos");
        Console.WriteLine("- Crea una clase llamada Libro que contenga los siguientes atributos: titulo, autor, numeroPaginas y precio. Añade un método llamado MostrarDetalles que imprima la información de cada libro.");
        Console.WriteLine("- Luego, en el programa principal, crea tres objetos de la clase Libro con diferentes valores y llama al método MostrarDetalles para cada objeto.");

        E01.Libro libro1 = new E01.Libro("Libro 1", "Autor 1", 50,10);
        E01.Libro libro2 = new E01.Libro("Libro 2", "Autor 2", 150, 29.99);
        E01.Libro libro3 = new E01.Libro("Libro 3", "Autor 3", 520, 90.99);
                               
        libro1.MostrarDetalles();
        libro2.MostrarDetalles();        
        libro3.MostrarDetalles();

        EndMessage(1);
    }

    public static void Ejer02()
    {
        InitMessage(2);
        Console.WriteLine("Implementación de Propiedades");
        Console.WriteLine("- Modifica la clase Libro del ejercicio anterior para que use propiedades en lugar de campos públicos. Usa propiedades de solo lectura para titulo y autor, y de lectura y escritura para numeroPaginas y precio.");
        Console.WriteLine("- En el programa principal, establece el precio y número de páginas de cada libro, y muestra sus detalles.");

        E02.Libro libro1 = new E02.Libro("Libro 1", "Autor 1", 50, 10);
        libro1.Precio = 10;
        libro1.NumeroPaginas = 50;

        E02.Libro libro2 = new E02.Libro("Libro 2", "Autor 2", 150, 29.99);
        libro2.Precio = 29.99;
        libro2.NumeroPaginas = 150;

        E02.Libro libro3 = new E02.Libro("Libro 3", "Autor 3", 520, 90.99);
        libro3.Precio = 90.99;
        libro3.NumeroPaginas = 520;

        libro1.MostrarDetalles();
        libro2.MostrarDetalles();
        libro3.MostrarDetalles();

        EndMessage(2);
    }


    public static void Ejer03()
    {
        InitMessage(3);
        Console.WriteLine("Métodos para Operaciones Básicas");
        Console.WriteLine("- Agrega un método llamado Descuento a la clase Libro, que reciba un porcentaje y reduzca el precio del libro en ese porcentaje.\r\n");
        Console.WriteLine("- En el programa principal, aplica un descuento del 10% a cada libro y muestra el nuevo precio.");

        E03.Libro libro1 = new E03.Libro("Libro 1", "Autor 1", 50, 1000);

        libro1.AplicaDescuento(20);

        EndMessage(3);
    }

 
    public static void Ejer04()
    {
        InitMessage(4);
        Console.WriteLine("Uso de Constructores");
        Console.WriteLine("- Modifica la clase Libro para incluir un constructor que inicialice titulo y autor. Añade otro constructor que inicialice todos los atributos de la clase.\r\n");
        Console.WriteLine("- En el programa principal, crea un libro con solo el título y el autor, y otro libro con todos los atributos, luego imprime sus detalles.");

        E04.Libro libro1 = new E04.Libro("Libro 2", "Autor 2");
        E04.Libro libro2 = new E04.Libro("Libro 3", "Autor 3", 520, 90.99);

        libro1.MostrarDetalles();
        libro2.MostrarDetalles(); 
        EndMessage(4);
    }


    public static void Ejer05()
    {
        InitMessage(5);
        Console.WriteLine("Sobrecarga de Métodos");
        Console.WriteLine("- En la clase Libro, agrega un método MostrarDetalles sobrecargado que tome un parámetro booleano mostrarPrecio. Si mostrarPrecio es verdadero, muestra todos los detalles; de lo contrario, omite el precio.");
        Console.WriteLine("- En el programa principal, prueba ambos métodos MostrarDetalles.");

        E05.Libro libro1 = new E05.Libro("Libro 3", "Autor 3", 520, 90.99);

        libro1.MostrarDetalles(true);
        libro1.MostrarDetalles(false);

        EndMessage(5);
    }

    public static void Ejer06()
    {
        InitMessage(6);
        Console.WriteLine("Encapsulación de Atributos");
        Console.WriteLine("- En la clase Libro, encapsula todos los atributos para que solo se puedan acceder mediante métodos o propiedades. Asegúrate de que los valores no puedan establecerse a negativos.");
        Console.WriteLine("- En el programa principal, intenta asignar valores inválidos a los atributos y observa cómo se manejan.");
        
        E06.Libro libro1 = new E06.Libro("Libro 3", "Autor 3", 520, 90.99);

        try
        {
            Console.WriteLine("Intenta colocar -1 en Precio");
            libro1.setPrecio(-1);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        try
        {
            Console.WriteLine("Intenta colocar -1 en Número de Paginas");
            libro1.setNumeroPaginas(-1);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        

        EndMessage(6);
    }

    public static void Ejer07()
    {
        InitMessage(7);
        Console.WriteLine("Herencia y Clases Derivadas");
        Console.WriteLine("- Crea una clase derivada llamada LibroDigital que herede de la clase Libro y que tenga un atributo adicional llamado tamanioArchivo.");
        Console.WriteLine("- Añade un método Descargar que imprima un mensaje indicando que el libro está siendo descargado.");
        Console.WriteLine("- En el programa principal, crea un objeto LibroDigital, asigna valores a sus atributos, y llama al método Descargar.");


        E07.LibroDigital libroDigital1 = new E07.LibroDigital("Libro Digital 1", "Autor 3", 520, 90.99, 500);

        libroDigital1.Descargar();
        EndMessage(7);
    }

    public static void Ejer08()
    {
        InitMessage(8);
        Console.WriteLine("Polimorfismo en Métodos");
        Console.WriteLine("- Crea un método en LibroDigital que sobrescriba el método MostrarDetalles de Libro, añadiendo el tamaño de archivo al final de los detalles mostrados.");
        Console.WriteLine("- En el programa principal, llama al método MostrarDetalles tanto para un objeto Libro como para un LibroDigital.");


        E08.LibroDigital libroDigital1 = new E08.LibroDigital("Libro Digital 1", "Autor 3", 520, 90.99, 500);

        libroDigital1.MostrarDetalles();
        

        EndMessage(8);
    }

    public static void Ejer09()
    {
        InitMessage(9);
        Console.WriteLine("Clases y Métodos Abstractos");
        Console.WriteLine("- Crea una clase abstracta llamada Producto con un método abstracto CalcularPrecioConImpuesto. Haz que la clase Libro herede de Producto e implemente CalcularPrecioConImpuesto, calculando el precio con un impuesto del 13%.");
        Console.WriteLine("- En el programa principal, crea un objeto Libro, llama a CalcularPrecioConImpuesto, y muestra el precio resultante.");


        E09.Libro libro1 = new E09.Libro("Libro 3", "Autor 3", 520, 100);
        double precioImpuesto13 = libro1.CalcularPrecioConImpuesto();
        Console.WriteLine($"Para {libro1.GetPrecio()} + impuestos daría {precioImpuesto13}");
        EndMessage(9);
    }

}


    