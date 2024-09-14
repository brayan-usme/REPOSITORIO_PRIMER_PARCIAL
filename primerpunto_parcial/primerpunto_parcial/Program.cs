public class Program
{
    private static void Main(string[] args)
    {


        /*
         Realizar un algoritmo con C# donde se solucione el siguiente problema: Un vendedor recibe un
sueldo base de $XXXX. Además, recibe una comisión del 10% sobre el valor total de cada venta que
realiza. El vendedor desea saber:

 ¿Cuánto dinero obtendrá por concepto de comisiones por las tres ventas que realiza en el
mes?

 ¿Cuál es el total que recibirá en el mes tomando en cuenta su sueldo base y comisiones?


 ¿Cuál fue la venta que le generó la mayor comisión?


 ¿Cuál fue el promedio de las comisiones que recibió por cada venta?

Además, la empresa da un beneficio extra de $100.000 si el vendedor supera el objetivo del mes. El
objetivo es sumar en las 3 ventas como mínimo $1.000.000 en ventas. Mostrar un mensaje donde
indique si ganó o no el beneficio.

        */

        // definir variables 
        const decimal diez_porciento = 10; // el 10% de descuento 

        const decimal sueldobase = 1300000; // sueldo  base fijo


        decimal concepto_comisiones; // cuanto se hizo por esas 3 ventas en comiciones // primera pregunta 
        decimal sueldo_mas_comiciones; // dinero que recibio el trabajador por ventas y sueldo basico  // segunda pregunta

        double venta_mayor_comicion; // pregunta 3
        decimal promedio_comisiones1, promedio_comisiones2, promedio_comisiones3; // pregunta 4

        decimal valor_venta1, valor_venta2, valor_venta3; // valores de cada venta realizada



        decimal bonificacaion_extra; // ultimo parrafo 

        // proceso

        Console.Write(" ingrese el valor de la venta 1  "); // pedimos el valor de cada venta 
        valor_venta1 = Convert.ToDecimal(Console.ReadLine());

        Console.Write(" ingrese el valor de venta 2 ");
        valor_venta2 = Convert.ToDecimal(Console.ReadLine());

        Console.Write(" ingrese el valor de venta 3 ");
        valor_venta3 = Convert.ToDecimal(Console.ReadLine());










































    }
}