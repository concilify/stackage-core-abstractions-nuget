using System.Collections.Generic;
using NUnit.Framework;
using Stackage.Core.Abstractions.Metrics;

namespace Stackage.Core.Abstractions.Tests.Metrics
{
   public class CounterTests
   {
      [Test]
      public void should_be_implementation_of_metric()
      {
         var counter = new Counter("name");

         Assert.That(counter, Is.InstanceOf<IMetric>());
      }

      [Test]
      public void dimensions_should_be_empty()
      {
         var counter = new Counter("name");

         Assert.That(counter.Dimensions, Is.Not.Null);
         Assert.That(counter.Dimensions.Count, Is.EqualTo(0));
      }

      [Test]
      public void name_should_be_set()
      {
         const string name = "metric-name";

         var counter = new Counter(name);

         Assert.That(counter.Name, Is.EqualTo(name));
      }

      [Test]
      public void should_have_dimensions_setter()
      {
         var dimensions = new Dictionary<string, object>();

         var counter = new Counter("name") {Dimensions = dimensions};

         Assert.That(counter.Dimensions, Is.SameAs(dimensions));
      }
   }
}
