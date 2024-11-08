using minimal_api.Dominio.Entidades;

namespace Test.Domain.Entidades;

[TestClass]

public class VeiculosTest
{
    [TestMethod]
    public void TestMethod1()
    {

    // Arrange

    Veiculo veiculo = new()
    {
    // Act
        Ano = 2005,
        Id = 1,
        Marca = "Honda",
        Nome = "Civic"
    };

    // Assert
        Assert.AreEqual(1, veiculo.Id);
        Assert.AreEqual("Honda", veiculo.Marca);
        Assert.AreEqual("Civic", veiculo.Nome);
        Assert.AreEqual(2005, veiculo.Ano);
    }
}
