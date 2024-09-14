using System;

public class Program
{
    private static void Main(string[] args)
    {
        /*Escriba un programa que pida los coeficientes de una ecuación de primer grado (a x + b = 0) y muestre la solución.
        Una ecuación de primer grado puede no tener solución, tener una solución única, o que todos los números sean solución. La fórmula de las soluciones es x = -b / a
        */



        // mostrale la formula al usuario para que sepa que se le esta pidiendo
        Console.WriteLine(" (a x + b = 0) esta es la formula para resolver el problema   ");
        // pedir variables y inicializar de una vez a fuegooooo

        Console.WriteLine("Introduce el valor de [A] (el coeficiente de x): ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Introduce el valor de [B] (numero independiente): ");
        double b = Convert.ToDouble(Console.ReadLine());

        double x;  // esta queda para hacer la operacion 


        // para que la ecuacion sea correcta  la variable "a" debe ser diferente de 0

        if (a != 0)
        {
            x = -b / a; // proceso para la ecuacion

            Console.WriteLine(" la solucion es: x =  " + x); // mostrar solucion 


        }
        // si la variable "a" es = 0 no seria una ecuacion de primer grado valida 
        else  
        {
        Console.WriteLine(" la variable (a) no puede sere igual a cero ya que sino no seria una ecuacuion de primer grado valido   ");
        
        }

















































    }
}