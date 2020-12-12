using Microsoft.AspNetCore.Components.Testing;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace FizzBuzz.UnitTest
{
    public class IndexPageUnitTests
    {
        [Fact]
        public void ShouldRenderText()
        {
            TestHost host = new TestHost();
            var component = host.AddComponent<FizzBuzz.Pages.Index>();
            // Assert h1
            Assert.Equal("Awesome FizzBuzz in the World!", component.Find("h1").InnerText);
            // Assert text in the body
            Assert.Contains("An example of FizzBuzz using", component.GetMarkup());
            // Assert if survey component exists
            Assert.NotNull(component.Find(".alert.alert-secondary"));
            // Assert the link
            Assert.Equal(
                "awsom_fizzbuzz",
                component.Find("a").Attributes["href"].Value);


        }
    }
}
