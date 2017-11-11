# Arrow Asserts

Adds a "Is.Referencing" assertion to NUnit 3.

This prevents large architectural changes from sneaking by unnoticed.

Available on Nuget.org:
https://www.nuget.org/packages/ArrowAsserts

# Example

```csharp
Assert.That("MyProject.UI", Is.Not.Referencing("MyProject.Data"));
```

