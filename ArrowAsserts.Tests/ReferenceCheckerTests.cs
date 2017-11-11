using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace ArrowAsserts.Tests
{
    [TestFixture]
    public class ReferenceCheckerTests
    {
        [Test]
        public void Check_Returns_True()
        {
            var checker = new ReferenceChecker();
            var actual = checker.DoesAReferenceB("ArrowAsserts.Tests", "ArrowAsserts");
            Assert.That(actual, Is.True);
        }

        [Test]
        public void Check_Returns_False()
        {
            var checker = new ReferenceChecker();
            var actual = checker.DoesAReferenceB("ArrowAsserts", "ArrowAsserts.Tests");
            Assert.That(actual, Is.False);
        }

        [Test]
        public void Check_Returns_True_With_Partial_Matches()
        {
            var checker = new ReferenceChecker();
            var actual = checker.DoesAReferenceB("ArrowAsserts.Tests", "nunit.fram");
            Assert.That(actual, Is.True);
        }
    }
}
