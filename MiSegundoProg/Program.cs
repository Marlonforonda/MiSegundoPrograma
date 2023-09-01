//Realizar un algoritmo que me pida 3 números por pantalla, con el primer numero hallar el cuadrado,
//con el segundo hallar la raiz cuadrada y con el tercer número hallar la raíz cubica

public class MiSegundoPrograma
{
    static void Main(string[] args)
    {   // 1 Definir el nombre de mi clase con su respectivo main
        // 2do Declaracion de mis variables (datos de entrada)
        double num2, num3, raiz,raizCubica;
        int num1, cuadrado;
        // 3ro pedir los valores por consola
        Console.Write("Ingrese su primer número: ");
        num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Ingrese su segundo número: ");
        num2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Ingrese su tercer número: ");
        num3 = Convert.ToInt32(Console.ReadLine());

        //4to Calculo (procesos)
        cuadrado = num1 * num1;
        raiz = Math.Sqrt(num2);
        raizCubica = Math.Pow(num3, 1.0 / 3.0);

        //5to Imprimir todos los resutados (datos de salida)
        Console.Write("El cuadrado es: " + cuadrado);
        Console.Write("\n");
        Console.Write("la raiz es: " + raiz);
        Console.Write("\n");
        Console.Write("la raiz cubica es: " + raizCubica);











    }






}
    


