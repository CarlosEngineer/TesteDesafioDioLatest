using TesteDesafioDioLatest;
using Xunit;
using System;


namespace TestDesafioDio

{
    public class UnitTest1
    {

        public Calculadora construirClasse()
        {
            string data = "13/05/2024";
            Calculadora calc = new Calculadora("13/05/2024");

            return calc;
        }


        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(10, 20, 30)]
        public void TestSomar(int num1, int num2, int resultado)
        {
            Calculadora calc = construirClasse();
            int resultadoCalculadora = calc.somar(num1, num2);

            Assert.Equal(resultado, resultadoCalculadora);

        }

        [Theory]
        [InlineData(10, 2, 20)]
        [InlineData(5, 2, 10)]
        public void TestMultiplicar(int num1, int num2, int resultado)
        {
            Calculadora calc = construirClasse();
            int resultadoCalculadora = calc.multiplicar(num1, num2);

            Assert.Equal(resultado, resultadoCalculadora);

        }

        [Theory]
        [InlineData(10, 2, 5)]
        [InlineData(100, 20, 5)]
        public void TestDividir(int num1, int num2, int resultado)
        {
            Calculadora calc = construirClasse();
            int resultadoCalculadora = calc.dividir(num1, num2);

            Assert.Equal(resultado, resultadoCalculadora);

        }

        [Fact]
        public void DivisaoPorZero()
        {
            Calculadora calc = construirClasse();

            Assert.Throws<DivideByZeroException>(() => calc.dividir(3, 0));

        }

        [Fact]
        public void TestarHistorico()
        {
            Calculadora calc = construirClasse();
            calc.somar(1, 2);
            calc.somar(2, 2);
            calc.somar(3, 2);
            calc.somar(4, 2);
            calc.somar(5, 2);


            var lista = calc.historico();

            Assert.NotEmpty(lista);
            Assert.Equal(3, lista.Count);

        }


    }

}