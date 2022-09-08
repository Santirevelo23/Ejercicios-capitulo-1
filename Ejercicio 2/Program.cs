namespace Ejercicio
{
    public class Clase
    {
        public static void Main()
        {
            int num1;
            int num2;
            int num3;
            int num4;

            int Sum;
            double Media;
            int produc;

            Console.WriteLine("Ingrese el primer numero");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo numero");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el tercer numero");
            num3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el cuarto numero");
            num4 = int.Parse(Console.ReadLine());

            produc = num1 * num2 * num3 * num4;

            Sum = num1 + num2 + num3 + num4;

            Media = Sum / 4;

            Console.WriteLine($"El resultado de la suma es {Sum}, el resultado de la media es {Media}, y el resultado del producto es {produc} ");
        }
    }

}