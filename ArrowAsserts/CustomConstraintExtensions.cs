using ArrowAsserts;
using NUnit.Framework.Constraints;

namespace NUnit.Framework
{
    public static class CustomConstraintExtensions
    {
        public static ReferencingConstraint Referencing(this ConstraintExpression expression, object expected)
        {
            var constraint = new ReferencingConstraint(expected);
            expression.Append(constraint);
            return constraint;
        }
    }
}

namespace ArrowAsserts
{
    public class Is : NUnit.Framework.Is
    {
        public static ReferencingConstraint Referencing(object expected)
        {
            return new ReferencingConstraint(expected);
        }
    }
}
