using NUnit.Framework;
using Moq;
using TestNinja.Mocking;

namespace TestNinja.UnitTests.Mocking
{
    [TestFixture]
    class ProductTests
    {
        [Test]
        public void GetPrice_GoldCustomer_Apply30PercentDiscount()
        {
            var product = new Product { ListPrice = 100 };
            var result = product.GetPrice(new Customer { IsGold = true });

            Assert.That(result, Is.EqualTo(70));
        }

        /*
         * this code was written to show that using mock is not always good, it reduces the clarity and maintainable of the test.
         * 
         * Use mocks, but removing external resources from your unit tests
         * 
        [Test]
        public void GetPrice_GoldCustomer_Apply30PercentDiscount2()
        {
            var customer = new Mock<ICustomer>();
            customer.Setup(c => c.IsGold).Returns(true);

            var product = new Product { ListPrice = 100 };
            var result = product.GetPrice(customer.Object);

            Assert.That(result, Is.EqualTo(70));
        }
        */
    }
}
