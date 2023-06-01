using CuadradoPoo2023.Entidades;

namespace CuadradoPoo2023.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Información de Cuadrados");


            var medidaLado = PedirEntero("Ingrese el valor del lado:");
            var c = new Cuadrado(medidaLado);
            if (c.Validar())
            {
                Console.WriteLine($"Cuadrado de lado {c.Lado} con perímetro {c.GetPerimetro()} y superficie {c.GetSuperficie()}");
            }
            else
            {
                Console.WriteLine("Objeto no válido... Chequear la medida del lado");
            }
        }

        private static int PedirEntero(string mensaje)
        {
            int nroIngresado;
            do
            {
                Console.Write(mensaje);
                var numero=Console.ReadLine();
                if (int.TryParse(numero, out nroIngresado))
                {
                    break;
                }
                Console.WriteLine("Número ingresado no válido");

            } while (true);
            return nroIngresado;
        }
    }
         
}