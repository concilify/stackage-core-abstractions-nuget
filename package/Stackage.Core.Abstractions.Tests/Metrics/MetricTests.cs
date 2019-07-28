using System.Collections.Generic;
using FakeItEasy;
using NUnit.Framework;
using Stackage.Core.Abstractions.Metrics;

namespace Stackage.Core.Abstractions.Tests.Metrics
{
   public class MetricTests
   {
      [Test]
      public void should_have_string_name_property()
      {
         var metric = A.Fake<IMetric>();

         A.CallTo(() => metric.Name).Returns("the-name");

         Assert.That(metric.Name, Is.EqualTo("the-name"));
      }

      [Test]
      public void should_have_dictionary_dimensions_property()
      {
         var metric = A.Fake<IMetric>();

         var dimensions = new Dictionary<string, object>();
         A.CallTo(() => metric.Dimensions).Returns(dimensions);

         Assert.That(metric.Dimensions, Is.SameAs(dimensions));
      }
   }
}
