namespace IntegrationTests
{
    using System.Linq;
    using BusinessLayer;
    using DataLayer;
    using Shouldly;
    using Xunit;

    public class SampleIntegrationTests : EfIntegrationBase
    {

        [Fact]
        public void AddACard()
        {
            using (var context = new AutoMotiveContext())
            {
                context.Cars.Count().ShouldBe(1);
            }
        }


        [Fact]
        public void AddAnotherCard()
        {
            using (var context = new AutoMotiveContext())
            {
                var car = new Car {Year = 2010, Make = "Honda", Model = "CRV"};
                context.Cars.Add(car);
                context.SaveChanges();
            }

            using (var context = new AutoMotiveContext())
            {
                context.Cars.Count().ShouldBe(2);
            }
        }
    }
}