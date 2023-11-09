using Calculadora;

namespace CalcularotaTests;

public class CalcTests
{

    CalculadoraApp calc;

    public CalcTests(){
        calc = new CalculadoraApp("20/05/2023");
    }

    [Theory]
    [InlineData(1,2,3)]
    [InlineData(4,5,9)]
    public void TesteSomar(int num1, int num2, int res)
    {
        int resultado = calc.Somar(num1, num2);
        Assert.Equal(res, resultado);
    }

    [Theory]
    [InlineData(1,2,-1)]
    [InlineData(4,5,-1)]
    public void TesteSubtrair(int num1, int num2, int res)
    {
        int resultado = calc.Subtrair(num1, num2);
        Assert.Equal(res, resultado);
    }

    [Theory]
    [InlineData(1,2,2)]
    [InlineData(4,5,20)]
    public void TesteMultiplicar(int num1, int num2, int res)
    {
        int resultado = calc.Multiplicar(num1, num2);
        Assert.Equal(res, resultado);
    }

    [Theory]
    [InlineData(6,2,3)]
    [InlineData(5,5,1)]
    public void TesteDividir(int num1, int num2, int res)
    {
        int resultado = calc.Dividir(num1, num2);
        Assert.Equal(res, resultado);
    }


    [Fact]
    public void TestarDivisaoPorZero(){
        Assert.Throws<DivideByZeroException>(() => calc.Dividir(3, 0));
    }

    [Fact]
    public void TestarHistorico(){

        calc.Somar(1,2);
        calc.Somar(1,2);
        calc.Somar(1,2);
        calc.Somar(1,2);
        var lista = calc.Historico();
        Assert.NotEmpty(lista);
        Assert.Equal(3, lista.Count);
    }

}