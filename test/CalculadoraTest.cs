using src;

namespace test;

public class CalculadoraTest
{
    //Arrange
    //Act
    //Assert

    [Fact]
    public void TestarSoma2e3Igual5()
    {
        //Arrange
        Calculadora c = new Calculadora();
        //Act
        int resultado = c.Somar(2,3);
        int valorEsperado = 5;
        //Assert
        Assert.Equal(valorEsperado, resultado);
    }

    [Theory]
    [InlineData(2, 3, 5)]
    [InlineData(2, 0, 2)]
    [InlineData(0, -1, -1)]
    public void TestarSomas(int val1, int val2, int valorEsperado)
    {
        //Arrange
        Calculadora c = new Calculadora();
        //Act
        int resultado = c.Somar(val1,val2);
        //Assert
        Assert.Equal(valorEsperado, resultado);
    }

    [Fact]
    public void TestarSubtrair3de5Igual2()
    {
        //Arrange
        Calculadora c = new Calculadora();
        //Act
        int resultado = c.Subtrair(5,3);
        int valorEsperado = 2;
        //Assert
        Assert.Equal(valorEsperado, resultado);
    }

    [Theory]
    [InlineData(2, 3, -1)]
    [InlineData(2, 0, 2)]
    [InlineData(5, -1, 6)]
    public void TestarSubtrair(int val1, int val2, int valorEsperado)
    {
        //Arrange
        Calculadora c = new Calculadora();
        //Act
        int resultado = c.Subtrair(val1,val2);
        //Assert
        Assert.Equal(valorEsperado, resultado);
    }

    [Fact]
    public void TestarMultiplicacao2e3Igual6()
    {
        //Arrange
        Calculadora c = new Calculadora();
        //Act
        int resultado = c.Multiplicar(2,3);
        int valorEsperado = 6;
        //Assert
        Assert.Equal(valorEsperado, resultado);
    }

    [Theory]
    [InlineData(2, 3, 6)]
    [InlineData(2, 0, 0)]
    [InlineData(2, -1, -2)]
    public void TestarMultiplicacao(int val1, int val2, int valorEsperado)
    {
        //Arrange
        Calculadora c = new Calculadora();
        //Act
        int resultado = c.Multiplicar(val1,val2);
        //Assert
        Assert.Equal(valorEsperado, resultado);
    }

    [Fact]
    public void TestarDivisao6Por2Igual3()
    {
        //Arrange
        Calculadora c = new Calculadora();
        //Act
        int resultado = c.Dividir(6,2);
        int valorEsperado = 3;
        //Assert
        Assert.Equal(valorEsperado, resultado);
    }

    [Theory]
    [InlineData(12, 3, 4)]
    [InlineData(2, 1, 2)]
    [InlineData(0, 1, 0)]
    public void TestarDivisoes(int val1, int val2, int valorEsperado)
    {
        //Arrange
        Calculadora c = new Calculadora();
        //Act
        int resultado = c.Dividir(val1,val2);
        //Assert
        Assert.Equal(valorEsperado, resultado);
    }

    [Fact]
    public void TestarDivisaoPor0()
    {
        //Arrange
        Calculadora c = new Calculadora();
        //Act & Assert
        Assert.Throws<DivideByZeroException>(() => c.Dividir(6,0));
    }

    [Fact]
    public void TestarHistoricoUmaOperacao()
    {
        //Arrange
        Calculadora c = new Calculadora();
        //Act 
        c.Somar(1,2);
        //Assert
        Assert.NotEmpty(c.Historico());
        Assert.Single(c.Historico());
    }

    [Fact]
    public void TestarHistoricoMaxTresOperacoes()
    {
        //Arrange
        Calculadora c = new Calculadora();
        //Act 
        c.Somar(1,2);
        c.Subtrair(1,2);
        c.Multiplicar(1,2);
        c.Dividir(10,5);
        //Assert
        Assert.NotEmpty(c.Historico());
        Assert.Equal(3, c.Historico().Count);
    }
}