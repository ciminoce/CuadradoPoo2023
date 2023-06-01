using CuadradoPoo2023.Entidades;

namespace CuadradoPoo2023.Testing
{
    [TestClass]
    public class CuadradoTesting
    {
        [TestMethod]
        public void CuadradoValidarValida()
        {
            //Arrange
            int medidaLado = 10;

            //Act
            var c = new Cuadrado(medidaLado);

            //Assert
            Assert.IsTrue(c.Validar());
        }
        [TestMethod]
        public void CuadradoValidarNoValida()
        {
            int medidaLado = -5;
            var c = new Cuadrado(medidaLado);
            Assert.IsFalse(c.Validar());
        }
        [TestMethod]
        public void CuadradoGetPerimetro()
        {
            int medidaLado = 10;
            var c = new Cuadrado(medidaLado);
            Assert.AreEqual(40, c.GetPerimetro());
        }
        [TestMethod]
        public void CuadradoGetSuperficie()
        {
            int medidaLado=10;
            var c = new Cuadrado(medidaLado);
            Assert.AreEqual(100, c.GetSuperficie());
        }
    }
}