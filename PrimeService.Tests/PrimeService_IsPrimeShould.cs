using NUnit.Framework;
using PrimeService;

namespace PrimeService.Tests;

[TestFixture]
public class PrimeService_IsPrimeShould
{

    private PrimeService _primeService;

    [SetUp]
    public void Setup()
    {
        _primeService = new PrimeService();
    }

    [TestCase(0)]
    [TestCase(1)]
    [TestCase(-1)]
    public void TeIsPrime_InputIs1_ReturnFalsest1(int value)
    {
        var result = _primeService.IsPrime(value);
        Assert.That(result, Is.False, $"{value} should not be prime");
        
    }
}
