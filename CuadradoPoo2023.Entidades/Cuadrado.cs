using System.Reflection.Metadata.Ecma335;

namespace CuadradoPoo2023.Entidades
{
    public class Cuadrado
    {
		private int lado;

		public int Lado
		{
			get { return lado; }
			set { lado = value; }
		}
        public Cuadrado(int medidaLado)
        {
             lado=medidaLado;
        }
        public bool Validar() => lado > 0;
        public int GetPerimetro() => lado *4;
        public double GetSuperficie() => Math.Pow(lado, 2);
    }
}