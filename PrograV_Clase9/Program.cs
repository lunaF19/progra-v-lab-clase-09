// See https://aka.ms/new-console-template for more information

int exerciseNumber = 0;
int attemps = 3;
while (attemps > 0)
{

    try {
        string messageGetExcesiseNumber = "Ingresa el número de Ejericio (Debe ser entre 1 y 9): ";
        Console.WriteLine(messageGetExcesiseNumber);
        var responseUser = Console.ReadLine();
        exerciseNumber = Int16.Parse(responseUser);

        if (exerciseNumber == -1 )
        {
            Console.WriteLine("Saliendo....."); 
            attemps = 0;
        }

        if (exerciseNumber < 1 || exerciseNumber > 9) throw new Exception("´Número fuera de rango");


        switch (exerciseNumber)
        {
            case 1:
                {
                    Ejercicios.Ejer01();
                    break;
                }

            case 2:
                {
                    Ejercicios.Ejer02();
                    break;
                }

            case 3:
                {
                    Ejercicios.Ejer03();
                    break;
                }

            case 4:
                {
                    Ejercicios.Ejer04();
                    break;
                }

            case 5:
                {
                    Ejercicios.Ejer05();
                    break;
                }

            case 6:
                {
                    Ejercicios.Ejer06();
                    break;
                }

            case 7:
                {
                    Ejercicios.Ejer07();
                    break;
                }

            case 8:
                {
                    Ejercicios.Ejer08();
                    break;
                }

            case 9:
                {
                    Ejercicios.Ejer09();
                    break;
                }

            default:
                {
                    Console.WriteLine($"Ejercicio {exerciseNumber} no manejado");
                    break;
                }
                
        }
        attemps = 3;
    } catch {
        attemps -= 1;
        Console.WriteLine("Valor ingresado no es un número!");
        Console.WriteLine($"Te quedan {attemps} intentos");
    }
}