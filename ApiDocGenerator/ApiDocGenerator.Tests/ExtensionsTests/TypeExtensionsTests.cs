using NUnit.Framework;
using Shouldly;
using ApiDocGenerator.Extensions;
using ApiDocGenerator.Tests.TestInfrastructure;
using Microsoft.AspNetCore.Mvc;

namespace ApiDocGenerator.Tests.ExtensionsTests
{
    public class TypeExtensionsTests
    {
        [Test]
        public void type_is_controller_returns_true()
        {
            typeof(Controller).IsApiController().ShouldBeTrue();
        }

        [Test]
        public void type_derives_from_controller_returns_true()
        {
            typeof(TestControllers.UnitTestController).IsApiController().ShouldBeTrue();
        }

        [Test]
        public void type_does_not_derive_from_controller_returns_false()
        {
            typeof(TypeExtensionsTests).IsApiController().ShouldBeFalse();
        }
    }
}
