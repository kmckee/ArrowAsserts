﻿using NUnit.Framework;
using Is = ArrowAsserts.Is;

namespace ArrowAsserts.Tests
{
    [TestFixture]
    public class ReferencingConstraintTests
    {
        [Test]
        public void A_Can_Reference_B_And_It_Does()
        {
            Assert.That("ArrowAsserts.Tests", Is.Referencing("ArrowAsserts"));
        }

        [Test]
        public void A_Can_Not_Reference_B_But_It_Does()
        {
            Assert.Throws<AssertionException>(() =>
            {
                Assert.That("ArrowAsserts.Tests", Is.Not.Referencing("ArrowAsserts"));
            });
        }

        [Test]
        public void A_Can_Reference_B_But_It_Does_Not()
        {
            Assert.Throws<AssertionException>(() =>
            {
                Assert.That("ArrowAsserts", Is.Referencing("ArrowAsserts.Tests"));
            });
        }

        [Test]
        public void A_Can_Not_Reference_B_And_It_Does_Not()
        {
            Assert.That("ArrowAsserts", Is.Not.Referencing("ArrowAsserts.Tests"));
        }
    }
}
