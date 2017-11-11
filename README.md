# Arrow Asserts

Adds a "Is.Referencing" assertion to NUnit 3.

This prevents large architectural changes from sneaking by unnoticed.

Available on Nuget.org:
https://www.nuget.org/packages/ArrowAsserts

# Examples

```csharp
Assert.That("MyProject.UI", Is.Not.Referencing("MyProject.Data"));
```

Note that if you want to assert that something `Is.Referencing` something, you'll need to explicitly use the ArrowAssert.Is:
```csharp
using NUnit.Framework;
using Is = ArrowAsserts.Is;

namespace ClassLibrary1
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void Test()
        {
            Assert.That("ClassLibrary1", Is.Referencing("nunit.framework"));
        }
    }
}

```
