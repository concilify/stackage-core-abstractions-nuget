using System.Collections.Generic;
using NUnit.Framework;
using Stackage.Core.Abstractions.Metrics;

namespace Stackage.Core.Abstractions.Tests.Metrics
{
   public class GaugeTests
   {
      [Test]
      public void should_be_implementation_of_metric()
      {
         var gauge = new Gauge();

         Assert.That(gauge, Is.InstanceOf<IMetric>());
      }

      [Test]
      public void dimensions_should_be_empty()
      {
         var gauge = new Gauge();

         Assert.That(gauge.Dimensions, Is.Not.Null);
         Assert.That(gauge.Dimensions.Count, Is.EqualTo(0));
      }

      [Test]
      public void should_have_string_name_property_setter()
      {
         const string name = "metric-name";

         var gauge = new Gauge {Name = name};

         Assert.That(gauge.Name, Is.EqualTo(name));
      }

      [Test]
      public void should_have_double_value_property_getter_and_setter()
      {
         const double value = 12.79;

         var gauge = new Gauge {Value = value};

         Assert.That(gauge.Value, Is.EqualTo(value));
      }

      [Test]
      public void should_have_dimensions_setter()
      {
         var dimensions = new Dictionary<string, object>();

         var counter = new Counter {Dimensions = dimensions};

         Assert.That(counter.Dimensions, Is.SameAs(dimensions));
      }
   }
}
